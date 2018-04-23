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
    public class HairProv : iHairProv
    {
        private iHair control;
        private AsyncConnection conntect;
        public delegate void Connected();
        public event Connected Connect;
        public HairProv()
        {
            conntect.Connect();
            conntect.Conne += Conntect_Conne;
        }

        private void Conntect_Conne(EFContext context)
        {
            control = new HairControl(context);
            Connect?.Invoke();
        }

        public Hair Add(Hair hairIn)
        {
            Hair hair = new Hair
            {
                Width = hairIn.Width,
                x1 = hairIn.x1,
                x2 = hairIn.x2,
                y2 = hairIn.y2,
                y1 = hairIn.y1
            };
            control.Add(hair);
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
