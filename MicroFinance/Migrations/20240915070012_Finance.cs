using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicroFinance.Migrations
{
    /// <inheritdoc />
    public partial class Finance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ExperyDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConformPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "govtDocumet",
                columns: table => new
                {
                    GovtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdharCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_govtDocumet", x => x.GovtId);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Roleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Roleid);
                });

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "branch",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statid = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch", x => x.BranchId);
                    table.ForeignKey(
                        name: "FK_branch_states_StateId",
                        column: x => x.StateId,
                        principalTable: "states",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Statid = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_cities_states_StateId",
                        column: x => x.StateId,
                        principalTable: "states",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Center",
                columns: table => new
                {
                    CneterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CenterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CenterAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CnetePinCoad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Center", x => x.CneterId);
                    table.ForeignKey(
                        name: "FK_Center_branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_branch_StateId",
                table: "branch",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Center_BranchId",
                table: "Center",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_cities_StateId",
                table: "cities",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Center");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "govtDocumet");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "branch");

            migrationBuilder.DropTable(
                name: "states");
        }
    }
}
