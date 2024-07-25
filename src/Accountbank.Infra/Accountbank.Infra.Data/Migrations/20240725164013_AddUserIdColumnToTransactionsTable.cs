using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accountbank.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdColumnToTransactionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Transactions");
        }
    }
}
