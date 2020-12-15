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
        private string selectedGroup;
        public Prepod prepod;
        public Student student;
        public static int NumberOfCertifications = 5;
        public PrepodForm()
        {
            InitializeComponent();
        }

        private void fillGrid(string name)
        {
            foreach (NameSubject nameSubject in Konteiner.kontainNamesSubjects)
            {
                if(nameSubject.nameSubject == name)
                {
                    dataGridView1.Columns.Clear();
                    this.selectedGroup = Convert.ToString(comboBox1.SelectedItem);

                    dataGridView1.Columns.Add("Name", "Фамилия");
                    for (int i = 0; i < NumberOfCertifications; i++)
                    {
                        dataGridView1.Columns.Add("i", Convert.ToString(i));
                        dataGridView1.Columns[i + 1].Width = 30;
                    }
                    dataGridView1.Columns.Add("res", "Средний балл");

                    foreach (var item in Konteiner.kontainStud)
                    {
                        if (item.numGroup.id == int.Parse(selectedGroup))
                        {
                            dataGridView1.Rows.Add(item.name);
                        }
                    }

                    for (int i = 0; i < Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                    }
                    UpdateGrid();
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.SelectedItem) != "" && Convert.ToString(comboBox2.SelectedItem) != "")
            {
                this.fillGrid(Convert.ToString(comboBox2.SelectedItem));
            }
        }

        private void UpdateGrid()
        {
            for (int i = 0; i < Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count - 2; j++)
                {
                    try
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value = Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject[Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject.IndexOf(Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].FindSubject(Convert.ToString(comboBox2.SelectedItem)))].Marks[j];
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void PrepodForm_Load(object sender, EventArgs e)
        {
            this.Text = prepod.name;
            foreach (Group group in Konteiner.kontainGroup)
            {
                comboBox1.Items.Add(group.id);
            }
            foreach (NameSubject subject in Konteiner.kontainNamesSubjects)
            {
                comboBox2.Items.Add(subject.nameSubject);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void SelectChange_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count - 2; j++)
                {
                    Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject[Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject.IndexOf(Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].FindSubject("ОАИП"))].Marks[j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j + 1].Value);
                }
            }
            for (int i = 0; i < Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup.Count; i++)
            {
                Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject[Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject.IndexOf(Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].FindSubject("ОАИП"))].CountAverageRating();
                dataGridView1.Rows[i].Cells["res"].Value = Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject[Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject.IndexOf(Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].FindSubject("ОАИП"))].AverageRating;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup.Count; i++)
            {
                Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject[Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject.IndexOf(Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].FindSubject("ОАИП"))].CountAverageRating();
                dataGridView1.Rows[i].Cells["res"].Value = Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject[Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].subject.IndexOf(Konteiner.findGroup(int.Parse(selectedGroup)).sostavGroup[i].FindSubject("ОАИП"))].AverageRating;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(comboBox1.SelectedItem) != "" && Convert.ToString(comboBox2.SelectedItem) != "")
            {
                this.fillGrid(Convert.ToString(comboBox2.SelectedItem));
            }
        }
    }
}

