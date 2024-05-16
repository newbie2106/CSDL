using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_BenhVien
{
    public class DBConnect
    {
        string Adres = System.IO.File.ReadAllText(@"E:\QL_BenhVien\connection.txt");
        protected SqlConnection _conn = new SqlConnection ("Adres");
    }
}
