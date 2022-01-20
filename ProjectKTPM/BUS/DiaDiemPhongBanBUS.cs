using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKTPM.DAO
{
    class DiaDiemPhongBanBUS
    {
        public List<DiaDiemPhongBan> GetAll()
        {
            List<DiaDiemPhongBan> phongs = new DiaDiemPhongDAO().SelectAll();
            return phongs;
        }
        public List<DiaDiemPhongBan> Search(String keyword)
        {
            List<DiaDiemPhongBan> sP_HDs = new DiaDiemPhongDAO().SelectByKeyword(keyword);
            return sP_HDs;
        }

        public DiaDiemPhongBan GetDetails(int Id)
        {
            DiaDiemPhongBan phong = new DiaDiemPhongDAO().SelectByCode(Id);
            return phong;
        }

        public bool Addnew(DiaDiemPhongBan newSP_HD)
        {
            bool result = new DiaDiemPhongDAO().Insert(newSP_HD);
            return result;
        }
        public bool Delete(int MAPHONG)
        {
            bool result = new DiaDiemPhongDAO().Delete(MAPHONG);
            return result;

        }
        public bool Update(DiaDiemPhongBan newSP_HD)
        {
            bool result = new DiaDiemPhongDAO().Update(newSP_HD);
            return result;
        }
    }
}
