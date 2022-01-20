using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ProjectSite.Models;

namespace ProjectSite.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HoaDonController : ApiController
    {
        [HttpGet]
        [Route("api/HoaDon")]
        public List<HOADON> GetAll()
        {
            List<HOADON> planes = new HoaDonDAO().SelectAll();
            return planes;
        }


        [HttpGet]
        [Route("api/HoaDon/search/{keyword}")]
        public List<HOADON> Search(String keyword)
        {
            List<HOADON> planes = new HoaDonDAO().SelectByKeyword(keyword);
            return planes;
        }

        [HttpGet]
        [Route("api/HoaDon/{MAHD}")]
        public HOADON GetDetails(int MAHD)
        {
            HOADON plane = new HoaDonDAO().SelectByCode(MAHD);
            return plane;
        }


        [HttpPost]
        [Route("api/HoaDon")]
        public bool Addnew(HOADON newPlane)
        {
            bool result = new HoaDonDAO().Insert(newPlane);
            return result;
        }

        [HttpDelete]
        [Route("api/HoaDon/{MAHD}")]
        public bool Delete(int MAHD)
        {
            bool result = new HoaDonDAO().Delete(MAHD);
            return result;

        }

        [HttpPut]
        [Route("api/HoaDon/{MAHD}")]
        public bool Update(int MAHD, HOADON newPlane)
        {
            if (MAHD != newPlane.MAHD) return false;
            bool result = new HoaDonDAO().Update(newPlane);
            return result;
        }
    }
}