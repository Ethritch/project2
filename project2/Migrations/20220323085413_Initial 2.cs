using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointmentTime = table.Column<DateTime>(nullable: false),
                    taken = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.TimeId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointments_Time_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Time",
                        principalColumn: "TimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 1, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 2, new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 3, new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 4, new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 5, new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 6, new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 7, new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 8, new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 9, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 10, new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 11, new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 12, new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Time",
                columns: new[] { "TimeId", "AppointmentTime", "taken" },
                values: new object[] { 13, new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TimeId",
                table: "Appointments",
                column: "TimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Time");
        }
    }
}
