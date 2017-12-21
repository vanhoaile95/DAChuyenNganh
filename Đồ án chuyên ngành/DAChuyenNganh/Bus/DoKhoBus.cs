using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace Bus
{
    public class DoKhoBus
    {
        public List<Common.DoKho> GetList()
        {
            return new DoKhoDal().GetList();
        }
        public int GetIDByName(string Name)
        {
            return new DoKhoDal().GetIDByName(Name);
        }
        public string GetNameById(int? Id)
        {
            return new DoKhoDal().GetNameById(Id);
        }
    }
}
