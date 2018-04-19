using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iConfigs
    {
        ConfigHair Add(ConfigHair item);
        IList<ConfigHair> GetAll();
        void Remove(ConfigHair item);
        void SaveChanges();
        void Dispose();
    }
}
