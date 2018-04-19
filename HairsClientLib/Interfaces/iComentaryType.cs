using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
   public interface iComentaryType
    {
        CommentaryType Add(CommentaryType item);
        IList<CommentaryType> GetAll();
        void Remove(CommentaryType item);
        void SaveChanges();
        void Dispose();
    }
}
