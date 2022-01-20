using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM
{
    class ProductBUS
    {
        String URI = "http://www.khoaaa.somee.com/api/sanpham";
        public List<SANPHAM> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            List<SANPHAM> planes = JsonConvert.DeserializeObject<List<SANPHAM>>(response);
            return planes;
        }

        public SANPHAM GetDetails(int MASP)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + MASP);
            SANPHAM plane = JsonConvert.DeserializeObject<SANPHAM>(response);
            return plane;
        }
        public bool AddNew(SANPHAM newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            bool result = bool.Parse(response);
            return result;

        }
        public bool Update(SANPHAM newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + "/" + newPlane.MASP, "PUT", data);
            return bool.Parse(response);
        }
        public bool Delete(int MASP)
        {
            WebClient client = new WebClient();
            String response = client.UploadString(URI + "/" + MASP, "DELETE", "");
            return bool.Parse(response);
        }
        public List<SANPHAM> Search(String keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<SANPHAM>>(response);
        }
        //public List<SANPHAM> GetAll()
        //{
        //    List<SANPHAM> dEPARTMENTs = new ProductDAO().SelectAll();
        //    return dEPARTMENTs;
        //}
        //public List<SANPHAM> Search(String keyword)
        //{
        //    List<SANPHAM> planes = new ProductDAO().SelectByKeyword(keyword);
        //    return planes;
        //}

        //public SANPHAM GetDetails(int Id)
        //{
        //    SANPHAM sANPHAM = new ProductDAO().SelectById(Id);
        //    return sANPHAM;
        //}

        //public bool Addnew(SANPHAM newPlane)
        //{
        //    bool result = new ProductDAO().Insert(newPlane);
        //    return result;
        //}
        //public bool Delete(int MASP)
        //{
        //    bool result = new ProductDAO().Delete(MASP);
        //    return result;

        //}
        //public bool Update(SANPHAM newPlane)
        //{
        //    bool result = new ProductDAO().Update(newPlane);
        //    return result;
        //}
    }
}

