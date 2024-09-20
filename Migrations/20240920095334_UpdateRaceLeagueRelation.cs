using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetCyclingFriends.Migrations
{
    public partial class UpdateRaceLeagueRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HashedPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    RaceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RealWinner = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeagueUsers",
                columns: table => new
                {
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    PointsInLeague = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueUsers", x => new { x.LeagueId, x.UserId });
                    table.ForeignKey(
                        name: "FK_LeagueUsers_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeagueUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FavoriRider = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    BonusRider = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PointsGained = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bets_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[] { 1, "League 1", "123456" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[] { 2, "League 2", "654321" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "HashedPassword", "Username" },
                values: new object[] { 1, "hashed_password_1", "john_doe" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "HashedPassword", "Username" },
                values: new object[] { 2, "hashed_password_2", "jane_smith" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "HashedPassword", "Username" },
                values: new object[] { 3, "hashed_password_3", "alice_jones" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "HashedPassword", "Username" },
                values: new object[] { 4, "hashed_password_4", "bob_brown" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "HashedPassword", "Username" },
                values: new object[] { 5, "hashed_password_5", "charlie_black" });

            migrationBuilder.InsertData(
                table: "LeagueUsers",
                columns: new[] { "LeagueId", "UserId", "PointsInLeague" },
                values: new object[] { 1, 1, 100 });

            migrationBuilder.InsertData(
                table: "LeagueUsers",
                columns: new[] { "LeagueId", "UserId", "PointsInLeague" },
                values: new object[] { 1, 2, 200 });

            migrationBuilder.InsertData(
                table: "LeagueUsers",
                columns: new[] { "LeagueId", "UserId", "PointsInLeague" },
                values: new object[] { 2, 1, 300 });

            migrationBuilder.InsertData(
                table: "LeagueUsers",
                columns: new[] { "LeagueId", "UserId", "PointsInLeague" },
                values: new object[] { 2, 2, 400 });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 1, 1, "Stage 1 - Nice", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tadej Pogacar" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 2, 1, "Stage 2 - Marseille", new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primoz Roglic" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 3, 1, "Stage 3 - Lyon", new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egan Bernal" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 4, 1, "Stage 4 - Paris", new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris Froome" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 5, 2, "Stage 1 - Rome", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vincenzo Nibali" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 6, 2, "Stage 2 - Florence", new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fabio Aru" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 7, 2, "Stage 3 - Milan", new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberto Contador" });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "LeagueId", "Name", "RaceDate", "RealWinner" },
                values: new object[] { 8, 2, "Stage 4 - Venice", new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nairo Quintana" });

            migrationBuilder.InsertData(
                table: "Bets",
                columns: new[] { "Id", "BonusRider", "FavoriRider", "PointsGained", "RaceId", "UserId" },
                values: new object[] { 1, "Primoz Roglic", "Tadej Pogacar", 100, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Bets_RaceId",
                table: "Bets",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_UserId",
                table: "Bets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_Password",
                table: "Leagues",
                column: "Password",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeagueUsers_UserId",
                table: "LeagueUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_LeagueId",
                table: "Races",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "LeagueUsers");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Leagues");
        }
    }
}
