using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Patililer.Migrations
{
    /// <inheritdoc />
    public partial class bir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresAcik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hakkimizdas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizdas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ilanlars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilanlars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Iletisims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Konu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "rolees",
                columns: table => new
                {
                    RoleeID = table.Column<byte>(type: "tinyint", nullable: false),
                    RoleeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolees", x => x.RoleeID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanlarID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yorumlars_Ilanlars_IlanlarID",
                        column: x => x.IlanlarID,
                        principalTable: "Ilanlars",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "userrs",
                columns: table => new
                {
                    UserrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emaill = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Passwordd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleeID = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userrs", x => x.UserrID);
                    table.ForeignKey(
                        name: "FK_userrs_rolees_RoleeID",
                        column: x => x.RoleeID,
                        principalTable: "rolees",
                        principalColumn: "RoleeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hakkimizdas",
                columns: new[] { "ID", "Aciklama", "FotoUrl" },
                values: new object[] { 1, "Ücretsiz evcil hayvan sahiplendirme ilanlarına göz atabilir, bir canlı sahiplenebilirsin.Aradığın canlıyı bulamadıysan, arıyorum ilanı bırakabilirsin.Pet için eş arıyorsan, eş arıyorum ilanı ekleyebilirsin. Dikkat :Kimseye ödeme yapmayın,dolandırılma riski var! Bu site satış sitesi değildir.Size yakın şehirlerden elden satın almaya özen gösterin.", "dsds" });

            migrationBuilder.InsertData(
                table: "Ilanlars",
                columns: new[] { "ID", "Aciklama", "Baslik", "Cinsiyet", "IlanImage", "Tarih", "Yas" },
                values: new object[,]
                {
                    { 1, "1.hayvan", "köpek", "erkek", "kdsk", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "2.hayvan", "kedi", "erkek", "kdsk", new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "3.hayvan", "kedi", "dişi", "kdsk", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "4.hayvan", "köpek", "dişi", "kdsk", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Iletisims",
                columns: new[] { "ID", "AdSoyad", "Konu", "Mail", "Mesaj" },
                values: new object[] { 1, "xcx", "fdf", "dfd", "fdf" });

            migrationBuilder.InsertData(
                table: "rolees",
                columns: new[] { "RoleeID", "RoleeName" },
                values: new object[,]
                {
                    { (byte)1, "Aday" },
                    { (byte)2, "Uye" },
                    { (byte)3, "Admin" },
                    { (byte)4, "Supervisor" }
                });

            migrationBuilder.InsertData(
                table: "userrs",
                columns: new[] { "UserrID", "Emaill", "Passwordd", "RoleeID" },
                values: new object[,]
                {
                    { 1, "aday@hotmail.com", "123456", (byte)1 },
                    { 2, "uye@hotmail.com", "123456", (byte)2 },
                    { 3, "admin@hotmail.com", "123456", (byte)3 },
                    { 4, "supervisor@hotmail.com", "123456", (byte)4 },
                    { 5, "uye2@hotmail.com", "123456", (byte)2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_userrs_RoleeID",
                table: "userrs",
                column: "RoleeID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_IlanlarID",
                table: "Yorumlars",
                column: "IlanlarID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropTable(
                name: "Hakkimizdas");

            migrationBuilder.DropTable(
                name: "Iletisims");

            migrationBuilder.DropTable(
                name: "userrs");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "rolees");

            migrationBuilder.DropTable(
                name: "Ilanlars");
        }
    }
}
