using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsInfo.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PointsOfInterest",
                type: "TEXT",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Company", "ImageUrl", "Model", "Name", "Variant", "Year" },
                values: new object[] { 1, "Porsche", "", "Carrera", "911", "S", 2023 });

            migrationBuilder.InsertData(
                table: "PointsOfInterest",
                columns: new[] { "Id", "CarId", "Description", "Name" },
                values: new object[] { 2, 1, "Dual-clutch automatic", "PDK Transmission" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PointsOfInterest",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
