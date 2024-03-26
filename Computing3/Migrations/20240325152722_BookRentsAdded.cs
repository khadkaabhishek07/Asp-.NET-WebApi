using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Computing3.Migrations
{
    /// <inheritdoc />
    public partial class BookRentsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_students_StudentId",
                table: "Bill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "Bills");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_StudentId",
                table: "Bills",
                newName: "IX_Bills_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "LMUID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bills",
                table: "Bills",
                column: "Bill_ID");

            migrationBuilder.CreateTable(
                name: "BookRents",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rented_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRents", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_BookRents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "LMUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookRents_StudentId",
                table: "BookRents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Students_StudentId",
                table: "Bills",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "LMUID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Students_StudentId",
                table: "Bills");

            migrationBuilder.DropTable(
                name: "BookRents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bills",
                table: "Bills");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Bills",
                newName: "Bill");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_StudentId",
                table: "Bill",
                newName: "IX_Bill_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "LMUID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "Bill_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_students_StudentId",
                table: "Bill",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "LMUID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
