using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    class ConfigStaticNormControl: iConfigStaticNorm
    {
        EFContext context;
        public ConfigStaticNormControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public ConfigStaticNormales Add(ConfigStaticNormales item)
        {
            return context.ConfigStaticNormales.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ConfigStaticNormales> GetAll()
        {
            return context.ConfigStaticNormales.ToList();
        }

        public void Remove(ConfigStaticNormales item)
        {
            context.ConfigStaticNormales.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
