using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairsClientLib.Interfaces;
using HairsClientLib.Lib;

namespace HairsClientLib.Controller
{
    public class CommentTypeControl : iComentaryType
    {
        EFContext context;
        public CommentTypeControl(EFContext eFContext)
        {
            context = eFContext;
        }
        public CommentaryType Add(CommentaryType item)
        {
            return context.CommentTypes.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<CommentaryType> GetAll()
        {
            return context.CommentTypes.ToList();
        }

        public void Remove(CommentaryType item)
        {
            context.CommentTypes.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
