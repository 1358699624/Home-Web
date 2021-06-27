using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YY_Dal;
using YY_Model;

namespace YY_Services
{
   public  class userInfoService
    {
        static string connection = "Data Source=.;User ID=sa;Password=Zd$1234;DataBase=NOEXDB";
        static DbContextOptions<SchoolUserInfoContext> dbContextOption = new DbContextOptions<SchoolUserInfoContext>();
        static DbContextOptionsBuilder<SchoolUserInfoContext> dbContextOptionBuilder = new DbContextOptionsBuilder<SchoolUserInfoContext>(dbContextOption);

        SchoolUserInfoContext schoolUserInfoContext = new SchoolUserInfoContext(dbContextOptionBuilder.UseSqlServer(connection).Options);
        public int Delete(int id)
        {
            var order = new UserInfo { Id = id };
            schoolUserInfoContext.Entry(order).State = EntityState.Deleted;
            return schoolUserInfoContext.SaveChanges();


        }
    }
}
