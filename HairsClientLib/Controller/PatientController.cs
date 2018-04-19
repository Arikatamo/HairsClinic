using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Controller
{
    public class PatientController : iPatient
    {
        EFContext context;
        public PatientController(EFContext eFContext)
        {
            context = eFContext;
        }
        public Patient Add(Patient item)
        {
            return context.Patient.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Patient> GetAll()
        {
            return context.Patient.ToList();
        }

        public void Remove(Patient item)
        {
            context.Patient.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
