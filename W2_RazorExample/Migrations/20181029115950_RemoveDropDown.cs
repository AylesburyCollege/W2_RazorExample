using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace W2_RazorExample.Migrations
{
    public partial class RemoveDropDown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Genre",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
