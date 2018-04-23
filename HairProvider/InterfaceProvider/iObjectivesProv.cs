using HairsClientLib.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairProvider.InterfaceProvider
{
   public interface iObjectivesProv
    {
        ObjectivControl Add(ObjectivControl hair);
        void Remove(ObjectivControl item);
        ObjectivControl Get(int id);
        IList<ObjectivControl> GetAll();
        void Dispose();
    }
}
