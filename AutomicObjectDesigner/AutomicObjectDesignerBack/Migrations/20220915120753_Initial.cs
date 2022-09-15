﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomicObjectDesignerBack.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileTransfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SapJobBwChain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SapClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kette = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineJob = table.Column<bool>(type: "bit", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapJobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteSapJob = table.Column<bool>(type: "bit", nullable: false),
                    ObjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapVariant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Folder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapJobBwChain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SapSimple",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SapClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapVariant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineJob = table.Column<bool>(type: "bit", nullable: true),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapJobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteSapJob = table.Column<bool>(type: "bit", nullable: true),
                    ObjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Folder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapSimple", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnixGeneral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnixServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnixLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineJob = table.Column<bool>(type: "bit", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Folder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnixGeneral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    HasEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsAdministrator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WindowsGeneral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Archive2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Folder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindowsGeneral", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "HasEmailConfirmed", "IsAdministrator", "LastName", "Password", "UserName" },
                values: new object[] { 100, "admin@gmail.com", "Admin", true, true, "Admin", "Admin!11", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileTransfers");

            migrationBuilder.DropTable(
                name: "SapJobBwChain");

            migrationBuilder.DropTable(
                name: "SapSimple");

            migrationBuilder.DropTable(
                name: "UnixGeneral");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WindowsGeneral");
        }
    }
}
