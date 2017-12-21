using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Common;

namespace Bus
{
    public class MonHocBus
    {
        public List<MonHoc> GetList()
        {
            return new MonHocDal().GetList();
        }
        public int GetIdByName(string Name)
        {
            return new MonHocDal().GetIdByName(Name);
        }
        public string GetNameByID(int? Id)
        {
            return new MonHocDal().GetNameByID(Id);
        }
    }
}
