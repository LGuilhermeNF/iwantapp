using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWantApp.Migrations
{
    public partial class RenomearColunaNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                table: "Products",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "Products",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                table: "Categories",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "Categories",
                newName: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Products",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Products",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Categories",
                newName: "UpdateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Categories",
                newName: "CreateBy");
        }
    }
}
