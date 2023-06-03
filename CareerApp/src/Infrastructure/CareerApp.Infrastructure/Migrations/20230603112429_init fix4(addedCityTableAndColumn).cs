using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initfix4addedCityTableAndColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Roles_RoleId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_Roles_RoleId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "JobSeekers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "JobSeekers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "JobPostings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekers_CityId",
                table: "JobSeekers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_CityId",
                table: "JobPostings",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_City_CityId",
                table: "Companies",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Roles_RoleId",
                table: "Companies",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_City_CityId",
                table: "JobPostings",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_City_CityId",
                table: "JobSeekers",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_Roles_RoleId",
                table: "JobSeekers",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_City_CityId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Roles_RoleId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_City_CityId",
                table: "JobPostings");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_City_CityId",
                table: "JobSeekers");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekers_Roles_RoleId",
                table: "JobSeekers");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekers_CityId",
                table: "JobSeekers");

            migrationBuilder.DropIndex(
                name: "IX_JobPostings_CityId",
                table: "JobPostings");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CityId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "JobSeekers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "JobSeekers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "JobPostings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Companies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Roles_RoleId",
                table: "Companies",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekers_Roles_RoleId",
                table: "JobSeekers",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
