using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iObjectives
    {
        Objectives Add(Objectives item);
        IList<Objectives> GetAll();
        void Remove(Objectives item);
        void SaveChanges();
        void Dispose();
    }
}
