using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    public interface iComentaryToVisit
    {
        CommentaryToVisit Add(CommentaryToVisit item);
        IList<CommentaryToVisit> GetAll();
        void Remove(CommentaryToVisit item);
        void SaveChanges();
        void Dispose();
    }
}
