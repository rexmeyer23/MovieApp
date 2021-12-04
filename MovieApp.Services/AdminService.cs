using MovieApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Services
{
    public class AdminService
    {
        private readonly Guid _profileID;
        public AdminService(Guid profileID)
        {
            _profileID = profileID;
        }
//        public RemoveProfile(int removeID)
//        {
//            using (var ctx = new ApplicationDbContext())
//                var entity =
//                    ctx
//                    .Profiles
//                    .Single(e => e.RemoveID == removeID && e.ProfileID == _profileID);

//            ctx.Profiles.Remove(entity);
//            return ctx.SaveChanges() == 1;
//        }

//    }
//}
