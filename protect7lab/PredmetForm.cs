using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protect7lab
{
    public partial class PredmetForm : Form
    {
        public Reg form1 = new Reg();
        public PredmetForm()
        {
            InitializeComponent();
            linkLabel1.Text = "Добавить предмет";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Поле должно быть заполнено!");
            }
            else
            {
                form1.predmet = comboBox1.Text;
                this.Hide();
                this.form1.Show();
            }
        }

        private void predmetBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void PredmetForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (NameSubject subject in Konteiner.kontainNamesSubjects)
            {
                comboBox1.Items.Add(subject.nameSubject);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.AddSubject addSubject = new Forms.AddSubject();
            addSubject.predmetForm = this;
            addSubject.Show();
            this.Hide();
        }
    }
}
