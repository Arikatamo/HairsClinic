using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iResearchStatus
    {
        ResearchStatus Add(ResearchStatus item);
        IList<ResearchStatus> GetAll();
        void Remove(ResearchStatus item);
        void SaveChanges();
        void Dispose();
    }
}
