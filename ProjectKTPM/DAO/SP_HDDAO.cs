using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM
{
    class SP_HDDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);//in app.config
        public List<SP_HD> SelectAll()
        {

            List<SP_HD> sP_HDs = db.SP_HDs.ToList();
            return sP_HDs;

        }
        public List<SP_HD> SelectByKeyword(String keyword)
        {


            List<SP_HD> sP_HDs = db.SP_HDs.Where(b => b.MASP.Contains(keyword)).ToList();
            return sP_HDs;

        }

        public SP_HD SelectById(int MAHD)
        {

            SP_HD sP_HD = db.SP_HDs.SingleOrDefault(b => b.MAHD == MAHD);
            return sP_HD;
        }




        public bool Insert(SP_HD newSP_HD)
        {
            try
            {
                db.SP_HDs.InsertOnSubmit(newSP_HD);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }

        }

        public bool Delete(int MAHD)
        {

            SP_HD dbLOAISP = db.SP_HDs.SingleOrDefault(b => b.MAHD == MAHD);
            if (dbLOAISP != null)
            {
                try
                {
                    db.SP_HDs.DeleteOnSubmit(dbLOAISP);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }

        public bool Update(SP_HD newSP_HD)
        {

            SP_HD dbloaiSp = db.SP_HDs.SingleOrDefault(b => b.MAHD == newSP_HD.MAHD);
            if (dbloaiSp != null)
            {
                try
                {
                    dbloaiSp.MAHD = newSP_HD.MAHD;
                    dbloaiSp.Soluong = newSP_HD.Soluong; 
                    dbloaiSp.Gia = newSP_HD.Gia;

                    db.SubmitChanges();
                    return true;

                }
                catch { return false; }
            }
            return false;

        }
    }
}
