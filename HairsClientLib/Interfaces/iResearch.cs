using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iResearch
    {
        Research Add(Research item);
        IList<Research> GetAll();
        void Remove(Research item);
        void SaveChanges();
        void Dispose();
    }
}
