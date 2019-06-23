using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Douana.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CountryCode = table.Column<string>(nullable: true),
                    CountryName = table.Column<string>(nullable: true),
                    IsEuropeanUnion = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    FlightNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    CountryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CountryId = table.Column<long>(nullable: true),
                    TranslationKey = table.Column<string>(nullable: true),
                    VisumRequired = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nationalities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    AddressId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Places_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoatTrips",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    TripId = table.Column<string>(nullable: true),
                    DepartureId = table.Column<long>(nullable: true),
                    DestinationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoatTrips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoatTrips_Places_DepartureId",
                        column: x => x.DepartureId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BoatTrips_Places_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MaidenName = table.Column<string>(nullable: true),
                    CurrentResidenceId = table.Column<long>(nullable: true),
                    BirthDate = table.Column<DateTimeOffset>(nullable: false),
                    BirthPlaceId = table.Column<long>(nullable: true),
                    Occupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citizens_Places_BirthPlaceId",
                        column: x => x.BirthPlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citizens_Places_CurrentResidenceId",
                        column: x => x.CurrentResidenceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomsForms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CitizenId = table.Column<long>(nullable: true),
                    FlightId = table.Column<long>(nullable: true),
                    BoatTripId = table.Column<long>(nullable: true),
                    GuestCountryPlaceId = table.Column<long>(nullable: true),
                    DestinationId = table.Column<long>(nullable: true),
                    OriginId = table.Column<long>(nullable: true),
                    NationalityId = table.Column<long>(nullable: true),
                    VisitingMotives = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomsForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomsForms_BoatTrips_BoatTripId",
                        column: x => x.BoatTripId,
                        principalTable: "BoatTrips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomsForms_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomsForms_Places_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomsForms_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomsForms_Places_GuestCountryPlaceId",
                        column: x => x.GuestCountryPlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomsForms_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomsForms_Places_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PassportNumbers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    PassportNr = table.Column<string>(nullable: true),
                    CitizenId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassportNumbers_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomsRequests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    LastChanged = table.Column<DateTimeOffset>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CustomsFormId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomsRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomsRequests_CustomsForms_CustomsFormId",
                        column: x => x.CustomsFormId,
                        principalTable: "CustomsForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BoatTrips_DepartureId",
                table: "BoatTrips",
                column: "DepartureId");

            migrationBuilder.CreateIndex(
                name: "IX_BoatTrips_DestinationId",
                table: "BoatTrips",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_BirthPlaceId",
                table: "Citizens",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_CurrentResidenceId",
                table: "Citizens",
                column: "CurrentResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsForms_BoatTripId",
                table: "CustomsForms",
                column: "BoatTripId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsForms_CitizenId",
                table: "CustomsForms",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsForms_DestinationId",
                table: "CustomsForms",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsForms_FlightId",
                table: "CustomsForms",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsForms_GuestCountryPlaceId",
                table: "CustomsForms",
                column: "GuestCountryPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsForms_NationalityId",
                table: "CustomsForms",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsForms_OriginId",
                table: "CustomsForms",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomsRequests_CustomsFormId",
                table: "CustomsRequests",
                column: "CustomsFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_CountryId",
                table: "Nationalities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PassportNumbers_CitizenId",
                table: "PassportNumbers",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Places_AddressId",
                table: "Places",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomsRequests");

            migrationBuilder.DropTable(
                name: "PassportNumbers");

            migrationBuilder.DropTable(
                name: "CustomsForms");

            migrationBuilder.DropTable(
                name: "BoatTrips");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
