using Microsoft.EntityFrameworkCore.Migrations;

namespace Myapp.Web.Migrations
{
    public partial class AddFieldAddressInTableStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Students");
        }
    }
}
