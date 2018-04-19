using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    public interface iImageLogo
    {
        ImageLogo Add(ImageLogo item);
        IList<ImageLogo> GetAll();
        void Remove(ImageLogo item);
        void SaveChanges();
        void Dispose();
    }
}
