using PMIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS.DAL
{
    public class UsersData
    {
        public static Users checkIfExists(Users model)
        {
            using (DB context = new DB())
            {
                Users user = context.Users.Where(o => o.Username.Equals(model.Username) && o.Password.Equals(model.Password)).SingleOrDefault();

                return user;
            }

        }
    }
}
