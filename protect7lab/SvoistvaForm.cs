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
    public partial class SvoistvaForm : Form
    {
        public Reg form1;
        public SvoistvaForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                form1.nomergroup = Convert.ToInt32(comboBox1.Text);
                form1.telephonstud = Convert.ToInt32(telephonBox.Text);
                form1.adressstud = adressBox.Text;
                this.Hide();
                this.form1.Show();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void SvoistvaForm_Load(object sender, EventArgs e)
        {
            foreach (Group group in Konteiner.kontainGroup)
            {
                comboBox1.Items.Add(group.id);
            }
        }
    }
}
