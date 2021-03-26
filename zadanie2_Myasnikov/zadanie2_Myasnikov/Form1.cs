using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2_Myasnikov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("DSR.docx");
            var item = new Dictionary<string, string>
            {
                { "<DSR>", textBox1.Text },
                { "<NAME>", textBox2.Text },
                { "<TZR>", textBox3.Text },
                { "<SOV>", textBox4.Text },
                { "<CRU>", textBox5.Text },
            };
            helper.Process(item);
            MessageBox.Show("Документ успешно сохранен", "Сохранено");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
