using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
    public interface iConfStatNormProv
    {
        ConfigStaticNormControl Add(ConfigStaticNormControl hair);
        void Remove(ConfigStaticNormControl item);
        ConfigStaticNormControl Get(int id);
        IList<ConfigStaticNormControl> GetAll();
        void Dispose();
    }
}
