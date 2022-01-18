using Microsoft.EntityFrameworkCore.Migrations;

namespace Myapp.Web.Migrations
{
    public partial class UpdateFieldAddressInTableStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "address",
                table: "Students",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Students",
                newName: "address");
        }
    }
}
