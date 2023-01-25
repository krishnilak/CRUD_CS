using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_CS
{
    internal class Student
    {
        public string studentName { get; set; }
        public string module { get; set; }

        public void add(String sname, String m)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=crudcs;uid=root;password=root;");

            String sql = "insert into Student(student_name, module) values ('" + sname + "','" + m + "')";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void remove(String sname)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=crudcs;uid=root;password=root;");

            String sql = "delete from Student where student_name = '" + sname + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void update(String sname, String m)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=crudcs;uid=root;password=root;");

            String sql = "update Student set module =  '" + m + "' where student_name = '" + sname + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Student> view()
        {
            List<Student> students = new List<Student>();
            MySqlConnection con1 = new MySqlConnection("server=localhost;database=crudcs;uid=root;password=root;");
            con1.Open();
            String sql1 = "select * from Student";
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            //  MySqlDataAdapter da=new MySqlDataAdapter(cmd1);


            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student();
                s.studentName = reader["student_name"].ToString();
                s.module = reader["module"].ToString();
               
                students.Add(s);
            }

            con1.Close();
            return students;
        }

    }
}
