using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
   public interface iFieldVariantProv
    {
        FieldVariantControl Add(FieldVariantControl variant);
        void Remove(FieldVariantControl item);
        FieldVariantControl Get(int id);
        IList<FieldVariantControl> GetAll();
        void Dispose();
    }
}
