using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PopCulture.DataAccess.Migrations
{
    public partial class CorrectPaymentIntent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentIntendId",
                table: "OrderHeaders",
                newName: "PaymentIntentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentIntentId",
                table: "OrderHeaders",
                newName: "PaymentIntendId");
        }
    }
}
