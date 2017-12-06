using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using Common;

namespace Dal
{
    public class LoginDal
    {
        public static SoanThaoDeThiEntities Db = new SoanThaoDeThiEntities();
        public string Test()
        {
            Db = new SoanThaoDeThiEntities();
            //User user = Db.Users.First();
            //return user.Username;
            return "Ds";
        }
        
    }
}
