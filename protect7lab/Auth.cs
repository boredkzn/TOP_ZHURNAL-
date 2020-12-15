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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg f1 = new Reg();
            f1.form = this;
            f1.Show();
            this.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.auth = this;
            adminPanel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Konteiner.kontainPrepod.Count; i++)
            {
                if (textBox1.Text == Konteiner.kontainPrepod[i].login && textBox2.Text == Konteiner.kontainPrepod[i].password)
                {
                    PrepodForm prepodForm = new PrepodForm();
                    prepodForm.prepod = Konteiner.kontainPrepod[i];
                    prepodForm.Show();
                    this.Hide();
                    return;
                }
            }
            for (int i = 0; i < Konteiner.kontainStud.Count; i++)
            {
                if(textBox1.Text == Konteiner.kontainStud[i].login && textBox2.Text == Konteiner.kontainStud[i].password)
                {
                    StudForm studForm = new StudForm();
                    studForm.student = Konteiner.kontainStud[i];
                    studForm.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Error");
        }
    }
}
