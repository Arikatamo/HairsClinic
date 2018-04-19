using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iReportField
    {
        Reportfield Add(Reportfield item);
        IList<Reportfield> GetAll();
        void Remove(Reportfield item);
        void SaveChanges();
        void Dispose();
    }
}
