using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats_papers {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            //Выход из программы
            Form1.block = true;
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
