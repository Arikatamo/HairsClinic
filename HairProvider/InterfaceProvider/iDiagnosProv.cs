using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
  public  interface iDiagnosProv
    {
        Diagnoses Add(Diagnoses hair);
        void Remove(Diagnoses item);
        Diagnoses Get(int id);
        IList<Diagnoses> GetAll();
        void Dispose();
    }
}
