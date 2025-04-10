using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactNativeApi.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjeSorumlusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DgtParcaKodu = table.Column<int>(type: "int", nullable: false),
                    SorumluKisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UretimAdeti = table.Column<int>(type: "int", nullable: false),
                    SureGun = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DosyaYukle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kaydet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaAcilmaSaatTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableOnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableThrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableThrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableTwos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeknisyenAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DgtParcaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnaylayanProjeYoneticisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeklemedeAdet = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AciklamaListesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableThreeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTwos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TableTwos_TableThrees_TableThreeId",
                        column: x => x.TableThreeId,
                        principalTable: "TableThrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TableTwos_TableThreeId",
                table: "TableTwos",
                column: "TableThreeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableOnes");

            migrationBuilder.DropTable(
                name: "TableTwos");

            migrationBuilder.DropTable(
                name: "TableThrees");
        }
    }
}
