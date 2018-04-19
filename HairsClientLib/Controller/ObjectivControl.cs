using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
   public class ObjectivControl: iObjectives
    {
        private EFContext context;
        public ObjectivControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Objectives Add(Objectives item)
        {
            return context.Objectivs.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Objectives> GetAll()
        {
            return context.Objectivs.ToList();
        }

        public void Remove(Objectives item)
        {
            context.Objectivs.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
