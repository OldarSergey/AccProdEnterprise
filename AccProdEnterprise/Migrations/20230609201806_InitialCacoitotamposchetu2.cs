using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccProdEnterprise.Migrations
{
    public partial class InitialCacoitotamposchetu2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvancedTrainingCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NameOfCourse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourseStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    CourseEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Organizer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedTrainingCourses_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NamePost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripton = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal", nullable: false),
                    EducationRequirement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfCreate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateOfDelete = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffDepartments_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tablesheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime", maxLength: 100, nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime", maxLength: 100, nullable: false),
                    QtyHoursWorked = table.Column<string>(type: "integer", nullable: false),
                    TypeWork = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablesheets_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdmissionDismissalOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfOrder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfOrders = table.Column<DateTime>(type: "date", maxLength: 100, nullable: false),
                    ReasonOfDismissal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StaffDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionDismissalOrder_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdmissionDismissalOrders_StaffDepartmentsId_StaffDepartments_Id",
                        column: x => x.StaffDepartmentId,
                        principalTable: "StaffDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NameDepartment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullNameOfTheHead = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StaffDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_StaffDepartmentsId_StaffDepartments_Id",
                        column: x => x.StaffDepartmentId,
                        principalTable: "StaffDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacationApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateOfSubmission = table.Column<DateTime>(type: "datetime", nullable: false),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QtyOfDays = table.Column<int>(type: "integer", nullable: false),
                    StatusApplication = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RejectsReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacationApplications_StaffDepartmentsId_StaffDepartments_Id",
                        column: x => x.StaffDepartmentId,
                        principalTable: "StaffDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Middlename = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumberPhone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PositionName = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    TablesheetsId = table.Column<int>(type: "int", nullable: false),
                    AdvancedTrainingCourseId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AdvancedTrainingCourseId_AdvancedTrainingCourse_Id",
                        column: x => x.AdvancedTrainingCourseId,
                        principalTable: "AdvancedTrainingCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_DepartmentId_Department_Id",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_PositionId_Positions_Id",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_TablesheetsId_Tablesheets_Id",
                        column: x => x.TablesheetsId,
                        principalTable: "Tablesheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionDismissalOrders_StaffDepartmentId",
                table: "AdmissionDismissalOrders",
                column: "StaffDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_StaffDepartmentId",
                table: "Departments",
                column: "StaffDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AdvancedTrainingCourseId",
                table: "Employees",
                column: "AdvancedTrainingCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TablesheetsId",
                table: "Employees",
                column: "TablesheetsId");

            migrationBuilder.CreateIndex(
                name: "IX_VacationApplications_StaffDepartmentId",
                table: "VacationApplications",
                column: "StaffDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionDismissalOrders");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "VacationApplications");

            migrationBuilder.DropTable(
                name: "AdvancedTrainingCourses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Tablesheets");

            migrationBuilder.DropTable(
                name: "StaffDepartments");
        }
    }
}
