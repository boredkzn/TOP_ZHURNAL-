using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protect7lab
{
    public class Subject
    {
        public static int Id = 0;
        public NameSubject NameSubject { get; set; }
        public List<double> Marks { get; set; }
        public double AverageRating { get; set; }

        public Subject()
        {
            Id++;
            this.AverageRating = 0.0;
            Marks = new List<double>(PrepodForm.NumberOfCertifications) {0.0, 0.0, 0.0, 0.0, 0.0};
        }
        public Subject(NameSubject subject)
        {
            Id++;
            this.AverageRating = 0.0;
            this.NameSubject = subject;
            Marks = new List<double>(PrepodForm.NumberOfCertifications) {0.0, 0.0, 0.0, 0.0, 0.0};
        }
        public void CountAverageRating()
        {
            foreach (var item in Marks)
            {
                this.AverageRating += item;
            }
            this.AverageRating /= (Marks.Count + 1);
        }
    }
}
