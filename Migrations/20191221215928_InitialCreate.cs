using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Movietheque.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mtq_User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    Login = table.Column<string>(maxLength: 25, nullable: false),
                    Password = table.Column<string>(maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mtq_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mtq_User_Email",
                table: "mtq_User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mtq_User_Login",
                table: "mtq_User",
                column: "Login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mtq_User");
        }
    }
}
