using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    class FieldTypeControl : iFieldType
    {
        EFContext context;
        public FieldTypeControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public FieldType Add(FieldType item)
        {
            return context.FieldTypes.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<FieldType> GetAll()
        {
            return context.FieldTypes.ToList();
        }

        public void Remove(FieldType item)
        {
            context.FieldTypes.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
