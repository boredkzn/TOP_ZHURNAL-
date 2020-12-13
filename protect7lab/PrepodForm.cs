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
    public partial class PrepodForm : Form
    {
        public PrepodForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrepodForm_Load(object sender, EventArgs e)
        {
            foreach (Group group in Konteiner.kontainGroup)
            {
                comboBox1.Items.Add(group.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
