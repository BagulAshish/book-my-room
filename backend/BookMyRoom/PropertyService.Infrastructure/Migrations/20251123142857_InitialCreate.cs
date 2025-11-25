using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "properties",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    company = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    owner_id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_type = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_properties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "property_addresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    address_line1 = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    address_line2 = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    area = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    country = table.Column<string>(type: "text", nullable: true),
                    zip_code = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_addresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_property_addresses_properties_property_id",
                        column: x => x.property_id,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "property_featured",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_featured", x => x.id);
                    table.ForeignKey(
                        name: "FK_property_featured_properties_property_id",
                        column: x => x.property_id,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "property_locations",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    longitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    latitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_locations", x => x.id);
                    table.ForeignKey(
                        name: "FK_property_locations_properties_property_id",
                        column: x => x.property_id,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "property_photos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    photo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_photos", x => x.id);
                    table.ForeignKey(
                        name: "FK_property_photos_properties_property_id",
                        column: x => x.property_id,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "property_rules",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    check_in_time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    check_out_time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    is_couple_friendly = table.Column<bool>(type: "boolean", nullable: false),
                    is_bachelor_friendly = table.Column<bool>(type: "boolean", nullable: false),
                    is_IdRequired = table.Column<bool>(type: "boolean", nullable: false),
                    are_pets_allowed = table.Column<bool>(type: "boolean", nullable: false),
                    additional_rules = table.Column<string>(type: "character varying(800)", maxLength: 800, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_rules", x => x.id);
                    table.ForeignKey(
                        name: "FK_property_rules_properties_property_id",
                        column: x => x.property_id,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "property_stars",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_star_type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_stars", x => x.id);
                    table.ForeignKey(
                        name: "FK_property_stars_properties_property_id",
                        column: x => x.property_id,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_types",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    adults_capacity = table.Column<int>(type: "integer", nullable: true),
                    children_capacity = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    base_price = table.Column<double>(type: "double precision", nullable: true),
                    discount_price = table.Column<double>(type: "double precision", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_types", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_types_properties_property_id",
                        column: x => x.property_id,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_basic_facilities",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_house_keeping = table.Column<bool>(type: "boolean", nullable: false),
                    is_elevator = table.Column<bool>(type: "boolean", nullable: false),
                    is_parking = table.Column<bool>(type: "boolean", nullable: false),
                    is_common_room = table.Column<bool>(type: "boolean", nullable: false),
                    is_swimming_pool = table.Column<bool>(type: "boolean", nullable: false),
                    is_power_backup = table.Column<bool>(type: "boolean", nullable: false),
                    is_laundry_service = table.Column<bool>(type: "boolean", nullable: false),
                    is_laundry_service_paid = table.Column<bool>(type: "boolean", nullable: false),
                    is_news_paper = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_basic_facilities", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_basic_facilities_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_discounts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_discounts", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_discounts_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_food_facilities",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_free_breakfast = table.Column<bool>(type: "boolean", nullable: false),
                    is_restaurant = table.Column<bool>(type: "boolean", nullable: false),
                    is_bar = table.Column<bool>(type: "boolean", nullable: false),
                    is_pure_vegetarian = table.Column<bool>(type: "boolean", nullable: false),
                    is_jain = table.Column<bool>(type: "boolean", nullable: false),
                    is_fasting_food_available = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_food_facilities", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_food_facilities_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_other_facilities",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_other_facilities", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_other_facilities_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_photos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    photo = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_photos", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_photos_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_reviews",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    stars = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_reviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_reviews_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_security_facilities",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_cctv = table.Column<bool>(type: "boolean", nullable: false),
                    is_security_alarm = table.Column<bool>(type: "boolean", nullable: false),
                    is_fire_extinguisher = table.Column<bool>(type: "boolean", nullable: false),
                    is_swimming_pool_safety = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_security_facilities", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_security_facilities_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_staff_services",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_luggage_assist = table.Column<bool>(type: "boolean", nullable: false),
                    is_full_day_room_service = table.Column<bool>(type: "boolean", nullable: false),
                    is_wheelchair_available = table.Column<bool>(type: "boolean", nullable: false),
                    is_concierge = table.Column<bool>(type: "boolean", nullable: false),
                    is_doctor_on_call = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_staff_services", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_staff_services_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    room_status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_rooms_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_type_review_photos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_type_review_id = table.Column<Guid>(type: "uuid", nullable: false),
                    review_photo = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_type_review_photos", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_type_review_photos_room_type_reviews_room_type_review_~",
                        column: x => x.room_type_review_id,
                        principalTable: "room_type_reviews",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "room_amenities",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    room_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_sofa = table.Column<bool>(type: "boolean", nullable: false),
                    is_air_conditioner = table.Column<bool>(type: "boolean", nullable: false),
                    is_tv = table.Column<bool>(type: "boolean", nullable: false),
                    is_refrigerator = table.Column<bool>(type: "boolean", nullable: false),
                    is_toiletries = table.Column<bool>(type: "boolean", nullable: false),
                    is_dental_kit = table.Column<bool>(type: "boolean", nullable: false),
                    is_hair_dryer = table.Column<bool>(type: "boolean", nullable: false),
                    is_work_desk = table.Column<bool>(type: "boolean", nullable: false),
                    is_geyser = table.Column<bool>(type: "boolean", nullable: false),
                    is_balcony = table.Column<bool>(type: "boolean", nullable: false),
                    is_bathtub = table.Column<bool>(type: "boolean", nullable: false),
                    is_mineral_water = table.Column<bool>(type: "boolean", nullable: false),
                    is_bath_towel = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_amenities", x => x.id);
                    table.ForeignKey(
                        name: "FK_room_amenities_rooms_room_id",
                        column: x => x.room_id,
                        principalTable: "rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_property_addresses_property_id",
                table: "property_addresses",
                column: "property_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_property_featured_property_id",
                table: "property_featured",
                column: "property_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_property_locations_property_id",
                table: "property_locations",
                column: "property_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_property_photos_property_id",
                table: "property_photos",
                column: "property_id");

            migrationBuilder.CreateIndex(
                name: "IX_property_rules_property_id",
                table: "property_rules",
                column: "property_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_property_stars_property_id",
                table: "property_stars",
                column: "property_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_room_amenities_room_id",
                table: "room_amenities",
                column: "room_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_room_type_basic_facilities_room_type_id",
                table: "room_type_basic_facilities",
                column: "room_type_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_room_type_discounts_room_type_id",
                table: "room_type_discounts",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_room_type_food_facilities_room_type_id",
                table: "room_type_food_facilities",
                column: "room_type_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_room_type_other_facilities_room_type_id",
                table: "room_type_other_facilities",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_room_type_photos_room_type_id",
                table: "room_type_photos",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_room_type_review_photos_room_type_review_id",
                table: "room_type_review_photos",
                column: "room_type_review_id");

            migrationBuilder.CreateIndex(
                name: "IX_room_type_reviews_room_type_id",
                table: "room_type_reviews",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_room_type_security_facilities_room_type_id",
                table: "room_type_security_facilities",
                column: "room_type_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_room_type_staff_services_room_type_id",
                table: "room_type_staff_services",
                column: "room_type_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_room_types_property_id",
                table: "room_types",
                column: "property_id");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_room_type_id",
                table: "rooms",
                column: "room_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "property_addresses");

            migrationBuilder.DropTable(
                name: "property_featured");

            migrationBuilder.DropTable(
                name: "property_locations");

            migrationBuilder.DropTable(
                name: "property_photos");

            migrationBuilder.DropTable(
                name: "property_rules");

            migrationBuilder.DropTable(
                name: "property_stars");

            migrationBuilder.DropTable(
                name: "room_amenities");

            migrationBuilder.DropTable(
                name: "room_type_basic_facilities");

            migrationBuilder.DropTable(
                name: "room_type_discounts");

            migrationBuilder.DropTable(
                name: "room_type_food_facilities");

            migrationBuilder.DropTable(
                name: "room_type_other_facilities");

            migrationBuilder.DropTable(
                name: "room_type_photos");

            migrationBuilder.DropTable(
                name: "room_type_review_photos");

            migrationBuilder.DropTable(
                name: "room_type_security_facilities");

            migrationBuilder.DropTable(
                name: "room_type_staff_services");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "room_type_reviews");

            migrationBuilder.DropTable(
                name: "room_types");

            migrationBuilder.DropTable(
                name: "properties");
        }
    }
}
