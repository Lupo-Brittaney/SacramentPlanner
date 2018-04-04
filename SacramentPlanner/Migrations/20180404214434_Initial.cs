using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SacramentPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClosePrayer = table.Column<string>(nullable: true),
                    CloseSong = table.Column<string>(nullable: true),
                    CloseSongNum = table.Column<int>(nullable: false),
                    Conduct = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    OpenPrayer = table.Column<string>(nullable: true),
                    OpenSong = table.Column<string>(nullable: true),
                    OpenSongNum = table.Column<int>(nullable: false),
                    SacSong = table.Column<string>(nullable: true),
                    SacSongNum = table.Column<int>(nullable: false),
                    SecondSpeaker = table.Column<string>(nullable: true),
                    SecondTopic = table.Column<string>(nullable: true),
                    ThirdSpeaker = table.Column<string>(nullable: true),
                    ThirdTopic = table.Column<string>(nullable: true),
                    YouthSpeaker = table.Column<string>(nullable: true),
                    YouthTopic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
