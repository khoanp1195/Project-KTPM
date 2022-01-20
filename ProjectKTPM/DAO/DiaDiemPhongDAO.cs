using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM.DAO
{
    class DiaDiemPhongDAO
    {

        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);//in app.config
        public List<DiaDiemPhongBan> SelectAll()
        {

            List<DiaDiemPhongBan> hOADONs = db.DiaDiemPhongBans.ToList();
            return hOADONs;

        }
        public List<DiaDiemPhongBan> SelectByKeyword(string keyword)
        {


            List<DiaDiemPhongBan> hOADONs = db.DiaDiemPhongBans.Where(b => b.DiaDiem.Contains(keyword)).ToList();
            return hOADONs;
        }
        public DiaDiemPhongBan SelectByCode(int MAPHONG)
        {

            DiaDiemPhongBan hd = db.DiaDiemPhongBans.SingleOrDefault(b => b.MaPhong == MAPHONG);
            return hd;
        }
        public bool Insert(DiaDiemPhongBan newHoaDon)
        {

            try
            {
                db.DiaDiemPhongBans.InsertOnSubmit(newHoaDon);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Delete(int MAPHONG)
        {

            DiaDiemPhongBan dbHOADON = db.DiaDiemPhongBans.SingleOrDefault(b => b.MaPhong == MAPHONG);
            if (dbHOADON != null)
            {
                try
                {
                    db.DiaDiemPhongBans.DeleteOnSubmit(dbHOADON);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }
        public bool Update(DiaDiemPhongBan newHOADON)
        {

            DiaDiemPhongBan dbHOADON = db.DiaDiemPhongBans.SingleOrDefault(b => b.MaPhong == newHOADON.MaPhong);
            if (dbHOADON != null)
            {
                try
                {
                    dbHOADON.MaPhong= newHOADON.MaPhong;
                    dbHOADON.DiaDiem= newHOADON.DiaDiem;
                 

                    db.SubmitChanges();
                    return true;

                }
                catch { return false; }
            }
            return false;

        }
    }
}
