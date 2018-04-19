using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
   public class ImageControl: iImageLogo
    {
        EFContext context;
        public ImageControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public ImageLogo Add(ImageLogo item)
        {
            return context.ImageLogos.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ImageLogo> GetAll()
        {
            return context.ImageLogos.ToList();
        }

        public void Remove(ImageLogo item)
        {
            context.ImageLogos.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
