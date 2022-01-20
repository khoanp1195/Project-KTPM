using ProjectSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectSite.Controllers
{
    public class loaispController : ApiController
    {
        [HttpGet]
        [Route("api/loaisp")]
        public List<LOAI_SP> GetAll()
        {
            List<LOAI_SP> planes = new loaispDAO().SelectAll();
            return planes;
        }


        [HttpGet]
        [Route("api/loaisp/search/{keyword}")]
        public List<LOAI_SP> Search(String keyword)
        {
            List<LOAI_SP> planes = new loaispDAO().SelectByKeyword(keyword);
            return planes;
        }

        [HttpGet]
        [Route("api/loaisp/{MALOAI}")]
        public LOAI_SP GetDetails(int MALOAI)
        {
            LOAI_SP plane = new loaispDAO().SelectById(MALOAI);
            return plane;
        }


        [HttpPost]
        [Route("api/loaisp")]
        public bool Addnew(LOAI_SP newPlane)
        {
            bool result = new loaispDAO().Insert(newPlane);
            return result;
        }

        [HttpDelete]
        [Route("api/loaisp/{MALOAI}")]
        public bool Delete(int MALOAI)
        {
            bool result = new loaispDAO().Delete(MALOAI);
            return result;

        }

        [HttpPut]
        [Route("api/loaisp/{MALOAI}")]
        public bool Update(int MALOAI, LOAI_SP newPlane)
        {
            if (MALOAI != newPlane.MALOAI) return false;
            bool result = new loaispDAO().Update(newPlane);
            return result;
        }
    }
}