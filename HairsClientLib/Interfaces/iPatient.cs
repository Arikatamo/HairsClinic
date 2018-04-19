using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    public interface iPatient
    {
        Patient Add(Patient item);
        IList<Patient> GetAll();
        void Remove(Patient item);
        void SaveChanges();
        void Dispose();
    }
}
