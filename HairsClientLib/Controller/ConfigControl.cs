using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    class ConfigControl : iConfigs
    {
        EFContext context;
        public ConfigControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Diagnoses Add(Diagnoses item)
        {
            return context.ConfigHairs.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Diagnoses> GetAll()
        {
            return context.ConfigHairs.ToList();
        }

        public void Remove(Diagnoses item)
        {
            context.ConfigHairs.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
