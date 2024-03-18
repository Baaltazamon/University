using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
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
                name: "EducationProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecializationId = table.Column<int>(type: "int", nullable: false),
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
                name: "ProgramEducationalOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationProgramId = table.Column<int>(type: "int", nullable: false),
                    EducationLevelId = table.Column<int>(type: "int", nullable: false),
                    EducationalOrganizationId = table.Column<int>(type: "int", nullable: false),
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
                    { 8, null, false, "Архитектура" }
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
                columns: new[] { "Id", "Description", "SpecializationId", "Name" },
                values: new object[,]
                {
                    { 1, null, 2, "01.05.01 Фундаментальные математика и механика" },
                    { 2, null, 1, "09.03.01 Прикладная информатика" },
                    { 3, null, 2, "09.03.02 Информационные системы и технологии" },
                    { 4, null, 2, "09.03.03 Прикладная информатика в экономике" },
                    { 5, null, 2, "09.03.04 Программная инженерия" },
                    { 6, null, 2, "09.03.05 Информационные системы и технологии (в экономике)" },
                    { 7, null, 2, "09.03.06 Программирование" },
                    { 8, null, 2, "09.03.07 Веб-технологии" },
                    { 9, null, 2, "09.03.08 Математическое обеспечение и администрирование информационных систем" },
                    { 10, null, 2, "09.03.09 Информационные системы и технологии (в здравоохранении)" },
                    { 11, null, 2, "09.03.10 Информационные системы и технологии (в бизнесе)" },
                    { 12, null, 2, "09.03.11 Информационная безопасность" },
                    { 13, null, 2, "09.03.12 Информационные технологии в юриспруденции" },
                    { 14, null, 2, "09.03.13 Наноинженерия" },
                    { 15, null, 2, "09.03.14 Антикризисное управление" },
                    { 16, null, 2, "09.03.15 Управление инновациями" },
                    { 17, null, 2, "09.03.16 Информатика и вычислительная техника" },
                    { 18, null, 2, "09.03.17 Интеллектуальные системы и технологии" },
                    { 19, null, 2, "09.03.18 Технологии управления организацией" },
                    { 20, null, 2, "09.03.19 Программное обеспечение экономической деятельности" },
                    { 21, null, 2, "09.03.20 Программное обеспечение информационных технологий" },
                    { 22, null, 2, "09.03.21 Программно-аппаратные комплексы защиты информации" },
                    { 23, null, 2, "09.03.22 Компьютерное моделирование и комплексная автоматизация проектирования" },
                    { 24, null, 2, "09.03.23 Прикладное программирование" },
                    { 25, null, 2, "09.03.24 Программирование в интеллектуальных робототехнических системах" },
                    { 26, null, 2, "09.03.25 Киберфизические системы" },
                    { 27, null, 2, "09.03.26 Технологии промышленного программирования" },
                    { 28, null, 2, "09.03.27 Технологии программирования систем и сетей" },
                    { 29, null, 2, "09.03.28 Информационные системы" },
                    { 30, null, 2, "09.02.07 Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "EducationalOrganization",
                columns: new[] { "Id", "Address", "CityId", "Description", "is_deleted", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, "ул. Ленинские Горы, 1", 1, "Сегодня Московский университет — крупнейший классический университет России, в котором обучается более 45 тысяч человек из всех регионов страны (на разных формах обучения). В МГУ 40 факультетов (за последние 20 лет создан 21 факультет), 15 научно-исследовательских институтов, около 750 кафедр, отделов и лабораторий, Медицинский научно-образовательный центр, Научная библиотека, 4 музея, Ботанический сад, Научный парк, филиалы в Севастополе, Ташкенте, Астане, Баку, Душанбе, Ереване. \r\n\r\nМГУ осуществляет обучение по собственным образовательным уникальным 6‑летним образовательным стандартам, реализуемым в двух формах: интегрированная магистратура (нормативный срок обучения 4 года в бакалавриате и 2 года в магистратуре) и специалитет (нормативный срок обучения 6 лет). Особенностью интегрированной магистратуры является непрерывная подготовка студентов (на протяжении 6 лет обучения) по выбранному направлению, что является гарантией качественной подготовки специалистов в избранной области. В условиях перехода страны на двухуровневую систему высшего образования план приема в бюджетную магистратуру МГУ позволяет продолжить обучение в магистратуре всех выпускников МГУ (бакалавров), способных и готовых к дальнейшему обучению.", false, "Московский государственный университет им. М.В. Ломоносова", 2 },
                    { 2, "Институтский пер., д. 9", 1, "Московский физико-технический институт (МФТИ) является ведущим техническим университетом России. Система образования сфокусирована на глубоком изучении фундаментальных наук в сочетании с активным участием студентов в исследованиях в крупнейших российских и международных научных центрах. В МФТИ используется уникальная «Система Физтеха», разработанная основателями института и его первыми профессорами Петром Капицей, Николаем Семеновым и Львом Ландау. МФТИ имеет статус Государственного университета, что позволяет получать регулярную прямую финансовую и организационную поддержку от Правительства Российской Федерации. Институт является участником программы 5–100, направленной на развитие исследовательской деятельности, организованной в самом МФТИ, а также выход Физтеха в верхние позиции мировых университетских рейтингов.", false, "Московский физико-технический институт", 2 },
                    { 3, "Каширское ш., д. 31", 1, "«Мекка» физиков-ядерщиков, базовый вуз атомной промышленности России располагает рядом высокотехничных установок, в том числе, исследовательским ядерным реактором. Также, МИФИ занимает лидирующие позиции по подготовке программистов и специалистов по информационной безопасности. Здесь активно используется компьютерная поддержка учебного процесса: электронные учебники, компьютерные лабораторные работы, тренажеры. Университет сотрудничает с несколькими десятками университетов по всему миру. Многие старшекурсники проходят обучение и стажировку в лучших ядерных центрах Германии, США", false, "Национальный исследовательский ядерный университет «МИФИ»", 2 },
                    { 4, "2-я Бауманская ул., д. 5, стр. 1", 1, "МГТУ им. Н.Э. Баумана является одним из ведущих технических вузов страны. Университет ведет подготовку инженеров с 1830 года. На сегодняшний день в университете обучают по большому количеству направлений. Выпускники МГТУ становятся очень востребованными у работодателей на рынке труда. Ключевой особенностью обучения является сочетание теоретических и практических знаний. Университет занимается научными исследованиями и разработками.", false, "Московский государственный технический университет им. Н.Э. Баумана", 2 },
                    { 5, "ул. Маршала Тимошенко, д. 19", 1, "Медицинский колледж имеет богатый опыт профессиональной подготовки квалифицированных кадров среднего звена, их переподготовки и усовершенствования, вносит существенный вклад в обеспечение лечебно-диагностической работы учреждений здравоохранения Управления делами Президента РФ.", false, "Медицинский колледж Управления делами Президента Российской Федерации", 1 },
                    { 6, "Хибинский проезд, дом 10", 1, "ГБПОУ КСТ имеет 4 обустроенных актовых зала в каждом подразделении для обучающихся, в том числе инвалидов и лиц с ограниченными возможностями здоровья, которые оснащены проекторами, звуковой аппаратурой. В 6 отдельно оборудованных кабинетах для занятий дополнительным образованием (обработка керамики, работы по дереву и др.) обучающиеся в том числе инвалидов и лиц с ограниченными возможностями здоровья занимаются научно-техническим и художественно-прикладным творчеством. В литературно-музыкальной гостиной в Учебном корпусе № 3 «Ярославский»  (Хибинский проезд, дом 10) проводятся тематические встречи с интересными людьми, литературные вечера, заседания студенческого самоуправления и женского клуба и другие мероприятия. ГБПОУ КСТ располагает широким спектром персональных компьютеров и информационного оборудования, которое в первую очередь используется в учебном и воспитательном процессах", false, "Колледж современных технологий имени Героя Советского Союза М.Ф. Панова", 1 }
                });

            migrationBuilder.InsertData(
                table: "DisciplineEducationProgram",
                columns: new[] { "Id", "DisciplineId", "EducationProgramId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 15, 2 },
                    { 3, 6, 2 },
                    { 4, 1, 8 },
                    { 5, 15, 8 },
                    { 6, 6, 8 },
                    { 7, 1, 30 },
                    { 8, 15, 30 },
                    { 9, 6, 30 }
                });

            migrationBuilder.InsertData(
                table: "EducationalOrganizationContact",
                columns: new[] { "Id", "EducationalOrganizationId", "TypeContactId", "Value" },
                values: new object[,]
                {
                    { 1, 3, 1, "rector@mephi.ru" },
                    { 2, 3, 2, "(499) 324-84-17" },
                    { 3, 3, 2, "(495) 785-55-25" },
                    { 4, 4, 2, "(499) 263-63-91" },
                    { 5, 4, 1, "bauman@bmstu.ru" }
                });

            migrationBuilder.InsertData(
                table: "ProgramEducationalOrganization",
                columns: new[] { "Id", "Description", "Duration", "EducationLevelId", "EducationProgramId", "EducationalOrganizationId", "TuitionPerYear" },
                values: new object[,]
                {
                    { 1, "Вы освоите программирование, научитесь разрабатывать и обслуживать программное обеспечение, проектировать и сопровождать информационные системы, анализировать данные и обучать нейронные сети, создавать AI-инструменты. ", 4, 3, 30, 1, 390000m },
                    { 2, "Сфера связи, информационных и коммуникационных технологий — одна из самых перспективных областей. Тот, кто владеет информационными технологиями, владеет будущим. Разработчики программного обеспечения (ПО) создают и внедряют различные информационные системы на предприятия, адаптируют их под конкретные бизнес-задачи, обеспечивают стабильную работу информационно-технической инфраструктуры и сервисов компании. ", 5, 4, 30, 1, 390000m },
                    { 3, "Специальность охватывает достаточно широкий спектр сфер профессиональной деятельности, что позволяет получить знания о безопасности информационных систем, техническом обслуживании и ремонте компьютеров, администрировании сетей, прикладном и системном программировании, WEB-дизайне и графическом моделировании объектов. Позволяет получить опыт в разработке и интеграции модулей программного обеспечения, администрировании баз данных, сопровождении программного обеспечения.", 2, 5, 30, 1, 430000m },
                    { 4, "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных коммерческих и бюджетных учреждений, программирование, защита информации и др.)", 4, 1, 30, 6, 140000m },
                    { 5, "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных коммерческих и бюджетных учреждений, программирование, защита информации и др.)", 3, 2, 30, 6, 150000m },
                    { 6, "Вы освоите программирование, научитесь разрабатывать и обслуживать программное обеспечение, проектировать и сопровождать информационные системы, анализировать данные и обучать нейронные сети, создавать AI-инструменты. ", 4, 3, 30, 1, 350000m }
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
                    { 5, true, 5, 4.5999999999999996, (short)2023 },
                    { 6, true, 4, 4.2999999999999998, (short)2023 },
                    { 7, false, 5, 4.0999999999999996, (short)2023 },
                    { 8, false, 4, 3.7999999999999998, (short)2023 }
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
                name: "PassingScore");

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
