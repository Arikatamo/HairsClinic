using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HairProvider.InterfaceProvider;
using HairsClientLib.Lib;
using HairsClientLib;
using HairsClientLib.Interfaces;
using HairsClientLib.Controller;

namespace HairProvider.Provider
{
    class HairProv : iHairProv
    {
        private iHair control;
        private AsyncConnection conntect;
        public delegate void HairsD();
        public event HairsD CheckConnect;
        public HairProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }

        private void Conntect_Conne(EFContext context)
        {
            control = new HairControl(context);
            CheckConnect?.Invoke();
        }

        public Hair Add(int Width, int x1, int y1, int x2, int y2)
        {
            Hair hair = new Hair
            {
                Width = Width,
                x1 = x1,
                x2 = x2,
                y2 = y2,
                y1 = y1
            };
            control.SaveChanges();
           
            return hair;
        }

        public Hair Get(int id)
        {
            Hair hair = control.GetAll().FirstOrDefault(x => x.Id == id);
            if (hair != null)
            {
                return hair;
            }
            else
            {
                throw new Exception("Not such id in Database");
            }
           
        }

        public IList<Hair> GetAll()
        {
            IList<Hair> hair = control.GetAll();
            if (hair!= null)
            {
                return hair;
            }
            else
            {
                throw new Exception("DataBase is Null");
            }
        }

        public void Remove(Hair item)
        {
            if (item != null)
            {
                control.Remove(item);
                control.SaveChanges();
            }
            else
            {
                throw new Exception("Item is Null");
            }
        }

        public void Dispose()
        {
            control.Dispose();
        }
    }
}
