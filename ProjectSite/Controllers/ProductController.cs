using ProjectSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectSite.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("api/sanpham")]
        public List<SANPHAM> GetAll()
        {
            List<SANPHAM> planes = new ProductDAO().SelectAll();
            return planes;
        }


        [HttpGet]
        [Route("api/sanpham/search/{keyword}")]
        public List<SANPHAM> Search(String keyword)
        {
            List<SANPHAM> planes = new ProductDAO().SelectByKeyword(keyword);
            return planes;
        }

        [HttpGet]
        [Route("api/sanpham/{MASP}")]
        public SANPHAM GetDetails(int MASP)
        {
            SANPHAM plane = new ProductDAO().SelectById(MASP);
            return plane;
        }


        [HttpPost]
        [Route("api/sanpham")]
        public bool Addnew(SANPHAM newPlane)
        {
            bool result = new ProductDAO().Insert(newPlane);
            return result;
        }

        [HttpDelete]
        [Route("api/sanpham/{MASP}")]
        public bool Delete(int MASP)
        {
            bool result = new ProductDAO().Delete(MASP);
            return result;

        }

        [HttpPut]
        [Route("api/sanpham/{MASP}")]
        public bool Update(int MASP, SANPHAM newPlane)
        {
            if (MASP != newPlane.MASP) return false;
            bool result = new ProductDAO().Update(newPlane);
            return result;
        }
    }
}