using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagingSystem.BL;
using MySql.Data;
using MySql;
using MySqlConnector;
namespace MessagingSystem.DL
{
    public class MUserStore
    {
        //public List<MUser> store = new List<MUser>();
        public void addUser(MUser user)
        {
            
            String constring = "Server = {0}; Uid= {1}; Pwd = {2}; Database = {3}";
            constring = String.Format(constring, "localhost", "root", "1234", "mailsystem");
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string dml = "insert into musers values('{0}','{1}')";
            dml = String.Format(dml, user.userName, user.password);
            Console.WriteLine(dml);
            MySqlCommand cmd = new MySqlCommand(dml,con);
            cmd.ExecuteNonQuery();
            con.Close();
          //  store.Add(user);
        }
        public List<MUser> getAll()
        {
            List<MUser> store = new List<MUser>();
            string constring = "Server = {0};Uid={1};Pwd={2};Database= {3}";
            constring = String.Format(constring, "localhost", "root", "1234", "mailsystem");
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string query = "select * from musers";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader =  cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["username"].ToString();
                string password = reader["password"].ToString();
                MUser user = new MUser(name, password);
                store.Add(user);
            }
            con.Close();
            return store;
        }
    }
}
