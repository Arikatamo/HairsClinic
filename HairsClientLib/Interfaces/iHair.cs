using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iHair
    {
        Hair Add(Hair item);
        IList<Hair> GetAll();
        void Remove(Hair item);
        void SaveChanges();
        void Dispose();
    }
}
