using Common;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    public class DeThiBus
    {
        public bool LuuDeThi(DeThi de)
        {
            return new DeThiDal().LuuDeThi(de);
        }
        public bool LuuChiTietDe(ChiTietDeThi detail)
        {
            return new DeThiDal().LuuChiTietDe(detail);
        }
        public List<DeThi> GetListDeByMonHoc(string MonHoc)
        {
            return new DeThiDal().GetListDeByMonHoc(MonHoc);
        }
        public List<CauHoi> GetListCauHoi(string Made)
        {
            return (new DeThiDal()).GetListCauHoi(Made);

            
        }
    }
}
