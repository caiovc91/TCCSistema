using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCCSistema.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Camera",
                columns: table => new
                {
                    id_camera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    camera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ipadress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camera", x => x.id_camera);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    id_user_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.id_user_type);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id_user = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_user_type = table.Column<int>(type: "int", nullable: false),
                    UserTypeid_user_type = table.Column<int>(type: "int", nullable: true),
                    isPatient = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id_user);
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeid_user_type",
                        column: x => x.UserTypeid_user_type,
                        principalTable: "UserType",
                        principalColumn: "id_user_type",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageLog",
                columns: table => new
                {
                    id_image = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    record = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_camera = table.Column<int>(type: "int", nullable: false),
                    image_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    frame_number = table.Column<int>(type: "int", nullable: false),
                    position_h = table.Column<int>(type: "int", nullable: false),
                    position_v = table.Column<int>(type: "int", nullable: false),
                    id_user = table.Column<int>(type: "int", nullable: false),
                    Userid_user = table.Column<int>(type: "int", nullable: true),
                    image_string = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageLog", x => x.id_image);
                    table.ForeignKey(
                        name: "FK_ImageLog_User_Userid_user",
                        column: x => x.Userid_user,
                        principalTable: "User",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    id_login = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_user = table.Column<int>(type: "int", nullable: false),
                    Userid_user = table.Column<int>(type: "int", nullable: true),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.id_login);
                    table.ForeignKey(
                        name: "FK_Login_User_Userid_user",
                        column: x => x.Userid_user,
                        principalTable: "User",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TargetUser",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_user1 = table.Column<int>(type: "int", nullable: false),
                    User1id_user = table.Column<int>(type: "int", nullable: true),
                    id_user2 = table.Column<int>(type: "int", nullable: false),
                    User2id_user = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetUser", x => x.id);
                    table.ForeignKey(
                        name: "FK_TargetUser_User_User1id_user",
                        column: x => x.User1id_user,
                        principalTable: "User",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TargetUser_User_User2id_user",
                        column: x => x.User2id_user,
                        principalTable: "User",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OccurrenceLog",
                columns: table => new
                {
                    id_occurrence = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    occurdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_camera = table.Column<int>(type: "int", nullable: false),
                    Cameraid_camera = table.Column<int>(type: "int", nullable: true),
                    id_user = table.Column<int>(type: "int", nullable: false),
                    Userid_user = table.Column<int>(type: "int", nullable: true),
                    id_image = table.Column<int>(type: "int", nullable: false),
                    ImageLogid_image = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccurrenceLog", x => x.id_occurrence);
                    table.ForeignKey(
                        name: "FK_OccurrenceLog_Camera_Cameraid_camera",
                        column: x => x.Cameraid_camera,
                        principalTable: "Camera",
                        principalColumn: "id_camera",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OccurrenceLog_ImageLog_ImageLogid_image",
                        column: x => x.ImageLogid_image,
                        principalTable: "ImageLog",
                        principalColumn: "id_image",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OccurrenceLog_User_Userid_user",
                        column: x => x.Userid_user,
                        principalTable: "User",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "id_login", "Userid_user", "id_user", "login", "password" },
                values: new object[] { 1, null, 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "id_user", "UserTypeid_user_type", "email", "id_user_type", "info", "isPatient", "name", "phone", "role" },
                values: new object[] { 1, null, "admin@admin.com", 1, "System Administrator", false, "Admin", "99999999", null });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "id_user_type", "type" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Observer" },
                    { 3, "Regular" },
                    { 4, "Patient" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageLog_Userid_user",
                table: "ImageLog",
                column: "Userid_user");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Userid_user",
                table: "Login",
                column: "Userid_user");

            migrationBuilder.CreateIndex(
                name: "IX_OccurrenceLog_Cameraid_camera",
                table: "OccurrenceLog",
                column: "Cameraid_camera");

            migrationBuilder.CreateIndex(
                name: "IX_OccurrenceLog_ImageLogid_image",
                table: "OccurrenceLog",
                column: "ImageLogid_image");

            migrationBuilder.CreateIndex(
                name: "IX_OccurrenceLog_Userid_user",
                table: "OccurrenceLog",
                column: "Userid_user");

            migrationBuilder.CreateIndex(
                name: "IX_TargetUser_User1id_user",
                table: "TargetUser",
                column: "User1id_user");

            migrationBuilder.CreateIndex(
                name: "IX_TargetUser_User2id_user",
                table: "TargetUser",
                column: "User2id_user");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeid_user_type",
                table: "User",
                column: "UserTypeid_user_type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "OccurrenceLog");

            migrationBuilder.DropTable(
                name: "TargetUser");

            migrationBuilder.DropTable(
                name: "Camera");

            migrationBuilder.DropTable(
                name: "ImageLog");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
