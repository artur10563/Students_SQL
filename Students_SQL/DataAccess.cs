using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Students_SQL
{
    public class DataAccess
    {
        private string DataBase = "DB_Students";


        public async Task<List<string>> GetColumnsAsync()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(DataBase)))
            {
                string sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'STUDENTS'";
                var result = await connection.QueryAsync<string>(sql);
                return result.ToList();
            }
        }

        public async Task<List<string>> GetTablesAsync()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(DataBase)))
            {
                string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
                var result = await connection.QueryAsync<string>(sql);
                return result.ToList();
            }
        }


        public async Task<List<T>> ShowAllAsync<T>(string table)
        {
            List<string> tables = await GetTablesAsync();
            if (tables.Contains(table.ToUpper()))
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(DataBase)))
                {
                    var result = await connection.QueryAsync<T>
                        ("SELECT * FROM " + table);
                    return result.ToList();
                }
            }
            else
            {
                MessageBox.Show("INVALID TABLE");
                return new List<T>();
            }
        }

        public async Task AddStudent(string fname, string lname, int age, string gender, string email, string phone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(DataBase)))
            {

                string sql = " INSERT INTO STUDENTS(first_name,last_name,age,phone_number,email_adres, gender) " +
                    "VALUES (@fname,@lname,@age,@phone,@email,@gender)";

                var parameters = new { fname = fname, lname = lname, age = age, gender = gender, email = email, phone = phone };

                await connection.ExecuteAsync(sql, parameters);

            }
        }

        public async Task DeleteAsync(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(DataBase)))
            {
                //string sql = "TRUNCATE TABLE STUDENTS";
                string sql = "DELETE FROM STUDENTS WHERE id = @id";
                var parameters = new { id = id };

                await connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<List<Student>> FindStudents(int id = 0, string fname = "", string lname = "", int age = 0, string phone = "", string email = "", string gender = "",
            string orderBy = "", string orderMode = "")
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(DataBase)))
            {
                StringBuilder sqlBuilder = new StringBuilder();
                var parameters = new DynamicParameters();


                //generate query
                sqlBuilder.Append("SELECT * FROM STUDENTS WHERE 1=1");
                sqlBuilder.Append(id == 0 ? "" : " AND id = @id");
                sqlBuilder.Append(string.IsNullOrWhiteSpace(fname) ? "" : " AND first_name LIKE @fname");
                sqlBuilder.Append(string.IsNullOrWhiteSpace(lname) ? "" : " AND last_name LIKE @lname");
                sqlBuilder.Append(age == 0 ? "" : " AND age = @age");
                sqlBuilder.Append(string.IsNullOrWhiteSpace(phone) ? "" : " AND phone_number LIKE @phone");
                sqlBuilder.Append(string.IsNullOrWhiteSpace(email) ? "" : " AND email_adres LIKE @email");
                sqlBuilder.Append(string.IsNullOrWhiteSpace(gender) ? "" : " AND gender = @gender");

                //ORDER OPTIONS
                sqlBuilder.Append(string.IsNullOrWhiteSpace(orderBy) ? "" : $" ORDER BY {orderBy} ");
                sqlBuilder.Append(string.IsNullOrWhiteSpace(orderBy) && string.IsNullOrWhiteSpace(orderMode) ? "" : $"{orderMode}");

                //add parameters
                parameters.Add("@id", id);
                parameters.Add("@fname", fname + "%");
                parameters.Add("@lname", lname + "%");
                parameters.Add("@age", age);
                parameters.Add("@phone", phone + "%");
                parameters.Add("@email", email + "%");
                parameters.Add("@gender", gender);



                var result = await connection.QueryAsync<Student>(sqlBuilder.ToString(), parameters);
                return result.ToList();
            }
        }

        public async Task RedactStudent(int id, string fname = "", string lname = "", int age = 0, string phone = "", string email = "", string gender = "")
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal(DataBase)))
            {
                //string sql = "TRUNCATE TABLE STUDENTS";

                string sql = "UPDATE STUDENTS " +
                             "SET first_name = @fname, last_name = @lname, age = @age, phone_number = @phone, email_adres = @email, gender = @gender " +
                             "WHERE id = @id";

                var parameters = new { id = id, fname = fname, lname = lname, age = age, phone = phone, email = email, gender = gender };
                await connection.ExecuteAsync(sql, parameters);
            }
        }


    }
}
