using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protect7lab.Forms
{
    public partial class AddSubject : Form
    {
        public protect7lab.PredmetForm predmetForm;
        public AddSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameSubject nameSubject = new NameSubject(textBox1.Text);
            Konteiner.kontainNamesSubjects.Add(nameSubject);
            Konteiner.kontainSubjects.Add(new Subject(nameSubject));
            this.predmetForm.Show();
            this.predmetForm.PredmetForm_Load(this.predmetForm, null);
            this.Hide();
        }
    }
}
