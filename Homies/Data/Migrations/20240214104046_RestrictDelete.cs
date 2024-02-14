using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Homies.Data.Migrations
{
    public partial class RestrictDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventsParticipants_Events_EventId",
                table: "EventsParticipants");

            migrationBuilder.AddForeignKey(
                name: "FK_EventsParticipants_Events_EventId",
                table: "EventsParticipants",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventsParticipants_Events_EventId",
                table: "EventsParticipants");

            migrationBuilder.AddForeignKey(
                name: "FK_EventsParticipants_Events_EventId",
                table: "EventsParticipants",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }
    }
}
