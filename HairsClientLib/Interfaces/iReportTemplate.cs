using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    public interface iReportTemplate
    {
        ReportTemplate Add(ReportTemplate item);
        IList<ReportTemplate> GetAll();
        void Remove(ReportTemplate item);
        void SaveChanges();
        void Dispose();
    }
}
