using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CareerApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSeekers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekers_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobSeekers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPostings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ListingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPostings_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPostings_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecourseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    JobSeekerId = table.Column<int>(type: "int", nullable: true),
                    JobPostingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recourses_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recourses_JobPostings_JobPostingId",
                        column: x => x.JobPostingId,
                        principalTable: "JobPostings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recourses_JobSeekers_JobSeekerId",
                        column: x => x.JobSeekerId,
                        principalTable: "JobSeekers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "adana" },
                    { 2, "adıyaman" },
                    { 3, "afyonkarahisar" },
                    { 4, "ağrı" },
                    { 5, "amasya" },
                    { 6, "ankara" },
                    { 7, "antalya" },
                    { 8, "artvin" },
                    { 9, "aydın" },
                    { 10, "balıkesir" },
                    { 11, "bilecik" },
                    { 12, "bingöl" },
                    { 13, "bitlis" },
                    { 14, "bolu" },
                    { 15, "burdur" },
                    { 16, "bursa" },
                    { 17, "çanakkale" },
                    { 18, "çankırı" },
                    { 19, "çorum" },
                    { 20, "denizli" },
                    { 21, "diyarbakır" },
                    { 22, "edirne" },
                    { 23, "elazığ" },
                    { 24, "erzincan" },
                    { 25, "erzurum" },
                    { 26, "eskişehir" },
                    { 27, "gaziantep" },
                    { 28, "giresun" },
                    { 29, "gümüşhane" },
                    { 30, "hakkari" },
                    { 31, "hatay" },
                    { 32, "ısparta" },
                    { 33, "mersin" },
                    { 34, "istanbul" },
                    { 35, "izmir" },
                    { 36, "kars" },
                    { 37, "kastamonu" },
                    { 38, "kayseri" },
                    { 39, "kırklareli" },
                    { 40, "kırşehir" },
                    { 41, "kocaeli" },
                    { 42, "konya" },
                    { 43, "kütahya" },
                    { 44, "malatya" },
                    { 45, "manisa" },
                    { 46, "kahramanmaraş" },
                    { 47, "mardin" },
                    { 48, "muğla" },
                    { 49, "muş" },
                    { 50, "nevşehir" },
                    { 51, "niğde" },
                    { 52, "ordu" },
                    { 53, "rize" },
                    { 54, "sakarya" },
                    { 55, "samsun" },
                    { 56, "siirt" },
                    { 57, "sinop" },
                    { 58, "sivas" },
                    { 59, "tekirdağ" },
                    { 60, "tokat" },
                    { 61, "trabzon" },
                    { 62, "tunceli" },
                    { 63, "şanlıurfa" },
                    { 64, "uşak" },
                    { 65, "van" },
                    { 66, "yozgat" },
                    { 67, "zonguldak" },
                    { 68, "aksaray" },
                    { 69, "bayburt" },
                    { 70, "karaman" },
                    { 71, "kırıkkale" },
                    { 72, "batman" },
                    { 73, "şırnak" },
                    { 74, "bartın" },
                    { 75, "ardahan" },
                    { 76, "ığdır" },
                    { 77, "yalova" },
                    { 78, "karabük" },
                    { 79, "kilis" },
                    { 80, "osmaniye" },
                    { 81, "düzce" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "inşaat mühendisi" },
                    { 2, "yazılım geliştirici" },
                    { 3, "doktor" },
                    { 4, "öğretmen" },
                    { 5, "hemşire" },
                    { 6, "avukat" },
                    { 7, "mimar" },
                    { 8, "eczacı" },
                    { 9, "muhabir" },
                    { 10, "elektrikçi" },
                    { 11, "şef" },
                    { 12, "grafiker" },
                    { 13, "fotografçı" },
                    { 14, "mekanikçi" },
                    { 15, "tasarımcı" },
                    { 16, "aşçı" },
                    { 17, "müzik öğretmeni" },
                    { 18, "itfaiyeci" },
                    { 19, "bankacı" },
                    { 20, "psikolog" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "company" },
                    { 2, "jobSeeker" },
                    { 3, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_RoleId",
                table: "Companies",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_CityId",
                table: "JobPostings",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_CompanyId",
                table: "JobPostings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_JobId",
                table: "JobPostings",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_CityId",
                table: "JobSeekers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_JobId",
                table: "JobSeekers",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_RoleId",
                table: "JobSeekers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Recourses_CompanyId",
                table: "Recourses",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Recourses_JobPostingId",
                table: "Recourses",
                column: "JobPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_Recourses_JobSeekerId",
                table: "Recourses",
                column: "JobSeekerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recourses");

            migrationBuilder.DropTable(
                name: "JobPostings");

            migrationBuilder.DropTable(
                name: "JobSeekers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
