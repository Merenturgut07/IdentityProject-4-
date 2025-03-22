using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity.DataAccessLayer.Migrations
{
    public partial class migaddrevieverorsendername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SenderName",
                table: "messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "messages");

            migrationBuilder.DropColumn(
                name: "SenderName",
                table: "messages");
        }
    }
}
