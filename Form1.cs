using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cats_papers.Properties;

namespace Cats_papers {
    public partial class Form1 : Form {
        public static bool block = false; //false - блок не стоит, окно подтверждения выхода; 
                                          //true - блок стоит, выход из программы немедленно
        private int sourceNumber = 1; //Текущий номер добавляемой литературы
        private int splitterPos = 0; //Позиция центрального разделителя
        string[][] fullTable = new string[0][] {}; //Массив всех источников
        string[] fullSource = new string[6]; //Массив параметров одного источника


        public Form1() {
            InitializeComponent();
        }


        private void AddNewLable(Label label, Label original) {
            //Копирование свойств для лейбла с эталона original
            label.BackColor = original.BackColor;
            label.BorderStyle = original.BorderStyle;
            label.Font = original.Font;
            label.Text = sourceNumber.ToString();
            label.TextAlign = original.TextAlign;
            label.Anchor = original.Anchor;
            label.Margin = original.Margin;
            label.MinimumSize = original.MinimumSize;
            label.Size = original.Size;
            label.Name = "label_" + sourceNumber.ToString();
            mainTable.Controls.Add(label, 0, sourceNumber - 1);
        }


        private void AddNewTextBox(TextBox text, TextBox original, int column) {
            //Копирование свойств для текстового поля с эталона original
            text.Font = original.Font;
            text.ScrollBars = original.ScrollBars;
            text.Anchor = original.Anchor;
            text.Margin = original.Margin;
            text.ContextMenuStrip = original.ContextMenuStrip;
            text.HideSelection = original.HideSelection;
            text.TabIndex = sourceNumber * 10 + column;
            text.WordWrap = original.WordWrap;
            text.Name = "textBox_" + sourceNumber.ToString() + column.ToString();
            text.Leave += Text_View_Correct;
            text.KeyDown += TextBox_KeyDown;
            mainTable.Controls.Add(text, column, sourceNumber - 1);
        }


        private void AddButton_Click(object sender, EventArgs e) {
            if (sourceNumber < 99) {
                //Сдвиг кнопки "Добавить"
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + 40);
                //Добавление строки в TableLayoutPanel
                mainTable.Size = new System.Drawing.Size(mainTable.Size.Width, mainTable.Size.Height + 40);
                mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
                //Корректировка шапки при появлении скролла
                titleLayoutPanel.Size = new System.Drawing.Size(mainTable.Size.Width, titleLayoutPanel.Size.Height);

                //Добавление лейбла и текстовых полей в новые ячейки
                sourceNumber++;
                Label newLable = new Label();
                AddNewLable(newLable, originalLable);
                for (int i = 1; i <= 6; i++) {
                    TextBox newTextBox = new TextBox();
                    AddNewTextBox(newTextBox, textBox_11, i);
                }
            }
        }


