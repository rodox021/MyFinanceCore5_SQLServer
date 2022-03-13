using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFinanceCore5_SQLServer.Migrations
{
    public partial class upadate_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Users",
                newName: "CreatAt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatAt",
                table: "Users",
                newName: "MyProperty");
        }
    }
}
