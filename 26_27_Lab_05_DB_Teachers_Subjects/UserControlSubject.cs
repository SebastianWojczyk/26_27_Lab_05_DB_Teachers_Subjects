using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_27_Lab_05_DB_Teachers_Subjects
{
    public partial class UserControlSubject : UserControl
    {
        private Subject mySubject;
        public UserControlSubject(Subject mySubject)
        {
            InitializeComponent();
            //tylko jak jest edycja
            if (mySubject != null)
            {
                this.mySubject = mySubject;
                this.textBoxName.Text = mySubject.Name;
                this.numericUpDownHours.Value = mySubject.Hours;
            }
        }

        internal void UpdateSubject(Teacher teacher)
        {
            //dodawanie nowego czyli insert
            //przypisanie do nauczyciela z listy
            if (mySubject == null)
            {
                mySubject = new Subject();
                mySubject.Teacher = teacher;
            }
            mySubject.Name = this.textBoxName.Text;
            mySubject.Hours = (int)this.numericUpDownHours.Value;
        }
    }
}
