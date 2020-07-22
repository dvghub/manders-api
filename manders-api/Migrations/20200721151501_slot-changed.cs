using Microsoft.EntityFrameworkCore.Migrations;

namespace manders_api.Migrations
{
    public partial class slotchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Doubleable",
                table: "Slots",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doubleable",
                table: "Slots");
        }
    }
}
