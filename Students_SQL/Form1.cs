using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Students_SQL
{


    public partial class Form1 : Form
    {
        private void RefreshDataGrid<T>(List<T> list)
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = list;
        }

        private void ClearFields()
        {
            foreach (Control field in grboxAdd.Controls)
            {

                if (field is TextBox) field.Text = string.Empty;
                if (field is ComboBox) ((ComboBox)field).SelectedIndex = -1;
            }
        }

        public static bool OnlyNumbers(string str)
        {
            foreach (char ch in str)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        private async void ShowAllStudents()
        {
            DataAccess DB = new DataAccess();
            students = await DB.ShowAllAsync<Student>("STUDENTS");
            RefreshDataGrid<Student>(students);
        }

        //Link columns to orderBy groupbox
        private async Task PopulateComboBoxes()
        {
            DataAccess DB = new DataAccess();
            boxOrderBy.DataSource = await DB.GetColumnsAsync();
            boxTables.DataSource = await DB.GetTablesAsync();

        }


        //Find all students using groupBox1 settings
        internal async Task FindStudentsAsync()
        {
            DataAccess DB = new DataAccess();

            int id = 0, age = 0;
            int.TryParse(boxFindId.Text, out id);
            int.TryParse(boxFindAge.Text, out age);

            students = await DB.FindStudents(
                id,
                boxFindFirstName.Text,
                boxFindLastName.Text,
                age,
                boxFindPhone.Text,
                boxFindEmail.Text,
                boxFindGender.Text,
                orderBy: boxOrderBy.Text,
                orderMode: orderState ? "DESC" : "ASC"
            );
            RefreshDataGrid<Student>(students);
        }


        //Make all boxes of groupbox linked to function
        private void InitializeEventHandlers(GroupBox group)
        {
            foreach (Control control in group.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.TextChanged += async (sender, e) => await FindStudentsAsync();
                }
                if (control is Button)
                {
                    control.Click += async (sender, e) => await FindStudentsAsync();
                }

            }
        }



        /// 
        //GLOBAL VARIABLES

        List<Student> students = new List<Student>();
        List<Subject> subjects = new List<Subject>();

        bool orderState = false; // false = desc, true = asc



        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers(groupBox1);
            PopulateComboBoxes();
            ShowAllStudents();


            buttonOrderBy.Text = char.ConvertFromUtf32(0x2193);


        }

        //Add new user
        private async void buttonAdd_Click(object sender, EventArgs e)
        {

            string fname = boxFirstName.Text.Trim(),
             lname = boxLastName.Text.Trim(),
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
            if (phone.Length > 12 || !OnlyNumbers(phone))
            {
                MessageBox.Show("Max phone length is 12 numbers\nOnly numbers allowed");
                return;
            }


            //add student 
            try
            {
                DataAccess DB = new DataAccess();
                await DB.AddStudent(fname, lname, age, gender, email, phone);
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await FindStudentsAsync();
            }
        }

        //Change order (descending or ascending) 
        private void buttonOrderBy_Click(object sender, EventArgs e)
        {
            if (orderState) // asc
            {
                buttonOrderBy.Text = char.ConvertFromUtf32(0x2193); // up   
            }
            else
            {
                buttonOrderBy.Text = char.ConvertFromUtf32(0x2191); // down

            }
            orderState = !orderState;




        }

        //Delete with selected id
        private async void buttonDelete_Click(object sender, EventArgs e)
        {

            int selected_id = -1;

            if (DataGrid.Rows.Count > 0)
                selected_id = (int)DataGrid.SelectedRows[0].Cells["id"].Value;
            else MessageBox.Show("Table is empty");

            if (selected_id > 0)
            {

                DataAccess DB = new DataAccess();
                await DB.DeleteAsync(selected_id);

            }

        }

        //generate  pseudo-random records from file names.txt and lastnames.txt
        private async void buttonGenerateData_Click(object sender, EventArgs e)
        {
            string[] names = File.ReadAllLines("C:\\Users\\user\\OneDrive\\Рабочий стол\\c#\\Students SQL\\Students_SQL\\Students_SQL\\names.txt");
            string[] lastnames = File.ReadAllLines("C:\\Users\\user\\OneDrive\\Рабочий стол\\c#\\Students SQL\\Students_SQL\\Students_SQL\\lastnames.txt");
            int size = Math.Min(names.Length, lastnames.Length);
            int generated = 0;
            if (size > 0)
            {
                DataAccess DB = new DataAccess();
                Random random = new Random();

                for (int i = 0; i < size; i++)
                {
                    int age = random.Next(1, 100);
                    string phone = "380" + random.Next(100, 1000) + random.Next(1000, 10000);
                    string gender = random.Next(2) == 1 ? "Male" : "Female";

                    await DB.AddStudent(names[i], lastnames[i], age, gender, names[i] + lastnames[i] + "@" + "gmail.com", phone);
                    generated++;
                }
                ShowAllStudents();
                MessageBox.Show($"Generated {generated} records");
            }
        }





        private async void boxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess DB = new DataAccess();
            string table = boxTables.Text.Trim().ToLower();

            switch (table)
            {
                case "students":
                    students = await DB.ShowAllAsync<Student>(table);
                    RefreshDataGrid<Student>(students);
                    break;
                case "subjects":
                    subjects = await DB.ShowAllAsync<Subject>(table);
                    RefreshDataGrid<Subject>(subjects);
                    break;
                default:
                    MessageBox.Show("Failed to connect");
                    break;
            }

        }

        private async void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            int id = (int)DataGrid.Rows[row].Cells[0].Value;

            DataAccess DB = new DataAccess();

            Student student = (await DB.FindStudents(id)).SingleOrDefault();


            EditForm editForm = new EditForm(student);

            editForm.ShowDialog();

            await FindStudentsAsync();

        }
    }
}
