using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeatSentry.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSentryRequestsAndCourseToContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Course_CourseId",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_SentryRequest_Section_SectionId",
                table: "SentryRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_SentryRequest_Users_UserId",
                table: "SentryRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SentryRequest",
                table: "SentryRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "SentryRequest",
                newName: "SentryRequests");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "Sections");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_SentryRequest_UserId",
                table: "SentryRequests",
                newName: "IX_SentryRequests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SentryRequest_SectionId",
                table: "SentryRequests",
                newName: "IX_SentryRequests_SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Section_CourseId",
                table: "Sections",
                newName: "IX_Sections_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SentryRequests",
                table: "SentryRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentryRequests_Sections_SectionId",
                table: "SentryRequests",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentryRequests_Users_UserId",
                table: "SentryRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses_CourseId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_SentryRequests_Sections_SectionId",
                table: "SentryRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_SentryRequests_Users_UserId",
                table: "SentryRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SentryRequests",
                table: "SentryRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "SentryRequests",
                newName: "SentryRequest");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Section");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_SentryRequests_UserId",
                table: "SentryRequest",
                newName: "IX_SentryRequest_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SentryRequests_SectionId",
                table: "SentryRequest",
                newName: "IX_SentryRequest_SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_CourseId",
                table: "Section",
                newName: "IX_Section_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SentryRequest",
                table: "SentryRequest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Course_CourseId",
                table: "Section",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentryRequest_Section_SectionId",
                table: "SentryRequest",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SentryRequest_Users_UserId",
                table: "SentryRequest",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
