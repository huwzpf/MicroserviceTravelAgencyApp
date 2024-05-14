using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace userservice.Migrations
{
    public partial class HardcodedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] {"Id", "Username", "Password", "IsAdmin" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "admin", "passwordadmin", true },
                    { Guid.NewGuid(), "user0", "password0", false },
                    { Guid.NewGuid(), "user1", "password1", false },
                    { Guid.NewGuid(), "user2", "password2", false },
                    { Guid.NewGuid(), "user3", "password3", false },
                    { Guid.NewGuid(), "user4", "password4", false },
                    { Guid.NewGuid(), "user5", "password5", false },
                    { Guid.NewGuid(), "user6", "password6", false },
                    { Guid.NewGuid(), "user7", "password7", false },
                    { Guid.NewGuid(), "user8", "password8", false },
                    { Guid.NewGuid(), "user9", "password9", false },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Username",
                keyValues: new string[]
                {
                    "admin",
                    "user0", 
                    "user1", 
                    "user2", 
                    "user3", 
                    "user4", 
                    "user5", 
                    "user6", 
                    "user7", 
                    "user8", 
                    "user9"
                }
            );
        }
    }
}