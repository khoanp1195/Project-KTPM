using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM
{
   class HoaDonBUS
    {
        String URI = "http://www.khoaaa.somee.com/api/HoaDon";
        public List<HOADON> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            List<HOADON> planes = JsonConvert.DeserializeObject<List<HOADON>>(response);
            return planes;
        }

        public HOADON GetDetails(int MAHD)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + MAHD);
             HOADON plane = JsonConvert.DeserializeObject<HOADON>(response);
            return plane;
        }
        public bool AddNew(HOADON newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            bool result = bool.Parse(response);
            return result;

        }
        public bool Update(HOADON newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + "/" + newPlane.MAHD, "PUT", data);
            return bool.Parse(response);
        }
        public bool Delete(int MAHD)
        {
            WebClient client = new WebClient();
            String response = client.UploadString(URI + "/" + MAHD, "DELETE", "");
            return bool.Parse(response);
        }
        public List<HOADON> Search(String keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<HOADON>>(response);
        }
        //public List<HOADON> GetAll()
        //{
        //    List<HOADON> pROJECTs = new HoaDonDAO().SelectAll();
        //    return pROJECTs;
        //}
        //public List<HOADON> Search(string keyword)
        //{
        //    List<HOADON> hoaDons = new HoaDonDAO().SelectByKeyword(keyword);
        //    return hoaDons;
        //}
        //public HOADON GetDetails(int MAHD)
        //{
        //    HOADON hoaDon = new HoaDonDAO().SelectByCode(MAHD);
        //    return hoaDon;
        //}
        //public bool AddNew(HOADON newHoaDon)
        //{
        //    bool result = new HoaDonDAO().Insert(newHoaDon);
        //    return result;
        //}
        //public bool Delete(int MaHD)
        //{
        //    bool result = new HoaDonDAO().Delete(MaHD);
        //    return result;
        //}
        //public bool Update(HOADON newHoaDon)
        //{
        //    bool result = new HoaDonDAO().Update(newHoaDon);
        //    return result;
        //}
    }
}
