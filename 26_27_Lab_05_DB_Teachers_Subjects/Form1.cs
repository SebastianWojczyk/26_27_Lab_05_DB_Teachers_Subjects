using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _26_27_Lab_05_DB_Teachers_Subjects
{
    public partial class Form1 : Form
    {
        private DBDataContext db = new DBDataContext();
        public Form1()
        {
            InitializeComponent();
            ReadTeachers();
        }

        private void ReadTeachers()
        {
            listBoxTeachers.Items.Clear();
            listBoxTeachers.Items.AddRange(db.Teachers.ToArray());
        }

        private void listBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeachers.SelectedItem is Teacher)
            {
                flowLayoutPanelSubjects.Controls.Clear();

                Teacher teacher = listBoxTeachers.SelectedItem as Teacher;
                foreach (Subject subject in teacher.Subjects)
                {
                    flowLayoutPanelSubjects.Controls.Add(new UserControlSubject(subject));
                }
            }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            if (listBoxTeachers.SelectedItem is Teacher)
            {
                flowLayoutPanelSubjects.Controls.Add(new UserControlSubject(null));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxTeachers.SelectedItem is Teacher)
            {
                Teacher teacher = listBoxTeachers.SelectedItem as Teacher;
                foreach (UserControlSubject userControlSubject in flowLayoutPanelSubjects.Controls)
                {
                    userControlSubject.UpdateSubject(teacher);//teacher potrzebny dla nowych przedmiotów
                }
                db.SubmitChanges();
            }
            flowLayoutPanelSubjects.Controls.Clear();
            ReadTeachers();
        }
    }
}
