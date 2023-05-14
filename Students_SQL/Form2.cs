using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_SQL
{
    public partial class EditForm : Form
    {
        private static Student SelectedStudent;

        public void FillInfo(Student student)
        {
            boxFname.Text = student.first_name;
            boxLname.Text = student.last_name;
            boxAge.Text = student.age.ToString();
            boxId.Text = student.id.ToString();
            boxGender.Text = student.gender;
            boxPhone.Text = student.phone_number;
            boxEmail.Text = student.email_adres;
        }

        public EditForm(Student student)
        {
            InitializeComponent();
            SelectedStudent = student;

            this.StartPosition = FormStartPosition.CenterScreen;
            FillInfo(SelectedStudent);
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string fname = boxFname.Text.Trim(),
             lname = boxLname.Text.Trim(),
             gender = boxGender.Text.Trim(),
             email = boxEmail.Text.Trim(),
             phone = boxPhone.Text.Trim();
            int age;

            //validate name and last name
            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Invalid name of last name");
                return;
            }

            //validate age
            if (!int.TryParse(boxAge.Text.Trim(), out age) || age < 0)
            {
                MessageBox.Show("Invalid age");
                return;
            }

            //validate gender
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Invalid gender");
                return;
            }

            //validate phone
            if (phone.Length > 12 || !Form1.OnlyNumbers(phone))
            {
                MessageBox.Show("Max phone length is 12 numbers\nOnly numbers allowed");
                return;
            }

            try
            {
                DataAccess db = new DataAccess();
                await db.RedactStudent(SelectedStudent.id, fname, lname, age, phone, email, gender);
                MessageBox.Show("Completed!", "Editing student");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
