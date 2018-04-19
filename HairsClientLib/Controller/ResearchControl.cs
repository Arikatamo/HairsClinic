using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class ResearchControl : iResearch
    {
        EFContext context;
        public ResearchControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Research Add(Research item)
        {
            return context.Research.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Research> GetAll()
        {
            return context.Research.ToList();
        }

        public void Remove(Research item)
        {
            context.Research.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
