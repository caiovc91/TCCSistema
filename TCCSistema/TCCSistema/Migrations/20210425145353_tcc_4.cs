using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCSistema.Migrations
{
    public partial class tcc_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageLog_Camera_Cameraid_camera",
                table: "ImageLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageLog_User_Userid_user",
                table: "ImageLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Login_User_Userid_user",
                table: "Login");

            migrationBuilder.DropForeignKey(
                name: "FK_OccurrenceLog_Camera_Cameraid_camera",
                table: "OccurrenceLog");

            migrationBuilder.DropIndex(
                name: "IX_OccurrenceLog_Cameraid_camera",
                table: "OccurrenceLog");

            migrationBuilder.DropIndex(
                name: "IX_Login_Userid_user",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_ImageLog_Cameraid_camera",
                table: "ImageLog");

            migrationBuilder.DropIndex(
                name: "IX_ImageLog_Userid_user",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "Cameraid_camera",
                table: "OccurrenceLog");

            migrationBuilder.DropColumn(
                name: "Userid_user",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "Cameraid_camera",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "Userid_user",
                table: "ImageLog");

            migrationBuilder.CreateIndex(
                name: "IX_User_id_user_type",
                table: "User",
                column: "id_user_type");

            migrationBuilder.CreateIndex(
                name: "IX_OccurrenceLog_id_camera",
                table: "OccurrenceLog",
                column: "id_camera");

            migrationBuilder.CreateIndex(
                name: "IX_Login_id_user",
                table: "Login",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_id_camera",
                table: "ImageLog",
                column: "id_camera");

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_id_user",
                table: "ImageLog",
                column: "id_user");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLog_Camera_id_camera",
                table: "ImageLog",
                column: "id_camera",
                principalTable: "Camera",
                principalColumn: "id_camera",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLog_User_id_user",
                table: "ImageLog",
                column: "id_user",
                principalTable: "User",
                principalColumn: "id_user",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Login_User_id_user",
                table: "Login",
                column: "id_user",
                principalTable: "User",
                principalColumn: "id_user",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OccurrenceLog_Camera_id_camera",
                table: "OccurrenceLog",
                column: "id_camera",
                principalTable: "Camera",
                principalColumn: "id_camera",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_id_user_type",
                table: "User",
                column: "id_user_type",
                principalTable: "UserType",
                principalColumn: "id_user_type",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageLog_Camera_id_camera",
                table: "ImageLog");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageLog_User_id_user",
                table: "ImageLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Login_User_id_user",
                table: "Login");

            migrationBuilder.DropForeignKey(
                name: "FK_OccurrenceLog_Camera_id_camera",
                table: "OccurrenceLog");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_id_user_type",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_id_user_type",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_OccurrenceLog_id_camera",
                table: "OccurrenceLog");

            migrationBuilder.DropIndex(
                name: "IX_Login_id_user",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_ImageLog_id_camera",
                table: "ImageLog");

            migrationBuilder.DropIndex(
                name: "IX_ImageLog_id_user",
                table: "ImageLog");

            migrationBuilder.AddColumn<int>(
                name: "Cameraid_camera",
                table: "OccurrenceLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Userid_user",
                table: "Login",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cameraid_camera",
                table: "ImageLog",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Userid_user",
                table: "ImageLog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OccurrenceLog_Cameraid_camera",
                table: "OccurrenceLog",
                column: "Cameraid_camera");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Userid_user",
                table: "Login",
                column: "Userid_user");

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_Cameraid_camera",
                table: "ImageLog",
                column: "Cameraid_camera");

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_Userid_user",
                table: "ImageLog",
                column: "Userid_user");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLog_Camera_Cameraid_camera",
                table: "ImageLog",
                column: "Cameraid_camera",
                principalTable: "Camera",
                principalColumn: "id_camera",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLog_User_Userid_user",
                table: "ImageLog",
                column: "Userid_user",
                principalTable: "User",
                principalColumn: "id_user",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Login_User_Userid_user",
                table: "Login",
                column: "Userid_user",
                principalTable: "User",
                principalColumn: "id_user",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OccurrenceLog_Camera_Cameraid_camera",
                table: "OccurrenceLog",
                column: "Cameraid_camera",
                principalTable: "Camera",
                principalColumn: "id_camera",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
