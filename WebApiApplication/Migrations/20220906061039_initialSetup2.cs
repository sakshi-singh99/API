////using System;
////using Microsoft.EntityFrameworkCore.Migrations;

////#nullable disable

////namespace WebApiApplication.Migrations
////{
////    public partial class initialSetup2 : Migration
////    {
////        protected override void Up(MigrationBuilder migrationBuilder)
////        {
////            migrationBuilder.CreateTable(
////                name: "AppraisalDetails",
////                columns: table => new
////                {
////                    EmployeeNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
////                    QuarterYear = table.Column<DateTime>(type: "datetime2", nullable: false),
////                    NumberOfGoals = table.Column<int>(type: "int", nullable: false),
////                    NineGridScoreDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Reviewer = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    HappinessPercent = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    CompletedPercent = table.Column<int>(type: "int", nullable: false),
////                    PerformancePercent = table.Column<int>(type: "int", nullable: false),
////                    BehaviouralPercent = table.Column<int>(type: "int", nullable: false),
////                    ExceptionallyHighPerformer = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    AnyIssue = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    ProjectManagerFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    CommentsToSupport = table.Column<string>(type: "nvarchar(max)", nullable: false)
////                },
////                constraints: table =>
////                {
////                    table.PrimaryKey("PK_AppraisalDetails", x => x.EmployeeNumber);
////                });

////            migrationBuilder.CreateTable(
////                name: "checkLists",
////                columns: table => new
////                {
////                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
////                    QuarterYear = table.Column<DateTime>(type: "datetime2", nullable: false),
////                    CType = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Achievable = table.Column<int>(type: "int", nullable: false),
////                    Achieved = table.Column<int>(type: "int", nullable: false)
////                },
////                constraints: table =>
////                {
////                    table.PrimaryKey("PK_checkLists", x => x.EmployeeId);
////                });

////            migrationBuilder.CreateTable(
////                name: "EmployeeGoalMonthWise",
////                columns: table => new
////                {
////                    EmployeeGoalObjective = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    quarterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    EmployeeComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    SupervisorComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    CompletedPercent = table.Column<int>(type: "int", nullable: false)
////                },
////                constraints: table =>
////                {
////                });

////            migrationBuilder.CreateTable(
////                name: "EmployeeGoalObjectives",
////                columns: table => new
////                {
////                    EmployeeQuarterlyGoalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Objective = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    CompletedPercentage = table.Column<int>(type: "int", nullable: false),
////                    ActionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
////                },
////                constraints: table =>
////                {
////                });

////            migrationBuilder.CreateTable(
////                name: "EmployeeQuarterlyGoals",
////                columns: table => new
////                {
////                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
////                    QuarterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    GoalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Weightage = table.Column<int>(type: "int", nullable: false)
////                },
////                constraints: table =>
////                {
////                    table.PrimaryKey("PK_EmployeeQuarterlyGoals", x => x.EmployeeId);
////                });

////            migrationBuilder.CreateTable(
////                name: "Employees",
////                columns: table => new
////                {
////                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
////                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    SupervisiorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Contact = table.Column<int>(type: "int", nullable: false),
////                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false)
////                },
////                constraints: table =>
////                {
////                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
////                });

////            migrationBuilder.CreateTable(
////                name: "financialYears",
////                columns: table => new
////                {
////                    FinancialYearName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
////                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
////                },
////                constraints: table =>
////                {
////                });

////            migrationBuilder.CreateTable(
////                name: "Goals",
////                columns: table => new
////                {
////                    GoalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    GoalType = table.Column<string>(type: "nvarchar(max)", nullable: false)
////                },
////                constraints: table =>
////                {
////                });

////            migrationBuilder.CreateTable(
////                name: "NineGridDetails",
////                columns: table => new
////                {
////                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    Choice = table.Column<int>(type: "int", nullable: false)
////                },
////                constraints: table =>
////                {
////                });

////            migrationBuilder.CreateTable(
////                name: "OnTheMoment",
////                columns: table => new
////                {
////                    FromEmployeeNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
////                    ToEmployeeNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
////                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    RequestedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
////                    RespondedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
////                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false)
////                },
////                constraints: table =>
////                {
////                });

////            migrationBuilder.CreateTable(
////                name: "PromotionData",
////                columns: table => new
////                {
////                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
////                    LastPromotionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
////                    ReadyForPromotion = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    PromotionComments = table.Column<string>(type: "nvarchar(max)", nullable: false)
////                },
////                constraints: table =>
////                {
////                    table.PrimaryKey("PK_PromotionData", x => x.EmployeeId);
////                });

////            migrationBuilder.CreateTable(
////                name: "QuarterDetails",
////                columns: table => new
////                {
////                    QuarterFinancialYearName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    MonthNumber = table.Column<int>(type: "int", nullable: false),
////                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: false)
////                },
////                constraints: table =>
////                {
////                });

////            migrationBuilder.CreateTable(
////                name: "QuarterFinancialYear",
////                columns: table => new
////                {
////                    FinancialYearName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    QuarterFinancialYearName = table.Column<string>(type: "nvarchar(max)", nullable: false),
////                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
////                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
////                },
////                constraints: table =>
////                {
////                });
////        }

////        protected override void Down(MigrationBuilder migrationBuilder)
////        {
////            migrationBuilder.DropTable(
////                name: "AppraisalDetails");

////            migrationBuilder.DropTable(
////                name: "checkLists");

////            migrationBuilder.DropTable(
////                name: "EmployeeGoalMonthWise");

////            migrationBuilder.DropTable(
////                name: "EmployeeGoalObjectives");

////            migrationBuilder.DropTable(
////                name: "EmployeeQuarterlyGoals");

////            migrationBuilder.DropTable(
////                name: "Employees");

////            migrationBuilder.DropTable(
////                name: "financialYears");

////            migrationBuilder.DropTable(
////                name: "Goals");

////            migrationBuilder.DropTable(
////                name: "NineGridDetails");

////            migrationBuilder.DropTable(
////                name: "OnTheMoment");

////            migrationBuilder.DropTable(
////                name: "PromotionData");

////            migrationBuilder.DropTable(
////                name: "QuarterDetails");

////            migrationBuilder.DropTable(
////                name: "QuarterFinancialYear");
////        }
////    }
////}
