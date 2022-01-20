using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace ProjectSite.Models
{
    class ProductDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
        //    String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
        public List<SANPHAM> SelectAll()
        {
            db.ObjectTrackingEnabled = false;

            List<SANPHAM> dEPARTMENTs = db.SANPHAMs.ToList();
            return dEPARTMENTs;

        }
        public List<SANPHAM> SelectByKeyword(String keyword)
        {

            db.ObjectTrackingEnabled = false;
            List<SANPHAM> planes = db.SANPHAMs.Where(b => b.Ten.Contains(keyword)).ToList();
            return planes;

        }

        public SANPHAM SelectById(int MASP)
        {
            db.ObjectTrackingEnabled = false;
            SANPHAM sANPHAM = db.SANPHAMs.SingleOrDefault(b =>b.MASP == MASP);
            return sANPHAM;
        }




        public bool Insert(SANPHAM newDepartment)
        {
            try
            {
                db.SANPHAMs.InsertOnSubmit(newDepartment);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }

        }

        public bool Delete(int Id)
        {

            SANPHAM dbSANPHAM = db.SANPHAMs.SingleOrDefault(b => b.MASP == Id);
            if (dbSANPHAM != null)
            {
                try
                {
                    db.SANPHAMs.DeleteOnSubmit(dbSANPHAM);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }

   

        public static Image Base64StringToImage(string str64)
        {
            byte[] img = Convert.FromBase64String(str64);
            MemoryStream m = new MemoryStream(img);
            return Image.FromStream(m);
        }
        public bool Update(SANPHAM newProduct)
        {

            SANPHAM dbProduct = db.SANPHAMs.SingleOrDefault(b => b.MASP == newProduct.MASP);
            if (dbProduct != null)
            {
                try
                {
                    dbProduct.Ten = newProduct.Ten;
                    dbProduct.Gia = newProduct.Gia;
                    dbProduct.Soluong = newProduct.Soluong;
                    dbProduct.Mota = newProduct.Mota;
                    dbProduct.Anh = newProduct.Anh;
                    dbProduct.MALOAI = newProduct.MALOAI;
                    db.SubmitChanges();
                    return true;

                }
                catch { return false; }
            }
            return false;

        }

    }
}




    

