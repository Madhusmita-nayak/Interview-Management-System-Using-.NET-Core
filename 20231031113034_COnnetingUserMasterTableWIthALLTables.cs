using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewMS.Migrations
{
    /// <inheritdoc />
    public partial class COnnetingUserMasterTableWIthALLTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IEDStatusMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IEDStatusMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LevelMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    YearOfExperience = table.Column<int>(type: "int", nullable: false),
                    PrimarySkillSet = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CurrentLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CurrentCompany = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidate_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidate_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DmName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DmName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DmName_User_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DmName_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grade_User_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grade_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recruiter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recruiter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recruiter_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequirementType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequirementType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequirementType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceType_User_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResourceType_User_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Source_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Source_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Status_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Status_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasicDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobRequestNum = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfVacancy = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    RequiredBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequirementType = table.Column<int>(type: "int", nullable: false),
                    ResourceType = table.Column<int>(type: "int", nullable: false),
                    NameOfTheProject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DmId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicDetail_DmName_DmId",
                        column: x => x.DmId,
                        principalTable: "DmName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicDetail_Grade_Grade",
                        column: x => x.Grade,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicDetail_RequirementType_RequirementType",
                        column: x => x.RequirementType,
                        principalTable: "RequirementType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicDetail_ResourceType_ResourceType",
                        column: x => x.ResourceType,
                        principalTable: "ResourceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicDetail_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasicDetail_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recruitment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateID = table.Column<long>(type: "bigint", nullable: false),
                    RecruiterID = table.Column<int>(type: "int", nullable: false),
                    RelevantExperience = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CTC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpectedCTC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoticePeriod = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SourceID = table.Column<int>(type: "int", nullable: false),
                    NameOfTheSource = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruitment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recruitment_Candidate_CandidateID",
                        column: x => x.CandidateID,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recruitment_Recruiter_RecruiterID",
                        column: x => x.RecruiterID,
                        principalTable: "Recruiter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recruitment_Source_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Source",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recruitment_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recruitment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recruitment_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdditionalInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicDetailId = table.Column<int>(type: "int", nullable: false),
                    Name_Of_The_Client = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Client_Domain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Type_Of_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Client_Geography = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Visibility_of_Project = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Project_Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tentative_Project_Duration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Additional_Resources_Required_In_Future = table.Column<bool>(type: "bit", nullable: true),
                    Project_Directly_With_Client_or_Through_Partner = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Project_Revenue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Type_Of_Project = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Project_Execution_Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalInformation_BasicDetail_BasicDetailId",
                        column: x => x.BasicDetailId,
                        principalTable: "BasicDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalInformation_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalInformation_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Approval",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicDetailId = table.Column<int>(type: "int", nullable: false),
                    InitiatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReviewedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApprovedByHr = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedByPresident = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approval", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Approval_BasicDetail_BasicDetailId",
                        column: x => x.BasicDetailId,
                        principalTable: "BasicDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Approval_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Approval_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobSpecification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicDetailId = table.Column<int>(type: "int", nullable: false),
                    YOE = table.Column<int>(type: "int", nullable: false),
                    KeySkill = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSpecification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobSpecification_BasicDetail_BasicDetailId",
                        column: x => x.BasicDetailId,
                        principalTable: "BasicDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobSpecification_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobSpecification_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequirementInDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicDetailId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementInDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequirementInDetail_BasicDetail_BasicDetailId",
                        column: x => x.BasicDetailId,
                        principalTable: "BasicDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequirementInDetail_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequirementInDetail_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HRClientRound",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interviewer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeId = table.Column<int>(type: "int", nullable: false),
                    ResultId = table.Column<int>(type: "int", nullable: false),
                    IEDStatusId = table.Column<int>(type: "int", nullable: false),
                    JoiningOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonForEsspl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ReasonForDecline = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    MarksScoredInOnlineTest = table.Column<float>(type: "real", nullable: false),
                    RoundName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterviewCommonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRClientRound", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HRClientRound_IEDStatusMaster_IEDStatusId",
                        column: x => x.IEDStatusId,
                        principalTable: "IEDStatusMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HRClientRound_ModeMaster_ModeId",
                        column: x => x.ModeId,
                        principalTable: "ModeMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HRClientRound_ResultMaster_ResultId",
                        column: x => x.ResultId,
                        principalTable: "ResultMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InterviewCommon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recruiter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobOrderNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CandidateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<long>(type: "bigint", nullable: false),
                    YearOfExperience = table.Column<int>(type: "int", nullable: false),
                    RelevantExp = table.Column<int>(type: "int", nullable: false),
                    CTCLPA = table.Column<float>(type: "real", nullable: false),
                    ExpCTCLPA = table.Column<float>(type: "real", nullable: false),
                    NoticePeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManagementRoundId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewCommon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagementRound",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interviewer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModeId = table.Column<int>(type: "int", nullable: false),
                    ResultId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterviewCommonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagementRound", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagementRound_InterviewCommon_InterviewCommonId",
                        column: x => x.InterviewCommonId,
                        principalTable: "InterviewCommon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ManagementRound_ModeMaster_ModeId",
                        column: x => x.ModeId,
                        principalTable: "ModeMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ManagementRound_ResultMaster_ResultId",
                        column: x => x.ResultId,
                        principalTable: "ResultMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TechnicalRound",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Interviewer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModeId = table.Column<int>(type: "int", nullable: false),
                    ResultId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterviewCommonId = table.Column<int>(type: "int", nullable: false),
                    IEDStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalRound", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalRound_IEDStatusMaster_IEDStatusId",
                        column: x => x.IEDStatusId,
                        principalTable: "IEDStatusMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalRound_InterviewCommon_InterviewCommonId",
                        column: x => x.InterviewCommonId,
                        principalTable: "InterviewCommon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalRound_LevelMaster_LevelId",
                        column: x => x.LevelId,
                        principalTable: "LevelMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalRound_ModeMaster_ModeId",
                        column: x => x.ModeId,
                        principalTable: "ModeMaster",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalRound_ResultMaster_ResultId",
                        column: x => x.ResultId,
                        principalTable: "ResultMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInformation_BasicDetailId",
                table: "AdditionalInformation",
                column: "BasicDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInformation_CreatedBy",
                table: "AdditionalInformation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInformation_ModifiedBy",
                table: "AdditionalInformation",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_BasicDetailId",
                table: "Approval",
                column: "BasicDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_CreatedBy",
                table: "Approval",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_ModifiedBy",
                table: "Approval",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetail_CreatedBy",
                table: "BasicDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetail_DmId",
                table: "BasicDetail",
                column: "DmId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetail_Grade",
                table: "BasicDetail",
                column: "Grade");

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetail_ModifiedBy",
                table: "BasicDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetail_RequirementType",
                table: "BasicDetail",
                column: "RequirementType");

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetail_ResourceType",
                table: "BasicDetail",
                column: "ResourceType");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_CreatedBy",
                table: "Candidate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_ModifiedBy",
                table: "Candidate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DmName_CreatedById",
                table: "DmName",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DmName_ModifiedById",
                table: "DmName",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_CreatedById",
                table: "Grade",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_ModifiedById",
                table: "Grade",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_HRClientRound_IEDStatusId",
                table: "HRClientRound",
                column: "IEDStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HRClientRound_InterviewCommonId",
                table: "HRClientRound",
                column: "InterviewCommonId");

            migrationBuilder.CreateIndex(
                name: "IX_HRClientRound_ModeId",
                table: "HRClientRound",
                column: "ModeId");

            migrationBuilder.CreateIndex(
                name: "IX_HRClientRound_ResultId",
                table: "HRClientRound",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCommon_ManagementRoundId",
                table: "InterviewCommon",
                column: "ManagementRoundId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSpecification_BasicDetailId",
                table: "JobSpecification",
                column: "BasicDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSpecification_CreatedBy",
                table: "JobSpecification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_JobSpecification_ModifiedBy",
                table: "JobSpecification",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ManagementRound_InterviewCommonId",
                table: "ManagementRound",
                column: "InterviewCommonId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagementRound_ModeId",
                table: "ManagementRound",
                column: "ModeId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagementRound_ResultId",
                table: "ManagementRound",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Recruiter_CreatedBy",
                table: "Recruiter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Recruiter_ModifiedBy",
                table: "Recruiter",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_CandidateID",
                table: "Recruitment",
                column: "CandidateID");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_CreatedBy",
                table: "Recruitment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_ModifiedBy",
                table: "Recruitment",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_RecruiterID",
                table: "Recruitment",
                column: "RecruiterID");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_SourceID",
                table: "Recruitment",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_StatusId",
                table: "Recruitment",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementInDetail_BasicDetailId",
                table: "RequirementInDetail",
                column: "BasicDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementInDetail_CreatedBy",
                table: "RequirementInDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementInDetail_ModifiedBy",
                table: "RequirementInDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementType_CreatedById",
                table: "RequirementType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementType_ModifiedById",
                table: "RequirementType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceType_CreatedById",
                table: "ResourceType",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceType_ModifiedById",
                table: "ResourceType",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Source_CreatedBy",
                table: "Source",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Source_ModifiedBy",
                table: "Source",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Status_CreatedBy",
                table: "Status",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Status_ModifiedBy",
                table: "Status",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalRound_IEDStatusId",
                table: "TechnicalRound",
                column: "IEDStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalRound_InterviewCommonId",
                table: "TechnicalRound",
                column: "InterviewCommonId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalRound_LevelId",
                table: "TechnicalRound",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalRound_ModeId",
                table: "TechnicalRound",
                column: "ModeId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalRound_ResultId",
                table: "TechnicalRound",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedById",
                table: "User",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedById",
                table: "User",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_HRClientRound_InterviewCommon_InterviewCommonId",
                table: "HRClientRound",
                column: "InterviewCommonId",
                principalTable: "InterviewCommon",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InterviewCommon_ManagementRound_ManagementRoundId",
                table: "InterviewCommon",
                column: "ManagementRoundId",
                principalTable: "ManagementRound",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagementRound_InterviewCommon_InterviewCommonId",
                table: "ManagementRound");

            migrationBuilder.DropTable(
                name: "AdditionalInformation");

            migrationBuilder.DropTable(
                name: "Approval");

            migrationBuilder.DropTable(
                name: "HRClientRound");

            migrationBuilder.DropTable(
                name: "JobSpecification");

            migrationBuilder.DropTable(
                name: "Recruitment");

            migrationBuilder.DropTable(
                name: "RequirementInDetail");

            migrationBuilder.DropTable(
                name: "TechnicalRound");

            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Recruiter");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "BasicDetail");

            migrationBuilder.DropTable(
                name: "IEDStatusMaster");

            migrationBuilder.DropTable(
                name: "LevelMaster");

            migrationBuilder.DropTable(
                name: "DmName");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "RequirementType");

            migrationBuilder.DropTable(
                name: "ResourceType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "InterviewCommon");

            migrationBuilder.DropTable(
                name: "ManagementRound");

            migrationBuilder.DropTable(
                name: "ModeMaster");

            migrationBuilder.DropTable(
                name: "ResultMaster");
        }
    }
}
