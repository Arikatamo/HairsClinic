using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    public interface iAccesRight
    {
        AccesRight AddVitamins(AccesRight vitamin);
        IList<AccesRight> GetAllVit();
        int Remove(AccesRight Vitamin);
        void SaveChanges();
        void Dispose();
    }
}
