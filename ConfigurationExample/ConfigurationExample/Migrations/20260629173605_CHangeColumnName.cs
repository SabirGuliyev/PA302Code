using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConfigurationExample.Migrations
{
    /// <inheritdoc />
    public partial class CHangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Id",
                table: "Products",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "Product_Id");
        }
    }
}
