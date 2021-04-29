using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCSistema.Migrations
{
    public partial class tcc_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cameraid_camera",
                table: "ImageLog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_Cameraid_camera",
                table: "ImageLog",
                column: "Cameraid_camera");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageLog_Camera_Cameraid_camera",
                table: "ImageLog",
                column: "Cameraid_camera",
                principalTable: "Camera",
                principalColumn: "id_camera",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageLog_Camera_Cameraid_camera",
                table: "ImageLog");

            migrationBuilder.DropIndex(
                name: "IX_ImageLog_Cameraid_camera",
                table: "ImageLog");

            migrationBuilder.DropColumn(
                name: "Cameraid_camera",
                table: "ImageLog");
        }
    }
}
