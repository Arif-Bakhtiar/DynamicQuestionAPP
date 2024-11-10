using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DynamicQuestionApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Answer", "Options", "OptionsJson", "Text" },
                values: new object[] { "Yuan", "[\"Yuan\",\"Yen\",\"Dollar\",\"Taka\"]", "[\"Yuan\",\"Yen\",\"Dollar\",\"Taka\"]", "What is the currency of China?" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "Options", "OptionsJson", "Text" },
                values: new object[,]
                {
                    { 3, "Amazon", "[\"Amazon\",\"Sundarbans\",\"Black Forest\",\"Africa\"]", "[\"Amazon\",\"Sundarbans\",\"Black Forest\",\"Africa\"]", "What is the largest rainforest in the world?" },
                    { 4, "Riyadh", "[\"Zedda\",\"Riyadh\",\"Mecca\",\"Medina\"]", "[\"Zedda\",\"Riyadh\",\"Mecca\",\"Medina\"]", "What is the capital of Saudi Arabia?" },
                    { 5, "London", "[\"Delhi\",\"London\",\"Berlin\",\"Rome\"]", "[\"Delhi\",\"London\",\"Berlin\",\"Rome\"]", "What is the capital of UK?" },
                    { 6, "Mars", "[\"Earth\",\"Mars\",\"Jupiter\",\"Saturn\"]", "[\"Earth\",\"Mars\",\"Jupiter\",\"Saturn\"]", "Which planet is known as the Red Planet?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Answer", "Options", "OptionsJson", "Text" },
                values: new object[] { "Mars", "[\"Earth\",\"Mars\",\"Jupiter\",\"Saturn\"]", "[\"Earth\",\"Mars\",\"Jupiter\",\"Saturn\"]", "Which planet is known as the Red Planet?" });
        }
    }
}
