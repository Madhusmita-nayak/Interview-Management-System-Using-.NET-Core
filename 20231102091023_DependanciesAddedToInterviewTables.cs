using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewMS.Migrations
{
    /// <inheritdoc />
    public partial class DependanciesAddedToInterviewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "TechnicalRound",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "ResultMaster",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ResultMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "ResultMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "ModeMaster",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ModeMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "ModeMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "ManagementRound",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ManagementRound",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "ManagementRound",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "LevelMaster",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "LevelMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "LevelMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "InterviewCommon",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "InterviewCommon",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "InterviewCommon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "IEDStatusMaster",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "IEDStatusMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "IEDStatusMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByAppUserId",
                table: "HRClientRound",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalRound_CreatedBy",
                table: "TechnicalRound",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalRound_CreatedByAppUserId",
                table: "TechnicalRound",
                column: "CreatedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultMaster_CreatedBy",
                table: "ResultMaster",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResultMaster_CreatedByAppUserId",
                table: "ResultMaster",
                column: "CreatedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeMaster_CreatedBy",
                table: "ModeMaster",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ModeMaster_CreatedByAppUserId",
                table: "ModeMaster",
                column: "CreatedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagementRound_CreatedBy",
                table: "ManagementRound",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ManagementRound_CreatedByAppUserId",
                table: "ManagementRound",
                column: "CreatedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LevelMaster_CreatedBy",
                table: "LevelMaster",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LevelMaster_CreatedByAppUserId",
                table: "LevelMaster",
                column: "CreatedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCommon_CreatedBy",
                table: "InterviewCommon",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCommon_CreatedByAppUserId",
                table: "InterviewCommon",
                column: "CreatedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IEDStatusMaster_CreatedBy",
                table: "IEDStatusMaster",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_IEDStatusMaster_CreatedByAppUserId",
                table: "IEDStatusMaster",
                column: "CreatedByAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HRClientRound_CreatedBy",
                table: "HRClientRound",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HRClientRound_CreatedByAppUserId",
                table: "HRClientRound",
                column: "CreatedByAppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HRClientRound_User_CreatedBy",
                table: "HRClientRound",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HRClientRound_User_CreatedByAppUserId",
                table: "HRClientRound",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IEDStatusMaster_User_CreatedBy",
                table: "IEDStatusMaster",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IEDStatusMaster_User_CreatedByAppUserId",
                table: "IEDStatusMaster",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InterviewCommon_User_CreatedBy",
                table: "InterviewCommon",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InterviewCommon_User_CreatedByAppUserId",
                table: "InterviewCommon",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LevelMaster_User_CreatedBy",
                table: "LevelMaster",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LevelMaster_User_CreatedByAppUserId",
                table: "LevelMaster",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagementRound_User_CreatedBy",
                table: "ManagementRound",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagementRound_User_CreatedByAppUserId",
                table: "ManagementRound",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModeMaster_User_CreatedBy",
                table: "ModeMaster",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ModeMaster_User_CreatedByAppUserId",
                table: "ModeMaster",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResultMaster_User_CreatedBy",
                table: "ResultMaster",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResultMaster_User_CreatedByAppUserId",
                table: "ResultMaster",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalRound_User_CreatedBy",
                table: "TechnicalRound",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalRound_User_CreatedByAppUserId",
                table: "TechnicalRound",
                column: "CreatedByAppUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HRClientRound_User_CreatedBy",
                table: "HRClientRound");

            migrationBuilder.DropForeignKey(
                name: "FK_HRClientRound_User_CreatedByAppUserId",
                table: "HRClientRound");

            migrationBuilder.DropForeignKey(
                name: "FK_IEDStatusMaster_User_CreatedBy",
                table: "IEDStatusMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_IEDStatusMaster_User_CreatedByAppUserId",
                table: "IEDStatusMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_InterviewCommon_User_CreatedBy",
                table: "InterviewCommon");

            migrationBuilder.DropForeignKey(
                name: "FK_InterviewCommon_User_CreatedByAppUserId",
                table: "InterviewCommon");

            migrationBuilder.DropForeignKey(
                name: "FK_LevelMaster_User_CreatedBy",
                table: "LevelMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_LevelMaster_User_CreatedByAppUserId",
                table: "LevelMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ManagementRound_User_CreatedBy",
                table: "ManagementRound");

            migrationBuilder.DropForeignKey(
                name: "FK_ManagementRound_User_CreatedByAppUserId",
                table: "ManagementRound");

            migrationBuilder.DropForeignKey(
                name: "FK_ModeMaster_User_CreatedBy",
                table: "ModeMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ModeMaster_User_CreatedByAppUserId",
                table: "ModeMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultMaster_User_CreatedBy",
                table: "ResultMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultMaster_User_CreatedByAppUserId",
                table: "ResultMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalRound_User_CreatedBy",
                table: "TechnicalRound");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalRound_User_CreatedByAppUserId",
                table: "TechnicalRound");

            migrationBuilder.DropIndex(
                name: "IX_TechnicalRound_CreatedBy",
                table: "TechnicalRound");

            migrationBuilder.DropIndex(
                name: "IX_TechnicalRound_CreatedByAppUserId",
                table: "TechnicalRound");

            migrationBuilder.DropIndex(
                name: "IX_ResultMaster_CreatedBy",
                table: "ResultMaster");

            migrationBuilder.DropIndex(
                name: "IX_ResultMaster_CreatedByAppUserId",
                table: "ResultMaster");

            migrationBuilder.DropIndex(
                name: "IX_ModeMaster_CreatedBy",
                table: "ModeMaster");

            migrationBuilder.DropIndex(
                name: "IX_ModeMaster_CreatedByAppUserId",
                table: "ModeMaster");

            migrationBuilder.DropIndex(
                name: "IX_ManagementRound_CreatedBy",
                table: "ManagementRound");

            migrationBuilder.DropIndex(
                name: "IX_ManagementRound_CreatedByAppUserId",
                table: "ManagementRound");

            migrationBuilder.DropIndex(
                name: "IX_LevelMaster_CreatedBy",
                table: "LevelMaster");

            migrationBuilder.DropIndex(
                name: "IX_LevelMaster_CreatedByAppUserId",
                table: "LevelMaster");

            migrationBuilder.DropIndex(
                name: "IX_InterviewCommon_CreatedBy",
                table: "InterviewCommon");

            migrationBuilder.DropIndex(
                name: "IX_InterviewCommon_CreatedByAppUserId",
                table: "InterviewCommon");

            migrationBuilder.DropIndex(
                name: "IX_IEDStatusMaster_CreatedBy",
                table: "IEDStatusMaster");

            migrationBuilder.DropIndex(
                name: "IX_IEDStatusMaster_CreatedByAppUserId",
                table: "IEDStatusMaster");

            migrationBuilder.DropIndex(
                name: "IX_HRClientRound_CreatedBy",
                table: "HRClientRound");

            migrationBuilder.DropIndex(
                name: "IX_HRClientRound_CreatedByAppUserId",
                table: "HRClientRound");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "TechnicalRound");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "ResultMaster");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "ModeMaster");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "ManagementRound");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "LevelMaster");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "InterviewCommon");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "IEDStatusMaster");

            migrationBuilder.DropColumn(
                name: "CreatedByAppUserId",
                table: "HRClientRound");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "ResultMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ResultMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "ModeMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ModeMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "ManagementRound",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ManagementRound",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "LevelMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "LevelMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "InterviewCommon",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "InterviewCommon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "IEDStatusMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "IEDStatusMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
