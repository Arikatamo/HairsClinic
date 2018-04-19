using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
   public class PhotoControl: iPhoto
    {
        EFContext context;
        public PhotoControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public Photoses Add(Photoses item)
        {
            return context.Photos.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Photoses> GetAll()
        {
            return context.Photos.ToList();
        }

        public void Remove(Photoses item)
        {
            context.Photos.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
