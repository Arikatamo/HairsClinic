using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
   public interface iFieldTypeProv
    {
        FieldTypeControl Add(FieldTypeControl type);
        void Remove(FieldTypeControl item);
        FieldTypeControl Get(int id);
        IList<FieldTypeControl> GetAll();
        void Dispose();
    }
}
