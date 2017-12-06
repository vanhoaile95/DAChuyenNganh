using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Dal
{
    public class CauHoiDal
    {
        public static SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities();
        public bool AddCauHoi(CauHoi ch)
        {
            try
            {
                Db.CauHois.Add(ch);
                Db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            { return false; }
            

        }
        public bool AddDapAn(DapAn da)
        {
            try
            {
                Db.DapAns.Add(da);
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public List<CauHoi> GetListCauHoi()
        {
            return Db.CauHois.ToList();
        }
        public List<DapAn> GetListDapAn(int CauHoiID)
        {
            return Db.DapAns.Where(x => x.ID_CauHoi == CauHoiID).ToList();
        }
    }
}
