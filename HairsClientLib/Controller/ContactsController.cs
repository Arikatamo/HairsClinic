using HairsClientLib.Interfaces;
using HairsClientLib.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib.Controller
{
    public class ContactsController : iContacts
    {
        EFContext context;
        public ContactsController(EFContext eFContext)
        {
            context = eFContext;
        }
        public ContactS Add(ContactS item)
        {
            return context.Contacts.Add(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<ContactS> GetAll()
        {
            return context.Contacts.ToList();
        }

        public void Remove(ContactS item)
        {
            context.Contacts.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
