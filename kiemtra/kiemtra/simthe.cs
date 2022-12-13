using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra
{
    class simthe
    {

        private string _iD;
        private string _SoSim;
        private string _MangID;
        private DateTime _NgayKichHoat;
        private DateTime _NgayHetHan; 
        

        public string ID { get => _iD; set => _iD = value; }
        public string SoSim { get => _SoSim; set => _SoSim = value; }
        public string MangID { get => _MangID; set => _MangID = value; }
        public DateTime NgayKichHoat { get => _NgayKichHoat; set => _NgayKichHoat = value; }
        public DateTime NgayHetHan { get => _NgayHetHan; set => _NgayHetHan = value; }

        public simthe() { }
    }
}
