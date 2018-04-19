using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Interfaces
{
    /// <summary>
    /// Контакты
    /// </summary>
    public interface iContacts
    {
        ContactS Add(ContactS item);
        IList<ContactS> GetAll();
        void Remove(ContactS item);
        void SaveChanges();
        void Dispose();
    }
}
