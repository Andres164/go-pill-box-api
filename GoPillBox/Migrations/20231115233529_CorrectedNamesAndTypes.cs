using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GoPillBox.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedNamesAndTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicationInTreatments",
                table: "MedicationInTreatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlarmEvents",
                table: "AlarmEvents");

            migrationBuilder.DropColumn(
                name: "MedicationId",
                table: "MedicationInTreatments");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Treatments",
                newName: "treatments");

            migrationBuilder.RenameTable(
                name: "MedicationInTreatments",
                newName: "medication_in_treatments");

            migrationBuilder.RenameTable(
                name: "AlarmEvents",
                newName: "alarm_events");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "users",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "treatments",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "GeneralDescription",
                table: "treatments",
                newName: "general_description");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "treatments",
                newName: "treatment_id");

            migrationBuilder.RenameColumn(
                name: "Dose",
                table: "medication_in_treatments",
                newName: "dose");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "medication_in_treatments",
                newName: "treatment_id");

            migrationBuilder.RenameColumn(
                name: "TimeInTreatmentInDays",
                table: "medication_in_treatments",
                newName: "time_in_treatment_in_days");

            migrationBuilder.RenameColumn(
                name: "MedicNotes",
                table: "medication_in_treatments",
                newName: "medic_notes");

            migrationBuilder.RenameColumn(
                name: "DosingFrequencyInHours",
                table: "medication_in_treatments",
                newName: "dosing_frequency_in_hours");

            migrationBuilder.RenameColumn(
                name: "DoseUnitOfMesure",
                table: "medication_in_treatments",
                newName: "dose_unit_of_mesure");

            migrationBuilder.RenameColumn(
                name: "MedicationInTreatmentId",
                table: "medication_in_treatments",
                newName: "medication_in_treatment_id");

            migrationBuilder.RenameColumn(
                name: "PostponedForInMinutes",
                table: "alarm_events",
                newName: "postponed_for_in_minutes");

            migrationBuilder.RenameColumn(
                name: "MedicationInTreatmentid",
                table: "alarm_events",
                newName: "medication_in_treatment_id");

            migrationBuilder.RenameColumn(
                name: "EventTimeStamp",
                table: "alarm_events",
                newName: "event_time_stamp");

            migrationBuilder.RenameColumn(
                name: "CurrentState",
                table: "alarm_events",
                newName: "current_state");

            migrationBuilder.RenameColumn(
                name: "AlarmEventId",
                table: "alarm_events",
                newName: "alarm_event_id");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "users",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "general_description",
                table: "treatments",
                type: "character varying(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "medic_notes",
                table: "medication_in_treatments",
                type: "character varying(350)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "dose_unit_of_mesure",
                table: "medication_in_treatments",
                type: "character varying(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "medication_name",
                table: "medication_in_treatments",
                type: "character varying(70)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_treatments",
                table: "treatments",
                column: "treatment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medication_in_treatments",
                table: "medication_in_treatments",
                column: "medication_in_treatment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_alarm_events",
                table: "alarm_events",
                column: "alarm_event_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_treatments",
                table: "treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medication_in_treatments",
                table: "medication_in_treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_alarm_events",
                table: "alarm_events");

            migrationBuilder.DropColumn(
                name: "medication_name",
                table: "medication_in_treatments");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "treatments",
                newName: "Treatments");

            migrationBuilder.RenameTable(
                name: "medication_in_treatments",
                newName: "MedicationInTreatments");

            migrationBuilder.RenameTable(
                name: "alarm_events",
                newName: "AlarmEvents");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Treatments",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "general_description",
                table: "Treatments",
                newName: "GeneralDescription");

            migrationBuilder.RenameColumn(
                name: "treatment_id",
                table: "Treatments",
                newName: "TreatmentId");

            migrationBuilder.RenameColumn(
                name: "dose",
                table: "MedicationInTreatments",
                newName: "Dose");

            migrationBuilder.RenameColumn(
                name: "treatment_id",
                table: "MedicationInTreatments",
                newName: "TreatmentId");

            migrationBuilder.RenameColumn(
                name: "time_in_treatment_in_days",
                table: "MedicationInTreatments",
                newName: "TimeInTreatmentInDays");

            migrationBuilder.RenameColumn(
                name: "medic_notes",
                table: "MedicationInTreatments",
                newName: "MedicNotes");

            migrationBuilder.RenameColumn(
                name: "dosing_frequency_in_hours",
                table: "MedicationInTreatments",
                newName: "DosingFrequencyInHours");

            migrationBuilder.RenameColumn(
                name: "dose_unit_of_mesure",
                table: "MedicationInTreatments",
                newName: "DoseUnitOfMesure");

            migrationBuilder.RenameColumn(
                name: "medication_in_treatment_id",
                table: "MedicationInTreatments",
                newName: "MedicationInTreatmentId");

            migrationBuilder.RenameColumn(
                name: "postponed_for_in_minutes",
                table: "AlarmEvents",
                newName: "PostponedForInMinutes");

            migrationBuilder.RenameColumn(
                name: "medication_in_treatment_id",
                table: "AlarmEvents",
                newName: "MedicationInTreatmentid");

            migrationBuilder.RenameColumn(
                name: "event_time_stamp",
                table: "AlarmEvents",
                newName: "EventTimeStamp");

            migrationBuilder.RenameColumn(
                name: "current_state",
                table: "AlarmEvents",
                newName: "CurrentState");

            migrationBuilder.RenameColumn(
                name: "alarm_event_id",
                table: "AlarmEvents",
                newName: "AlarmEventId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)");

            migrationBuilder.AlterColumn<string>(
                name: "GeneralDescription",
                table: "Treatments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(250)");

            migrationBuilder.AlterColumn<string>(
                name: "MedicNotes",
                table: "MedicationInTreatments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(350)");

            migrationBuilder.AlterColumn<string>(
                name: "DoseUnitOfMesure",
                table: "MedicationInTreatments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)");

            migrationBuilder.AddColumn<int>(
                name: "MedicationId",
                table: "MedicationInTreatments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments",
                column: "TreatmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicationInTreatments",
                table: "MedicationInTreatments",
                column: "MedicationInTreatmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlarmEvents",
                table: "AlarmEvents",
                column: "AlarmEventId");

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    MedicationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string[]>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.MedicationId);
                });
        }
    }
}
