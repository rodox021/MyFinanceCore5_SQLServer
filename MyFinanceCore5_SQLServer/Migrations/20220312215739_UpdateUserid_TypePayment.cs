using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFinanceCore5_SQLServer.Migrations
{
    public partial class UpdateUserid_TypePayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "TypePayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TypePayments_UserID",
                table: "TypePayments",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_TypePayments_Users_UserID",
                table: "TypePayments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction. NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypePayments_Users_UserID",
                table: "TypePayments");

            migrationBuilder.DropIndex(
                name: "IX_TypePayments_UserID",
                table: "TypePayments");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "TypePayments");
        }
    }
}
