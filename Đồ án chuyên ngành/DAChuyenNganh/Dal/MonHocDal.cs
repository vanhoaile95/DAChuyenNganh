using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MonHocDal
    {
        public static SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities();
        public List<MonHoc> GetList()
        {
            return Db.MonHocs.ToList();
        }
        public int GetIdByName(string Name)
        {
            var result = Db.MonHocs.Where(x => x.TenMonHoc == Name).FirstOrDefault();
            if (result != null)
                return result.ID;
            else
                return -1;
        }
        public string GetNameByID(int? Id)
        {
            return Db.MonHocs.Find(Id).TenMonHoc;
        }
    }
}
