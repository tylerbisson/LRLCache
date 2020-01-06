using Microsoft.EntityFrameworkCore.Migrations;

namespace RecordsApi.Migrations
{
    public partial class AddArtistModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Record",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Record",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Record_ArtistId",
                table: "Record",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Record_Artist_ArtistId",
                table: "Record",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Record_Artist_ArtistId",
                table: "Record");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropIndex(
                name: "IX_Record_ArtistId",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Record");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Record",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
