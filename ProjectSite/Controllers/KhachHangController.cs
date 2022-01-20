using ProjectSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectSite.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class KhachHangController : ApiController
    {
        [HttpGet]
        [Route("api/KhachHang")]
        public List<KHACHHANG> GetAll()
        {
            List<KHACHHANG> planes = new KhachHangDAO().SelectAll();
            return planes;
        }


        [HttpGet]
        [Route("api/KhachHang/search/{keyword}")]
        public List<KHACHHANG> Search(String keyword)
        {
            List<KHACHHANG> planes = new KhachHangDAO().SelectByKeyword(keyword);
            return planes;
        }

        [HttpGet]
        [Route("api/KhachHang/{KH_ID}")]
        public KHACHHANG GetDetails(int KH_ID)
        {
            KHACHHANG plane = new KhachHangDAO().SelectByCode(KH_ID);
            return plane;
        }


        [HttpPost]
        [Route("api/KhachHang")]
        public bool Addnew(KHACHHANG newPlane)
        {
            bool result = new KhachHangDAO().Insert(newPlane);
            return result;
        }

        [HttpDelete]
        [Route("api/KhachHang/{KH_ID}")]
        public bool Delete(int KH_ID)
        {
            bool result = new KhachHangDAO().Delete(KH_ID);
            return result;

        }

        [HttpPut]
        [Route("api/KhachHang/{KH_ID}")]
        public bool Update(int KH_ID, KHACHHANG newPlane)
        {
            if (KH_ID != newPlane.KH_ID) return false;
            bool result = new KhachHangDAO().Update(newPlane);
            return result;
        }
    }
}