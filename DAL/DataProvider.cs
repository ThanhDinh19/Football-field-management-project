using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Class để kết nối đến Database
    public class DataProvider
    {
        static string server = "DESKTOP-9GVK8OD\\SQLEXPRESS"; //Server Name
        static string userID = "; User ID = sa"; //Nếu dùng Windows Authentication thì userID = ""
        static string password = "; Password = 123"; //Nếu dùng Windows Authentication thì password = ""
        public static string connectionString = "Data Source= " + server + ";Initial Catalog=QL_SanBongMini;Integrated Security=True" + userID + password;
        protected SqlConnection conn = new SqlConnection(connectionString);

        public DataTable ExecQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable data = new DataTable();

            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(data);
                }
            }
            return data;
        }

        public int ExecNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            int data = 0;
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                data = cmd.ExecuteNonQuery();
            }
            return data;
        }

        public object ExecScalar(string query, Dictionary<string, object> parameters = null)
        {
            object data = null;

            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                data = cmd.ExecuteScalar();
            }
            return data;
        }
    }
}