        private string[][] BubbleSort(string[][] array) {
            //Сортировка пузырьком
            string[] t = new string[6] { "", "", "", "", "", "" };
            string[] autor = new string[2] { "", "" };
            for (int i = 0; i < array.Length; i++) {
                //Корректировка поля "Автор" (фамилия вперед, инициалы в конец) для корректного сравнения
                autor[0] = "";
                if (array[i][0].Length > 4 && array[i][0][4] == '.') {
                    for (int ch = 6; ch < array[i][0].Length; ch++) {
                        autor[0] += array[i][0][ch];
                    }
                    autor[0] += " " + array[i][0][0] + array[i][0][1] + array[i][0][2] + array[i][0][3] + array[i][0][4];
                }
                else {
                    for (int ch = 3; ch < array[i][0].Length; ch++) {
                        autor[0] += array[i][0][ch];
                    }
                    autor[0] += " " + array[i][0][0] + array[i][0][1] + array[i][0][2];
                }
                for (int j = i + 1; j < array.Length; j++) {
                    autor[1] = "";
                    if (array[j][0].Length > 4 && array[j][0][4] == '.') {
                        for (int ch = 6; ch < array[j][0].Length; ch++) {
                            autor[1] += array[j][0][ch];
                        }
                        autor[1] += " " + array[j][0][0] + array[j][0][1] + array[j][0][2] + array[j][0][3] + array[j][0][4];
                    }
                    else {
                        for (int ch = 3; ch < array[j][0].Length; ch++) {
                            autor[1] += array[j][0][ch];
                        }
                        autor[1] += " " + array[j][0][0] + array[j][0][1];
                    }
                    if (((array[i][0].Length < 4 || array[i][0].Substring(0, 4).ToLower() != "http") && 
                        (array[j][0].Length < 4 || array[j][0].Substring(0, 4).ToLower() != "http") && 
                        (autor[0].CompareTo(autor[1]) == 1)) || ((array[i][0].Length > 3 && 
                        array[i][0].Substring(0, 4).ToLower() == "http") && (array[j][0].Length < 4 || 
                        array[j][0].Substring(0, 4).ToLower() != "http")) || ((array[i][0].Length > 3 && 
                        array[i][0].Substring(0, 4).ToLower() == "http") && (array[j][0].Length > 3 && 
                        array[j][0].Substring(0, 4).ToLower() == "http") && array[i][1].CompareTo(array[j][1]) == 1)) {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            return array;
        }


        private string FormalizeTable(string[][] array) {
            //Формирование текста с результатом оформления
            string result = "";
            for (int source = 0; source < array.Length; source++) {
                result += (source + 1).ToString() + ". ";
                if (array[source][0].Length < 4 || array[source][0].Substring(0, 4).ToLower() != "http") {
                    //Бумажный источник
                    //Первый автор
                    if (array[source][0].Length > 4 && array[source][0][4] == '.') {
                        //Отчество есть
                        for (int i = 6; i <= array[source][0].Length; i++) {
                            if (i == array[source][0].Length || array[source][0][i] == ',' || 
                                array[source][0][i] == ';' || array[source][0][i] == ' ') {
                                result += ", " + array[source][0][0].ToString() + ". " + array[source][0][3].ToString() + ". ";
                                break;
                            }
                            else {
                                result += array[source][0][i];
                            }
                        }
                    }
                    else {
                        //Отчества нет
                        for (int i = 3; i <= array[source][0].Length; i++) {
                            if (i == array[source][0].Length || array[source][0][i] == ',' || 
                                array[source][0][i] == ';' || array[source][0][i] == ' ') {
                                result += ", " + array[source][0][0].ToString() + ". ";
                                break;
                            }
                            else {
                                result += array[source][0][i];
                            }
                        }
                    }
                    //Название
                    result += array[source][1];
                    //Все авторы
                    result += " / " + array[source][0];
                    //Издательство и город издания
                    if (array[source][3] != "") {
                        switch (array[source][3].ToLower()) {
                            case "москва":
                                result += ". – М.";
                                break;
                            case "санкт-петербург":
                                result += ". – СПб.";
                                break;
                            case "ленинград":
                                result += ". – Л.";
                                break;
                            case "ростов на дону":
                                result += ". – Р. н/Д.";
                                break;
                            case "нижний новгород":
                                result += ". – Н. Новгород";
                                break;
                            default:
                                result += ". – " + array[source][3];
                                break;
                        }
                        if (array[source][2] != "") {
                            result += ": " + array[source][2];
                        }
                    }
                    else if (array[source][2] != "") {
                        result += ".– " + array[source][2];
                    }
                    //Год издания
                    if (array[source][4] != "") {
                        result += ", " + array[source][4];
                    }
                    //Объем
                    result += ". – " + array[source][5] + " c." + "\n";
                }
                else {
                    //Электронный источник
                    result += array[source][1] + ": [Электронный ресурс]. URL: " + array[source][0] + 
                        ". (Дата обращения: " + DateTime.Now.ToShortDateString() + ")." + "\n";
                }
            }
            return result;
        }


        private void Formalize_Click(object sender, EventArgs e) {
            //Оформление списка литературы   
            //Формирование двумерного массива параметров источников
            Array.Resize<string[]>(ref fullTable, 0);
            for (int row = 0; row < sourceNumber; row++) {

                for (int i = 0; i < 6; i++) {
                    fullSource[i] = (this.Controls.Find("textBox_" +
                        (row + 1).ToString() + (i + 1).ToString(), true).First() as TextBox).Text;
                }
                if ((fullSource[0] != "" && fullSource[1] != "" && fullSource[5] != "") ||
                    (fullSource[0].Length > 3 && fullSource[0].Substring(0,4).ToLower() == "http" && 
                    fullSource[1] != "")) {
                    //Если все важные поля заполнены - добавление источника в массив
                    Array.Resize<string[]>(ref fullTable, fullTable.Length + 1);
                    fullTable[fullTable.Length - 1] = new string[6];
                    for (int column = 0; column < 6; column++) {
                        //Вставка пробелов в поле "Автор", если они пропущены
                        if (column == 0) {
                            for (int i = 0; i < fullSource[0].Length - 1; i++) {
                                if ((fullSource[0].Length < 4 || fullSource[0].Substring(0, 4).ToLower() != "http") && 
                                    fullSource[0][i] == '.' && fullSource[0][i + 1] != ' ') {
                                    fullSource[0] = fullSource[0].Insert(i + 1, " ");
                                }
                            }
                        }
                        fullTable[fullTable.Length - 1][column] = fullSource[column];
                    }
                }
            }
            //Сортировка массива источников
            fullTable = BubbleSort(fullTable);
            //Вывод оформленного спсика литературы
            Result.Text = FormalizeTable(fullTable);  
        }


        private void Copy_Click(object sender, EventArgs e) {
            //Копирование оформленного списка летературы
            if (Result.Text != "") {
                Clipboard.SetText(Result.Text);
                Result.Focus();
                Result.SelectAll();
            }
        }


        private void Text_View_Correct(object sender, EventArgs e) {
            //Корректирование отображения текстового поля после потери фокуса
            (sender as TextBox).SelectionLength = 0;
            (sender as TextBox).SelectionStart = 0;
            string name = (sender as TextBox).Name;
            string autor = "";
            if (name.Length == 10) {
                autor = (this.Controls.Find("textBox_" +
                    name[8] + "1", true).First() as TextBox).Text;
            }
            else {
                autor = (this.Controls.Find("textBox_" +
                    name.Substring(8, 2) + "1", true).First() as TextBox).Text;
            }
            if ((sender as TextBox).Text == "" &&
               (((name.Length == 10 && name[9] == '1') || (name.Length == 11 && name[10] == '1')) ||
               ((name.Length == 10 && name[9] == '2') || (name.Length == 11 && name[10] == '2')) || 
               ((autor.Length < 4 || autor.Length > 3 && autor.Substring(0, 4).ToLower() != "http") &&
               ((name.Length == 10 && name[9] == '6') || (name.Length == 11 && name[10] == '6')))) ||
                (((name.Length == 10 && name[9] == '1') || (name.Length == 11 && name[10] == '1')) && 
                autor.Length > 0 && autor[autor.Length - 1] == '.')) {
                    //Если важное поле не заполнено или формат записи автора неверный - окрасить поле в розовый
                    (sender as TextBox).BackColor = System.Drawing.Color.Pink;
            }
            else {
                (sender as TextBox).BackColor = System.Drawing.Color.White;
            }
        }


        private void Context_Menu_Copy(object sender, EventArgs e) {
            //Копирование текста (Контекстное меню)
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            ContextMenuStrip menu = (ContextMenuStrip)item.Owner;
            if (menu.SourceControl.GetType() == typeof(TextBox)) {
                TextBox text_box = (TextBox)menu.SourceControl;
                if (text_box.SelectedText != "") {
                    Clipboard.SetText(text_box.SelectedText);
                }
            }
            else {
                RichTextBox text_box = (RichTextBox)menu.SourceControl;
                if (text_box.SelectedText != "") {
                    Clipboard.SetText(text_box.SelectedText);
                }
            }
        }


        private void Context_Menu_Paste(object sender, EventArgs e) {
            //Вставка текста (Контекстное меню)
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            ContextMenuStrip menu = (ContextMenuStrip)item.Owner;
            TextBox text_box = (TextBox)menu.SourceControl;
            text_box.SelectedText = Clipboard.GetText();
        }


        private void Splitter_Position(object sender, SplitterEventArgs e) {
            //Сохранение позиции центрального разделителя при его сдвиге
            if (this.WindowState != FormWindowState.Maximized) {
                splitterPos = (sender as SplitContainer).SplitterDistance;
            }
        }


        private void Form1_Load(object sender, EventArgs e) {
            //Позиционирование окна программы, как было
            if (Settings.Default.WindowLocation != null) {
                this.Location = Settings.Default.WindowLocation;
            }
            // Установка размера окна программы, как было
            if (Settings.Default.WindowSize != null) {
                this.Size = Settings.Default.WindowSize;
            }
            //Позиционирование центрального разделителя, как было
            if (Settings.Default.SplitterDistance != 0) {
                splitterPos = Settings.Default.SplitterDistance;
                splitContainer1.SplitterDistance = splitterPos;
            }
            //Фокус по умолчанию
            textBox_11.Focus();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (!block) {
                //Подтверждение выхода
                Form2 f2 = new Form2();
                f2.ShowDialog();
                e.Cancel = true;
            }
            else {
                //Сохранение позиции и размера экрана, а также позиции центрального разделителя для следующего запуска
                Settings.Default.SplitterDistance = splitterPos;
                if (this.WindowState == FormWindowState.Normal) {
                    Settings.Default.WindowLocation = this.Location;
                    Settings.Default.WindowSize = this.Size;
                }
                else {
                    Settings.Default.WindowSize = this.RestoreBounds.Size;
                    Settings.Default.WindowLocation =
                        new Point((Screen.PrimaryScreen.Bounds.Width - Settings.Default.WindowSize.Width) / 2,
                                  (Screen.PrimaryScreen.Bounds.Height - Settings.Default.WindowSize.Height) / 2);
                }
                //Сохранение настроек
                Settings.Default.Save();
            }
        }


        private void Form1_SizeChanged(object sender, EventArgs e) {
            //Корректировка шапки при появлении скролла
            titleLayoutPanel.Size = new System.Drawing.Size(mainTable.Size.Width, titleLayoutPanel.Size.Height);
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e) {
            //Переход к следующему полю при нажатии на "Enter"
            if (e.KeyData == Keys.Enter) {
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }
        }
    }
}
