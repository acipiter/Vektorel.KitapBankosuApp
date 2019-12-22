using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DAL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosu.BLL
{
    public class KitapYazarBL
    {
        KitapYazar ky = new KitapYazar();
        Helper hlp = new Helper();
        public bool KitapYazarEkle(KitapYazar ky)
        {
            try
            {
                SqlParameter[] p = {
                new SqlParameter("@KitapId",ky.KitapId),
                new SqlParameter("@YazarId",ky.YazarId)
                };

                return hlp.ExecuteNonQuery("Insert into tblKitapYazar values (@YazarId,@KitapId)") > 0;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
