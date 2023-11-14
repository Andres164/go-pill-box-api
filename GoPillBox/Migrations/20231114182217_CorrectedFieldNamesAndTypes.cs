using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoPillBox.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedFieldNamesAndTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treatments",
                table: "Treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medications",
                table: "Medications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicationInTreatments",
                table: "MedicationInTreatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlarmEvents",
                table: "AlarmEvents");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "Treatments",
                newName: "treatment");

            migrationBuilder.RenameTable(
                name: "Medications",
                newName: "medication");

            migrationBuilder.RenameTable(
                name: "MedicationInTreatments",
                newName: "medication_in_treatment");

            migrationBuilder.RenameTable(
                name: "AlarmEvents",
                newName: "alarm_event");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "user",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "user",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "treatment",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "GeneralDescription",
                table: "treatment",
                newName: "general_description");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "treatment",
                newName: "treatment_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "medication",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MedicationId",
                table: "medication",
                newName: "medication_id");

            migrationBuilder.RenameColumn(
                name: "Dose",
                table: "medication_in_treatment",
                newName: "dose");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "medication_in_treatment",
                newName: "treatment_id");

            migrationBuilder.RenameColumn(
                name: "TimeInTreatmentInDays",
                table: "medication_in_treatment",
                newName: "time_in_treatment_in_days");

            migrationBuilder.RenameColumn(
                name: "MedicationId",
                table: "medication_in_treatment",
                newName: "medication_id");

            migrationBuilder.RenameColumn(
                name: "MedicNotes",
                table: "medication_in_treatment",
                newName: "medic_notes");

            migrationBuilder.RenameColumn(
                name: "DosingFrequencyInHours",
                table: "medication_in_treatment",
                newName: "dosing_frequency_in_hours");

            migrationBuilder.RenameColumn(
                name: "DoseUnitOfMesure",
                table: "medication_in_treatment",
                newName: "dose_unit_of_mesure");

            migrationBuilder.RenameColumn(
                name: "MedicationInTreatmentId",
                table: "medication_in_treatment",
                newName: "medication_in_treatment_id");

            migrationBuilder.RenameColumn(
                name: "PostponedForInMinutes",
                table: "alarm_event",
                newName: "postponed_for_in_minutes");

            migrationBuilder.RenameColumn(
                name: "MedicationInTreatmentid",
                table: "alarm_event",
                newName: "medication_in_treatment_id");

            migrationBuilder.RenameColumn(
                name: "EventTimeStamp",
                table: "alarm_event",
                newName: "event_time_stamp");

            migrationBuilder.RenameColumn(
                name: "CurrentState",
                table: "alarm_event",
                newName: "current_state");

            migrationBuilder.RenameColumn(
                name: "AlarmEventId",
                table: "alarm_event",
                newName: "alarm_event_id");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "user",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "user",
                type: "character varying(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "general_description",
                table: "treatment",
                type: "character varying(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "medication",
                type: "character varying(70)",
                nullable: false,
                oldClrType: typeof(string[]),
                oldType: "text[]");

            migrationBuilder.AlterColumn<string>(
                name: "medic_notes",
                table: "medication_in_treatment",
                type: "character varying(350)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "dose_unit_of_mesure",
                table: "medication_in_treatment",
                type: "character varying(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_treatment",
                table: "treatment",
                column: "treatment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medication",
                table: "medication",
                column: "medication_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medication_in_treatment",
                table: "medication_in_treatment",
                column: "medication_in_treatment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_alarm_event",
                table: "alarm_event",
                column: "alarm_event_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_treatment",
                table: "treatment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medication_in_treatment",
                table: "medication_in_treatment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medication",
                table: "medication");

            migrationBuilder.DropPrimaryKey(
                name: "PK_alarm_event",
                table: "alarm_event");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "treatment",
                newName: "Treatments");

            migrationBuilder.RenameTable(
                name: "medication_in_treatment",
                newName: "MedicationInTreatments");

            migrationBuilder.RenameTable(
                name: "medication",
                newName: "Medications");

            migrationBuilder.RenameTable(
                name: "alarm_event",
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
                name: "medication_id",
                table: "MedicationInTreatments",
                newName: "MedicationId");

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
                name: "name",
                table: "Medications",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "medication_id",
                table: "Medications",
                newName: "MedicationId");

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

            migrationBuilder.AlterColumn<string[]>(
                name: "Name",
                table: "Medications",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(70)");

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
                name: "PK_Medications",
                table: "Medications",
                column: "MedicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlarmEvents",
                table: "AlarmEvents",
                column: "AlarmEventId");
        }
    }
}
