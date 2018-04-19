using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public  class ResearchStatusControl: iResearchStatus
    {
        EFContext context;
        public ResearchStatusControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public ResearchStatus Add(ResearchStatus item)
        {
            return context.ResearStatus.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ResearchStatus> GetAll()
        {
            return context.ResearStatus.ToList();
        }

        public void Remove(ResearchStatus item)
        {
            context.ResearStatus.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
