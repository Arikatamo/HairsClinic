using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairProvider.InterfaceProvider;
using HairsClientLib.Controller;
using HairsClientLib.Lib;

namespace HairProvider.InterfaceProvider
{
    public interface iHairProv
    {
        Hair Add(int height, int x1,int y1,int x2,int y2);
        void Remove(Hair item);
        Hair Get(int id);
        IList<Hair> GetAll();
        void Dispose();
    }
}
