using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iVisit
    {
        Visit Add(Visit item);
        IList<Visit> GetAll();
        void Remove(Visit item);
        void SaveChanges();
        void Dispose();
    }
}
