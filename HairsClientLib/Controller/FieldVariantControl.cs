using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
   public class FieldVariantControl: iFieldVariant
    {
        EFContext context;
        public FieldVariantControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public FieldVariants Add(FieldVariants item)
        {
            return context.FieldVariant.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<FieldVariants> GetAll()
        {
            return context.FieldVariant.ToList();
        }

        public void Remove(FieldVariants item)
        {
            context.FieldVariant.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
