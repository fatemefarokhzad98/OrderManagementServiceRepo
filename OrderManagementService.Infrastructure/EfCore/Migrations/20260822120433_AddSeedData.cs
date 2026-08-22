using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderManagementService.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "PhoneNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 8, 1, 0, 0, DateTimeKind.Utc), "Customer01", "Test01", "09120000001", null },
                    { 2L, new DateTime(2026, 1, 1, 8, 2, 0, 0, DateTimeKind.Utc), "Customer02", "Test02", "09120000002", null },
                    { 3L, new DateTime(2026, 1, 1, 8, 3, 0, 0, DateTimeKind.Utc), "Customer03", "Test03", "09120000003", null },
                    { 4L, new DateTime(2026, 1, 1, 8, 4, 0, 0, DateTimeKind.Utc), "Customer04", "Test04", "09120000004", null },
                    { 5L, new DateTime(2026, 1, 1, 8, 5, 0, 0, DateTimeKind.Utc), "Customer05", "Test05", "09120000005", null },
                    { 6L, new DateTime(2026, 1, 1, 8, 6, 0, 0, DateTimeKind.Utc), "Customer06", "Test06", "09120000006", null },
                    { 7L, new DateTime(2026, 1, 1, 8, 7, 0, 0, DateTimeKind.Utc), "Customer07", "Test07", "09120000007", null },
                    { 8L, new DateTime(2026, 1, 1, 8, 8, 0, 0, DateTimeKind.Utc), "Customer08", "Test08", "09120000008", null },
                    { 9L, new DateTime(2026, 1, 1, 8, 9, 0, 0, DateTimeKind.Utc), "Customer09", "Test09", "09120000009", null },
                    { 10L, new DateTime(2026, 1, 1, 8, 10, 0, 0, DateTimeKind.Utc), "Customer10", "Test10", "09120000010", null },
                    { 11L, new DateTime(2026, 1, 1, 8, 11, 0, 0, DateTimeKind.Utc), "Customer11", "Test11", "09120000011", null },
                    { 12L, new DateTime(2026, 1, 1, 8, 12, 0, 0, DateTimeKind.Utc), "Customer12", "Test12", "09120000012", null },
                    { 13L, new DateTime(2026, 1, 1, 8, 13, 0, 0, DateTimeKind.Utc), "Customer13", "Test13", "09120000013", null },
                    { 14L, new DateTime(2026, 1, 1, 8, 14, 0, 0, DateTimeKind.Utc), "Customer14", "Test14", "09120000014", null },
                    { 15L, new DateTime(2026, 1, 1, 8, 15, 0, 0, DateTimeKind.Utc), "Customer15", "Test15", "09120000015", null },
                    { 16L, new DateTime(2026, 1, 1, 8, 16, 0, 0, DateTimeKind.Utc), "Customer16", "Test16", "09120000016", null },
                    { 17L, new DateTime(2026, 1, 1, 8, 17, 0, 0, DateTimeKind.Utc), "Customer17", "Test17", "09120000017", null },
                    { 18L, new DateTime(2026, 1, 1, 8, 18, 0, 0, DateTimeKind.Utc), "Customer18", "Test18", "09120000018", null },
                    { 19L, new DateTime(2026, 1, 1, 8, 19, 0, 0, DateTimeKind.Utc), "Customer19", "Test19", "09120000019", null },
                    { 20L, new DateTime(2026, 1, 1, 8, 20, 0, 0, DateTimeKind.Utc), "Customer20", "Test20", "09120000020", null },
                    { 21L, new DateTime(2026, 1, 1, 8, 21, 0, 0, DateTimeKind.Utc), "Customer21", "Test21", "09120000021", null },
                    { 22L, new DateTime(2026, 1, 1, 8, 22, 0, 0, DateTimeKind.Utc), "Customer22", "Test22", "09120000022", null },
                    { 23L, new DateTime(2026, 1, 1, 8, 23, 0, 0, DateTimeKind.Utc), "Customer23", "Test23", "09120000023", null },
                    { 24L, new DateTime(2026, 1, 1, 8, 24, 0, 0, DateTimeKind.Utc), "Customer24", "Test24", "09120000024", null },
                    { 25L, new DateTime(2026, 1, 1, 8, 25, 0, 0, DateTimeKind.Utc), "Customer25", "Test25", "09120000025", null },
                    { 26L, new DateTime(2026, 1, 1, 8, 26, 0, 0, DateTimeKind.Utc), "Customer26", "Test26", "09120000026", null },
                    { 27L, new DateTime(2026, 1, 1, 8, 27, 0, 0, DateTimeKind.Utc), "Customer27", "Test27", "09120000027", null },
                    { 28L, new DateTime(2026, 1, 1, 8, 28, 0, 0, DateTimeKind.Utc), "Customer28", "Test28", "09120000028", null },
                    { 29L, new DateTime(2026, 1, 1, 8, 29, 0, 0, DateTimeKind.Utc), "Customer29", "Test29", "09120000029", null },
                    { 30L, new DateTime(2026, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), "Customer30", "Test30", "09120000030", null },
                    { 31L, new DateTime(2026, 1, 1, 8, 31, 0, 0, DateTimeKind.Utc), "Customer31", "Test31", "09120000031", null },
                    { 32L, new DateTime(2026, 1, 1, 8, 32, 0, 0, DateTimeKind.Utc), "Customer32", "Test32", "09120000032", null },
                    { 33L, new DateTime(2026, 1, 1, 8, 33, 0, 0, DateTimeKind.Utc), "Customer33", "Test33", "09120000033", null },
                    { 34L, new DateTime(2026, 1, 1, 8, 34, 0, 0, DateTimeKind.Utc), "Customer34", "Test34", "09120000034", null },
                    { 35L, new DateTime(2026, 1, 1, 8, 35, 0, 0, DateTimeKind.Utc), "Customer35", "Test35", "09120000035", null },
                    { 36L, new DateTime(2026, 1, 1, 8, 36, 0, 0, DateTimeKind.Utc), "Customer36", "Test36", "09120000036", null },
                    { 37L, new DateTime(2026, 1, 1, 8, 37, 0, 0, DateTimeKind.Utc), "Customer37", "Test37", "09120000037", null },
                    { 38L, new DateTime(2026, 1, 1, 8, 38, 0, 0, DateTimeKind.Utc), "Customer38", "Test38", "09120000038", null },
                    { 39L, new DateTime(2026, 1, 1, 8, 39, 0, 0, DateTimeKind.Utc), "Customer39", "Test39", "09120000039", null },
                    { 40L, new DateTime(2026, 1, 1, 8, 40, 0, 0, DateTimeKind.Utc), "Customer40", "Test40", "09120000040", null },
                    { 41L, new DateTime(2026, 1, 1, 8, 41, 0, 0, DateTimeKind.Utc), "Customer41", "Test41", "09120000041", null },
                    { 42L, new DateTime(2026, 1, 1, 8, 42, 0, 0, DateTimeKind.Utc), "Customer42", "Test42", "09120000042", null },
                    { 43L, new DateTime(2026, 1, 1, 8, 43, 0, 0, DateTimeKind.Utc), "Customer43", "Test43", "09120000043", null },
                    { 44L, new DateTime(2026, 1, 1, 8, 44, 0, 0, DateTimeKind.Utc), "Customer44", "Test44", "09120000044", null },
                    { 45L, new DateTime(2026, 1, 1, 8, 45, 0, 0, DateTimeKind.Utc), "Customer45", "Test45", "09120000045", null },
                    { 46L, new DateTime(2026, 1, 1, 8, 46, 0, 0, DateTimeKind.Utc), "Customer46", "Test46", "09120000046", null },
                    { 47L, new DateTime(2026, 1, 1, 8, 47, 0, 0, DateTimeKind.Utc), "Customer47", "Test47", "09120000047", null },
                    { 48L, new DateTime(2026, 1, 1, 8, 48, 0, 0, DateTimeKind.Utc), "Customer48", "Test48", "09120000048", null },
                    { 49L, new DateTime(2026, 1, 1, 8, 49, 0, 0, DateTimeKind.Utc), "Customer49", "Test49", "09120000049", null },
                    { 50L, new DateTime(2026, 1, 1, 8, 50, 0, 0, DateTimeKind.Utc), "Customer50", "Test50", "09120000050", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 8, 1, 0, 0, DateTimeKind.Utc), "Seeded product number 001", true, "Product 001", 125000m, null },
                    { 2L, new DateTime(2026, 1, 1, 8, 2, 0, 0, DateTimeKind.Utc), "Seeded product number 002", true, "Product 002", 150000m, null },
                    { 3L, new DateTime(2026, 1, 1, 8, 3, 0, 0, DateTimeKind.Utc), "Seeded product number 003", true, "Product 003", 175000m, null },
                    { 4L, new DateTime(2026, 1, 1, 8, 4, 0, 0, DateTimeKind.Utc), "Seeded product number 004", true, "Product 004", 200000m, null },
                    { 5L, new DateTime(2026, 1, 1, 8, 5, 0, 0, DateTimeKind.Utc), "Seeded product number 005", true, "Product 005", 225000m, null },
                    { 6L, new DateTime(2026, 1, 1, 8, 6, 0, 0, DateTimeKind.Utc), "Seeded product number 006", true, "Product 006", 250000m, null },
                    { 7L, new DateTime(2026, 1, 1, 8, 7, 0, 0, DateTimeKind.Utc), "Seeded product number 007", true, "Product 007", 275000m, null },
                    { 8L, new DateTime(2026, 1, 1, 8, 8, 0, 0, DateTimeKind.Utc), "Seeded product number 008", true, "Product 008", 300000m, null },
                    { 9L, new DateTime(2026, 1, 1, 8, 9, 0, 0, DateTimeKind.Utc), "Seeded product number 009", true, "Product 009", 325000m, null },
                    { 10L, new DateTime(2026, 1, 1, 8, 10, 0, 0, DateTimeKind.Utc), "Seeded product number 010", true, "Product 010", 350000m, null },
                    { 11L, new DateTime(2026, 1, 1, 8, 11, 0, 0, DateTimeKind.Utc), "Seeded product number 011", true, "Product 011", 375000m, null },
                    { 12L, new DateTime(2026, 1, 1, 8, 12, 0, 0, DateTimeKind.Utc), "Seeded product number 012", true, "Product 012", 400000m, null },
                    { 13L, new DateTime(2026, 1, 1, 8, 13, 0, 0, DateTimeKind.Utc), "Seeded product number 013", true, "Product 013", 425000m, null },
                    { 14L, new DateTime(2026, 1, 1, 8, 14, 0, 0, DateTimeKind.Utc), "Seeded product number 014", true, "Product 014", 450000m, null },
                    { 15L, new DateTime(2026, 1, 1, 8, 15, 0, 0, DateTimeKind.Utc), "Seeded product number 015", true, "Product 015", 475000m, null },
                    { 16L, new DateTime(2026, 1, 1, 8, 16, 0, 0, DateTimeKind.Utc), "Seeded product number 016", true, "Product 016", 500000m, null },
                    { 17L, new DateTime(2026, 1, 1, 8, 17, 0, 0, DateTimeKind.Utc), "Seeded product number 017", true, "Product 017", 525000m, null },
                    { 18L, new DateTime(2026, 1, 1, 8, 18, 0, 0, DateTimeKind.Utc), "Seeded product number 018", true, "Product 018", 550000m, null },
                    { 19L, new DateTime(2026, 1, 1, 8, 19, 0, 0, DateTimeKind.Utc), "Seeded product number 019", true, "Product 019", 575000m, null },
                    { 20L, new DateTime(2026, 1, 1, 8, 20, 0, 0, DateTimeKind.Utc), "Seeded product number 020", true, "Product 020", 600000m, null },
                    { 21L, new DateTime(2026, 1, 1, 8, 21, 0, 0, DateTimeKind.Utc), "Seeded product number 021", true, "Product 021", 625000m, null },
                    { 22L, new DateTime(2026, 1, 1, 8, 22, 0, 0, DateTimeKind.Utc), "Seeded product number 022", true, "Product 022", 650000m, null },
                    { 23L, new DateTime(2026, 1, 1, 8, 23, 0, 0, DateTimeKind.Utc), "Seeded product number 023", true, "Product 023", 675000m, null },
                    { 24L, new DateTime(2026, 1, 1, 8, 24, 0, 0, DateTimeKind.Utc), "Seeded product number 024", true, "Product 024", 700000m, null },
                    { 25L, new DateTime(2026, 1, 1, 8, 25, 0, 0, DateTimeKind.Utc), "Seeded product number 025", true, "Product 025", 725000m, null },
                    { 26L, new DateTime(2026, 1, 1, 8, 26, 0, 0, DateTimeKind.Utc), "Seeded product number 026", true, "Product 026", 750000m, null },
                    { 27L, new DateTime(2026, 1, 1, 8, 27, 0, 0, DateTimeKind.Utc), "Seeded product number 027", true, "Product 027", 775000m, null },
                    { 28L, new DateTime(2026, 1, 1, 8, 28, 0, 0, DateTimeKind.Utc), "Seeded product number 028", true, "Product 028", 800000m, null },
                    { 29L, new DateTime(2026, 1, 1, 8, 29, 0, 0, DateTimeKind.Utc), "Seeded product number 029", true, "Product 029", 825000m, null },
                    { 30L, new DateTime(2026, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), "Seeded product number 030", true, "Product 030", 850000m, null },
                    { 31L, new DateTime(2026, 1, 1, 8, 31, 0, 0, DateTimeKind.Utc), "Seeded product number 031", true, "Product 031", 875000m, null },
                    { 32L, new DateTime(2026, 1, 1, 8, 32, 0, 0, DateTimeKind.Utc), "Seeded product number 032", true, "Product 032", 900000m, null },
                    { 33L, new DateTime(2026, 1, 1, 8, 33, 0, 0, DateTimeKind.Utc), "Seeded product number 033", true, "Product 033", 925000m, null },
                    { 34L, new DateTime(2026, 1, 1, 8, 34, 0, 0, DateTimeKind.Utc), "Seeded product number 034", true, "Product 034", 950000m, null },
                    { 35L, new DateTime(2026, 1, 1, 8, 35, 0, 0, DateTimeKind.Utc), "Seeded product number 035", true, "Product 035", 975000m, null },
                    { 36L, new DateTime(2026, 1, 1, 8, 36, 0, 0, DateTimeKind.Utc), "Seeded product number 036", true, "Product 036", 1000000m, null },
                    { 37L, new DateTime(2026, 1, 1, 8, 37, 0, 0, DateTimeKind.Utc), "Seeded product number 037", true, "Product 037", 1025000m, null },
                    { 38L, new DateTime(2026, 1, 1, 8, 38, 0, 0, DateTimeKind.Utc), "Seeded product number 038", true, "Product 038", 1050000m, null },
                    { 39L, new DateTime(2026, 1, 1, 8, 39, 0, 0, DateTimeKind.Utc), "Seeded product number 039", true, "Product 039", 1075000m, null },
                    { 40L, new DateTime(2026, 1, 1, 8, 40, 0, 0, DateTimeKind.Utc), "Seeded product number 040", true, "Product 040", 1100000m, null },
                    { 41L, new DateTime(2026, 1, 1, 8, 41, 0, 0, DateTimeKind.Utc), "Seeded product number 041", true, "Product 041", 1125000m, null },
                    { 42L, new DateTime(2026, 1, 1, 8, 42, 0, 0, DateTimeKind.Utc), "Seeded product number 042", true, "Product 042", 1150000m, null },
                    { 43L, new DateTime(2026, 1, 1, 8, 43, 0, 0, DateTimeKind.Utc), "Seeded product number 043", true, "Product 043", 1175000m, null },
                    { 44L, new DateTime(2026, 1, 1, 8, 44, 0, 0, DateTimeKind.Utc), "Seeded product number 044", true, "Product 044", 1200000m, null },
                    { 45L, new DateTime(2026, 1, 1, 8, 45, 0, 0, DateTimeKind.Utc), "Seeded product number 045", true, "Product 045", 1225000m, null },
                    { 46L, new DateTime(2026, 1, 1, 8, 46, 0, 0, DateTimeKind.Utc), "Seeded product number 046", true, "Product 046", 1250000m, null },
                    { 47L, new DateTime(2026, 1, 1, 8, 47, 0, 0, DateTimeKind.Utc), "Seeded product number 047", true, "Product 047", 1275000m, null },
                    { 48L, new DateTime(2026, 1, 1, 8, 48, 0, 0, DateTimeKind.Utc), "Seeded product number 048", true, "Product 048", 1300000m, null },
                    { 49L, new DateTime(2026, 1, 1, 8, 49, 0, 0, DateTimeKind.Utc), "Seeded product number 049", true, "Product 049", 1325000m, null },
                    { 50L, new DateTime(2026, 1, 1, 8, 50, 0, 0, DateTimeKind.Utc), "Seeded product number 050", true, "Product 050", 1350000m, null },
                    { 51L, new DateTime(2026, 1, 1, 8, 51, 0, 0, DateTimeKind.Utc), "Seeded product number 051", true, "Product 051", 1375000m, null },
                    { 52L, new DateTime(2026, 1, 1, 8, 52, 0, 0, DateTimeKind.Utc), "Seeded product number 052", true, "Product 052", 1400000m, null },
                    { 53L, new DateTime(2026, 1, 1, 8, 53, 0, 0, DateTimeKind.Utc), "Seeded product number 053", true, "Product 053", 1425000m, null },
                    { 54L, new DateTime(2026, 1, 1, 8, 54, 0, 0, DateTimeKind.Utc), "Seeded product number 054", true, "Product 054", 1450000m, null },
                    { 55L, new DateTime(2026, 1, 1, 8, 55, 0, 0, DateTimeKind.Utc), "Seeded product number 055", true, "Product 055", 1475000m, null },
                    { 56L, new DateTime(2026, 1, 1, 8, 56, 0, 0, DateTimeKind.Utc), "Seeded product number 056", true, "Product 056", 1500000m, null },
                    { 57L, new DateTime(2026, 1, 1, 8, 57, 0, 0, DateTimeKind.Utc), "Seeded product number 057", true, "Product 057", 1525000m, null },
                    { 58L, new DateTime(2026, 1, 1, 8, 58, 0, 0, DateTimeKind.Utc), "Seeded product number 058", true, "Product 058", 1550000m, null },
                    { 59L, new DateTime(2026, 1, 1, 8, 59, 0, 0, DateTimeKind.Utc), "Seeded product number 059", true, "Product 059", 1575000m, null },
                    { 60L, new DateTime(2026, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), "Seeded product number 060", true, "Product 060", 1600000m, null },
                    { 61L, new DateTime(2026, 1, 1, 9, 1, 0, 0, DateTimeKind.Utc), "Seeded product number 061", true, "Product 061", 1625000m, null },
                    { 62L, new DateTime(2026, 1, 1, 9, 2, 0, 0, DateTimeKind.Utc), "Seeded product number 062", true, "Product 062", 1650000m, null },
                    { 63L, new DateTime(2026, 1, 1, 9, 3, 0, 0, DateTimeKind.Utc), "Seeded product number 063", true, "Product 063", 1675000m, null },
                    { 64L, new DateTime(2026, 1, 1, 9, 4, 0, 0, DateTimeKind.Utc), "Seeded product number 064", true, "Product 064", 1700000m, null },
                    { 65L, new DateTime(2026, 1, 1, 9, 5, 0, 0, DateTimeKind.Utc), "Seeded product number 065", true, "Product 065", 1725000m, null },
                    { 66L, new DateTime(2026, 1, 1, 9, 6, 0, 0, DateTimeKind.Utc), "Seeded product number 066", true, "Product 066", 1750000m, null },
                    { 67L, new DateTime(2026, 1, 1, 9, 7, 0, 0, DateTimeKind.Utc), "Seeded product number 067", true, "Product 067", 1775000m, null },
                    { 68L, new DateTime(2026, 1, 1, 9, 8, 0, 0, DateTimeKind.Utc), "Seeded product number 068", true, "Product 068", 1800000m, null },
                    { 69L, new DateTime(2026, 1, 1, 9, 9, 0, 0, DateTimeKind.Utc), "Seeded product number 069", true, "Product 069", 1825000m, null },
                    { 70L, new DateTime(2026, 1, 1, 9, 10, 0, 0, DateTimeKind.Utc), "Seeded product number 070", true, "Product 070", 1850000m, null },
                    { 71L, new DateTime(2026, 1, 1, 9, 11, 0, 0, DateTimeKind.Utc), "Seeded product number 071", true, "Product 071", 1875000m, null },
                    { 72L, new DateTime(2026, 1, 1, 9, 12, 0, 0, DateTimeKind.Utc), "Seeded product number 072", true, "Product 072", 1900000m, null },
                    { 73L, new DateTime(2026, 1, 1, 9, 13, 0, 0, DateTimeKind.Utc), "Seeded product number 073", true, "Product 073", 1925000m, null },
                    { 74L, new DateTime(2026, 1, 1, 9, 14, 0, 0, DateTimeKind.Utc), "Seeded product number 074", true, "Product 074", 1950000m, null },
                    { 75L, new DateTime(2026, 1, 1, 9, 15, 0, 0, DateTimeKind.Utc), "Seeded product number 075", true, "Product 075", 1975000m, null },
                    { 76L, new DateTime(2026, 1, 1, 9, 16, 0, 0, DateTimeKind.Utc), "Seeded product number 076", true, "Product 076", 2000000m, null },
                    { 77L, new DateTime(2026, 1, 1, 9, 17, 0, 0, DateTimeKind.Utc), "Seeded product number 077", true, "Product 077", 2025000m, null },
                    { 78L, new DateTime(2026, 1, 1, 9, 18, 0, 0, DateTimeKind.Utc), "Seeded product number 078", true, "Product 078", 2050000m, null },
                    { 79L, new DateTime(2026, 1, 1, 9, 19, 0, 0, DateTimeKind.Utc), "Seeded product number 079", true, "Product 079", 2075000m, null },
                    { 80L, new DateTime(2026, 1, 1, 9, 20, 0, 0, DateTimeKind.Utc), "Seeded product number 080", true, "Product 080", 2100000m, null },
                    { 81L, new DateTime(2026, 1, 1, 9, 21, 0, 0, DateTimeKind.Utc), "Seeded product number 081", true, "Product 081", 2125000m, null },
                    { 82L, new DateTime(2026, 1, 1, 9, 22, 0, 0, DateTimeKind.Utc), "Seeded product number 082", true, "Product 082", 2150000m, null },
                    { 83L, new DateTime(2026, 1, 1, 9, 23, 0, 0, DateTimeKind.Utc), "Seeded product number 083", true, "Product 083", 2175000m, null },
                    { 84L, new DateTime(2026, 1, 1, 9, 24, 0, 0, DateTimeKind.Utc), "Seeded product number 084", true, "Product 084", 2200000m, null },
                    { 85L, new DateTime(2026, 1, 1, 9, 25, 0, 0, DateTimeKind.Utc), "Seeded product number 085", true, "Product 085", 2225000m, null },
                    { 86L, new DateTime(2026, 1, 1, 9, 26, 0, 0, DateTimeKind.Utc), "Seeded product number 086", true, "Product 086", 2250000m, null },
                    { 87L, new DateTime(2026, 1, 1, 9, 27, 0, 0, DateTimeKind.Utc), "Seeded product number 087", true, "Product 087", 2275000m, null },
                    { 88L, new DateTime(2026, 1, 1, 9, 28, 0, 0, DateTimeKind.Utc), "Seeded product number 088", true, "Product 088", 2300000m, null },
                    { 89L, new DateTime(2026, 1, 1, 9, 29, 0, 0, DateTimeKind.Utc), "Seeded product number 089", true, "Product 089", 2325000m, null },
                    { 90L, new DateTime(2026, 1, 1, 9, 30, 0, 0, DateTimeKind.Utc), "Seeded product number 090", true, "Product 090", 2350000m, null },
                    { 91L, new DateTime(2026, 1, 1, 9, 31, 0, 0, DateTimeKind.Utc), "Seeded product number 091", true, "Product 091", 2375000m, null },
                    { 92L, new DateTime(2026, 1, 1, 9, 32, 0, 0, DateTimeKind.Utc), "Seeded product number 092", true, "Product 092", 2400000m, null },
                    { 93L, new DateTime(2026, 1, 1, 9, 33, 0, 0, DateTimeKind.Utc), "Seeded product number 093", true, "Product 093", 2425000m, null },
                    { 94L, new DateTime(2026, 1, 1, 9, 34, 0, 0, DateTimeKind.Utc), "Seeded product number 094", true, "Product 094", 2450000m, null },
                    { 95L, new DateTime(2026, 1, 1, 9, 35, 0, 0, DateTimeKind.Utc), "Seeded product number 095", true, "Product 095", 2475000m, null },
                    { 96L, new DateTime(2026, 1, 1, 9, 36, 0, 0, DateTimeKind.Utc), "Seeded product number 096", true, "Product 096", 2500000m, null },
                    { 97L, new DateTime(2026, 1, 1, 9, 37, 0, 0, DateTimeKind.Utc), "Seeded product number 097", true, "Product 097", 2525000m, null },
                    { 98L, new DateTime(2026, 1, 1, 9, 38, 0, 0, DateTimeKind.Utc), "Seeded product number 098", true, "Product 098", 2550000m, null },
                    { 99L, new DateTime(2026, 1, 1, 9, 39, 0, 0, DateTimeKind.Utc), "Seeded product number 099", true, "Product 099", 2575000m, null },
                    { 100L, new DateTime(2026, 1, 1, 9, 40, 0, 0, DateTimeKind.Utc), "Seeded product number 100", true, "Product 100", 2600000m, null },
                    { 101L, new DateTime(2026, 1, 1, 9, 41, 0, 0, DateTimeKind.Utc), "Seeded product number 101", true, "Product 101", 2625000m, null },
                    { 102L, new DateTime(2026, 1, 1, 9, 42, 0, 0, DateTimeKind.Utc), "Seeded product number 102", true, "Product 102", 2650000m, null },
                    { 103L, new DateTime(2026, 1, 1, 9, 43, 0, 0, DateTimeKind.Utc), "Seeded product number 103", true, "Product 103", 2675000m, null },
                    { 104L, new DateTime(2026, 1, 1, 9, 44, 0, 0, DateTimeKind.Utc), "Seeded product number 104", true, "Product 104", 2700000m, null },
                    { 105L, new DateTime(2026, 1, 1, 9, 45, 0, 0, DateTimeKind.Utc), "Seeded product number 105", true, "Product 105", 2725000m, null },
                    { 106L, new DateTime(2026, 1, 1, 9, 46, 0, 0, DateTimeKind.Utc), "Seeded product number 106", true, "Product 106", 2750000m, null },
                    { 107L, new DateTime(2026, 1, 1, 9, 47, 0, 0, DateTimeKind.Utc), "Seeded product number 107", true, "Product 107", 2775000m, null },
                    { 108L, new DateTime(2026, 1, 1, 9, 48, 0, 0, DateTimeKind.Utc), "Seeded product number 108", true, "Product 108", 2800000m, null },
                    { 109L, new DateTime(2026, 1, 1, 9, 49, 0, 0, DateTimeKind.Utc), "Seeded product number 109", true, "Product 109", 2825000m, null },
                    { 110L, new DateTime(2026, 1, 1, 9, 50, 0, 0, DateTimeKind.Utc), "Seeded product number 110", true, "Product 110", 2850000m, null },
                    { 111L, new DateTime(2026, 1, 1, 9, 51, 0, 0, DateTimeKind.Utc), "Seeded product number 111", true, "Product 111", 2875000m, null },
                    { 112L, new DateTime(2026, 1, 1, 9, 52, 0, 0, DateTimeKind.Utc), "Seeded product number 112", true, "Product 112", 2900000m, null },
                    { 113L, new DateTime(2026, 1, 1, 9, 53, 0, 0, DateTimeKind.Utc), "Seeded product number 113", true, "Product 113", 2925000m, null },
                    { 114L, new DateTime(2026, 1, 1, 9, 54, 0, 0, DateTimeKind.Utc), "Seeded product number 114", true, "Product 114", 2950000m, null },
                    { 115L, new DateTime(2026, 1, 1, 9, 55, 0, 0, DateTimeKind.Utc), "Seeded product number 115", true, "Product 115", 2975000m, null },
                    { 116L, new DateTime(2026, 1, 1, 9, 56, 0, 0, DateTimeKind.Utc), "Seeded product number 116", true, "Product 116", 3000000m, null },
                    { 117L, new DateTime(2026, 1, 1, 9, 57, 0, 0, DateTimeKind.Utc), "Seeded product number 117", true, "Product 117", 3025000m, null },
                    { 118L, new DateTime(2026, 1, 1, 9, 58, 0, 0, DateTimeKind.Utc), "Seeded product number 118", true, "Product 118", 3050000m, null },
                    { 119L, new DateTime(2026, 1, 1, 9, 59, 0, 0, DateTimeKind.Utc), "Seeded product number 119", true, "Product 119", 3075000m, null },
                    { 120L, new DateTime(2026, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc), "Seeded product number 120", true, "Product 120", 3100000m, null },
                    { 121L, new DateTime(2026, 1, 1, 10, 1, 0, 0, DateTimeKind.Utc), "Seeded product number 121", true, "Product 121", 3125000m, null },
                    { 122L, new DateTime(2026, 1, 1, 10, 2, 0, 0, DateTimeKind.Utc), "Seeded product number 122", true, "Product 122", 3150000m, null },
                    { 123L, new DateTime(2026, 1, 1, 10, 3, 0, 0, DateTimeKind.Utc), "Seeded product number 123", true, "Product 123", 3175000m, null },
                    { 124L, new DateTime(2026, 1, 1, 10, 4, 0, 0, DateTimeKind.Utc), "Seeded product number 124", true, "Product 124", 3200000m, null },
                    { 125L, new DateTime(2026, 1, 1, 10, 5, 0, 0, DateTimeKind.Utc), "Seeded product number 125", true, "Product 125", 3225000m, null },
                    { 126L, new DateTime(2026, 1, 1, 10, 6, 0, 0, DateTimeKind.Utc), "Seeded product number 126", true, "Product 126", 3250000m, null },
                    { 127L, new DateTime(2026, 1, 1, 10, 7, 0, 0, DateTimeKind.Utc), "Seeded product number 127", true, "Product 127", 3275000m, null },
                    { 128L, new DateTime(2026, 1, 1, 10, 8, 0, 0, DateTimeKind.Utc), "Seeded product number 128", true, "Product 128", 3300000m, null },
                    { 129L, new DateTime(2026, 1, 1, 10, 9, 0, 0, DateTimeKind.Utc), "Seeded product number 129", true, "Product 129", 3325000m, null },
                    { 130L, new DateTime(2026, 1, 1, 10, 10, 0, 0, DateTimeKind.Utc), "Seeded product number 130", true, "Product 130", 3350000m, null },
                    { 131L, new DateTime(2026, 1, 1, 10, 11, 0, 0, DateTimeKind.Utc), "Seeded product number 131", true, "Product 131", 3375000m, null },
                    { 132L, new DateTime(2026, 1, 1, 10, 12, 0, 0, DateTimeKind.Utc), "Seeded product number 132", true, "Product 132", 3400000m, null },
                    { 133L, new DateTime(2026, 1, 1, 10, 13, 0, 0, DateTimeKind.Utc), "Seeded product number 133", true, "Product 133", 3425000m, null },
                    { 134L, new DateTime(2026, 1, 1, 10, 14, 0, 0, DateTimeKind.Utc), "Seeded product number 134", true, "Product 134", 3450000m, null },
                    { 135L, new DateTime(2026, 1, 1, 10, 15, 0, 0, DateTimeKind.Utc), "Seeded product number 135", true, "Product 135", 3475000m, null },
                    { 136L, new DateTime(2026, 1, 1, 10, 16, 0, 0, DateTimeKind.Utc), "Seeded product number 136", true, "Product 136", 3500000m, null },
                    { 137L, new DateTime(2026, 1, 1, 10, 17, 0, 0, DateTimeKind.Utc), "Seeded product number 137", true, "Product 137", 3525000m, null },
                    { 138L, new DateTime(2026, 1, 1, 10, 18, 0, 0, DateTimeKind.Utc), "Seeded product number 138", true, "Product 138", 3550000m, null },
                    { 139L, new DateTime(2026, 1, 1, 10, 19, 0, 0, DateTimeKind.Utc), "Seeded product number 139", true, "Product 139", 3575000m, null },
                    { 140L, new DateTime(2026, 1, 1, 10, 20, 0, 0, DateTimeKind.Utc), "Seeded product number 140", true, "Product 140", 3600000m, null },
                    { 141L, new DateTime(2026, 1, 1, 10, 21, 0, 0, DateTimeKind.Utc), "Seeded product number 141", true, "Product 141", 3625000m, null },
                    { 142L, new DateTime(2026, 1, 1, 10, 22, 0, 0, DateTimeKind.Utc), "Seeded product number 142", true, "Product 142", 3650000m, null },
                    { 143L, new DateTime(2026, 1, 1, 10, 23, 0, 0, DateTimeKind.Utc), "Seeded product number 143", true, "Product 143", 3675000m, null },
                    { 144L, new DateTime(2026, 1, 1, 10, 24, 0, 0, DateTimeKind.Utc), "Seeded product number 144", true, "Product 144", 3700000m, null },
                    { 145L, new DateTime(2026, 1, 1, 10, 25, 0, 0, DateTimeKind.Utc), "Seeded product number 145", true, "Product 145", 3725000m, null },
                    { 146L, new DateTime(2026, 1, 1, 10, 26, 0, 0, DateTimeKind.Utc), "Seeded product number 146", true, "Product 146", 3750000m, null },
                    { 147L, new DateTime(2026, 1, 1, 10, 27, 0, 0, DateTimeKind.Utc), "Seeded product number 147", true, "Product 147", 3775000m, null },
                    { 148L, new DateTime(2026, 1, 1, 10, 28, 0, 0, DateTimeKind.Utc), "Seeded product number 148", true, "Product 148", 3800000m, null },
                    { 149L, new DateTime(2026, 1, 1, 10, 29, 0, 0, DateTimeKind.Utc), "Seeded product number 149", true, "Product 149", 3825000m, null },
                    { 150L, new DateTime(2026, 1, 1, 10, 30, 0, 0, DateTimeKind.Utc), "Seeded product number 150", true, "Product 150", 3850000m, null },
                    { 151L, new DateTime(2026, 1, 1, 10, 31, 0, 0, DateTimeKind.Utc), "Seeded product number 151", true, "Product 151", 3875000m, null },
                    { 152L, new DateTime(2026, 1, 1, 10, 32, 0, 0, DateTimeKind.Utc), "Seeded product number 152", true, "Product 152", 3900000m, null },
                    { 153L, new DateTime(2026, 1, 1, 10, 33, 0, 0, DateTimeKind.Utc), "Seeded product number 153", true, "Product 153", 3925000m, null },
                    { 154L, new DateTime(2026, 1, 1, 10, 34, 0, 0, DateTimeKind.Utc), "Seeded product number 154", true, "Product 154", 3950000m, null },
                    { 155L, new DateTime(2026, 1, 1, 10, 35, 0, 0, DateTimeKind.Utc), "Seeded product number 155", true, "Product 155", 3975000m, null },
                    { 156L, new DateTime(2026, 1, 1, 10, 36, 0, 0, DateTimeKind.Utc), "Seeded product number 156", true, "Product 156", 4000000m, null },
                    { 157L, new DateTime(2026, 1, 1, 10, 37, 0, 0, DateTimeKind.Utc), "Seeded product number 157", true, "Product 157", 4025000m, null },
                    { 158L, new DateTime(2026, 1, 1, 10, 38, 0, 0, DateTimeKind.Utc), "Seeded product number 158", true, "Product 158", 4050000m, null },
                    { 159L, new DateTime(2026, 1, 1, 10, 39, 0, 0, DateTimeKind.Utc), "Seeded product number 159", true, "Product 159", 4075000m, null },
                    { 160L, new DateTime(2026, 1, 1, 10, 40, 0, 0, DateTimeKind.Utc), "Seeded product number 160", true, "Product 160", 4100000m, null },
                    { 161L, new DateTime(2026, 1, 1, 10, 41, 0, 0, DateTimeKind.Utc), "Seeded product number 161", true, "Product 161", 4125000m, null },
                    { 162L, new DateTime(2026, 1, 1, 10, 42, 0, 0, DateTimeKind.Utc), "Seeded product number 162", true, "Product 162", 4150000m, null },
                    { 163L, new DateTime(2026, 1, 1, 10, 43, 0, 0, DateTimeKind.Utc), "Seeded product number 163", true, "Product 163", 4175000m, null },
                    { 164L, new DateTime(2026, 1, 1, 10, 44, 0, 0, DateTimeKind.Utc), "Seeded product number 164", true, "Product 164", 4200000m, null },
                    { 165L, new DateTime(2026, 1, 1, 10, 45, 0, 0, DateTimeKind.Utc), "Seeded product number 165", true, "Product 165", 4225000m, null },
                    { 166L, new DateTime(2026, 1, 1, 10, 46, 0, 0, DateTimeKind.Utc), "Seeded product number 166", true, "Product 166", 4250000m, null },
                    { 167L, new DateTime(2026, 1, 1, 10, 47, 0, 0, DateTimeKind.Utc), "Seeded product number 167", true, "Product 167", 4275000m, null },
                    { 168L, new DateTime(2026, 1, 1, 10, 48, 0, 0, DateTimeKind.Utc), "Seeded product number 168", true, "Product 168", 4300000m, null },
                    { 169L, new DateTime(2026, 1, 1, 10, 49, 0, 0, DateTimeKind.Utc), "Seeded product number 169", true, "Product 169", 4325000m, null },
                    { 170L, new DateTime(2026, 1, 1, 10, 50, 0, 0, DateTimeKind.Utc), "Seeded product number 170", true, "Product 170", 4350000m, null },
                    { 171L, new DateTime(2026, 1, 1, 10, 51, 0, 0, DateTimeKind.Utc), "Seeded product number 171", true, "Product 171", 4375000m, null },
                    { 172L, new DateTime(2026, 1, 1, 10, 52, 0, 0, DateTimeKind.Utc), "Seeded product number 172", true, "Product 172", 4400000m, null },
                    { 173L, new DateTime(2026, 1, 1, 10, 53, 0, 0, DateTimeKind.Utc), "Seeded product number 173", true, "Product 173", 4425000m, null },
                    { 174L, new DateTime(2026, 1, 1, 10, 54, 0, 0, DateTimeKind.Utc), "Seeded product number 174", true, "Product 174", 4450000m, null },
                    { 175L, new DateTime(2026, 1, 1, 10, 55, 0, 0, DateTimeKind.Utc), "Seeded product number 175", true, "Product 175", 4475000m, null },
                    { 176L, new DateTime(2026, 1, 1, 10, 56, 0, 0, DateTimeKind.Utc), "Seeded product number 176", true, "Product 176", 4500000m, null },
                    { 177L, new DateTime(2026, 1, 1, 10, 57, 0, 0, DateTimeKind.Utc), "Seeded product number 177", true, "Product 177", 4525000m, null },
                    { 178L, new DateTime(2026, 1, 1, 10, 58, 0, 0, DateTimeKind.Utc), "Seeded product number 178", true, "Product 178", 4550000m, null },
                    { 179L, new DateTime(2026, 1, 1, 10, 59, 0, 0, DateTimeKind.Utc), "Seeded product number 179", true, "Product 179", 4575000m, null },
                    { 180L, new DateTime(2026, 1, 1, 11, 0, 0, 0, DateTimeKind.Utc), "Seeded product number 180", true, "Product 180", 4600000m, null },
                    { 181L, new DateTime(2026, 1, 1, 11, 1, 0, 0, DateTimeKind.Utc), "Seeded product number 181", true, "Product 181", 4625000m, null },
                    { 182L, new DateTime(2026, 1, 1, 11, 2, 0, 0, DateTimeKind.Utc), "Seeded product number 182", true, "Product 182", 4650000m, null },
                    { 183L, new DateTime(2026, 1, 1, 11, 3, 0, 0, DateTimeKind.Utc), "Seeded product number 183", true, "Product 183", 4675000m, null },
                    { 184L, new DateTime(2026, 1, 1, 11, 4, 0, 0, DateTimeKind.Utc), "Seeded product number 184", true, "Product 184", 4700000m, null },
                    { 185L, new DateTime(2026, 1, 1, 11, 5, 0, 0, DateTimeKind.Utc), "Seeded product number 185", true, "Product 185", 4725000m, null },
                    { 186L, new DateTime(2026, 1, 1, 11, 6, 0, 0, DateTimeKind.Utc), "Seeded product number 186", true, "Product 186", 4750000m, null },
                    { 187L, new DateTime(2026, 1, 1, 11, 7, 0, 0, DateTimeKind.Utc), "Seeded product number 187", true, "Product 187", 4775000m, null },
                    { 188L, new DateTime(2026, 1, 1, 11, 8, 0, 0, DateTimeKind.Utc), "Seeded product number 188", true, "Product 188", 4800000m, null },
                    { 189L, new DateTime(2026, 1, 1, 11, 9, 0, 0, DateTimeKind.Utc), "Seeded product number 189", true, "Product 189", 4825000m, null },
                    { 190L, new DateTime(2026, 1, 1, 11, 10, 0, 0, DateTimeKind.Utc), "Seeded product number 190", true, "Product 190", 4850000m, null },
                    { 191L, new DateTime(2026, 1, 1, 11, 11, 0, 0, DateTimeKind.Utc), "Seeded product number 191", true, "Product 191", 4875000m, null },
                    { 192L, new DateTime(2026, 1, 1, 11, 12, 0, 0, DateTimeKind.Utc), "Seeded product number 192", true, "Product 192", 4900000m, null },
                    { 193L, new DateTime(2026, 1, 1, 11, 13, 0, 0, DateTimeKind.Utc), "Seeded product number 193", true, "Product 193", 4925000m, null },
                    { 194L, new DateTime(2026, 1, 1, 11, 14, 0, 0, DateTimeKind.Utc), "Seeded product number 194", true, "Product 194", 4950000m, null },
                    { 195L, new DateTime(2026, 1, 1, 11, 15, 0, 0, DateTimeKind.Utc), "Seeded product number 195", true, "Product 195", 4975000m, null },
                    { 196L, new DateTime(2026, 1, 1, 11, 16, 0, 0, DateTimeKind.Utc), "Seeded product number 196", true, "Product 196", 5000000m, null },
                    { 197L, new DateTime(2026, 1, 1, 11, 17, 0, 0, DateTimeKind.Utc), "Seeded product number 197", true, "Product 197", 5025000m, null },
                    { 198L, new DateTime(2026, 1, 1, 11, 18, 0, 0, DateTimeKind.Utc), "Seeded product number 198", true, "Product 198", 5050000m, null },
                    { 199L, new DateTime(2026, 1, 1, 11, 19, 0, 0, DateTimeKind.Utc), "Seeded product number 199", true, "Product 199", 5075000m, null },
                    { 200L, new DateTime(2026, 1, 1, 11, 20, 0, 0, DateTimeKind.Utc), "Seeded product number 200", true, "Product 200", 5100000m, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1L, true, "Admin" },
                    { 2L, true, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "IsActive", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), true, "AQAAAAIAAYagAAAAEMNRuOXkXfvGqBVGIP8IO/rJ7a+14WbIWpedabZCj6IhcPFGsSbnRssT38ebMpVomA==", null, "admin" },
                    { 2L, new DateTime(2026, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), true, "AQAAAAIAAYagAAAAEPRd88RKLoyAe6Srmd6mjlwlY6RJfTbB1Kh5lpRPqbnjsos3L/xxeQVc3AY84rKZbQ==", null, "testuser" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedAt", "IsActive", "ProductId", "Quantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 1, 8, 1, 0, 0, DateTimeKind.Utc), true, 1L, 500, null },
                    { 2L, new DateTime(2026, 1, 1, 8, 2, 0, 0, DateTimeKind.Utc), true, 2L, 500, null },
                    { 3L, new DateTime(2026, 1, 1, 8, 3, 0, 0, DateTimeKind.Utc), true, 3L, 500, null },
                    { 4L, new DateTime(2026, 1, 1, 8, 4, 0, 0, DateTimeKind.Utc), true, 4L, 500, null },
                    { 5L, new DateTime(2026, 1, 1, 8, 5, 0, 0, DateTimeKind.Utc), true, 5L, 498, null },
                    { 6L, new DateTime(2026, 1, 1, 8, 6, 0, 0, DateTimeKind.Utc), true, 6L, 497, null },
                    { 7L, new DateTime(2026, 1, 1, 8, 7, 0, 0, DateTimeKind.Utc), true, 7L, 500, null },
                    { 8L, new DateTime(2026, 1, 1, 8, 8, 0, 0, DateTimeKind.Utc), true, 8L, 500, null },
                    { 9L, new DateTime(2026, 1, 1, 8, 9, 0, 0, DateTimeKind.Utc), true, 9L, 500, null },
                    { 10L, new DateTime(2026, 1, 1, 8, 10, 0, 0, DateTimeKind.Utc), true, 10L, 500, null },
                    { 11L, new DateTime(2026, 1, 1, 8, 11, 0, 0, DateTimeKind.Utc), true, 11L, 500, null },
                    { 12L, new DateTime(2026, 1, 1, 8, 12, 0, 0, DateTimeKind.Utc), true, 12L, 499, null },
                    { 13L, new DateTime(2026, 1, 1, 8, 13, 0, 0, DateTimeKind.Utc), true, 13L, 500, null },
                    { 14L, new DateTime(2026, 1, 1, 8, 14, 0, 0, DateTimeKind.Utc), true, 14L, 497, null },
                    { 15L, new DateTime(2026, 1, 1, 8, 15, 0, 0, DateTimeKind.Utc), true, 15L, 500, null },
                    { 16L, new DateTime(2026, 1, 1, 8, 16, 0, 0, DateTimeKind.Utc), true, 16L, 500, null },
                    { 17L, new DateTime(2026, 1, 1, 8, 17, 0, 0, DateTimeKind.Utc), true, 17L, 500, null },
                    { 18L, new DateTime(2026, 1, 1, 8, 18, 0, 0, DateTimeKind.Utc), true, 18L, 500, null },
                    { 19L, new DateTime(2026, 1, 1, 8, 19, 0, 0, DateTimeKind.Utc), true, 19L, 500, null },
                    { 20L, new DateTime(2026, 1, 1, 8, 20, 0, 0, DateTimeKind.Utc), true, 20L, 500, null },
                    { 21L, new DateTime(2026, 1, 1, 8, 21, 0, 0, DateTimeKind.Utc), true, 21L, 500, null },
                    { 22L, new DateTime(2026, 1, 1, 8, 22, 0, 0, DateTimeKind.Utc), true, 22L, 497, null },
                    { 23L, new DateTime(2026, 1, 1, 8, 23, 0, 0, DateTimeKind.Utc), true, 23L, 500, null },
                    { 24L, new DateTime(2026, 1, 1, 8, 24, 0, 0, DateTimeKind.Utc), true, 24L, 500, null },
                    { 25L, new DateTime(2026, 1, 1, 8, 25, 0, 0, DateTimeKind.Utc), true, 25L, 500, null },
                    { 26L, new DateTime(2026, 1, 1, 8, 26, 0, 0, DateTimeKind.Utc), true, 26L, 500, null },
                    { 27L, new DateTime(2026, 1, 1, 8, 27, 0, 0, DateTimeKind.Utc), true, 27L, 496, null },
                    { 28L, new DateTime(2026, 1, 1, 8, 28, 0, 0, DateTimeKind.Utc), true, 28L, 500, null },
                    { 29L, new DateTime(2026, 1, 1, 8, 29, 0, 0, DateTimeKind.Utc), true, 29L, 500, null },
                    { 30L, new DateTime(2026, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), true, 30L, 500, null },
                    { 31L, new DateTime(2026, 1, 1, 8, 31, 0, 0, DateTimeKind.Utc), true, 31L, 496, null },
                    { 32L, new DateTime(2026, 1, 1, 8, 32, 0, 0, DateTimeKind.Utc), true, 32L, 500, null },
                    { 33L, new DateTime(2026, 1, 1, 8, 33, 0, 0, DateTimeKind.Utc), true, 33L, 500, null },
                    { 34L, new DateTime(2026, 1, 1, 8, 34, 0, 0, DateTimeKind.Utc), true, 34L, 500, null },
                    { 35L, new DateTime(2026, 1, 1, 8, 35, 0, 0, DateTimeKind.Utc), true, 35L, 500, null },
                    { 36L, new DateTime(2026, 1, 1, 8, 36, 0, 0, DateTimeKind.Utc), true, 36L, 495, null },
                    { 37L, new DateTime(2026, 1, 1, 8, 37, 0, 0, DateTimeKind.Utc), true, 37L, 500, null },
                    { 38L, new DateTime(2026, 1, 1, 8, 38, 0, 0, DateTimeKind.Utc), true, 38L, 500, null },
                    { 39L, new DateTime(2026, 1, 1, 8, 39, 0, 0, DateTimeKind.Utc), true, 39L, 500, null },
                    { 40L, new DateTime(2026, 1, 1, 8, 40, 0, 0, DateTimeKind.Utc), true, 40L, 500, null },
                    { 41L, new DateTime(2026, 1, 1, 8, 41, 0, 0, DateTimeKind.Utc), true, 41L, 500, null },
                    { 42L, new DateTime(2026, 1, 1, 8, 42, 0, 0, DateTimeKind.Utc), true, 42L, 500, null },
                    { 43L, new DateTime(2026, 1, 1, 8, 43, 0, 0, DateTimeKind.Utc), true, 43L, 500, null },
                    { 44L, new DateTime(2026, 1, 1, 8, 44, 0, 0, DateTimeKind.Utc), true, 44L, 495, null },
                    { 45L, new DateTime(2026, 1, 1, 8, 45, 0, 0, DateTimeKind.Utc), true, 45L, 499, null },
                    { 46L, new DateTime(2026, 1, 1, 8, 46, 0, 0, DateTimeKind.Utc), true, 46L, 500, null },
                    { 47L, new DateTime(2026, 1, 1, 8, 47, 0, 0, DateTimeKind.Utc), true, 47L, 500, null },
                    { 48L, new DateTime(2026, 1, 1, 8, 48, 0, 0, DateTimeKind.Utc), true, 48L, 495, null },
                    { 49L, new DateTime(2026, 1, 1, 8, 49, 0, 0, DateTimeKind.Utc), true, 49L, 500, null },
                    { 50L, new DateTime(2026, 1, 1, 8, 50, 0, 0, DateTimeKind.Utc), true, 50L, 500, null },
                    { 51L, new DateTime(2026, 1, 1, 8, 51, 0, 0, DateTimeKind.Utc), true, 51L, 500, null },
                    { 52L, new DateTime(2026, 1, 1, 8, 52, 0, 0, DateTimeKind.Utc), true, 52L, 500, null },
                    { 53L, new DateTime(2026, 1, 1, 8, 53, 0, 0, DateTimeKind.Utc), true, 53L, 499, null },
                    { 54L, new DateTime(2026, 1, 1, 8, 54, 0, 0, DateTimeKind.Utc), true, 54L, 500, null },
                    { 55L, new DateTime(2026, 1, 1, 8, 55, 0, 0, DateTimeKind.Utc), true, 55L, 500, null },
                    { 56L, new DateTime(2026, 1, 1, 8, 56, 0, 0, DateTimeKind.Utc), true, 56L, 500, null },
                    { 57L, new DateTime(2026, 1, 1, 8, 57, 0, 0, DateTimeKind.Utc), true, 57L, 500, null },
                    { 58L, new DateTime(2026, 1, 1, 8, 58, 0, 0, DateTimeKind.Utc), true, 58L, 500, null },
                    { 59L, new DateTime(2026, 1, 1, 8, 59, 0, 0, DateTimeKind.Utc), true, 59L, 500, null },
                    { 60L, new DateTime(2026, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), true, 60L, 500, null },
                    { 61L, new DateTime(2026, 1, 1, 9, 1, 0, 0, DateTimeKind.Utc), true, 61L, 499, null },
                    { 62L, new DateTime(2026, 1, 1, 9, 2, 0, 0, DateTimeKind.Utc), true, 62L, 498, null },
                    { 63L, new DateTime(2026, 1, 1, 9, 3, 0, 0, DateTimeKind.Utc), true, 63L, 497, null },
                    { 64L, new DateTime(2026, 1, 1, 9, 4, 0, 0, DateTimeKind.Utc), true, 64L, 500, null },
                    { 65L, new DateTime(2026, 1, 1, 9, 5, 0, 0, DateTimeKind.Utc), true, 65L, 500, null },
                    { 66L, new DateTime(2026, 1, 1, 9, 6, 0, 0, DateTimeKind.Utc), true, 66L, 500, null },
                    { 67L, new DateTime(2026, 1, 1, 9, 7, 0, 0, DateTimeKind.Utc), true, 67L, 500, null },
                    { 68L, new DateTime(2026, 1, 1, 9, 8, 0, 0, DateTimeKind.Utc), true, 68L, 500, null },
                    { 69L, new DateTime(2026, 1, 1, 9, 9, 0, 0, DateTimeKind.Utc), true, 69L, 500, null },
                    { 70L, new DateTime(2026, 1, 1, 9, 10, 0, 0, DateTimeKind.Utc), true, 70L, 498, null },
                    { 71L, new DateTime(2026, 1, 1, 9, 11, 0, 0, DateTimeKind.Utc), true, 71L, 500, null },
                    { 72L, new DateTime(2026, 1, 1, 9, 12, 0, 0, DateTimeKind.Utc), true, 72L, 496, null },
                    { 73L, new DateTime(2026, 1, 1, 9, 13, 0, 0, DateTimeKind.Utc), true, 73L, 500, null },
                    { 74L, new DateTime(2026, 1, 1, 9, 14, 0, 0, DateTimeKind.Utc), true, 74L, 500, null },
                    { 75L, new DateTime(2026, 1, 1, 9, 15, 0, 0, DateTimeKind.Utc), true, 75L, 500, null },
                    { 76L, new DateTime(2026, 1, 1, 9, 16, 0, 0, DateTimeKind.Utc), true, 76L, 500, null },
                    { 77L, new DateTime(2026, 1, 1, 9, 17, 0, 0, DateTimeKind.Utc), true, 77L, 500, null },
                    { 78L, new DateTime(2026, 1, 1, 9, 18, 0, 0, DateTimeKind.Utc), true, 78L, 498, null },
                    { 79L, new DateTime(2026, 1, 1, 9, 19, 0, 0, DateTimeKind.Utc), true, 79L, 500, null },
                    { 80L, new DateTime(2026, 1, 1, 9, 20, 0, 0, DateTimeKind.Utc), true, 80L, 496, null },
                    { 81L, new DateTime(2026, 1, 1, 9, 21, 0, 0, DateTimeKind.Utc), true, 81L, 495, null },
                    { 82L, new DateTime(2026, 1, 1, 9, 22, 0, 0, DateTimeKind.Utc), true, 82L, 500, null },
                    { 83L, new DateTime(2026, 1, 1, 9, 23, 0, 0, DateTimeKind.Utc), true, 83L, 500, null },
                    { 84L, new DateTime(2026, 1, 1, 9, 24, 0, 0, DateTimeKind.Utc), true, 84L, 500, null },
                    { 85L, new DateTime(2026, 1, 1, 9, 25, 0, 0, DateTimeKind.Utc), true, 85L, 500, null },
                    { 86L, new DateTime(2026, 1, 1, 9, 26, 0, 0, DateTimeKind.Utc), true, 86L, 500, null },
                    { 87L, new DateTime(2026, 1, 1, 9, 27, 0, 0, DateTimeKind.Utc), true, 87L, 497, null },
                    { 88L, new DateTime(2026, 1, 1, 9, 28, 0, 0, DateTimeKind.Utc), true, 88L, 500, null },
                    { 89L, new DateTime(2026, 1, 1, 9, 29, 0, 0, DateTimeKind.Utc), true, 89L, 495, null },
                    { 90L, new DateTime(2026, 1, 1, 9, 30, 0, 0, DateTimeKind.Utc), true, 90L, 500, null },
                    { 91L, new DateTime(2026, 1, 1, 9, 31, 0, 0, DateTimeKind.Utc), true, 91L, 500, null },
                    { 92L, new DateTime(2026, 1, 1, 9, 32, 0, 0, DateTimeKind.Utc), true, 92L, 500, null },
                    { 93L, new DateTime(2026, 1, 1, 9, 33, 0, 0, DateTimeKind.Utc), true, 93L, 500, null },
                    { 94L, new DateTime(2026, 1, 1, 9, 34, 0, 0, DateTimeKind.Utc), true, 94L, 500, null },
                    { 95L, new DateTime(2026, 1, 1, 9, 35, 0, 0, DateTimeKind.Utc), true, 95L, 500, null },
                    { 96L, new DateTime(2026, 1, 1, 9, 36, 0, 0, DateTimeKind.Utc), true, 96L, 500, null },
                    { 97L, new DateTime(2026, 1, 1, 9, 37, 0, 0, DateTimeKind.Utc), true, 97L, 495, null },
                    { 98L, new DateTime(2026, 1, 1, 9, 38, 0, 0, DateTimeKind.Utc), true, 98L, 499, null },
                    { 99L, new DateTime(2026, 1, 1, 9, 39, 0, 0, DateTimeKind.Utc), true, 99L, 498, null },
                    { 100L, new DateTime(2026, 1, 1, 9, 40, 0, 0, DateTimeKind.Utc), true, 100L, 500, null },
                    { 101L, new DateTime(2026, 1, 1, 9, 41, 0, 0, DateTimeKind.Utc), true, 101L, 500, null },
                    { 102L, new DateTime(2026, 1, 1, 9, 42, 0, 0, DateTimeKind.Utc), true, 102L, 500, null },
                    { 103L, new DateTime(2026, 1, 1, 9, 43, 0, 0, DateTimeKind.Utc), true, 103L, 500, null },
                    { 104L, new DateTime(2026, 1, 1, 9, 44, 0, 0, DateTimeKind.Utc), true, 104L, 496, null },
                    { 105L, new DateTime(2026, 1, 1, 9, 45, 0, 0, DateTimeKind.Utc), true, 105L, 500, null },
                    { 106L, new DateTime(2026, 1, 1, 9, 46, 0, 0, DateTimeKind.Utc), true, 106L, 499, null },
                    { 107L, new DateTime(2026, 1, 1, 9, 47, 0, 0, DateTimeKind.Utc), true, 107L, 500, null },
                    { 108L, new DateTime(2026, 1, 1, 9, 48, 0, 0, DateTimeKind.Utc), true, 108L, 497, null },
                    { 109L, new DateTime(2026, 1, 1, 9, 49, 0, 0, DateTimeKind.Utc), true, 109L, 500, null },
                    { 110L, new DateTime(2026, 1, 1, 9, 50, 0, 0, DateTimeKind.Utc), true, 110L, 500, null },
                    { 111L, new DateTime(2026, 1, 1, 9, 51, 0, 0, DateTimeKind.Utc), true, 111L, 500, null },
                    { 112L, new DateTime(2026, 1, 1, 9, 52, 0, 0, DateTimeKind.Utc), true, 112L, 500, null },
                    { 113L, new DateTime(2026, 1, 1, 9, 53, 0, 0, DateTimeKind.Utc), true, 113L, 500, null },
                    { 114L, new DateTime(2026, 1, 1, 9, 54, 0, 0, DateTimeKind.Utc), true, 114L, 499, null },
                    { 115L, new DateTime(2026, 1, 1, 9, 55, 0, 0, DateTimeKind.Utc), true, 115L, 500, null },
                    { 116L, new DateTime(2026, 1, 1, 9, 56, 0, 0, DateTimeKind.Utc), true, 116L, 497, null },
                    { 117L, new DateTime(2026, 1, 1, 9, 57, 0, 0, DateTimeKind.Utc), true, 117L, 496, null },
                    { 118L, new DateTime(2026, 1, 1, 9, 58, 0, 0, DateTimeKind.Utc), true, 118L, 500, null },
                    { 119L, new DateTime(2026, 1, 1, 9, 59, 0, 0, DateTimeKind.Utc), true, 119L, 500, null },
                    { 120L, new DateTime(2026, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc), true, 120L, 500, null },
                    { 121L, new DateTime(2026, 1, 1, 10, 1, 0, 0, DateTimeKind.Utc), true, 121L, 500, null },
                    { 122L, new DateTime(2026, 1, 1, 10, 2, 0, 0, DateTimeKind.Utc), true, 122L, 500, null },
                    { 123L, new DateTime(2026, 1, 1, 10, 3, 0, 0, DateTimeKind.Utc), true, 123L, 498, null },
                    { 124L, new DateTime(2026, 1, 1, 10, 4, 0, 0, DateTimeKind.Utc), true, 124L, 500, null },
                    { 125L, new DateTime(2026, 1, 1, 10, 5, 0, 0, DateTimeKind.Utc), true, 125L, 496, null },
                    { 126L, new DateTime(2026, 1, 1, 10, 6, 0, 0, DateTimeKind.Utc), true, 126L, 500, null },
                    { 127L, new DateTime(2026, 1, 1, 10, 7, 0, 0, DateTimeKind.Utc), true, 127L, 500, null },
                    { 128L, new DateTime(2026, 1, 1, 10, 8, 0, 0, DateTimeKind.Utc), true, 128L, 500, null },
                    { 129L, new DateTime(2026, 1, 1, 10, 9, 0, 0, DateTimeKind.Utc), true, 129L, 500, null },
                    { 130L, new DateTime(2026, 1, 1, 10, 10, 0, 0, DateTimeKind.Utc), true, 130L, 500, null },
                    { 131L, new DateTime(2026, 1, 1, 10, 11, 0, 0, DateTimeKind.Utc), true, 131L, 500, null },
                    { 132L, new DateTime(2026, 1, 1, 10, 12, 0, 0, DateTimeKind.Utc), true, 132L, 500, null },
                    { 133L, new DateTime(2026, 1, 1, 10, 13, 0, 0, DateTimeKind.Utc), true, 133L, 496, null },
                    { 134L, new DateTime(2026, 1, 1, 10, 14, 0, 0, DateTimeKind.Utc), true, 134L, 495, null },
                    { 135L, new DateTime(2026, 1, 1, 10, 15, 0, 0, DateTimeKind.Utc), true, 135L, 499, null },
                    { 136L, new DateTime(2026, 1, 1, 10, 16, 0, 0, DateTimeKind.Utc), true, 136L, 500, null },
                    { 137L, new DateTime(2026, 1, 1, 10, 17, 0, 0, DateTimeKind.Utc), true, 137L, 500, null },
                    { 138L, new DateTime(2026, 1, 1, 10, 18, 0, 0, DateTimeKind.Utc), true, 138L, 500, null },
                    { 139L, new DateTime(2026, 1, 1, 10, 19, 0, 0, DateTimeKind.Utc), true, 139L, 500, null },
                    { 140L, new DateTime(2026, 1, 1, 10, 20, 0, 0, DateTimeKind.Utc), true, 140L, 497, null },
                    { 141L, new DateTime(2026, 1, 1, 10, 21, 0, 0, DateTimeKind.Utc), true, 141L, 500, null },
                    { 142L, new DateTime(2026, 1, 1, 10, 22, 0, 0, DateTimeKind.Utc), true, 142L, 495, null },
                    { 143L, new DateTime(2026, 1, 1, 10, 23, 0, 0, DateTimeKind.Utc), true, 143L, 500, null },
                    { 144L, new DateTime(2026, 1, 1, 10, 24, 0, 0, DateTimeKind.Utc), true, 144L, 498, null },
                    { 145L, new DateTime(2026, 1, 1, 10, 25, 0, 0, DateTimeKind.Utc), true, 145L, 500, null },
                    { 146L, new DateTime(2026, 1, 1, 10, 26, 0, 0, DateTimeKind.Utc), true, 146L, 500, null },
                    { 147L, new DateTime(2026, 1, 1, 10, 27, 0, 0, DateTimeKind.Utc), true, 147L, 500, null },
                    { 148L, new DateTime(2026, 1, 1, 10, 28, 0, 0, DateTimeKind.Utc), true, 148L, 500, null },
                    { 149L, new DateTime(2026, 1, 1, 10, 29, 0, 0, DateTimeKind.Utc), true, 149L, 500, null },
                    { 150L, new DateTime(2026, 1, 1, 10, 30, 0, 0, DateTimeKind.Utc), true, 150L, 495, null },
                    { 151L, new DateTime(2026, 1, 1, 10, 31, 0, 0, DateTimeKind.Utc), true, 151L, 500, null },
                    { 152L, new DateTime(2026, 1, 1, 10, 32, 0, 0, DateTimeKind.Utc), true, 152L, 498, null },
                    { 153L, new DateTime(2026, 1, 1, 10, 33, 0, 0, DateTimeKind.Utc), true, 153L, 497, null },
                    { 154L, new DateTime(2026, 1, 1, 10, 34, 0, 0, DateTimeKind.Utc), true, 154L, 500, null },
                    { 155L, new DateTime(2026, 1, 1, 10, 35, 0, 0, DateTimeKind.Utc), true, 155L, 500, null },
                    { 156L, new DateTime(2026, 1, 1, 10, 36, 0, 0, DateTimeKind.Utc), true, 156L, 500, null },
                    { 157L, new DateTime(2026, 1, 1, 10, 37, 0, 0, DateTimeKind.Utc), true, 157L, 500, null },
                    { 158L, new DateTime(2026, 1, 1, 10, 38, 0, 0, DateTimeKind.Utc), true, 158L, 500, null },
                    { 159L, new DateTime(2026, 1, 1, 10, 39, 0, 0, DateTimeKind.Utc), true, 159L, 499, null },
                    { 160L, new DateTime(2026, 1, 1, 10, 40, 0, 0, DateTimeKind.Utc), true, 160L, 500, null },
                    { 161L, new DateTime(2026, 1, 1, 10, 41, 0, 0, DateTimeKind.Utc), true, 161L, 497, null },
                    { 162L, new DateTime(2026, 1, 1, 10, 42, 0, 0, DateTimeKind.Utc), true, 162L, 500, null },
                    { 163L, new DateTime(2026, 1, 1, 10, 43, 0, 0, DateTimeKind.Utc), true, 163L, 500, null },
                    { 164L, new DateTime(2026, 1, 1, 10, 44, 0, 0, DateTimeKind.Utc), true, 164L, 500, null },
                    { 165L, new DateTime(2026, 1, 1, 10, 45, 0, 0, DateTimeKind.Utc), true, 165L, 500, null },
                    { 166L, new DateTime(2026, 1, 1, 10, 46, 0, 0, DateTimeKind.Utc), true, 166L, 500, null },
                    { 167L, new DateTime(2026, 1, 1, 10, 47, 0, 0, DateTimeKind.Utc), true, 167L, 500, null },
                    { 168L, new DateTime(2026, 1, 1, 10, 48, 0, 0, DateTimeKind.Utc), true, 168L, 500, null },
                    { 169L, new DateTime(2026, 1, 1, 10, 49, 0, 0, DateTimeKind.Utc), true, 169L, 497, null },
                    { 170L, new DateTime(2026, 1, 1, 10, 50, 0, 0, DateTimeKind.Utc), true, 170L, 496, null },
                    { 171L, new DateTime(2026, 1, 1, 10, 51, 0, 0, DateTimeKind.Utc), true, 171L, 495, null },
                    { 172L, new DateTime(2026, 1, 1, 10, 52, 0, 0, DateTimeKind.Utc), true, 172L, 500, null },
                    { 173L, new DateTime(2026, 1, 1, 10, 53, 0, 0, DateTimeKind.Utc), true, 173L, 500, null },
                    { 174L, new DateTime(2026, 1, 1, 10, 54, 0, 0, DateTimeKind.Utc), true, 174L, 500, null },
                    { 175L, new DateTime(2026, 1, 1, 10, 55, 0, 0, DateTimeKind.Utc), true, 175L, 500, null },
                    { 176L, new DateTime(2026, 1, 1, 10, 56, 0, 0, DateTimeKind.Utc), true, 176L, 498, null },
                    { 177L, new DateTime(2026, 1, 1, 10, 57, 0, 0, DateTimeKind.Utc), true, 177L, 500, null },
                    { 178L, new DateTime(2026, 1, 1, 10, 58, 0, 0, DateTimeKind.Utc), true, 178L, 496, null },
                    { 179L, new DateTime(2026, 1, 1, 10, 59, 0, 0, DateTimeKind.Utc), true, 179L, 500, null },
                    { 180L, new DateTime(2026, 1, 1, 11, 0, 0, 0, DateTimeKind.Utc), true, 180L, 499, null },
                    { 181L, new DateTime(2026, 1, 1, 11, 1, 0, 0, DateTimeKind.Utc), true, 181L, 500, null },
                    { 182L, new DateTime(2026, 1, 1, 11, 2, 0, 0, DateTimeKind.Utc), true, 182L, 500, null },
                    { 183L, new DateTime(2026, 1, 1, 11, 3, 0, 0, DateTimeKind.Utc), true, 183L, 500, null },
                    { 184L, new DateTime(2026, 1, 1, 11, 4, 0, 0, DateTimeKind.Utc), true, 184L, 500, null },
                    { 185L, new DateTime(2026, 1, 1, 11, 5, 0, 0, DateTimeKind.Utc), true, 185L, 500, null },
                    { 186L, new DateTime(2026, 1, 1, 11, 6, 0, 0, DateTimeKind.Utc), true, 186L, 496, null },
                    { 187L, new DateTime(2026, 1, 1, 11, 7, 0, 0, DateTimeKind.Utc), true, 187L, 500, null },
                    { 188L, new DateTime(2026, 1, 1, 11, 8, 0, 0, DateTimeKind.Utc), true, 188L, 499, null },
                    { 189L, new DateTime(2026, 1, 1, 11, 9, 0, 0, DateTimeKind.Utc), true, 189L, 498, null },
                    { 190L, new DateTime(2026, 1, 1, 11, 10, 0, 0, DateTimeKind.Utc), true, 190L, 500, null },
                    { 191L, new DateTime(2026, 1, 1, 11, 11, 0, 0, DateTimeKind.Utc), true, 191L, 500, null },
                    { 192L, new DateTime(2026, 1, 1, 11, 12, 0, 0, DateTimeKind.Utc), true, 192L, 500, null },
                    { 193L, new DateTime(2026, 1, 1, 11, 13, 0, 0, DateTimeKind.Utc), true, 193L, 500, null },
                    { 194L, new DateTime(2026, 1, 1, 11, 14, 0, 0, DateTimeKind.Utc), true, 194L, 500, null },
                    { 195L, new DateTime(2026, 1, 1, 11, 15, 0, 0, DateTimeKind.Utc), true, 195L, 495, null },
                    { 196L, new DateTime(2026, 1, 1, 11, 16, 0, 0, DateTimeKind.Utc), true, 196L, 500, null },
                    { 197L, new DateTime(2026, 1, 1, 11, 17, 0, 0, DateTimeKind.Utc), true, 197L, 498, null },
                    { 198L, new DateTime(2026, 1, 1, 11, 18, 0, 0, DateTimeKind.Utc), true, 198L, 500, null },
                    { 199L, new DateTime(2026, 1, 1, 11, 19, 0, 0, DateTimeKind.Utc), true, 199L, 500, null },
                    { 200L, new DateTime(2026, 1, 1, 11, 20, 0, 0, DateTimeKind.Utc), true, 200L, 500, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 1, 2, 8, 0, 0, 0, DateTimeKind.Utc), 1L, 1, null },
                    { 2L, new DateTime(2026, 1, 3, 8, 0, 0, 0, DateTimeKind.Utc), 2L, 2, new DateTime(2026, 1, 3, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { 3L, new DateTime(2026, 1, 4, 8, 0, 0, 0, DateTimeKind.Utc), 3L, 3, new DateTime(2026, 1, 4, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 4L, new DateTime(2026, 1, 5, 8, 0, 0, 0, DateTimeKind.Utc), 4L, 4, new DateTime(2026, 1, 5, 11, 0, 0, 0, DateTimeKind.Utc) },
                    { 5L, new DateTime(2026, 1, 6, 8, 0, 0, 0, DateTimeKind.Utc), 5L, 1, null },
                    { 6L, new DateTime(2026, 1, 7, 8, 0, 0, 0, DateTimeKind.Utc), 6L, 2, new DateTime(2026, 1, 7, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { 7L, new DateTime(2026, 1, 8, 8, 0, 0, 0, DateTimeKind.Utc), 7L, 3, new DateTime(2026, 1, 8, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 8L, new DateTime(2026, 1, 9, 8, 0, 0, 0, DateTimeKind.Utc), 8L, 4, new DateTime(2026, 1, 9, 11, 0, 0, 0, DateTimeKind.Utc) },
                    { 9L, new DateTime(2026, 1, 10, 8, 0, 0, 0, DateTimeKind.Utc), 9L, 1, null },
                    { 10L, new DateTime(2026, 1, 11, 8, 0, 0, 0, DateTimeKind.Utc), 10L, 2, new DateTime(2026, 1, 11, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { 11L, new DateTime(2026, 1, 12, 8, 0, 0, 0, DateTimeKind.Utc), 11L, 3, new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 12L, new DateTime(2026, 1, 13, 8, 0, 0, 0, DateTimeKind.Utc), 12L, 4, new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc) },
                    { 13L, new DateTime(2026, 1, 14, 8, 0, 0, 0, DateTimeKind.Utc), 13L, 1, null },
                    { 14L, new DateTime(2026, 1, 15, 8, 0, 0, 0, DateTimeKind.Utc), 14L, 2, new DateTime(2026, 1, 15, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { 15L, new DateTime(2026, 1, 16, 8, 0, 0, 0, DateTimeKind.Utc), 15L, 3, new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 16L, new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Utc), 16L, 4, new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc) },
                    { 17L, new DateTime(2026, 1, 18, 8, 0, 0, 0, DateTimeKind.Utc), 17L, 1, null },
                    { 18L, new DateTime(2026, 1, 19, 8, 0, 0, 0, DateTimeKind.Utc), 18L, 2, new DateTime(2026, 1, 19, 9, 0, 0, 0, DateTimeKind.Utc) },
                    { 19L, new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Utc), 19L, 3, new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc) },
                    { 20L, new DateTime(2026, 1, 21, 8, 0, 0, 0, DateTimeKind.Utc), 20L, 4, new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "RoleUser",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "IsActive", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, true, 1L, 18L, 3, 550000m },
                    { 2L, true, 1L, 35L, 4, 975000m },
                    { 3L, true, 1L, 52L, 5, 1400000m },
                    { 4L, true, 2L, 27L, 4, 775000m },
                    { 5L, true, 2L, 44L, 5, 1200000m },
                    { 6L, true, 2L, 61L, 1, 1625000m },
                    { 7L, true, 2L, 78L, 2, 2050000m },
                    { 8L, true, 3L, 36L, 5, 1000000m },
                    { 9L, true, 3L, 53L, 1, 1425000m },
                    { 10L, true, 3L, 70L, 2, 1850000m },
                    { 11L, true, 3L, 87L, 3, 2275000m },
                    { 12L, true, 3L, 104L, 4, 2700000m },
                    { 13L, true, 4L, 45L, 1, 1225000m },
                    { 14L, true, 4L, 62L, 2, 1650000m },
                    { 15L, true, 5L, 54L, 2, 1450000m },
                    { 16L, true, 5L, 71L, 3, 1875000m },
                    { 17L, true, 5L, 88L, 4, 2300000m },
                    { 18L, true, 6L, 63L, 3, 1675000m },
                    { 19L, true, 6L, 80L, 4, 2100000m },
                    { 20L, true, 6L, 97L, 5, 2525000m },
                    { 21L, true, 6L, 114L, 1, 2950000m },
                    { 22L, true, 7L, 72L, 4, 1900000m },
                    { 23L, true, 7L, 89L, 5, 2325000m },
                    { 24L, true, 7L, 106L, 1, 2750000m },
                    { 25L, true, 7L, 123L, 2, 3175000m },
                    { 26L, true, 7L, 140L, 3, 3600000m },
                    { 27L, true, 8L, 81L, 5, 2125000m },
                    { 28L, true, 8L, 98L, 1, 2550000m },
                    { 29L, true, 9L, 90L, 1, 2350000m },
                    { 30L, true, 9L, 107L, 2, 2775000m },
                    { 31L, true, 9L, 124L, 3, 3200000m },
                    { 32L, true, 10L, 99L, 2, 2575000m },
                    { 33L, true, 10L, 116L, 3, 3000000m },
                    { 34L, true, 10L, 133L, 4, 3425000m },
                    { 35L, true, 10L, 150L, 5, 3850000m },
                    { 36L, true, 11L, 108L, 3, 2800000m },
                    { 37L, true, 11L, 125L, 4, 3225000m },
                    { 38L, true, 11L, 142L, 5, 3650000m },
                    { 39L, true, 11L, 159L, 1, 4075000m },
                    { 40L, true, 11L, 176L, 2, 4500000m },
                    { 41L, true, 12L, 117L, 4, 3025000m },
                    { 42L, true, 12L, 134L, 5, 3450000m },
                    { 43L, true, 13L, 126L, 5, 3250000m },
                    { 44L, true, 13L, 143L, 1, 3675000m },
                    { 45L, true, 13L, 160L, 2, 4100000m },
                    { 46L, true, 14L, 135L, 1, 3475000m },
                    { 47L, true, 14L, 152L, 2, 3900000m },
                    { 48L, true, 14L, 169L, 3, 4325000m },
                    { 49L, true, 14L, 186L, 4, 4750000m },
                    { 50L, true, 15L, 144L, 2, 3700000m },
                    { 51L, true, 15L, 161L, 3, 4125000m },
                    { 52L, true, 15L, 178L, 4, 4550000m },
                    { 53L, true, 15L, 195L, 5, 4975000m },
                    { 54L, true, 15L, 12L, 1, 400000m },
                    { 55L, true, 16L, 153L, 3, 3925000m },
                    { 56L, true, 16L, 170L, 4, 4350000m },
                    { 57L, true, 17L, 162L, 4, 4150000m },
                    { 58L, true, 17L, 179L, 5, 4575000m },
                    { 59L, true, 17L, 196L, 1, 5000000m },
                    { 60L, true, 18L, 171L, 5, 4375000m },
                    { 61L, true, 18L, 188L, 1, 4800000m },
                    { 62L, true, 18L, 5L, 2, 225000m },
                    { 63L, true, 18L, 22L, 3, 650000m },
                    { 64L, true, 19L, 180L, 1, 4600000m },
                    { 65L, true, 19L, 197L, 2, 5025000m },
                    { 66L, true, 19L, 14L, 3, 450000m },
                    { 67L, true, 19L, 31L, 4, 875000m },
                    { 68L, true, 19L, 48L, 5, 1300000m },
                    { 69L, true, 20L, 189L, 2, 4825000m },
                    { 70L, true, 20L, 6L, 3, 250000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "RoleUser",
                keyColumns: new[] { "RolesId", "UsersId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "RoleUser",
                keyColumns: new[] { "RolesId", "UsersId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20L);
        }
    }
}
