using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalSystem.Infrastructure.Migrations
{
    public partial class damages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DamageFiledBy",
                table: "Damage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "Damage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Damage_DamageFiledBy",
                table: "Damage",
                column: "DamageFiledBy");

            migrationBuilder.CreateIndex(
                name: "IX_Damage_VehicleId",
                table: "Damage",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Damage_Customer_DamageFiledBy",
                table: "Damage",
                column: "DamageFiledBy",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Damage_Vehicle_VehicleId",
                table: "Damage",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Damage_Customer_DamageFiledBy",
                table: "Damage");

            migrationBuilder.DropForeignKey(
                name: "FK_Damage_Vehicle_VehicleId",
                table: "Damage");

            migrationBuilder.DropIndex(
                name: "IX_Damage_DamageFiledBy",
                table: "Damage");

            migrationBuilder.DropIndex(
                name: "IX_Damage_VehicleId",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "DamageFiledBy",
                table: "Damage");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Damage");
        }
    }
}
