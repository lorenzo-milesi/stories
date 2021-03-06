﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Stories.Migrations
{
    public partial class AddStoryInScenario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoryId",
                table: "Scenarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Scenarios_StoryId",
                table: "Scenarios",
                column: "StoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Scenarios_Stories_StoryId",
                table: "Scenarios",
                column: "StoryId",
                principalTable: "Stories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scenarios_Stories_StoryId",
                table: "Scenarios");

            migrationBuilder.DropIndex(
                name: "IX_Scenarios_StoryId",
                table: "Scenarios");

            migrationBuilder.DropColumn(
                name: "StoryId",
                table: "Scenarios");
        }
    }
}
