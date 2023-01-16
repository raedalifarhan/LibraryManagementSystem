using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class storedproc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var sp = @"CREATE PROCEDURE [LIB].[GetBooks]
                        AS
                        BEGIN
	                        SELECT * FROM [LIB].[Book]
                        END";

            migrationBuilder.Sql(sp);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
