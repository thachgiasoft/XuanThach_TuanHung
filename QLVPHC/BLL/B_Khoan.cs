using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVPHC.DTO;
using QLVPHC.DAL;

namespace QLVPHC.BLL
{
    public class B_Khoan
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public bool Insert(Khoan dto)
        {
            if (string.IsNullOrEmpty(dto.MaKhoan) || string.IsNullOrEmpty(dto.MoTa))
                return false;

            int dem = context.Khoans.Count(x => x.MaKhoan.Contains(dto.MaKhoan));
            if (dem > 0)
                return false;

            try
            {
                context.Khoans.Add(dto);
                context.SaveChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Update(Khoan dto)
        {
            if (string.IsNullOrEmpty(dto.MaKhoan) || string.IsNullOrEmpty(dto.MoTa))
                return false;

            var khoan = context.Khoans.Find(dto.Id);
            if (khoan == null)
                return false;
            try
            {
                khoan.MaDieu = dto.MaDieu;
                khoan.MaKhoan = dto.MaKhoan;
                khoan.MoTa = dto.MoTa;
                khoan.GhiChu = dto.GhiChu;
                context.SaveChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Delete(long? Id, bool status)
        {
            if (Id == null)
                return false;

            var khoan = context.Khoans.Find(Id);
            if (khoan == null)
                return false;

            try
            {
                khoan.IsDelete = status;
                context.SaveChanges();

                return true;
            }
            catch { return false; }
        }

        public List<KhoanDto> GetDanhMucDieu()
        {
            List<KhoanDto> danhMucKhoan = new List<KhoanDto>();

            var khoans = context.Khoans.Where(x => x.IsDelete == false).ToList();

            if (khoans == null)
                return null;

            foreach (var item in khoans)
            {
                var khoanDto = new KhoanDto()
                {
                    Id = item.Id,
                    MaDieu = item.MaDieu,
                    MaKhoan =item.MaKhoan,
                    MoTa = item.MoTa,
                    GhiChu = item.GhiChu,
                    IsDelete = item.IsDelete,
                };
                danhMucKhoan.Add(khoanDto);
            }

            return danhMucKhoan;
        }

        public KhoanDto InitKhoan()
        {
            KhoanDto khoan = new KhoanDto
            {
                MaKhoan = "",
                MaDieu = 0,
                MoTa = "",
                GhiChu = "",
            };
            return khoan;
        }
    }
}
