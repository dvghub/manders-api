using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace manders_api.Migrations
{
    public partial class scheduleadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: true),
                    ScheduleId1 = table.Column<int>(nullable: true),
                    ScheduleId2 = table.Column<int>(nullable: true),
                    ScheduleId3 = table.Column<int>(nullable: true),
                    ScheduleId4 = table.Column<int>(nullable: true),
                    ScheduleId5 = table.Column<int>(nullable: true),
                    ScheduleId6 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slots_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_Schedules_ScheduleId1",
                        column: x => x.ScheduleId1,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_Schedules_ScheduleId2",
                        column: x => x.ScheduleId2,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_Schedules_ScheduleId3",
                        column: x => x.ScheduleId3,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_Schedules_ScheduleId4",
                        column: x => x.ScheduleId4,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_Schedules_ScheduleId5",
                        column: x => x.ScheduleId5,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slots_Schedules_ScheduleId6",
                        column: x => x.ScheduleId6,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlotId = table.Column<int>(nullable: true),
                    Double = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    Confirmed = table.Column<bool>(nullable: false),
                    Reminded = table.Column<bool>(nullable: false),
                    Cancelled = table.Column<bool>(nullable: false),
                    Handled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SlotId",
                table: "Appointments",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ScheduleId",
                table: "Slots",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ScheduleId1",
                table: "Slots",
                column: "ScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ScheduleId2",
                table: "Slots",
                column: "ScheduleId2");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ScheduleId3",
                table: "Slots",
                column: "ScheduleId3");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ScheduleId4",
                table: "Slots",
                column: "ScheduleId4");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ScheduleId5",
                table: "Slots",
                column: "ScheduleId5");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_ScheduleId6",
                table: "Slots",
                column: "ScheduleId6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
