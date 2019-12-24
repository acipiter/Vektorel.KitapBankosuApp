using System;
using System.Collections.Generic;
using System.Data;
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
        public List<Yazar> KitapYazarListesi(int kitapid)
        {
            List<Yazar> lst = new List<Yazar>();
            SqlParameter[] p = { new SqlParameter("@KitapId", kitapid) };
            SqlDataReader dr = hlp.ExecuteReader("spKitapYazarGetir", p, CommandType.StoredProcedure);
            while (dr.Read())
            {
                lst.Add(new Yazar { AdSoyad = dr["Ad"].ToString() + " " + dr["Soyad"].ToString(), Yazarid = Convert.ToInt32(dr["YazarId"]) });
            }
            dr.Close();
            return lst;
        }

    }
}
