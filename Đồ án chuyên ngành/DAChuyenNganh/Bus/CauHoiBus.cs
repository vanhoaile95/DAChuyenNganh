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
        public bool DeleteCauHoi(int Id)
        {
            return new CauHoiDal().DeleteCauHoi(Id);
        }
        public bool AddDapAn(DapAn da)
        {
            return new CauHoiDal().AddDapAn(da);
        }
        public List<CauHoi> GetListCauHoiByMonHoc(int MonHoc)
        {
            return new CauHoiDal().GetListCauHoiByMonHoc(MonHoc);
        }
        public CauHoi GetListCauHoiByID(int ID)
        {
            return new CauHoiDal().GetListCauHoiByID(ID);
        }
        public List<DapAn> GetListDapAn(int CauHoiID)
        {
            return new CauHoiDal().GetListDapAn(CauHoiID);
        }
        public List<CauHoi> GetList()
        {
            return new CauHoiDal().GetList();
        }
        public int GetIDByMa(string MA)
        {
            return new CauHoiDal().GetIDByMa(MA);
        }
    }
}
