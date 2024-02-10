using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hoteluri.Migrations
{
    /// <inheritdoc />
    public partial class Rezervari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervare",
                columns: table => new
                {
                    RezervareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CameraId = table.Column<int>(type: "int", nullable: false),
                    DataCheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCheckOut = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervare", x => x.RezervareId);
                    table.ForeignKey(
                        name: "FK_Rezervare_Camera_CameraId",
                        column: x => x.CameraId,
                        principalTable: "Camera",
                        principalColumn: "CameraId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Rezervare_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Rezervare_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_CameraId",
                table: "Rezervare",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_ClientId",
                table: "Rezervare",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_HotelId",
                table: "Rezervare",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervare");
        }
    }
}
