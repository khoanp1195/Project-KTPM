using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM
{
    class loaispBUS
    {

        String URI = "http://www.khoaaa.somee.com/api/loaisp";
        public List<LOAI_SP> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            List<LOAI_SP> planes = JsonConvert.DeserializeObject<List<LOAI_SP>>(response);
            return planes;

        }

        public LOAI_SP GetDetails(int MALOAI)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + MALOAI);
            LOAI_SP plane = JsonConvert.DeserializeObject<LOAI_SP>(response);
            return plane;
        }
        public bool AddNew(LOAI_SP newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            bool result = bool.Parse(response);
            return result;

        }
        public bool Update(LOAI_SP newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + "/" + newPlane.MALOAI, "PUT", data);
            return bool.Parse(response);
        }
        public bool Delete(int MALOAI)
        {
            WebClient client = new WebClient();
            String response = client.UploadString(URI + "/" + MALOAI, "DELETE", "");
            return bool.Parse(response);
        }
        public List<LOAI_SP> Search(String keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<LOAI_SP>>(response);
        }

        //public List<LOAI_SP> GetAll()
        //{
        //    List<LOAI_SP> lOAI_SPs = new loaispDAO().SelectAll();
        //    return lOAI_SPs;
        //}
        //public List<LOAI_SP> Search(string keyword)
        //{
        //    List<LOAI_SP> lOAI_SPs = new loaispDAO().SelectByKeyword(keyword);
        //    return lOAI_SPs;
        //}
        //public LOAI_SP GetDetails(int MALOAI)
        //{
        //    LOAI_SP lOAI_SP = new loaispDAO().SelectById(MALOAI);
        //    return lOAI_SP;
        //}
        //public bool AddNew(LOAI_SP newLOAISP)
        //{
        //    bool result = new loaispDAO().Insert(newLOAISP);
        //    return result;
        //}
        //public bool Delete(int MALOAI)
        //{
        //    bool result = new loaispDAO().Delete(MALOAI);
        //    return result;
        //}
        //public bool Update(LOAI_SP newLoaiSP)
        //{
        //    bool result = new loaispDAO().Update(newLoaiSP);
        //    return result;
        //}
    }
}
