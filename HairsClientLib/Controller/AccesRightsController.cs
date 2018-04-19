using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Concrete
{
    public class AccesRightsController : iAccesRight
    {
        EFContext context;
        public AccesRightsController(EFContext _context)
        {
            context = _context;
        }
        public AccesRight AddVitamins(AccesRight vitamin)
        {
            return context.Access.Add(vitamin);
        }

        public IList<AccesRight> GetAllVit()
        {
            return context.Access.ToList();
        }

        public void Remove(AccesRight Vitamin)
        {
            context.Access.Remove(Vitamin);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
