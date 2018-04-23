using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairProvider.InterfaceProvider;
using HairsClientLib.Lib;
using static HairProvider.Provider.HairProv;

namespace HairProvider.InterfaceProvider
{
    public interface iHairProv
    {
        Hair Add(Hair hair);
        void Remove(Hair item);
        Hair Get(int id);
        IList<Hair> GetAll();
        event Connected Connect;
        void Dispose();
    }
}
