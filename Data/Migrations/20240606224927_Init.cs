using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discipline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discipline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeContact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeEducationalOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEducationalOrganization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecializationId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationProgram_Specialization_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specialization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalOrganization_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalOrganization_TypeEducationalOrganization_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeEducationalOrganization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineEducationProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationProgramId = table.Column<int>(type: "int", nullable: false),
                    DisciplineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineEducationProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplineEducationProgram_Discipline_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Discipline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DisciplineEducationProgram_EducationProgram_EducationProgramId",
                        column: x => x.EducationProgramId,
                        principalTable: "EducationProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalOrganizationContact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeContactId = table.Column<int>(type: "int", nullable: false),
                    EducationalOrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalOrganizationContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalOrganizationContact_EducationalOrganization_EducationalOrganizationId",
                        column: x => x.EducationalOrganizationId,
                        principalTable: "EducationalOrganization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalOrganizationContact_TypeContact_TypeContactId",
                        column: x => x.TypeContactId,
                        principalTable: "TypeContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationalOrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_EducationalOrganization_EducationalOrganizationId",
                        column: x => x.EducationalOrganizationId,
                        principalTable: "EducationalOrganization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramEducationalOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationProgramId = table.Column<int>(type: "int", nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: false),
                    EducationalOrganizationId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TuitionPerYear = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramEducationalOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramEducationalOrganization_EducationalOrganization_EducationalOrganizationId",
                        column: x => x.EducationalOrganizationId,
                        principalTable: "EducationalOrganization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramEducationalOrganization_EducationLevel_EducationLevelId",
                        column: x => x.EducationLevelId,
                        principalTable: "EducationLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramEducationalOrganization_EducationProgram_EducationProgramId",
                        column: x => x.EducationProgramId,
                        principalTable: "EducationProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassingScore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramEducationalOrganizationId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    IsBudget = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassingScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassingScore_ProgramEducationalOrganization_ProgramEducationalOrganizationId",
                        column: x => x.ProgramEducationalOrganizationId,
                        principalTable: "ProgramEducationalOrganization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Москва" },
                    { 2, false, "Санкт-Петербург" },
                    { 3, false, "Новосибирск" },
                    { 4, false, "Екатеринбург" },
                    { 5, false, "Нижний Новгород" },
                    { 6, false, "Казань" },
                    { 7, false, "Челябинск" },
                    { 8, false, "Омск" },
                    { 9, false, "Самара" },
                    { 10, false, "Ростов-на-Дону" },
                    { 11, false, "Уфа" },
                    { 12, false, "Красноярск" },
                    { 13, false, "Воронеж" },
                    { 14, false, "Пермь" },
                    { 15, false, "Волгоград" },
                    { 16, false, "Краснодар" },
                    { 17, false, "Саратов" },
                    { 18, false, "Тюмень" },
                    { 19, false, "Тольятти" },
                    { 20, false, "Ижевск" }
                });

            migrationBuilder.InsertData(
                table: "Discipline",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Математика (профильный уровень)" },
                    { 2, false, "Физика" },
                    { 3, false, "Химия" },
                    { 4, false, "История" },
                    { 5, false, "Обществознание" },
                    { 6, false, "Информатика" },
                    { 7, false, "Биология" },
                    { 8, false, "География" },
                    { 9, false, "Иностранный язык" },
                    { 13, false, "Литература" },
                    { 14, false, "Математика (базовый уровень)" },
                    { 15, false, "Русский язык" }
                });

            migrationBuilder.InsertData(
                table: "EducationLevel",
                columns: new[] { "Id", "is_deleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Профессия" },
                    { 2, false, "Специальность" },
                    { 3, false, "Бакалавриат" },
                    { 4, false, "Специалитет" },
                    { 5, false, "Магистратура" },
                    { 6, false, "Аспирантура" },
                    { 7, false, "Докторантура" }
                });

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "Id", "Description", "is_deleted", "Name" },
                values: new object[,]
                {
                    { 1, null, false, "Информатика и вычислительная техника" },
                    { 2, null, false, "Математика и механика" },
                    { 3, null, false, "Компьютерные и информационные науки" }
                });

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "Id", "Description", "is_deleted", "Name" },
                values: new object[,]
                {
                    { 4, null, false, "Физика и астрономия" },
                    { 5, null, false, "Химия" },
                    { 6, null, false, "Науки о Земле" },
                    { 7, null, false, "Биологические науки" },
                    { 8, null, false, "Архитектура" },
                    { 9, null, false, "Строительство" },
                    { 10, null, false, "Электротехника и электроника" },
                    { 11, null, false, "Энергетика и электротехника" },
                    { 12, null, false, "Техника и технологии наземного транспорта" },
                    { 13, null, false, "Техника и технологии водного транспорта" },
                    { 14, null, false, "Техника и технологии воздушного транспорта" },
                    { 15, null, false, "Экономика" },
                    { 16, null, false, "Управление в технических системах" },
                    { 17, null, false, "Психология" },
                    { 18, null, false, "Социология" },
                    { 19, null, false, "Философия" },
                    { 20, null, false, "Политология" },
                    { 21, null, false, "Юриспруденция" },
                    { 22, null, false, "История" },
                    { 23, null, false, "Филология" },
                    { 24, null, false, "Журналистика" },
                    { 25, null, false, "Культурология" },
                    { 26, null, false, "Искусствоведение" },
                    { 27, null, false, "Дизайн" },
                    { 28, null, false, "Физическая культура и спорт" }
                });

            migrationBuilder.InsertData(
                table: "TypeContact",
                columns: new[] { "Id", "Description", "is_deleted", "Name" },
                values: new object[,]
                {
                    { 1, null, false, "Email" },
                    { 2, null, false, "Телефон" },
                    { 3, null, false, "Сайт" }
                });

            migrationBuilder.InsertData(
                table: "TypeEducationalOrganization",
                columns: new[] { "Id", "Description", "is_deleted", "Name" },
                values: new object[,]
                {
                    { 1, null, false, "Профессиональная образовательная организация" },
                    { 2, null, false, "Образовательная организация высшего образования" }
                });

            migrationBuilder.InsertData(
                table: "EducationProgram",
                columns: new[] { "Id", "Description", "SpecializationId", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, null, 2, "mahmat.png", false, "01.05.01 Фундаментальные математика и механика" },
                    { 2, null, 1, "prinfo.png", false, "09.03.01 Прикладная информатика" },
                    { 3, null, 1, "it.png", false, "09.03.02 Информационные системы и технологии" },
                    { 4, null, 1, "ite.png", false, "09.03.03 Прикладная информатика в экономике" },
                    { 5, null, 1, "iteng.png", false, "09.03.04 Программная инженерия" },
                    { 6, null, 1, "itec.png", false, "09.03.05 Информационные системы и технологии (в экономике)" },
                    { 7, null, 1, "it2.png", false, "09.03.06 Программирование" },
                    { 8, null, 1, "it3.png", false, "09.03.07 Веб-технологии" },
                    { 9, null, 1, "it4.png", false, "09.03.08 Математическое обеспечение и администрирование информационных систем" },
                    { 10, null, 1, "it5.png", false, "09.03.09 Информационные системы и технологии (в здравоохранении)" },
                    { 11, null, 1, "it6.png", false, "09.03.10 Информационные системы и технологии (в бизнесе)" },
                    { 12, null, 1, "it7.png", false, "09.03.11 Информационная безопасность" },
                    { 13, null, 1, "it8.png", false, "09.03.12 Информационные технологии в юриспруденции" },
                    { 14, null, 1, "it9.png", false, "09.03.13 Наноинженерия" },
                    { 15, null, 1, "it11.png", false, "09.03.14 Антикризисное управление" },
                    { 16, null, 1, "it12.png", false, "09.03.15 Управление инновациями" },
                    { 17, null, 1, "it13.png", false, "09.03.16 Информатика и вычислительная техника" },
                    { 18, null, 1, "it14.png", false, "09.03.17 Интеллектуальные системы и технологии" },
                    { 19, null, 1, "it15.png", false, "09.03.18 Технологии управления организацией" },
                    { 20, null, 1, "it16.png", false, "09.03.19 Программное обеспечение экономической деятельности" },
                    { 21, null, 1, "it17.png", false, "09.03.20 Программное обеспечение информационных технологий" },
                    { 22, null, 1, "it18.png", false, "09.03.21 Программно-аппаратные комплексы защиты информации" },
                    { 23, null, 1, "it19.png", false, "09.03.22 Компьютерное моделирование и комплексная автоматизация проектирования" },
                    { 24, null, 1, "it20.png", false, "09.03.23 Прикладное программирование" },
                    { 25, null, 1, "it21.png", false, "09.03.24 Программирование в интеллектуальных робототехнических системах" },
                    { 26, null, 1, "it22.png", false, "09.03.25 Киберфизические системы" },
                    { 27, null, 1, "it23.png", false, "09.03.26 Технологии промышленного программирования" },
                    { 28, null, 1, "it24.png", false, "09.03.27 Технологии программирования систем и сетей" },
                    { 29, null, 1, "it25.png", false, "09.03.28 Информационные системы" },
                    { 30, null, 1, "it10.png", false, "09.02.07 Информационные системы и программирование" },
                    { 31, null, 2, "", false, "02.03.01 Математика и компьютерные науки" },
                    { 32, null, 3, "", false, "02.03.02 Фундаментальная информатика и информационные технологии" },
                    { 33, null, 3, "", false, "02.03.03 Математическое и программное обеспечение вычислительных машин и комплексов" },
                    { 34, null, 2, "", false, "02.03.04 Прикладная математика и информатика" },
                    { 35, null, 4, "", false, "03.03.01 Прикладная математика и физика" },
                    { 36, null, 4, "", false, "03.03.02 Физика" },
                    { 37, null, 4, "", false, "03.03.03 Радиофизика" },
                    { 38, null, 4, "", false, "03.03.04 Физика конденсированного состояния" },
                    { 39, null, 4, "", false, "03.03.05 Лазерная физика" },
                    { 40, null, 4, "", false, "03.03.06 Астрономия" },
                    { 41, null, 5, "", false, "04.03.01 Химия" },
                    { 42, null, 5, "", false, "04.03.02 Химическая технология" }
                });

            migrationBuilder.InsertData(
                table: "EducationProgram",
                columns: new[] { "Id", "Description", "SpecializationId", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 43, null, 5, "", false, "04.03.03 Физическая химия" },
                    { 44, null, 5, "", false, "04.03.04 Неорганическая химия" },
                    { 45, null, 6, "", false, "05.03.01 Геология" },
                    { 46, null, 6, "", false, "05.03.02 Геофизика" },
                    { 47, null, 6, "", false, "05.03.03 География" },
                    { 48, null, 6, "", false, "05.03.04 Метеорология" },
                    { 49, null, 6, "", false, "05.03.05 Картография и геоинформатика" },
                    { 50, null, 7, "", false, "06.03.01 Биология" },
                    { 51, null, 7, "", false, "06.03.02 Биотехнология" }
                });

            migrationBuilder.InsertData(
                table: "EducationalOrganization",
                columns: new[] { "Id", "Address", "CityId", "Description", "Image", "is_deleted", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, "ул. Ленинские Горы, 1", 1, "Сегодня Московский университет — крупнейший классический университет России, в котором обучается более 45 тысяч человек из всех регионов страны (на разных формах обучения). В МГУ 40 факультетов (за последние 20 лет создан 21 факультет), 15 научно-исследовательских институтов, около 750 кафедр, отделов и лабораторий, Медицинский научно-образовательный центр, Научная библиотека, 4 музея, Ботанический сад, Научный парк, филиалы в Севастополе, Ташкенте, Астане, Баку, Душанбе, Ереване. \r\n\r\nМГУ осуществляет обучение по собственным образовательным уникальным 6‑летним образовательным стандартам, реализуемым в двух формах: интегрированная магистратура (нормативный срок обучения 4 года в бакалавриате и 2 года в магистратуре) и специалитет (нормативный срок обучения 6 лет). Особенностью интегрированной магистратуры является непрерывная подготовка студентов (на протяжении 6 лет обучения) по выбранному направлению, что является гарантией качественной подготовки специалистов в избранной области. В условиях перехода страны на двухуровневую систему высшего образования план приема в бюджетную магистратуру МГУ позволяет продолжить обучение в магистратуре всех выпускников МГУ (бакалавров), способных и готовых к дальнейшему обучению.", "msu.jpg", false, "Московский государственный университет им. М.В. Ломоносова", 2 },
                    { 2, "Институтский пер., д. 9", 1, "Московский физико-технический институт (МФТИ) является ведущим техническим университетом России. Система образования сфокусирована на глубоком изучении фундаментальных наук в сочетании с активным участием студентов в исследованиях в крупнейших российских и международных научных центрах. В МФТИ используется уникальная «Система Физтеха», разработанная основателями института и его первыми профессорами Петром Капицей, Николаем Семеновым и Львом Ландау. МФТИ имеет статус Государственного университета, что позволяет получать регулярную прямую финансовую и организационную поддержку от Правительства Российской Федерации. Институт является участником программы 5–100, направленной на развитие исследовательской деятельности, организованной в самом МФТИ, а также выход Физтеха в верхние позиции мировых университетских рейтингов.", "mfti.jpg", false, "Московский физико-технический институт", 2 },
                    { 3, "Каширское ш., д. 31", 1, "«Мекка» физиков-ядерщиков, базовый вуз атомной промышленности России располагает рядом высокотехничных установок, в том числе, исследовательским ядерным реактором. Также, МИФИ занимает лидирующие позиции по подготовке программистов и специалистов по информационной безопасности. Здесь активно используется компьютерная поддержка учебного процесса: электронные учебники, компьютерные лабораторные работы, тренажеры. Университет сотрудничает с несколькими десятками университетов по всему миру. Многие старшекурсники проходят обучение и стажировку в лучших ядерных центрах Германии, США.", "mifi.jpg", false, "Национальный исследовательский ядерный университет «МИФИ»", 2 },
                    { 4, "2-я Бауманская ул., д. 5, стр. 1", 1, "МГТУ им. Н.Э. Баумана является одним из ведущих технических вузов страны. Университет ведет подготовку инженеров с 1830 года. На сегодняшний день в университете обучают по большому количеству направлений. Выпускники МГТУ становятся очень востребованными у работодателей на рынке труда. Ключевой особенностью обучения является сочетание теоретических и практических знаний. Университет занимается научными исследованиями и разработками.", "bauman.jpg", false, "Московский государственный технический университет им. Н.Э. Баумана", 2 },
                    { 5, "ул. Маршала Тимошенко, д. 19", 1, "Медицинский колледж имеет богатый опыт профессиональной подготовки квалифицированных кадров среднего звена, их переподготовки и усовершенствования, вносит существенный вклад в обеспечение лечебно-диагностической работы учреждений здравоохранения Управления делами Президента РФ.", "prez.jpg", false, "Медицинский колледж Управления делами Президента Российской Федерации", 1 },
                    { 6, "Хибинский проезд, дом 10", 1, "ГБПОУ КСТ имеет 4 обустроенных актовых зала в каждом подразделении для обучающихся, в том числе инвалидов и лиц с ограниченными возможностями здоровья, которые оснащены проекторами, звуковой аппаратурой. В 6 отдельно оборудованных кабинетах для занятий дополнительным образованием (обработка керамики, работы по дереву и др.) обучающиеся в том числе инвалидов и лиц с ограниченными возможностями здоровья занимаются научно-техническим и художественно-прикладным творчеством. В литературно-музыкальной гостиной в Учебном корпусе № 3 «Ярославский»  (Хибинский проезд, дом 10) проводятся тематические встречи с интересными людьми, литературные вечера, заседания студенческого самоуправления и женского клуба и другие мероприятия. ГБПОУ КСТ располагает широким спектром персональных компьютеров и информационного оборудования, которое в первую очередь используется в учебном и воспитательном процессах.", "kst.png", false, "Колледж современных технологий имени Героя Советского Союза М.Ф. Панова", 1 },
                    { 7, "Университетская наб., д. 7/9", 2, "Санкт-Петербургский государственный университет (СПбГУ) — один из крупнейших и старейших вузов России. Университет предоставляет образование на уровне мировых стандартов, и многие его выпускники стали выдающимися учеными, политиками и деятелями искусства. В СПбГУ функционируют современные научные лаборатории и центры.", "spbu.png", false, "Санкт-Петербургский государственный университет", 2 },
                    { 8, "ул. Пирогова, д. 2", 3, "Новосибирский государственный университет (НГУ) — один из ведущих научных и образовательных центров России, расположенный в научном центре Академгородок. НГУ активно сотрудничает с институтами Сибирского отделения РАН, что обеспечивает высокий уровень подготовки специалистов в области науки и технологий.", "nsu.png", false, "Новосибирский государственный университет", 2 },
                    { 9, "ул. Мира, д. 19", 4, "Уральский федеральный университет имени первого Президента России Б.Н. Ельцина (УрФУ) — один из крупнейших федеральных университетов России, входит в топ-10 вузов страны. Университет предлагает широкий спектр образовательных программ, активно ведет научные исследования и международное сотрудничество.", "urfu.png", false, "Уральский федеральный университет", 2 },
                    { 10, "пр. Гагарина, д. 23", 5, "Нижегородский государственный университет имени Н.И. Лобачевского (ННГУ) — ведущий классический университет России, основанный в 1916 году. Университет предлагает программы бакалавриата, магистратуры и аспирантуры по различным направлениям, активно развивает научные исследования.", "unn.png", false, "Нижегородский государственный университет им. Н.И. Лобачевского", 2 },
                    { 11, "ул. Кремлевская, д. 18", 6, "Казанский (Приволжский) федеральный университет (КФУ) — один из старейших и крупнейших вузов России, основанный в 1804 году. КФУ предлагает широкий спектр образовательных программ и активно участвует в международных научных проектах.", "kfu.png", false, "Казанский (Приволжский) федеральный университет", 2 },
                    { 12, "пр. Ленина, д. 76", 7, "Южно-Уральский государственный университет (ЮУрГУ) — один из крупнейших и ведущих технических университетов России, расположенный в Челябинске. Университет активно занимается научными исследованиями и разработками, предлагает программы бакалавриата, магистратуры и аспирантуры.", "susurgu.png", false, "Южно-Уральский государственный университет", 2 },
                    { 13, "пр. Мира, д. 11", 8, "Омский государственный технический университет (ОмГТУ) — один из ведущих технических вузов Сибири, предлагающий образовательные программы в области инженерии, информационных технологий и менеджмента.", "omgtu.png", false, "Омский государственный технический университет", 2 },
                    { 14, "ул. Академика Павлова, д. 1", 9, "Самарский государственный университет (СамГУ) — один из ведущих вузов Поволжья, предлагающий образовательные программы в области естественных, гуманитарных и социальных наук.", "ssu.png", false, "Самарский государственный университет", 2 },
                    { 15, "ул. Большая Садовая, д. 105", 10, "Ростовский государственный университет (РГУ) — крупный вуз на юге России, предлагающий образовательные программы в различных областях науки и техники.", "rsu.png", false, "Ростовский государственный университет", 2 },
                    { 16, "ул. К. Маркса, д. 12", 11, "Уфимский государственный авиационный технический университет (УГАТУ) — ведущий технический вуз Башкортостана, специализирующийся на подготовке специалистов в области авиационной техники и технологий.", "ugatu.png", false, "Уфимский государственный авиационный технический университет", 2 },
                    { 17, "ул. Свободный проспект, д. 79", 12, "Сибирский федеральный университет (СФУ) — один из крупнейших вузов России, расположенный в Красноярске. Университет предлагает образовательные программы в области естественных, технических и гуманитарных наук.", "sfu.png", false, "Сибирский федеральный университет", 2 },
                    { 18, "ул. Университетская пл., д. 1", 13, "Воронежский государственный университет (ВГУ) — крупный классический университет, предлагающий образовательные программы в различных областях науки и техники.", "vsu.png", false, "Воронежский государственный университет", 2 },
                    { 19, "ул. Букирева, д. 15", 14, "Пермский государственный национальный исследовательский университет (ПГНИУ) — один из ведущих вузов Урала, предлагающий образовательные программы в области естественных, технических и гуманитарных наук.", "pstu.png", false, "Пермский государственный национальный исследовательский университет", 2 },
                    { 20, "пр. Ленина, д. 28", 15, "Волгоградский государственный технический университет (ВолгГТУ) — крупный технический вуз, предлагающий образовательные программы в области инженерии, информационных технологий и менеджмента.", "vstu.png", false, "Волгоградский государственный технический университет", 2 }
                });

            migrationBuilder.InsertData(
                table: "DisciplineEducationProgram",
                columns: new[] { "Id", "DisciplineId", "EducationProgramId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 15, 1 },
                    { 3, 6, 1 },
                    { 4, 1, 2 },
                    { 5, 15, 2 },
                    { 6, 6, 2 },
                    { 7, 1, 3 },
                    { 8, 15, 3 },
                    { 9, 6, 3 },
                    { 10, 1, 4 },
                    { 11, 15, 4 },
                    { 12, 5, 4 },
                    { 13, 1, 5 },
                    { 14, 15, 5 },
                    { 15, 6, 5 },
                    { 16, 1, 6 },
                    { 17, 15, 6 },
                    { 18, 5, 6 },
                    { 19, 1, 7 },
                    { 20, 15, 7 },
                    { 21, 6, 7 },
                    { 22, 1, 8 },
                    { 23, 15, 8 },
                    { 24, 6, 8 },
                    { 25, 1, 9 },
                    { 26, 15, 9 },
                    { 27, 6, 9 },
                    { 28, 1, 10 },
                    { 29, 15, 10 },
                    { 30, 6, 10 },
                    { 31, 1, 11 },
                    { 32, 15, 11 },
                    { 33, 5, 11 },
                    { 34, 1, 12 },
                    { 35, 15, 12 },
                    { 36, 6, 12 },
                    { 37, 1, 13 },
                    { 38, 15, 13 },
                    { 39, 5, 13 },
                    { 40, 1, 14 },
                    { 41, 15, 14 },
                    { 42, 2, 14 }
                });

            migrationBuilder.InsertData(
                table: "DisciplineEducationProgram",
                columns: new[] { "Id", "DisciplineId", "EducationProgramId" },
                values: new object[,]
                {
                    { 43, 1, 15 },
                    { 44, 15, 15 },
                    { 45, 5, 15 },
                    { 46, 1, 16 },
                    { 47, 15, 16 },
                    { 48, 5, 16 },
                    { 49, 1, 17 },
                    { 50, 15, 17 },
                    { 51, 6, 17 },
                    { 52, 1, 18 },
                    { 53, 15, 18 },
                    { 54, 6, 18 },
                    { 55, 1, 19 },
                    { 56, 15, 19 },
                    { 57, 5, 19 },
                    { 58, 1, 20 },
                    { 59, 15, 20 },
                    { 60, 5, 20 },
                    { 61, 1, 21 },
                    { 62, 15, 21 },
                    { 63, 6, 21 },
                    { 64, 1, 22 },
                    { 65, 15, 22 },
                    { 66, 6, 22 },
                    { 67, 1, 23 },
                    { 68, 15, 23 },
                    { 69, 6, 23 },
                    { 70, 1, 24 },
                    { 71, 15, 24 },
                    { 72, 6, 24 },
                    { 73, 1, 25 },
                    { 74, 15, 25 },
                    { 75, 6, 25 },
                    { 76, 1, 26 },
                    { 77, 15, 26 },
                    { 78, 6, 26 },
                    { 79, 1, 27 },
                    { 80, 15, 27 },
                    { 81, 6, 27 },
                    { 82, 1, 28 },
                    { 83, 15, 28 },
                    { 84, 6, 28 }
                });

            migrationBuilder.InsertData(
                table: "DisciplineEducationProgram",
                columns: new[] { "Id", "DisciplineId", "EducationProgramId" },
                values: new object[,]
                {
                    { 85, 1, 29 },
                    { 86, 15, 29 },
                    { 87, 6, 29 },
                    { 88, 1, 30 },
                    { 89, 15, 30 },
                    { 90, 6, 30 }
                });

            migrationBuilder.InsertData(
                table: "EducationalOrganizationContact",
                columns: new[] { "Id", "EducationalOrganizationId", "TypeContactId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "info@msu.ru" },
                    { 2, 1, 2, "(495) 939-10-00" },
                    { 3, 1, 3, "http://www.msu.ru" },
                    { 4, 2, 1, "info@mipt.ru" },
                    { 5, 2, 2, "(495) 408-48-00" },
                    { 6, 2, 3, "http://www.mipt.ru" },
                    { 7, 3, 1, "rector@mephi.ru" },
                    { 8, 3, 2, "(499) 324-84-17" },
                    { 9, 3, 2, "(495) 785-55-25" },
                    { 10, 3, 3, "http://www.mephi.ru" },
                    { 11, 4, 1, "bauman@bmstu.ru" },
                    { 12, 4, 2, "(499) 263-63-91" },
                    { 13, 4, 3, "http://www.bmstu.ru" },
                    { 14, 5, 1, "info@prezcollege.ru" },
                    { 15, 5, 2, "(495) 123-45-67" },
                    { 16, 5, 3, "http://www.prezcollege.ru" },
                    { 17, 6, 1, "info@kst.edu.ru" },
                    { 18, 6, 2, "(495) 987-65-43" },
                    { 19, 6, 3, "http://www.kst.edu.ru" },
                    { 20, 7, 1, "info@spbu.ru" },
                    { 21, 7, 2, "(812) 328-20-00" },
                    { 22, 7, 3, "http://www.spbu.ru" },
                    { 23, 8, 1, "info@nspu.ru" },
                    { 24, 8, 2, "(383) 217-02-22" },
                    { 25, 8, 3, "http://www.nspu.ru" },
                    { 26, 9, 1, "info@urfu.ru" },
                    { 27, 9, 2, "(343) 375-46-46" },
                    { 28, 9, 3, "http://www.urfu.ru" },
                    { 29, 10, 1, "info@unn.ru" },
                    { 30, 10, 2, "(831) 462-30-00" },
                    { 31, 10, 3, "http://www.unn.ru" }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "EducationalOrganizationId", "Name", "TextFeedback" },
                values: new object[,]
                {
                    { 1, 1, "Мария Стеклова", "Закончила бакалавриат в МГУ по специальности математика и компьютерные науки. Преподаватели - настоящие профессионалы с огромным опытом. Учиться было сложно, но очень интересно!" },
                    { 2, 1, "Алексей Иванов", "Учился в магистратуре по фундаментальной информатике. Программа очень насыщенная, требовалось много усилий, но это того стоило. Спасибо преподавателям за их поддержку!" },
                    { 3, 2, "Екатерина Петрова", "Закончила бакалавриат по прикладной математике и информатике в МФТИ. Учиться было непросто, но преподаватели всегда помогали и поддерживали. Отличный вуз!" },
                    { 4, 2, "Дмитрий Смирнов", "Получил степень магистра по прикладной математике и физике. Преподаватели - эксперты в своей области, учебный процесс был сложным, но интересным." },
                    { 5, 3, "Ольга Сидорова", "Училась на бакалавриате по программированию в МИФИ. Преподаватели очень компетентные, но учиться было нелегко. Университет предоставляет отличные возможности для развития." }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "Id", "EducationalOrganizationId", "Name", "TextFeedback" },
                values: new object[,]
                {
                    { 6, 3, "Иван Кузнецов", "Заканчиваю магистратуру по киберфизическим системам. Преподаватели всегда готовы помочь, но учебная нагрузка значительная. Это отличный опыт!" },
                    { 7, 4, "Анастасия Воронцова", "Закончила бакалавриат по информационной безопасности в МГТУ. Учеба была очень сложной, но преподаватели - профессионалы своего дела, всегда помогали разобраться." },
                    { 8, 4, "Сергей Михайлов", "Получил степень магистра по интеллектуальным системам и технологиям. Учиться было трудно, но очень интересно благодаря опытным преподавателям." },
                    { 9, 5, "Наталья Николаева", "Закончила колледж по биотехнологии. Преподаватели обладают большим опытом, учиться было непросто, но знания полученные здесь бесценны." },
                    { 10, 5, "Виктор Павлов", "Учился на биологическом направлении. Преподаватели отличные, учёба давалась тяжело, но я доволен результатом." },
                    { 11, 6, "Елена Новикова", "Получила профессию по информационным системам. Преподаватели помогали на каждом шагу, учиться было интересно и познавательно." },
                    { 12, 6, "Михаил Петров", "Закончила колледж по специальности информационные системы и программирование. Учеба была насыщенной и сложной, но преподаватели всегда поддерживали." },
                    { 13, 7, "Андрей Смирнов", "Получил бакалавра по информационным системам и технологиям в бизнесе. Преподаватели - профессионалы, учеба была сложной, но это стоило того." },
                    { 14, 7, "Анна Васильева", "Училась на специалитете по информационной безопасности. Учеба была непростой, но преподаватели всегда были готовы помочь." },
                    { 15, 8, "Оксана Федорова", "Закончила бакалавриат по программной инженерии. Преподаватели отличные, учебный процесс насыщенный, учиться было сложно, но интересно." },
                    { 16, 8, "Евгений Иванов", "Учился на специалитете по информационным системам и технологиям в экономике. Преподаватели всегда помогали, учиться было непросто." },
                    { 17, 9, "Валерия Петрова", "Закончила бакалавриат по информатике и вычислительной технике. Учиться было трудно, но преподаватели всегда поддерживали." },
                    { 18, 9, "Александр Сидоров", "Получил магистра по программному обеспечению информационных технологий. Учеба была сложной, но преподаватели помогали на каждом этапе." },
                    { 19, 10, "Ксения Смирнова", "Закончила бакалавриат по информационным системам в здравоохранении. Учеба была интересной и сложной, преподаватели отличные." },
                    { 20, 10, "Владимир Петров", "Учился на специалитете по антикризисному управлению. Преподаватели профессионалы своего дела, учеба была насыщенной и трудной." },
                    { 21, 11, "Елизавета Павлова", "Закончила бакалавриат по информационным технологиям в юриспруденции. Учиться было сложно, но преподаватели всегда поддерживали." },
                    { 22, 11, "Максим Иванов", "Учился на специалитете по наноинженерии. Преподаватели - профессионалы, учебный процесс был сложным, но интересным." },
                    { 23, 12, "Ольга Смирнова", "Закончила бакалавриат по веб-технологиям. Учеба была сложной, но преподаватели всегда помогали разобраться в трудных темах." },
                    { 24, 12, "Игорь Кузнецов", "Получил магистра по технологиям промышленного программирования. Преподаватели - профессионалы, учебный процесс был трудным, но интересным." },
                    { 25, 13, "Елена Иванова", "Закончила бакалавриат по технологиям управления организацией. Учеба была сложной, но преподаватели всегда поддерживали." },
                    { 26, 13, "Алексей Смирнов", "Учился на специалитете по программно-аппаратным комплексам защиты информации. Преподаватели отличные, учебный процесс был насыщенным." },
                    { 27, 14, "Оксана Новикова", "Закончила бакалавриат по информационным системам. Учеба была сложной, но преподаватели всегда помогали." },
                    { 28, 14, "Евгений Петров", "Учился на специалитете по компьютерному моделированию и комплексной автоматизации проектирования. Преподаватели профессионалы, учебный процесс был трудным, но интересным." },
                    { 29, 15, "Мария Смирнова", "Закончила бакалавриат по антикризисному управлению. Учеба была сложной, но преподаватели всегда поддерживали." },
                    { 30, 15, "Владимир Кузнецов", "Учился на магистратуре по киберфизическим системам. Преподаватели профессионалы, учебный процесс был насыщенным." },
                    { 31, 16, "Анна Петрова", "Закончила бакалавриат по информатике и вычислительной технике. Учеба была сложной, но преподаватели всегда поддерживали." },
                    { 32, 16, "Иван Васильев", "Получил магистра по программно-аппаратным комплексам защиты информации. Преподаватели отличные, учебный процесс был трудным." },
                    { 33, 17, "Наталья Смирнова", "Закончила бакалавриат по фундаментальной математике и механике. Учеба была сложной, но преподаватели всегда поддерживали." },
                    { 34, 17, "Сергей Иванов", "Учился на специалитете по управлению инновациями. Преподаватели - профессионалы, учебный процесс был трудным, но интересным." },
                    { 35, 18, "Марина Кузнецова", "Закончила бакалавриат по информационным системам. Учеба была сложной, но преподаватели всегда помогали разобраться в трудных темах." },
                    { 36, 18, "Александр Смирнов", "Получил магистра по программно-аппаратным комплексам защиты информации. Преподаватели профессионалы, учебный процесс был интересным." },
                    { 37, 19, "Ирина Петрова", "Закончила бакалавриат по химии. Учеба была сложной, но преподаватели всегда поддерживали." },
                    { 38, 19, "Дмитрий Васильев", "Учился на магистратуре по физической химии. Преподаватели - профессионалы, учебный процесс был насыщенным и интересным." },
                    { 39, 20, "Ольга Смирнова", "Закончила бакалавриат по информационным системам. Учеба была сложной, но преподаватели всегда помогали." },
                    { 40, 20, "Алексей Петров", "Учился на специалитете по программно-аппаратным комплексам защиты информации. Преподаватели профессионалы, учебный процесс был трудным, но интересным." }
                });

            migrationBuilder.InsertData(
                table: "ProgramEducationalOrganization",
                columns: new[] { "Id", "Description", "Duration", "EducationLevelId", "EducationProgramId", "EducationalOrganizationId", "IsDeleted", "TuitionPerYear" },
                values: new object[,]
                {
                    { 1, "Программа обучения по математике и компьютерным наукам (бакалавриат).", 4, 3, 31, 1, false, 390000m },
                    { 2, "Программа обучения по фундаментальной информатике и информационным технологиям (специалитет).", 5, 4, 32, 1, false, 390000m },
                    { 3, "Программа обучения по математическому и программному обеспечению вычислительных машин и комплексов (магистратура).", 2, 5, 33, 1, false, 430000m },
                    { 4, "Программа обучения по прикладной математике и информатике (бакалавриат).", 4, 3, 34, 2, false, 400000m },
                    { 5, "Программа обучения по прикладной математике и физике (магистратура).", 2, 5, 35, 2, false, 450000m },
                    { 6, "Программа обучения по программированию (бакалавриат).", 4, 3, 7, 3, false, 350000m },
                    { 7, "Программа обучения по информационной безопасности (специалитет).", 5, 4, 12, 3, false, 380000m }
                });

            migrationBuilder.InsertData(
                table: "ProgramEducationalOrganization",
                columns: new[] { "Id", "Description", "Duration", "EducationLevelId", "EducationProgramId", "EducationalOrganizationId", "IsDeleted", "TuitionPerYear" },
                values: new object[,]
                {
                    { 8, "Программа обучения по киберфизическим системам (магистратура).", 2, 5, 26, 3, false, 400000m },
                    { 9, "Программа обучения по информационной безопасности (бакалавриат).", 4, 3, 12, 4, false, 380000m },
                    { 10, "Программа обучения по интеллектуальным системам и технологиям (специалитет).", 5, 4, 18, 4, false, 420000m },
                    { 11, "Программа обучения по киберфизическим системам (магистратура).", 2, 5, 26, 4, false, 450000m },
                    { 12, "Программа обучения по биологии (профессия).", 3, 1, 50, 5, false, 200000m },
                    { 13, "Программа обучения по биотехнологии (специальность).", 3, 2, 51, 5, false, 220000m },
                    { 14, "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных коммерческих и бюджетных учреждений, программирование, защита информации и др.).", 4, 1, 30, 6, false, 140000m },
                    { 15, "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных коммерческих и бюджетных учреждений, программирование, защита информации и др.).", 3, 2, 30, 6, false, 150000m },
                    { 16, "Программа обучения по информационным системам и технологиям в бизнесе (бакалавриат).", 4, 3, 11, 7, false, 360000m },
                    { 17, "Программа обучения по информационной безопасности (специалитет).", 5, 4, 12, 7, false, 390000m },
                    { 18, "Программа обучения по технологиям управления организацией (магистратура).", 2, 5, 19, 7, false, 420000m },
                    { 19, "Программа обучения по программной инженерии (бакалавриат).", 4, 3, 5, 8, false, 350000m },
                    { 20, "Программа обучения по информационным системам и технологиям в экономике (специалитет).", 5, 4, 6, 8, false, 370000m },
                    { 21, "Программа обучения по математическому обеспечению и администрированию информационных систем (магистратура).", 2, 5, 9, 8, false, 400000m },
                    { 22, "Программа обучения по информатике и вычислительной технике (бакалавриат).", 4, 3, 17, 9, false, 360000m },
                    { 23, "Программа обучения по интеллектуальным системам и технологиям (специалитет).", 5, 4, 18, 9, false, 380000m },
                    { 24, "Программа обучения по программному обеспечению информационных технологий (магистратура).", 2, 5, 21, 9, false, 420000m },
                    { 25, "Программа обучения по информационным системам и технологиям в здравоохранении (бакалавриат).", 4, 3, 10, 10, false, 350000m },
                    { 26, "Программа обучения по антикризисному управлению (специалитет).", 5, 4, 15, 10, false, 380000m },
                    { 27, "Программа обучения по программному обеспечению экономической деятельности (магистратура).", 2, 5, 20, 10, false, 400000m },
                    { 28, "Программа обучения по информационным технологиям в юриспруденции (бакалавриат).", 4, 3, 13, 11, false, 340000m },
                    { 29, "Программа обучения по наноинженерии (специалитет).", 5, 4, 14, 11, false, 360000m },
                    { 30, "Программа обучения по управлению инновациями (магистратура).", 2, 5, 16, 11, false, 400000m },
                    { 31, "Программа обучения по веб-технологиям (бакалавриат).", 4, 3, 8, 12, false, 330000m },
                    { 32, "Программа обучения по прикладному программированию (специалитет).", 5, 4, 24, 12, false, 350000m },
                    { 33, "Программа обучения по технологиям промышленного программирования (магистратура).", 2, 5, 27, 12, false, 370000m },
                    { 34, "Программа обучения по технологиям управления организацией (бакалавриат).", 4, 3, 19, 13, false, 340000m },
                    { 35, "Программа обучения по программно-аппаратным комплексам защиты информации (специалитет).", 5, 4, 22, 13, false, 360000m },
                    { 36, "Программа обучения по технологиям программирования систем и сетей (магистратура).", 2, 5, 28, 13, false, 380000m },
                    { 37, "Программа обучения по информационным системам (бакалавриат).", 4, 3, 29, 14, false, 350000m },
                    { 38, "Программа обучения по компьютерному моделированию и комплексной автоматизации проектирования (специалитет).", 5, 4, 23, 14, false, 370000m },
                    { 39, "Программа обучения по программированию в интеллектуальных робототехнических системах (магистратура).", 2, 5, 25, 14, false, 390000m },
                    { 40, "Программа обучения по антикризисному управлению (бакалавриат).", 4, 3, 15, 15, false, 330000m },
                    { 41, "Программа обучения по программному обеспечению экономической деятельности (специалитет).", 5, 4, 20, 15, false, 350000m }
                });

            migrationBuilder.InsertData(
                table: "PassingScore",
                columns: new[] { "Id", "IsBudget", "ProgramEducationalOrganizationId", "Score", "Year" },
                values: new object[,]
                {
                    { 1, true, 1, 290.0, (short)2023 },
                    { 2, false, 1, 180.0, (short)2023 },
                    { 3, false, 6, 192.0, (short)2023 },
                    { 4, true, 6, 295.0, (short)2023 },
                    { 5, true, 7, 4.5999999999999996, (short)2023 },
                    { 6, true, 8, 4.2999999999999998, (short)2023 },
                    { 7, false, 7, 4.0999999999999996, (short)2023 },
                    { 8, false, 8, 3.7999999999999998, (short)2023 },
                    { 9, true, 2, 310.0, (short)2023 },
                    { 10, false, 2, 200.0, (short)2023 },
                    { 11, true, 3, 300.0, (short)2023 },
                    { 12, false, 3, 210.0, (short)2023 },
                    { 13, true, 4, 320.0, (short)2023 },
                    { 14, false, 4, 230.0, (short)2023 },
                    { 15, true, 5, 290.0, (short)2023 },
                    { 16, false, 5, 180.0, (short)2023 },
                    { 17, true, 9, 310.0, (short)2023 },
                    { 18, false, 9, 190.0, (short)2023 },
                    { 19, true, 10, 300.0, (short)2023 },
                    { 20, false, 10, 185.0, (short)2023 },
                    { 21, true, 11, 295.0, (short)2023 },
                    { 22, false, 11, 180.0, (short)2023 },
                    { 23, true, 12, 285.0, (short)2023 },
                    { 24, false, 12, 175.0, (short)2023 },
                    { 25, true, 13, 290.0, (short)2023 },
                    { 26, false, 13, 185.0, (short)2023 },
                    { 27, true, 14, 280.0, (short)2023 },
                    { 28, false, 14, 170.0, (short)2023 },
                    { 29, true, 15, 275.0, (short)2023 },
                    { 30, false, 15, 165.0, (short)2023 },
                    { 31, true, 16, 290.0, (short)2023 },
                    { 32, false, 16, 180.0, (short)2023 },
                    { 33, true, 17, 285.0, (short)2023 },
                    { 34, false, 17, 175.0, (short)2023 },
                    { 35, true, 18, 290.0, (short)2023 },
                    { 36, false, 18, 180.0, (short)2023 },
                    { 37, true, 19, 295.0, (short)2023 },
                    { 38, false, 19, 185.0, (short)2023 },
                    { 39, true, 20, 300.0, (short)2023 },
                    { 40, false, 20, 190.0, (short)2023 },
                    { 41, true, 21, 310.0, (short)2023 },
                    { 42, false, 21, 200.0, (short)2023 }
                });

            migrationBuilder.InsertData(
                table: "PassingScore",
                columns: new[] { "Id", "IsBudget", "ProgramEducationalOrganizationId", "Score", "Year" },
                values: new object[,]
                {
                    { 43, true, 22, 320.0, (short)2023 },
                    { 44, false, 22, 210.0, (short)2023 },
                    { 45, true, 23, 315.0, (short)2023 },
                    { 46, false, 23, 205.0, (short)2023 },
                    { 47, true, 24, 310.0, (short)2023 },
                    { 48, false, 24, 200.0, (short)2023 },
                    { 49, true, 25, 320.0, (short)2023 },
                    { 50, false, 25, 210.0, (short)2023 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineEducationProgram_DisciplineId",
                table: "DisciplineEducationProgram",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineEducationProgram_EducationProgramId",
                table: "DisciplineEducationProgram",
                column: "EducationProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalOrganization_CityId",
                table: "EducationalOrganization",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalOrganization_TypeId",
                table: "EducationalOrganization",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalOrganizationContact_EducationalOrganizationId",
                table: "EducationalOrganizationContact",
                column: "EducationalOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalOrganizationContact_TypeContactId",
                table: "EducationalOrganizationContact",
                column: "TypeContactId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationProgram_SpecializationId",
                table: "EducationProgram",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_EducationalOrganizationId",
                table: "Feedback",
                column: "EducationalOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PassingScore_ProgramEducationalOrganizationId",
                table: "PassingScore",
                column: "ProgramEducationalOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramEducationalOrganization_EducationalOrganizationId",
                table: "ProgramEducationalOrganization",
                column: "EducationalOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramEducationalOrganization_EducationLevelId",
                table: "ProgramEducationalOrganization",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramEducationalOrganization_EducationProgramId",
                table: "ProgramEducationalOrganization",
                column: "EducationProgramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisciplineEducationProgram");

            migrationBuilder.DropTable(
                name: "EducationalOrganizationContact");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "PassingScore");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Discipline");

            migrationBuilder.DropTable(
                name: "TypeContact");

            migrationBuilder.DropTable(
                name: "ProgramEducationalOrganization");

            migrationBuilder.DropTable(
                name: "EducationalOrganization");

            migrationBuilder.DropTable(
                name: "EducationLevel");

            migrationBuilder.DropTable(
                name: "EducationProgram");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "TypeEducationalOrganization");

            migrationBuilder.DropTable(
                name: "Specialization");
        }
    }
}
