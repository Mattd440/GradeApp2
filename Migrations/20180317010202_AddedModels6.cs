using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GradeProject.Migrations
{
    public partial class AddedModels6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignmentClass",
                table: "Assignment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssignmentGrade",
                table: "Assignment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Assignment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Assignment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignmentClass",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "AssignmentGrade",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Assignment");
        }
    }
}
