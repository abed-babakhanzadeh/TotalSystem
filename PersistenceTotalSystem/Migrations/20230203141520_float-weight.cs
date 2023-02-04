using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersistenceTotalSystem.Migrations
{
	/// <inheritdoc />
	public partial class floatweight : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<float>(
				name: "Weight",
				table: "Products",
				type: "real",
				nullable: true,
				oldClrType: typeof(int),
				oldType: "int",
				oldNullable: true);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<int>(
				name: "Weight",
				table: "Products",
				type: "int",
				nullable: true,
				oldClrType: typeof(float),
				oldType: "real",
				oldNullable: true);
		}
	}
}
