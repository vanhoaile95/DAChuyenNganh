using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using Common;

namespace Dal
{
    public class LoginDal
    {
        public static CHTracNghiemEntities Db = new CHTracNghiemEntities();
        public string Test()
        {
            Db = new CHTracNghiemEntities();
            User user = Db.Users.First();
            return user.Username;
        }
    }
}
