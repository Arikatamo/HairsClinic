using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Controller
{
    public class StatusPatientController : iPatientStatus
    {
        EFContext context;
        public StatusPatientController(EFContext eFContext)
        {
            context = eFContext;
        }


        public StatusesForPatient Add(StatusesForPatient item)
        {
            return context.StatusesPatient.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<StatusesForPatient> GetAll()
        {
            return context.StatusesPatient.ToList();
        }

        public void Remove(StatusesForPatient item)
        {
            context.StatusesPatient.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
