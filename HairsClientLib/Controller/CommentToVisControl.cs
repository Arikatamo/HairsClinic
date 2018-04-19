using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class CommentToVisControl : iComentaryToVisit
    {
        EFContext context;
        public CommentToVisControl(EFContext eFContext)
        {
            context = eFContext;
        }

        public CommentaryToVisit Add(CommentaryToVisit item)
        {
            return context.CommentToVisits.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<CommentaryToVisit> GetAll()
        {
            return context.CommentToVisits.ToList();
        }

        public void Remove(CommentaryToVisit item)
        {
            context.CommentToVisits.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
