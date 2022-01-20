using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM
{
    class KhachHangBUS
    {

        String URI = "http://www.khoaaa.somee.com/api/KhachHang";
        public List<KHACHHANG> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            List<KHACHHANG> planes = JsonConvert.DeserializeObject<List<KHACHHANG>>(response);
            return planes;
        }

        public KHACHHANG GetDetails(int KH_ID)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + KH_ID);
            KHACHHANG plane = JsonConvert.DeserializeObject<KHACHHANG>(response);
            return plane;
        }
        public bool AddNew(KHACHHANG newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            bool result = bool.Parse(response);
            return result;

        }
        public bool Update(KHACHHANG newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + "/" + newPlane.KH_ID, "PUT", data);
            return bool.Parse(response);
        }
        public bool Delete(int KH_ID)
        {
            WebClient client = new WebClient();
            String response = client.UploadString(URI + "/" + KH_ID, "DELETE", "");
            return bool.Parse(response);
        }
        public List<KHACHHANG> Search(String keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<KHACHHANG>>(response);
        }
        //    public List<KHACHHANG> GetAll()
        //    {
        //        List<KHACHHANG> nhanViens = new KhachHangDAO().SelectAll();
        //        return nhanViens;
        //    }
        //    public List<KHACHHANG> Search(string keyword)
        //    {
        //        List<KHACHHANG> kHACHHANGs = new KhachHangDAO().SelectByKeyword(keyword);
        //        return kHACHHANGs;
        //    }
        //    public KHACHHANG GetDetails(int KH_ID)
        //    {
        //        KHACHHANG kHACHHANG = new KhachHangDAO().SelectByCode(KH_ID);
        //        return kHACHHANG;
        //    }
        //    public bool AddNew(KHACHHANG newKhachHang)
        //    {
        //        bool result = new KhachHangDAO().Insert(newKhachHang);
        //        return result;
        //    }
        //    public bool Delete(int KH_ID)
        //    {
        //        bool result = new KhachHangDAO().Delete(KH_ID);
        //        return result;
        //    }
        //    public bool Update(KHACHHANG newKhachHang)
        //    {
        //        bool result = new KhachHangDAO().Update(newKhachHang);
        //        return result;
        //    }




    }
}
