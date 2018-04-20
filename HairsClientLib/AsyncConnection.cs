using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairsClientLib
{
    public class AsyncConnection
    {
        public delegate void ConectionDel(EFContext context);
        public event ConectionDel Conne;
        private EFContext context;
        public Task Connect()
        {
            return Task.Run(() =>
            {
                context = new EFContext();
                context.Configuration.AutoDetectChangesEnabled = false;
                var a = context.Access.Count();
                Conne?.Invoke(context);
            });
        }

        public Task Disconnect()
        {
            return Task.Run(() =>
            {
                context.Dispose();
                Conne?.Invoke(context);
            });
        }


    }
}
