using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace Bus
{
   
    public class LoginBus
    {
        public string Test()
        {
            return new LoginDal().Test();
        }
    }
}
