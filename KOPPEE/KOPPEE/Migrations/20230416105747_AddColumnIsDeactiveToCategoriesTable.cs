﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace KOPPEE.Migrations
{
    public partial class AddColumnIsDeactiveToCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "Categories");
        }
    }
}
