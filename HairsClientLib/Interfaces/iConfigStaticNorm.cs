using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iConfigStaticNorm
    {
        ConfigStaticNormales Add(ConfigStaticNormales item);
        IList<ConfigStaticNormales> GetAll();
        void Remove(ConfigStaticNormales item);
        void SaveChanges();
        void Dispose();
    }
}
