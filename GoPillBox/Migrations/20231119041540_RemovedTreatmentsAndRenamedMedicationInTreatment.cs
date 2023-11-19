using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GoPillBox.Migrations
{
    /// <inheritdoc />
    public partial class RemovedTreatmentsAndRenamedMedicationInTreatment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medication_in_treatments");

            migrationBuilder.DropTable(
                name: "treatments");

            migrationBuilder.RenameColumn(
                name: "medication_in_treatment_id",
                table: "alarm_events",
                newName: "user_medication_id");

            migrationBuilder.CreateTable(
                name: "user_medications",
                columns: table => new
                {
                    user_medication_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    medic_notes = table.Column<string>(type: "character varying(350)", nullable: false),
                    medication_name = table.Column<string>(type: "character varying(70)", nullable: false),
                    dose = table.Column<float>(type: "real", nullable: false),
                    dose_unit_of_mesure = table.Column<string>(type: "character varying(20)", nullable: false),
                    dosing_frequency_in_hours = table.Column<float>(type: "real", nullable: false),
                    time_in_treatment_in_days = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_medications", x => x.user_medication_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_medications");

            migrationBuilder.RenameColumn(
                name: "user_medication_id",
                table: "alarm_events",
                newName: "medication_in_treatment_id");

            migrationBuilder.CreateTable(
                name: "medication_in_treatments",
                columns: table => new
                {
                    medication_in_treatment_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dose = table.Column<float>(type: "real", nullable: false),
                    dose_unit_of_mesure = table.Column<string>(type: "character varying(20)", nullable: false),
                    dosing_frequency_in_hours = table.Column<float>(type: "real", nullable: false),
                    medic_notes = table.Column<string>(type: "character varying(350)", nullable: false),
                    medication_name = table.Column<string>(type: "character varying(70)", nullable: false),
                    time_in_treatment_in_days = table.Column<int>(type: "integer", nullable: false),
                    treatment_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medication_in_treatments", x => x.medication_in_treatment_id);
                });

            migrationBuilder.CreateTable(
                name: "treatments",
                columns: table => new
                {
                    treatment_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    general_description = table.Column<string>(type: "character varying(250)", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatments", x => x.treatment_id);
                });
        }
    }
}
