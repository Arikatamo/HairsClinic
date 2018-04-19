using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
  public  interface iPatientStatus
    {
        StatusesForPatient Add(StatusesForPatient item);
        IList<StatusesForPatient> GetAll();
        void Remove(StatusesForPatient item);
        void SaveChanges();
        void Dispose();
    }
}
