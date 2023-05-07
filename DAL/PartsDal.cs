using DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PartsDal
    {
        public bool Insert(PartForDevice d)
        {
            try
            {
                using (DbModels.SpareDnContext ctx = new())
                {
                    ctx.PartForDevices.Add(d);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool GetAll(PartForDevice d)
        {
            try
            {
                using (DbModels.SpareDnContext ctx = new())
                {
                    ctx.PartForDevices.Add(d);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;

            }
        }

    }
}
