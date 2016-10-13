using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVPHC.DTO;
using QLVPHC.DAL;


namespace QLVPHC.BLL
{
    public class B_Dieu
    {
        QLVPHCEntities context = new QLVPHCEntities();
        public bool Insert(Dieu dto)
        {
            if(string.IsNullOrEmpty(dto.MaDieu) || string.IsNullOrEmpty(dto.MoTa))
                return false;

            int dem = context.Dieux.Count(x => x.MaDieu.Contains(dto.MaDieu));
            if (dem > 0)
                return false;

            try
            {
                context.Dieux.Add(dto);
                context.SaveChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Update(Dieu dto)
        {
            if (string.IsNullOrEmpty(dto.MaDieu) || string.IsNullOrEmpty(dto.MoTa))
                return false;

            var dieu = context.Dieux.Find(dto.Id);
            if (dieu == null)
                return false;
            try
            {
                dieu.MaDieu = dto.MaDieu;
                dieu.MoTa = dto.MoTa;
                dieu.GhiChu = dto.GhiChu;
                context.SaveChanges();

                return true;
            }
            catch { return false; }
        }

        public bool Delete(long? Id, bool status)
        {
            if (Id == null)
                return false;

            var dieu = context.Dieux.Find(Id);
            if (dieu == null)
                return false;

            try
            {
                dieu.IsDelete = status;
                context.SaveChanges();

                return true;
            }
            catch { return false; }
        }

        public List<DieuDto> GetDanhMucDieu()
        {
            List<DieuDto> danhMucDieu = new List<DieuDto>();

            var dieus = context.Dieux.Where(x => x.IsDelete == false).ToList();

            if (dieus == null)
                return null;

            foreach(var item in dieus)
            {
                var dieuDto = new DieuDto()
                {
                    Id = item.Id,
                    MaDieu = item.MaDieu,
                    MoTa = item.MoTa,
                    GhiChu = item.GhiChu,
                    IsDelete = item.IsDelete,
                };
                danhMucDieu.Add(dieuDto);
            }

            return danhMucDieu;
        }

        public List<DieuLoopkup> GetLoopkup()
        {
            List<DieuLoopkup> danhMucDieu = new List<DieuLoopkup>();

            var dieus = context.Dieux.Where(x => x.IsDelete == false).ToList();

            if (dieus == null)
                return null;

            foreach (var item in dieus)
            {
                var dieuDto = new DieuLoopkup()
                {
                    Id = item.Id,
                    MaDieu = item.MaDieu,
                    MoTa = item.MoTa,
                };
                danhMucDieu.Add(dieuDto);
            }

            return danhMucDieu;
        }
    }
}
