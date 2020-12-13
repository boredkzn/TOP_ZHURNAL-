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
    public partial class AdminPanel : Form
    {
        public Form2 auth;
        public AdminPanel()
        {
            InitializeComponent();
            loginLable.Text = "";
            passwordLable.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Prepod i in Konteiner.kontainPrepod)
            {
                listBox1.Items.Add(i.name);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Student i in Konteiner.kontainStud)
            {
                listBox1.Items.Add(i.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.auth.Show();
            this.Hide();
        }



        private void loginLable_Click(object sender, EventArgs e)
        {

        }

        private void passwordLable_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginLable.Text = "";
            passwordLable.Text = "";

            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < Konteiner.kontainStud.Count; i++)
                {
                    if (Convert.ToString(listBox1.SelectedItem) == Konteiner.kontainStud[i].name)
                    {
                        loginLable.Text = Konteiner.kontainStud[i].login.ToString();
                        passwordLable.Text = Konteiner.kontainStud[i].password.ToString();
                    }
                }
            }
            if(radioButton2.Checked == true)
            {
                for (int i = 0; i < Konteiner.kontainPrepod.Count; i++)
                {
                    if (Convert.ToString(listBox1.SelectedItem) == Konteiner.kontainPrepod[i].name)
                    {
                        loginLable.Text = Konteiner.kontainPrepod[i].login.ToString();
                        passwordLable.Text = Konteiner.kontainPrepod[i].password.ToString();
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < Konteiner.kontainStud.Count; i++)
                {
                    if (Convert.ToString(listBox1.SelectedItem) == Konteiner.kontainStud[i].name)
                    {
                        Konteiner.kontainStud.Remove(Konteiner.kontainStud[i]);
                    }
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
           
            if (radioButton2.Checked == true)
            {
                for (int i = 0; i < Konteiner.kontainPrepod.Count; i++)
                {
                    if (Convert.ToString(listBox1.SelectedItem) == Konteiner.kontainPrepod[i].name)
                    {
                        Konteiner.kontainPrepod.Remove(Konteiner.kontainPrepod[i]);
                    }
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            //for (int i = 0; i <= this.ListAccounts.accounts.Count; i++)
            //{

            //    if (Convert.ToString(listBox1.SelectedItem) == this.ListAccounts.accounts[i].Surname)
            //    {
            //        MessageBox.Show("");
            //        this.ListAccounts.accounts.Remove(this.ListAccounts.accounts[i]);
            //    }
            //}
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
