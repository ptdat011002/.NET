using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra
{
    class simthe
    {
        private string _id;
        private string _sosim;
        private string _mangid;
        private DateTime ngaykichhoat;
        private DateTime ngayhethan;

        public string Id { get => _id; set => _id = value; }
        public string Sosim { get => _sosim; set => _sosim = value; }
        public string Mangid { get => _mangid; set => _mangid = value; }
        public DateTime Ngaykichhoat { get => ngaykichhoat; set => ngaykichhoat = value; }
        public DateTime Ngayhethan { get => ngayhethan; set => ngayhethan = value; }

        public simthe() { }
    }
}
