using Microsoft.EntityFrameworkCore.Migrations;

namespace WandioRestful.Migrations
{
    public partial class moreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "Id", "ImageThumbnailUrl", "ImageUrl", "ManufacturerId", "MemoryInGB", "Name", "OperatingSystem", "Price", "Processor", "ScreenSizeAndResolution", "Size", "Weight" },
                values: new object[] { 6, "davamateb mere", "davmateb mere", 3, 16, "Iphone 5", "iOS", 350, "1.3GHz dual-core", "1136 x 640", 1440.0, 112.0 });

            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "Id", "ImageThumbnailUrl", "ImageUrl", "ManufacturerId", "MemoryInGB", "Name", "OperatingSystem", "Price", "Processor", "ScreenSizeAndResolution", "Size", "Weight" },
                values: new object[] { 7, "davamateb mere", "davmateb mere", 3, 16, "Iphone 5", "iOS", 350, "1.3GHz dual-core", "1136 x 640", 1440.0, 112.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
