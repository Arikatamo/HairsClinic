using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
   public interface iReportTemplateProv
    {
        ReportTemplControl Add(ReportTemplControl hair);
        void Remove(ReportTemplControl item);
        ReportTemplControl Get(int id);
        IList<ReportTemplControl> GetAll();
        void Dispose();
    }
}
