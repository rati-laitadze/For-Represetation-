using Microsoft.EntityFrameworkCore.Migrations;

namespace WandioRestful.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mobiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    ScreenSizeAndResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoryInGB = table.Column<int>(type: "int", nullable: false),
                    OperatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mobiles_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Apple" },
                    { 3, "Huawei" },
                    { 4, "Oppo" },
                    { 5, "LG" }
                });

            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "Id", "ImageThumbnailUrl", "ImageUrl", "ManufacturerId", "MemoryInGB", "Name", "OperatingSystem", "Price", "Processor", "ScreenSizeAndResolution", "Size", "Weight" },
                values: new object[,]
                {
                    { 2, "davamateb mere", "davmateb mere", 1, 16, "Iphone 5", "iOS", 350, "1.3GHz dual-core", "1136 x 640", 1440.0, 112.0 },
                    { 1, "davamateb mere", "davmateb mere", 2, 16, "Iphone 5", "iOS", 350, "1.3GHz dual-core", "1136 x 640", 1440.0, 112.0 },
                    { 3, "davamateb mere", "davmateb mere", 2, 16, "Iphone 5", "iOS", 350, "1.3GHz dual-core", "1136 x 640", 1440.0, 112.0 },
                    { 5, "davamateb mere", "davmateb mere", 2, 16, "Iphone 5", "iOS", 350, "1.3GHz dual-core", "1136 x 640", 1440.0, 112.0 },
                    { 4, "davamateb mere", "davmateb mere", 3, 16, "Iphone 5", "iOS", 350, "1.3GHz dual-core", "1136 x 640", 1440.0, 112.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobiles_ManufacturerId",
                table: "Mobiles",
                column: "ManufacturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mobiles");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
