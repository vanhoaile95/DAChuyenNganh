using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DoKhoDal
    {
        public static SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities();
        public List<Common.DoKho> GetList()
        {
            return Db.DoKhoes.ToList();
        }
        public int GetIDByName(string Name)
        { 
            var result = Db.DoKhoes.Where(x => x.MoTa == Name).FirstOrDefault();
            if (result != null)
                return result.ID;
            else
                return -1;
        }
        public string GetNameById(int? Id)
        {
            return Db.DoKhoes.Find(Id).MoTa;
        }
    }
}
