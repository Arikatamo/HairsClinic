using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
   public class ReportTemplControl: iReportTemplate
    {
        EFContext context;
        public ReportTemplControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public ReportTemplate Add(ReportTemplate item)
        {
            return context.ReportTemplates.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ReportTemplate> GetAll()
        {
            return context.ReportTemplates.ToList();
        }

        public void Remove(ReportTemplate item)
        {
            context.ReportTemplates.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
