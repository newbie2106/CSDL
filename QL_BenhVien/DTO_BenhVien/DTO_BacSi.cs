using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BenhVien
{
    public class DTO_BacSi
    {
        private int id;
        private string firstName;
        private string lastName;
        private int idNganh;
        private string taiKhoan;
        private string matKhau;

        public DTO_BacSi() { }

        public DTO_BacSi(int id, string firstName, string lastName, int idNganh, string taiKhoan, string matKhau)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNganh = idNganh;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int IdNganh { get => idNganh; set => idNganh = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
