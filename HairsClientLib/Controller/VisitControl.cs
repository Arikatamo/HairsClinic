using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class VisitControl: iVisit
    {
        EFContext context;
        public VisitControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Visit Add(Visit item)
        {
            return context.Visits.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Visit> GetAll()
        {
            return context.Visits.ToList();
        }

        public void Remove(Visit item)
        {
            context.Visits.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
