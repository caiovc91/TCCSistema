using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCSistema.Migrations
{
    public partial class tcc_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Loginid_login",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Loginid_login",
                table: "User",
                column: "Loginid_login");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Login_Loginid_login",
                table: "User",
                column: "Loginid_login",
                principalTable: "Login",
                principalColumn: "id_login",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Login_Loginid_login",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Loginid_login",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Loginid_login",
                table: "User");
        }
    }
}
