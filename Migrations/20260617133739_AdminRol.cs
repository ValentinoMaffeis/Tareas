using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id From AspNetRoles WHERE Id = 'e08f0f93-96bb-4dae-8b18-bebe0b1e15b3')
                                    BEGIN
	                                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
	                                    VALUES ('e08f0f93-96bb-4dae-8b18-bebe0b1e15b3', 'admin', 'ADMIN')
                                    END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles WHERE Id = 'e08f0f93-96bb-4dae-8b18-bebe0b1e15b3'");
        }
    }
}
