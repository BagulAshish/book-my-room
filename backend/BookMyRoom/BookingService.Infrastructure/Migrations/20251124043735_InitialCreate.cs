using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "booking_groups",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    customer_id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    check_in_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    check_out_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_groups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "coupons",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    code = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    coupon_type = table.Column<int>(type: "integer", nullable: false),
                    discount = table.Column<decimal>(type: "numeric", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "booking_group_amounts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    booking_group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    actual_amount = table.Column<decimal>(type: "numeric", nullable: false),
                    is_coupon_applicable = table.Column<bool>(type: "boolean", nullable: false),
                    discounted_amount = table.Column<decimal>(type: "numeric", nullable: false),
                    total_amount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_group_amounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_booking_group_amounts_booking_groups_booking_group_id",
                        column: x => x.booking_group_id,
                        principalTable: "booking_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booking_group_histories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    booking_group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    old_status = table.Column<int>(type: "integer", nullable: false),
                    new_status = table.Column<int>(type: "integer", nullable: false),
                    changed_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_group_histories", x => x.id);
                    table.ForeignKey(
                        name: "FK_booking_group_histories_booking_groups_booking_group_id",
                        column: x => x.booking_group_id,
                        principalTable: "booking_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    booking_group_id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_id = table.Column<Guid>(type: "uuid", nullable: false),
                    check_in_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    check_out_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    is_cancelled = table.Column<bool>(type: "boolean", nullable: false),
                    adults = table.Column<int>(type: "integer", nullable: false),
                    children = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.id);
                    table.ForeignKey(
                        name: "FK_bookings_booking_groups_booking_group_id",
                        column: x => x.booking_group_id,
                        principalTable: "booking_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booking_group_amount_coupons",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    booking_group_amount_id = table.Column<Guid>(type: "uuid", nullable: false),
                    coupon_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_group_amount_coupons", x => x.id);
                    table.ForeignKey(
                        name: "FK_booking_group_amount_coupons_booking_group_amounts_booking_~",
                        column: x => x.booking_group_amount_id,
                        principalTable: "booking_group_amounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booking_group_amount_coupons_coupons_coupon_id",
                        column: x => x.coupon_id,
                        principalTable: "coupons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booking_guests",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    booking_id = table.Column<Guid>(type: "uuid", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: true),
                    age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_guests", x => x.id);
                    table.ForeignKey(
                        name: "FK_booking_guests_bookings_booking_id",
                        column: x => x.booking_id,
                        principalTable: "bookings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_group_amount_coupons_booking_group_amount_id",
                table: "booking_group_amount_coupons",
                column: "booking_group_amount_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_group_amount_coupons_coupon_id",
                table: "booking_group_amount_coupons",
                column: "coupon_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_group_amounts_booking_group_id",
                table: "booking_group_amounts",
                column: "booking_group_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_booking_group_histories_booking_group_id",
                table: "booking_group_histories",
                column: "booking_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_booking_guests_booking_id",
                table: "booking_guests",
                column: "booking_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_booking_group_id",
                table: "bookings",
                column: "booking_group_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking_group_amount_coupons");

            migrationBuilder.DropTable(
                name: "booking_group_histories");

            migrationBuilder.DropTable(
                name: "booking_guests");

            migrationBuilder.DropTable(
                name: "booking_group_amounts");

            migrationBuilder.DropTable(
                name: "coupons");

            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "booking_groups");
        }
    }
}
