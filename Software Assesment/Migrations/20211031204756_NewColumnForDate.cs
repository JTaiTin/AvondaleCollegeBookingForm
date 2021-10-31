using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Software_Assesment.Migrations
{
    public partial class NewColumnForDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SessionDate",
                table: "Booking",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionDate",
                table: "Booking");
        }
    }
}
