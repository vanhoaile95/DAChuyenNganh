using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Dal
{
    public class DeThiDal
    {
        public static SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities();
        public bool LuuDeThi(DeThi de)
        {
            try
            {
                Db.DeThis.Add(de);
                Db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool LuuChiTietDe(ChiTietDeThi detail)
        {
            try
            {
                Db.ChiTietDeThis.Add(detail);
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<DeThi> GetListDeByMonHoc(string MonHoc)
        {
            return Db.DeThis.Where(x=>x.MonHoc.TenMonHoc == MonHoc.Trim()).ToList();
        }

        public List<CauHoi> GetListCauHoi(string dethi)
        {
                        
            return Db.Database.SqlQuery<CauHoi>("select ch.* from ChiTietDeThi ct, CauHoi ch, DeThi dt where dt.MaDeThi=N'"+dethi+"' and ct.ID_DeThi=dt.ID and ch.ID=ct.ID_CauHoi").ToList(); ;
        }
    }
}
