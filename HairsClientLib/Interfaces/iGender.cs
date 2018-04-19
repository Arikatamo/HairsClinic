using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    public interface iGender
    {
        GenderS Add(GenderS item);
        IList<GenderS> GetAll();
        void Remove(GenderS item);
        void SaveChanges();
        void Dispose();
    }
}
