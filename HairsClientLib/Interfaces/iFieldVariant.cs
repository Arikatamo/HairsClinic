using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    //⦁	Вариант поля 
    public interface iFieldVariant
    {
        FieldVariants Add(FieldVariants item);
        IList<FieldVariants> GetAll();
        void Remove(FieldVariants item);
        void SaveChanges();
        void Dispose();
    }
}
