using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersistenceTotalSystem.Migrations
{
	/// <inheritdoc />
	public partial class initial : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Products",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TypeId = table.Column<int>(type: "int", nullable: true),
					Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Weight = table.Column<int>(type: "int", nullable: true),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					DateModify = table.Column<DateTime>(type: "datetime2", nullable: true),
					DateChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
					UserModify = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Products", x => x.Id);
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Products");
		}
	}
}
