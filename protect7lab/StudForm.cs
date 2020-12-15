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
    public partial class StudForm : Form
    {
        public Student student = new Student();
        public StudForm()
        {
            InitializeComponent();
        }

        private void StudForm_Load(object sender, EventArgs e)
        {
            foreach (Subject subject in student.subject)
            {
                comboBox1.Items.Add(subject.NameSubject.nameSubject);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Name", "ОАИП");
            for (int i = 0; i < PrepodForm.NumberOfCertifications; i++)
            {
                dataGridView1.Columns.Add("i", Convert.ToString(i));
                dataGridView1.Columns[i + 1].Width = 30;
            }
            dataGridView1.Columns.Add("res", "Средний балл");

            foreach (var item in Konteiner.kontainStud)
            {
                if (item.name == student.name)
                {
                    dataGridView1.Rows.Add(item.name);
                }
            }
            
            for (int j = 0; j < PrepodForm.NumberOfCertifications; j++)
            {
                dataGridView1.Rows[0].Cells[j].ReadOnly = true;
            }

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            for (int j = 0; j < dataGridView1.Rows[0].Cells.Count - 2; j++)
            {
                dataGridView1.Rows[0].Cells[j + 1].Value = student.FindSubject("ОАИП").Marks[j];
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
