using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class updatemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author_life_brief",
                schema: "LIB",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "Country",
                schema: "LIB",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "LIB",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "DOB",
                schema: "LIB",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "LIB",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                schema: "LIB",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "LIB",
                table: "Author");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                schema: "LIB",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FileUrl",
                schema: "LIB",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageCoverUrl",
                schema: "LIB",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                schema: "LIB",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                schema: "LIB",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "FileUrl",
                schema: "LIB",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ImageCoverUrl",
                schema: "LIB",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                schema: "LIB",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Author_life_brief",
                schema: "LIB",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "LIB",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "LIB",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                schema: "LIB",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "LIB",
                table: "Author",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "LIB",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "LIB",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
