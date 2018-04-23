using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
   public interface iConfHairProv
    {
        DiagnosControl Add(DiagnosControl hair);
        void Remove(DiagnosControl item);
        DiagnosControl Get(int id);
        IList<DiagnosControl> GetAll();
        void Dispose();
    }
}
