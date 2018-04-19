using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class DiagnosControl: iDiagnos
    {
        EFContext context;
        public DiagnosControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Diagnoses Add(Diagnoses item)
        {
            return context.Diagnos.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Diagnoses> GetAll()
        {
           return context.Diagnos.ToList();
        }

        public void Remove(Diagnoses item)
        {
            context.Diagnos.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
