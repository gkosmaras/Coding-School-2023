using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Course.Orm.Migrations
{
    /// <inheritdoc />
    public partial class ColumnDetailsInTodoInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "TodoInfo",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "TodoInfo");
        }
    }
}
