﻿using System;
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
    public partial class Reg : Form
    {
        Random rnd = new Random();
        public string predmet = "";
        public int nomergroup = 0;
        public int telephonstud = 0;
        public string adressstud = "";
        
        public Form2 form;
        public Reg()
        {
            InitializeComponent();
            label5.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.form.Show();

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (teacherButton.Checked == true)
            {
                label5.Text = "";
                Konteiner.kontainPrepod.Add(new Prepod(rnd.Next(100000, 999999), nameBox.Text, surnameBox.Text, predmet, logBox.Text, passwordBox.Text));
                this.Hide();
                this.form.Show();
            }
            else if (studentsButton.Checked == true)
            {
                label5.Text = "";
                Konteiner.kontainStud.Add(new Student(rnd.Next(100000, 999999), nameBox.Text, surnameBox.Text, nomergroup, adressstud, telephonstud, logBox.Text, passwordBox.Text));
                this.Hide();
                this.form.Show();
            }
            else if (teacherButton.Checked == false || studentsButton.Checked == false)
            {
                label5.Text = "Вы не выбрали роль!";
                label5.ForeColor = Color.Red;
            }
        }

        private void teacherButton_CheckedChanged(object sender, EventArgs e)
        {
            if (teacherButton.Checked == true)
            {
                PredmetForm prd = new PredmetForm();
                prd.form1 = this;
                prd.Show();
                this.Hide();   
            }
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (studentsButton.Checked == true)
            {
                SvoistvaForm svoistva = new SvoistvaForm();
                svoistva.form1 = this;
                svoistva.Show();
                this.Hide();


            }
        }

    }
}
