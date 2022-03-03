using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFinanceCore5_SQLServer.Migrations
{
    public partial class createIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PictureIconId",
                table: "TypePayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PictureIcons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureIcons", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypePayments_PictureIconId",
                table: "TypePayments",
                column: "PictureIconId");

            migrationBuilder.AddForeignKey(
                name: "FK_TypePayments_PictureIcons_PictureIconId",
                table: "TypePayments",
                column: "PictureIconId",
                principalTable: "PictureIcons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypePayments_PictureIcons_PictureIconId",
                table: "TypePayments");

            migrationBuilder.DropTable(
                name: "PictureIcons");

            migrationBuilder.DropIndex(
                name: "IX_TypePayments_PictureIconId",
                table: "TypePayments");

            migrationBuilder.DropColumn(
                name: "PictureIconId",
                table: "TypePayments");
        }
    }
}
