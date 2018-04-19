using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iUser
    {
        User Add(User item);
        IList<User> GetAll();
        void Remove(User item);
        void SaveChanges();
        void Dispose();
    }
}
