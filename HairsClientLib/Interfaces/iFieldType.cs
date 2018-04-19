using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
  public  interface iFieldType
    {
        FieldType Add(FieldType item);
        IList<FieldType> GetAll();
        void Remove(FieldType item);
        void SaveChanges();
        void Dispose();
    }
}
