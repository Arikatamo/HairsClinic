using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
   public interface iReportFieldProv
    {
        ReportFieldControl Add(ReportFieldControl hair);
        void Remove(ReportFieldControl item);
        ReportFieldControl Get(int id);
        IList<ReportFieldControl> GetAll();
        void Dispose();
    }
}
