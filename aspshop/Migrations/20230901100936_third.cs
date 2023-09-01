using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspshop.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    brandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.brandID);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    catID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.catID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    proID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pdesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pprice = table.Column<int>(type: "int", nullable: false),
                    catID = table.Column<int>(type: "int", nullable: false),
                    categorycatID = table.Column<int>(type: "int", nullable: false),
                    brandID = table.Column<int>(type: "int", nullable: false),
                    Imagepath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.proID);
                    table.ForeignKey(
                        name: "FK_products_brands_brandID",
                        column: x => x.brandID,
                        principalTable: "brands",
                        principalColumn: "brandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_categories_categorycatID",
                        column: x => x.categorycatID,
                        principalTable: "categories",
                        principalColumn: "catID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_brandID",
                table: "products",
                column: "brandID");

            migrationBuilder.CreateIndex(
                name: "IX_products_categorycatID",
                table: "products",
                column: "categorycatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
