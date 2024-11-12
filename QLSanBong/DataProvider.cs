using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong
{
    public class DataProvider
    {
        public string ConnectionString = "Data Source=DESKTOP-RSGJD4U\\THANHDINH;Initial Catalog=QL_SanBongMini;Integrated Security=True";

        public DataTable ExecQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
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
            }
            return data;
        }


        public int ExecNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
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
            }
            return data;
        }


        public object ExecScalar(string query, Dictionary<string, object> parameters = null)
        {
            object data = null;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
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
            }
            return data;
        }

    }
}
