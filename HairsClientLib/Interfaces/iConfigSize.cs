using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
  public  interface iConfigSize
    {
        ConfigHairSize Add(ConfigHairSize item);
        IList<ConfigHairSize> GetAll();
        void Remove(ConfigHairSize item);
        void SaveChanges();
        void Dispose();
    }
}
