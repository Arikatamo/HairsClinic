using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class ConfigSizeHaiControl: iConfigSize
    {
        EFContext context;
        public ConfigSizeHaiControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public ConfigHairSize Add(ConfigHairSize item)
        {
            return context.ConfHairSizes.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ConfigHairSize> GetAll()
        {
            return context.ConfHairSizes.ToList();
        }

        public void Remove(ConfigHairSize item)
        {
            context.ConfHairSizes.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
