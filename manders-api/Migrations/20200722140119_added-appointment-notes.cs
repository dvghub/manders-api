using Microsoft.EntityFrameworkCore.Migrations;

namespace manders_api.Migrations
{
    public partial class addedappointmentnotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminNote",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserNote",
                table: "Appointments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminNote",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserNote",
                table: "Appointments");
        }
    }
}
