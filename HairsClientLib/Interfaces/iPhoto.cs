using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iPhoto
    {
        Photoses Add(Photoses item);
        IList<Photoses> GetAll();
        void Remove(Photoses item);
        void SaveChanges();
        void Dispose();
    }
}
