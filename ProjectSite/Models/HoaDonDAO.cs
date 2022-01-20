using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
namespace ProjectSite.Models
{
    class HoaDonDAO
    {
       
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);//in app.config
        public List<HOADON> SelectAll()
        {
            
            List<HOADON> hOADONs = db.HOADONs.ToList();
            return hOADONs;

        }
        public List<HOADON> SelectByKeyword(string keyword)
        {


            List<HOADON> hOADONs = db.HOADONs.Where(b => b.TenKH.Contains(keyword)).ToList();
            return hOADONs;
        }
        public HOADON SelectByCode(int MAHD)
        {

            HOADON hd = db.HOADONs.SingleOrDefault(b =>b.MAHD == MAHD);
            return hd;
        }
        public bool Insert(HOADON newHoaDon)
        {

            try
            {
                db.HOADONs.InsertOnSubmit(newHoaDon);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Delete(int MAHD)
        {

            HOADON dbHOADON = db.HOADONs.SingleOrDefault(b => b.MAHD == MAHD);
            if (dbHOADON != null)
            {
                try
                {
                    db.HOADONs.DeleteOnSubmit(dbHOADON);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }
        public bool Update(HOADON newHOADON)
        {

            HOADON dbHOADON = db.HOADONs.SingleOrDefault(b => b.MAHD == newHOADON.MAHD);
            if (dbHOADON != null)
            {
                try
                {
                    dbHOADON.Ngaytao = newHOADON.Ngaytao;
                    dbHOADON.TenKH= newHOADON.TenKH;
                    dbHOADON.Tongtien = newHOADON.Tongtien;
                    dbHOADON.Trangthai = newHOADON.Trangthai;
                    dbHOADON.DiachiKH = newHOADON.DiachiKH;

                    db.SubmitChanges();
                    return true;

                }
                catch { return false; }
            }
            return false;

        }
    }
}
