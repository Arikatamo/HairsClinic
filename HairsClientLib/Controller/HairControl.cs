using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
   public class HairControl: iHair
    {
        EFContext context;
        public HairControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Hair Add(Hair item)
        {
            return context.Hairs.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Hair> GetAll()
        {
            return context.Hairs.ToList();
        }

        public void Remove(Hair item)
        {
            context.Hairs.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
