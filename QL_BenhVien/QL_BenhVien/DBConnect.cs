using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhVien
{
    internal class DBConnect
    {
       public SqlConnection connection()
        {
            //string Adres = System.IO.File.ReadAllText(@"E:\QL_BenhVien\connection.txt");
            SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-9TNEKCVK\\TAN_DAT;Initial Catalog=HOSPITALDB;Integrated Security=True");
            _conn.Open();
            return _conn;
        }
    }
}
