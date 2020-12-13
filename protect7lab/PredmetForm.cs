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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(predmetBox.Text == "")
            {
                MessageBox.Show("Поле должно быть заполнено!");
            }
            else
            {
                form1.predmet = predmetBox.Text;
                this.Hide();
                this.form1.Show();
            }
            

        }

        private void predmetBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
