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
      
        public bool AddCauHoi(CauHoi ch)
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
            {
                try
                {
                    Db.CauHois.Add(ch);
                    Db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                { return false; }
            }
            

        }
        public bool DeleteCauHoi(int Id)
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
            {
                try
                {
                    CauHoi ch = Db.CauHois.Find(Id);
                    Db.CauHois.Remove(ch);

                    List<DapAn> da = Db.DapAns.Where(x => x.ID_CauHoi == Id).ToList();
                    for (int i = 0; i < da.Count; i++)
                    {
                        Db.DapAns.Remove(da[i]);
                    }
                    Db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool AddDapAn(DapAn da)
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
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
        }
       
        public List<CauHoi> GetListCauHoiByMonHoc(int MonHoc)
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
            {
                return Db.CauHois.Where(x=>x.ID_MonHoc == MonHoc).OrderBy(x=>x.MaCauHoi).ToList();
            }
        }
        public CauHoi GetListCauHoiByID(int ID)
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
            {
                return Db.CauHois.Find(ID);
            }
        }
        public List<DapAn> GetListDapAn(int CauHoiID)
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
            {
                return Db.DapAns.Where(x => x.ID_CauHoi == CauHoiID).ToList();
            }
        }
        public List<CauHoi> GetList()
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
            {
                return Db.CauHois.OrderByDescending(x => x.MaCauHoi).ToList();
            }
        }
        public int GetIDByMa(string MA)
        {
            using (SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities())
            {
                return Db.CauHois.Where(x => x.MaCauHoi == MA.Trim()).FirstOrDefault().ID;
            }
        }
    }
}
