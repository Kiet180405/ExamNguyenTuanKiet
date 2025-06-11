using System.ComponentModel.DataAnnotations;

namespace ExamNguyenTuanKiet.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string TuaDe { get; set; }
        public string DienVien { get; set; }

        public bool TrongNuoc { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Giá vé phải lớn hơn hoặc bằng 0")]
        public double GiaVe { get; set; }

        public int ThoiLuong { get; set; }
    }
}
