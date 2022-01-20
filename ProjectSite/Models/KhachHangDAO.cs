using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSite.Models
{
    class KhachHangDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);//in app.config
        public List<KHACHHANG> SelectAll()
        {

            List<KHACHHANG> nhanViens = db.KHACHHANGs.ToList();
            return nhanViens;

        }
        public List<KHACHHANG> SelectByKeyword(string keyword)
        {
            List<KHACHHANG> kHACHHANGs = db.KHACHHANGs.Where(b => b.Ten.Contains(keyword)).ToList();
            return kHACHHANGs;
        }
        public KHACHHANG SelectByCode(int KH_ID)
        {

            KHACHHANG hd = db.KHACHHANGs.SingleOrDefault(b => b.KH_ID == KH_ID);
            return hd;
        }
        public bool Insert(KHACHHANG newKHACHHANG)
        {

            try
            {
                db.KHACHHANGs.InsertOnSubmit(newKHACHHANG);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Delete(int KH_ID)
        {

            KHACHHANG dbKHACHANG = db.KHACHHANGs.SingleOrDefault(b => b.KH_ID == KH_ID);
            if (dbKHACHANG != null)
            {
                try
                {
                    db.KHACHHANGs.DeleteOnSubmit(dbKHACHANG);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }
        public bool Update(KHACHHANG newKHACHHANG)
        {

            KHACHHANG dbKHACHHANG = db.KHACHHANGs.SingleOrDefault(b => b.KH_ID == newKHACHHANG.KH_ID);
            if (dbKHACHHANG != null)
            {
                try
                {
                    dbKHACHHANG.KH_ID = newKHACHHANG.KH_ID;
                    dbKHACHHANG.Ten = newKHACHHANG.Ten;
                    dbKHACHHANG.MK = newKHACHHANG.MK;
                    dbKHACHHANG.Email = newKHACHHANG.Email;
                    dbKHACHHANG.Ngaysinh = newKHACHHANG.Ngaysinh;
                    dbKHACHHANG.SDT = newKHACHHANG.SDT;
                    dbKHACHHANG.Diachi = newKHACHHANG.Diachi;
                    dbKHACHHANG.Quyen = newKHACHHANG.Quyen;
                    dbKHACHHANG.Trangthai = newKHACHHANG.Trangthai;



                    db.SubmitChanges();
                    return true;

                }
                catch { return false; }
            }
            return false;

        }
    }
}
