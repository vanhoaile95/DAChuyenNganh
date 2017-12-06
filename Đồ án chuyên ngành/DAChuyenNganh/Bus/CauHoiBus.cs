using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Common;
namespace Bus
{
    public class CauHoiBus
    {
        public bool AddCauHoi(CauHoi ch)
        {
            return new CauHoiDal().AddCauHoi(ch);
        }
        public bool AddDapAn(DapAn da)
        {
            return new CauHoiDal().AddDapAn(da);
        }
        public List<CauHoi> GetListCauHoi()
        {
            return new CauHoiDal().GetListCauHoi();
        }
        public List<DapAn> GetListDapAn(int CauHoiID)
        {
            return new CauHoiDal().GetListDapAn(CauHoiID);
        }
    }
}
