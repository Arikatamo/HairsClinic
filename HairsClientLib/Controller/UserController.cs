using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class UserController : iUser
    {
        EFContext contex;
        public UserController(EFContext eFContext)
        {
            contex = eFContext;
        }
        public User Add(User item)
        {
            return contex.User.Add(item);
        }

        public void Dispose()
        {
            contex.Dispose();
        }

        public IList<User> GetAll()
        {
            return contex.User.ToList();
        }

        public void Remove(User item)
        {
            contex.User.Remove(item);
        }

        public void SaveChanges()
        {
            contex.SaveChanges();
        }
    }
}
