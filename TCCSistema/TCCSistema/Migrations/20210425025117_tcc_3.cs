using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCSistema.Migrations
{
    public partial class tcc_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeid_user_type",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserTypeid_user_type",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserTypeid_user_type",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserTypeid_user_type",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeid_user_type",
                table: "User",
                column: "UserTypeid_user_type");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeid_user_type",
                table: "User",
                column: "UserTypeid_user_type",
                principalTable: "UserType",
                principalColumn: "id_user_type",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
