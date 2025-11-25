using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProfileService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profile_addresses_profiles_ProfileId",
                table: "profile_addresses");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "profiles",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "profiles",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "profiles",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "profiles",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "ProfileImage",
                table: "profiles",
                newName: "profile_image");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "profiles",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "profiles",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "profiles",
                newName: "display_name");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "profiles",
                newName: "date_of_birth");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "profiles",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "profile_addresses",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "profile_addresses",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "profile_addresses",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "profile_addresses",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "profile_addresses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "profile_addresses",
                newName: "zip_code");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "profile_addresses",
                newName: "profile_id");

            migrationBuilder.RenameColumn(
                name: "AddressLine2",
                table: "profile_addresses",
                newName: "address_line2");

            migrationBuilder.RenameColumn(
                name: "AddressLine1",
                table: "profile_addresses",
                newName: "address_line1");

            migrationBuilder.RenameIndex(
                name: "IX_profile_addresses_ProfileId",
                table: "profile_addresses",
                newName: "IX_profile_addresses_profile_id");

            migrationBuilder.AlterColumn<string>(
                name: "area",
                table: "profile_addresses",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_profile_addresses_profiles_profile_id",
                table: "profile_addresses",
                column: "profile_id",
                principalTable: "profiles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profile_addresses_profiles_profile_id",
                table: "profile_addresses");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "profiles",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "profiles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "profiles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "profiles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "profile_image",
                table: "profiles",
                newName: "ProfileImage");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "profiles",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "profiles",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "display_name",
                table: "profiles",
                newName: "DisplayName");

            migrationBuilder.RenameColumn(
                name: "date_of_birth",
                table: "profiles",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "profiles",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "profile_addresses",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "profile_addresses",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "profile_addresses",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "profile_addresses",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "profile_addresses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "zip_code",
                table: "profile_addresses",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "profile_id",
                table: "profile_addresses",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "address_line2",
                table: "profile_addresses",
                newName: "AddressLine2");

            migrationBuilder.RenameColumn(
                name: "address_line1",
                table: "profile_addresses",
                newName: "AddressLine1");

            migrationBuilder.RenameIndex(
                name: "IX_profile_addresses_profile_id",
                table: "profile_addresses",
                newName: "IX_profile_addresses_ProfileId");

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "profile_addresses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_profile_addresses_profiles_ProfileId",
                table: "profile_addresses",
                column: "ProfileId",
                principalTable: "profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
