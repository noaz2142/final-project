using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DbModels;


namespace BL
{
    public class PartBL
    {
        public bool SaveNewPart(DAL.DbModels.PartForDevice p)
        {
            try
            {
                PartsDal d = new PartsDal();
                d.Insert(p);
                return true;
            }
            catch {
                return false;
            }

        }
        public object GetParts(string recieverName = "")
        {
          /*  DAL.partDAL partDAL = new DAL.partDAL();*/

            return null;
        }

    }
}
