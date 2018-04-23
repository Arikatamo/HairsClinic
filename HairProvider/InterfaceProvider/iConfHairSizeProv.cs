using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
    public interface iConfHairSizeProv
    {
        ConfigSizeHaiControl Add(ConfigSizeHaiControl hair);
        void Remove(ConfigSizeHaiControl item);
        ConfigSizeHaiControl Get(int id);
        IList<ConfigSizeHaiControl> GetAll();
        void Dispose();
    }
}
