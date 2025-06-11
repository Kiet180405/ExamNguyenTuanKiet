using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamWeb_TranQuangNha.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
        table: "Phims",
        columns: new[] { "Id", "TuaDe", "DienVien", "TrongNuoc", "GiaVe", "ThoiLuong" },
        values: new object[,]
        {
            { 1, "Avengers: Endgame", "Robert Downey Jr.", false, 120000, 180 },
            { 2, "Mắt Biếc", "Trần Nghĩa", true, 90000, 120 },
            { 3, "Spider-Man: No Way Home", "Tom Holland", false, 110000, 150 },
            { 4, "Bố Già", "Trấn Thành", true, 95000, 140 },
            { 5, "Fast & Furious 9", "Vin Diesel", false, 105000, 145 },
            { 6, "Lật Mặt 5", "Lý Hải", true, 85000, 130 }
        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
