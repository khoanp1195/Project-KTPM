using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM
{
    class loaispDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);//in app.config
        public List<LOAI_SP> SelectAll()
        {

            List<LOAI_SP> lOAI_SPs = db.LOAI_SPs.ToList();
            return lOAI_SPs;

        }
        public List<LOAI_SP> SelectByKeyword(String keyword)
        {


            List<LOAI_SP> lOAI_SPs = db.LOAI_SPs.Where(b => b.Ten.Contains(keyword)).ToList();
            return lOAI_SPs;

        }

        public LOAI_SP SelectById(int MALOAI)
        {

            LOAI_SP lOAI_SP = db.LOAI_SPs.SingleOrDefault(b => b.MALOAI == MALOAI);
            return lOAI_SP ;
        }




        public bool Insert(LOAI_SP newLoaiSP)
        {
            try
            {
                db.LOAI_SPs.InsertOnSubmit(newLoaiSP);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }

        }

        public bool Delete(int MALOAI)
        {

            LOAI_SP dbLOAISP = db.LOAI_SPs.SingleOrDefault(b => b.MALOAI == MALOAI);
            if (dbLOAISP != null)
            {
                try
                {
                    db.LOAI_SPs.DeleteOnSubmit(dbLOAISP);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }

        public bool Update(LOAI_SP newLOAISP)
        {

            LOAI_SP dbloaiSp = db.LOAI_SPs.SingleOrDefault(b => b.MALOAI == newLOAISP.MALOAI);
            if (dbloaiSp != null)
            {
                try
                {
                    dbloaiSp.MALOAI = newLOAISP.MALOAI;
                    dbloaiSp.Ten = newLOAISP.Ten;
                  
                    db.SubmitChanges();
                    return true;

                }
                catch { return false; }
            }
            return false;

        }
    }
}
