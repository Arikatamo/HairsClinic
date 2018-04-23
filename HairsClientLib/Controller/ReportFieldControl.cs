using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class ReportFieldControl: iReportField
    {
        EFContext context;
        public ReportFieldControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Reportfield Add(Reportfield item)
        {
            return context.ReportFields.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Reportfield> GetAll()
        {
            return context.ReportFields.ToList();
        }

        public void Remove(Reportfield item)
        {
            context.ReportFields.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
