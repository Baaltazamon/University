using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Data.Context
{
    public class UniversityDbContext : DbContext
    {
        
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Discipline>().HasData(new Discipline[]
            {
                new Discipline
                {
                    Id = 1,
                    Name = "Математика (профильный уровень)"
                },
                new Discipline
                {
                    Id = 2,
                    Name = "Физика"
                },
                new Discipline
                {
                    Id = 3,
                    Name = "Химия"
                },
                new Discipline
                {
                    Id = 4,
                    Name = "История"
                },
                new Discipline
                {
                    Id = 5,
                    Name = "Обществознание"
                },
                new Discipline
                {
                    Id = 6,
                    Name = "Информатика"
                },
                new Discipline
                {
                    Id = 7,
                    Name = "Биология"
                },
                new Discipline
                {
                    Id = 8,
                    Name = "География"
                },
                new Discipline
                {
                    Id = 9,
                    Name = "Иностранный язык"
                },
                new Discipline
                {
                    Id = 13,
                    Name = "Литература"
                },
                new Discipline
                {
                    Id = 14,
                    Name = "Математика (базовый уровень)"
                },
                new Discipline
                {
                    Id = 15,
                    Name = "Русский язык"
                },
            });
            modelBuilder.Entity<Specialization>().HasData(new Specialization[]
            {
                new Specialization
                {
                    Id = 1,
                    Name = "Информатика и вычислительная техника"
                },
                new Specialization
                {
                    Id = 2,
                    Name = "Математика и механика"
                },
                new Specialization
                {
                    Id = 3,
                    Name = "Компьютерные и информационные науки"
                },
                new Specialization
                {
                    Id = 4,
                    Name = "Физика и астрономия"
                },
                new Specialization
                {
                    Id = 5,
                    Name = "Химия"
                },
                new Specialization
                {
                    Id = 6,
                    Name = "Науки о Земле"
                },
                new Specialization
                {
                    Id = 7,
                    Name = "Биологические науки"
                },
                new Specialization
                {
                    Id = 8,
                    Name = "Архитектура"
                }
            });
            modelBuilder.Entity<EducationProgram>().HasData(new EducationProgram[]
            {
                new EducationProgram { Id = 1, Name = "01.05.01 Фундаментальные математика и механика", EducationalOrganizationSpecializationId = 2, Image = "mahmat.png"},
                new EducationProgram { Id = 2, Name = "09.03.01 Прикладная информатика", EducationalOrganizationSpecializationId = 1, Image = "prinfo.png" },
                new EducationProgram { Id = 3, Name = "09.03.02 Информационные системы и технологии", EducationalOrganizationSpecializationId = 1, Image = "it.png" },
                new EducationProgram { Id = 4, Name = "09.03.03 Прикладная информатика в экономике", EducationalOrganizationSpecializationId = 1, Image = "ite.png" },
                new EducationProgram { Id = 5, Name = "09.03.04 Программная инженерия", EducationalOrganizationSpecializationId = 1 , Image = "iteng.png"},
                new EducationProgram { Id = 6, Name = "09.03.05 Информационные системы и технологии (в экономике)" , EducationalOrganizationSpecializationId = 1, Image = "itec.png"},
                new EducationProgram { Id = 7, Name = "09.03.06 Программирование", EducationalOrganizationSpecializationId = 1 , Image = "it2.png"},
                new EducationProgram { Id = 8, Name = "09.03.07 Веб-технологии", EducationalOrganizationSpecializationId = 1 , Image = "it3.png"},
                new EducationProgram { Id = 9, Name = "09.03.08 Математическое обеспечение и администрирование информационных систем" , EducationalOrganizationSpecializationId = 1, Image = "it4.png"},
                new EducationProgram { Id = 10, Name = "09.03.09 Информационные системы и технологии (в здравоохранении)", EducationalOrganizationSpecializationId = 1 , Image = "it5.png"},
                new EducationProgram { Id = 11, Name = "09.03.10 Информационные системы и технологии (в бизнесе)", EducationalOrganizationSpecializationId = 1 , Image = "it6.png"},
                new EducationProgram { Id = 12, Name = "09.03.11 Информационная безопасность", EducationalOrganizationSpecializationId = 1 , Image = "it7.png"},
                new EducationProgram { Id = 13, Name = "09.03.12 Информационные технологии в юриспруденции", EducationalOrganizationSpecializationId = 1 , Image = "it8.png"},
                new EducationProgram { Id = 14, Name = "09.03.13 Наноинженерия", EducationalOrganizationSpecializationId = 1 , Image = "it9.png"},
                new EducationProgram { Id = 15, Name = "09.03.14 Антикризисное управление", EducationalOrganizationSpecializationId = 1 , Image = "it11.png"},
                new EducationProgram { Id = 16, Name = "09.03.15 Управление инновациями", EducationalOrganizationSpecializationId = 1 , Image = "it12.png"},
                new EducationProgram { Id = 17, Name = "09.03.16 Информатика и вычислительная техника", EducationalOrganizationSpecializationId = 1 , Image = "it13.png"},
                new EducationProgram { Id = 18, Name = "09.03.17 Интеллектуальные системы и технологии", EducationalOrganizationSpecializationId = 1 , Image = "it14.png"},
                new EducationProgram { Id = 19, Name = "09.03.18 Технологии управления организацией", EducationalOrganizationSpecializationId = 1 , Image = "it15.png"},
                new EducationProgram { Id = 20, Name = "09.03.19 Программное обеспечение экономической деятельности", EducationalOrganizationSpecializationId = 1 , Image = "it16.png"},
                new EducationProgram { Id = 21, Name = "09.03.20 Программное обеспечение информационных технологий", EducationalOrganizationSpecializationId = 1 , Image = "it17.png"},
                new EducationProgram { Id = 22, Name = "09.03.21 Программно-аппаратные комплексы защиты информации", EducationalOrganizationSpecializationId = 1 , Image = "it18.png"},
                new EducationProgram { Id = 23, Name = "09.03.22 Компьютерное моделирование и комплексная автоматизация проектирования", EducationalOrganizationSpecializationId = 1 , Image = "it19.png"},
                new EducationProgram { Id = 24, Name = "09.03.23 Прикладное программирование", EducationalOrganizationSpecializationId = 1 , Image = "it20.png"},
                new EducationProgram { Id = 25, Name = "09.03.24 Программирование в интеллектуальных робототехнических системах" , EducationalOrganizationSpecializationId = 1, Image = "it21.png"},
                new EducationProgram { Id = 26, Name = "09.03.25 Киберфизические системы", EducationalOrganizationSpecializationId = 1 , Image = "it22.png"},
                new EducationProgram { Id = 27, Name = "09.03.26 Технологии промышленного программирования", EducationalOrganizationSpecializationId = 1 , Image = "it23.png"},
                new EducationProgram { Id = 28, Name = "09.03.27 Технологии программирования систем и сетей", EducationalOrganizationSpecializationId = 1 , Image = "it24.png"},
                new EducationProgram { Id = 29, Name = "09.03.28 Информационные системы" , EducationalOrganizationSpecializationId = 1, Image = "it25.png"},
                new EducationProgram { Id = 30, Name = "09.02.07 Информационные системы и программирование" , EducationalOrganizationSpecializationId = 1, Image = "it10.png"},
            });
            modelBuilder.Entity<TypeEducationalOrganization>().HasData(new TypeEducationalOrganization[]
            {
                new TypeEducationalOrganization
                {
                    Id = 1,
                    Name = "Профессиональная образовательная организация"
                },
                new TypeEducationalOrganization
                {
                    Id= 2,
                    Name = "Образовательная организация высшего образования"
                }
            });
            modelBuilder.Entity<City>().HasData(new City[]
            {
                new City { Id = 1, Name = "Москва" },
                new City { Id = 2, Name = "Санкт-Петербург" },
                new City { Id = 3, Name = "Новосибирск" },
                new City { Id = 4, Name = "Екатеринбург" },
                new City { Id = 5, Name = "Нижний Новгород" },
                new City { Id = 6, Name = "Казань" },
                new City { Id = 7, Name = "Челябинск" },
                new City { Id = 8, Name = "Омск" },
                new City { Id = 9, Name = "Самара" },
                new City { Id = 10, Name = "Ростов-на-Дону" },
                new City { Id = 11, Name = "Уфа" },
                new City { Id = 12, Name = "Красноярск" },
                new City { Id = 13, Name = "Воронеж" },
                new City { Id = 14, Name = "Пермь" },
                new City { Id = 15, Name = "Волгоград" },
                new City { Id = 16, Name = "Краснодар" },
                new City { Id = 17, Name = "Саратов" },
                new City { Id = 18, Name = "Тюмень" },
                new City { Id = 19, Name = "Тольятти" },
                new City { Id = 20, Name = "Ижевск" }
            });
            modelBuilder.Entity<EducationLevel>().HasData(new EducationLevel[]
           {
                new EducationLevel
                {
                    Id = 1,
                    Name = "Профессия"
                },
                new EducationLevel
                {
                    Id = 2,
                    Name = "Специальность"
                },
                new EducationLevel
                {
                    Id = 3,
                    Name = "Бакалавриат"
                },
                new EducationLevel
                {
                    Id = 4,
                    Name = "Специалитет"
                },
                new EducationLevel
                {
                    Id = 5,
                    Name = "Магистратура"
                },
                new EducationLevel
                {
                    Id = 6,
                    Name = "Аспирантура"
                },
                new EducationLevel
                {
                    Id = 7,
                    Name = "Докторантура"
                }

           });
            modelBuilder.Entity<TypeContact>().HasData(new TypeContact[]
            {
                new TypeContact
                {
                    Id = 1,
                    Name = "Email"
                },
                new TypeContact
                {
                    Id= 2,
                    Name = "Телефон"
                },
                new TypeContact
                {
                    Id= 3,
                    Name = "Сайт"
                }
            });
            modelBuilder.Entity<EducationalOrganization>().HasData(new EducationalOrganization[]
            {
                new EducationalOrganization
                {
                    Id = 1,
                    Name = "Московский государственный университет им. М.В. Ломоносова",
                    CityId = 1,
                    TypeId = 2,
                    Description = "Сегодня Московский университет — крупнейший классический университет России, в котором обучается более 45 тысяч человек из всех регионов страны (на разных формах обучения). " +
                    "В МГУ 40 факультетов (за последние 20 лет создан 21 факультет), 15 научно-исследовательских институтов, около 750 кафедр, отделов и лабораторий, Медицинский научно-образовательный центр, " +
                    "Научная библиотека, 4 музея, Ботанический сад, Научный парк, филиалы в Севастополе, Ташкенте, Астане, Баку, Душанбе, Ереване. \r\n\r\n" +
                    "МГУ осуществляет обучение по собственным образовательным уникальным 6‑летним образовательным стандартам, реализуемым в двух формах: интегрированная магистратура " +
                    "(нормативный срок обучения 4 года в бакалавриате и 2 года в магистратуре) и специалитет (нормативный срок обучения 6 лет). Особенностью интегрированной магистратуры " +
                    "является непрерывная подготовка студентов (на протяжении 6 лет обучения) по выбранному направлению, что является гарантией качественной подготовки специалистов в избранной области. " +
                    "В условиях перехода страны на двухуровневую систему высшего образования план приема в бюджетную магистратуру МГУ позволяет продолжить обучение в магистратуре всех выпускников МГУ " +
                    "(бакалавров), способных и готовых к дальнейшему обучению.",
                    Address = "ул. Ленинские Горы, 1",
                    Image = "msu.jpg"
                },
                new EducationalOrganization
                {
                    Id= 2,
                    Name = "Московский физико-технический институт",
                    CityId = 1,
                    TypeId = 2,
                    Description = "Московский физико-технический институт (МФТИ) является ведущим техническим университетом России. Система образования сфокусирована на глубоком изучении фундаментальных наук в " +
                    "сочетании с активным участием студентов в исследованиях в крупнейших российских и международных научных центрах. В МФТИ используется уникальная «Система Физтеха», разработанная основателями " +
                    "института и его первыми профессорами Петром Капицей, Николаем Семеновым и Львом Ландау. МФТИ имеет статус Государственного университета, что позволяет получать регулярную прямую финансовую и " +
                    "организационную поддержку от Правительства Российской Федерации. Институт является участником программы 5–100, направленной на развитие исследовательской деятельности, организованной" +
                    " в самом МФТИ, а также выход Физтеха в верхние позиции мировых университетских рейтингов.",
                    Address = "Институтский пер., д. 9",
                    Image = "mfti.jpg"
                },
                new EducationalOrganization
                {
                    Id= 3,
                    Name = "Национальный исследовательский ядерный университет «МИФИ»",
                    CityId = 1,
                    TypeId = 2,
                    Description = "«Мекка» физиков-ядерщиков, базовый вуз атомной промышленности России располагает рядом высокотехничных установок, в том числе, исследовательским ядерным реактором. " +
                    "Также, МИФИ занимает лидирующие позиции по подготовке программистов и специалистов по информационной безопасности. Здесь активно используется компьютерная поддержка учебного процесса:" +
                    " электронные учебники, компьютерные лабораторные работы, тренажеры. Университет сотрудничает с несколькими десятками университетов по всему миру. Многие старшекурсники проходят обучение " +
                    "и стажировку в лучших ядерных центрах Германии, США",
                    Address = "Каширское ш., д. 31",
                    Image = "mifi.jpg"
                },
                new EducationalOrganization
                {
                    Id= 4,
                    Name = "Московский государственный технический университет им. Н.Э. Баумана",
                    CityId = 1,
                    TypeId = 2,
                    Description = "МГТУ им. Н.Э. Баумана является одним из ведущих технических вузов страны. Университет ведет подготовку инженеров с 1830 года. На сегодняшний день в университете обучают" +
                    " по большому количеству направлений. Выпускники МГТУ становятся очень востребованными у работодателей на рынке труда. Ключевой особенностью обучения является сочетание теоретических и " +
                    "практических знаний. Университет занимается научными исследованиями и разработками.",
                    Address = "2-я Бауманская ул., д. 5, стр. 1",
                    Image = "bauman.jpg"
                },
                new EducationalOrganization
                {
                    Id= 5,
                    Name = "Медицинский колледж Управления делами Президента Российской Федерации",
                    CityId = 1,
                    TypeId = 1,
                    Description = "Медицинский колледж имеет богатый опыт профессиональной подготовки квалифицированных кадров среднего звена, их переподготовки и усовершенствования, " +
                    "вносит существенный вклад в обеспечение лечебно-диагностической работы учреждений здравоохранения Управления делами Президента РФ.",
                    Address = "ул. Маршала Тимошенко, д. 19",
                    Image = "prez.jpg"
                },
                new EducationalOrganization
                {
                    Id= 6,
                    Name = "Колледж современных технологий имени Героя Советского Союза М.Ф. Панова",
                    CityId = 1,
                    TypeId = 1,
                    Description = "ГБПОУ КСТ имеет 4 обустроенных актовых зала в каждом подразделении для обучающихся, в том числе инвалидов и лиц с ограниченными возможностями здоровья, " +
                    "которые оснащены проекторами, звуковой аппаратурой. В 6 отдельно оборудованных кабинетах для занятий дополнительным образованием (обработка керамики, работы по дереву и др.) " +
                    "обучающиеся в том числе инвалидов и лиц с ограниченными возможностями здоровья занимаются научно-техническим и художественно-прикладным творчеством. В литературно-музыкальной " +
                    "гостиной в Учебном корпусе № 3 «Ярославский»  (Хибинский проезд, дом 10) проводятся тематические встречи с интересными людьми, литературные вечера, заседания студенческого самоуправления" +
                    " и женского клуба и другие мероприятия. ГБПОУ КСТ располагает широким спектром персональных компьютеров и информационного оборудования, которое в первую очередь используется в учебном" +
                    " и воспитательном процессах",
                    Address = "Хибинский проезд, дом 10",
                    Image = "kst.png"
                }
            });
            modelBuilder.Entity<EducationalOrganizationContact>().HasData(new EducationalOrganizationContact[]
            {
                new EducationalOrganizationContact
                {
                    Id = 1,
                    TypeContactId = 1,
                    Value = "rector@mephi.ru",
                    EducationalOrganizationId = 3
                },
                new EducationalOrganizationContact
                {
                    Id = 2,
                    TypeContactId = 2,
                    Value = "(499) 324-84-17",
                    EducationalOrganizationId = 3
                },
                new EducationalOrganizationContact
                {
                    Id = 3,
                    TypeContactId = 2,
                    Value = "(495) 785-55-25",
                    EducationalOrganizationId = 3
                },
                new EducationalOrganizationContact
                {
                    Id = 4,
                    TypeContactId = 2,
                    Value = "(499) 263-63-91",
                    EducationalOrganizationId = 4
                },
                new EducationalOrganizationContact
                {
                    Id = 5,
                    TypeContactId = 1,
                    Value = "bauman@bmstu.ru",
                    EducationalOrganizationId = 4
                }
            });
            modelBuilder.Entity<ProgramEducationalOrganization>().HasData(new ProgramEducationalOrganization[]
            {
                new ProgramEducationalOrganization
                {
                    EducationalOrganizationId = 1,
                    EducationProgramId = 30,
                    EducationLevel = 3,
                    Duration = 4,
                    Id = 1,
                    TuitionPerYear = 390000,
                    Description = "Вы освоите программирование, научитесь разрабатывать и обслуживать программное обеспечение, проектировать и сопровождать информационные системы," +
                    " анализировать данные и обучать нейронные сети, создавать AI-инструменты. "
                },
                new ProgramEducationalOrganization
                {
                    EducationalOrganizationId = 1,
                    EducationProgramId = 30,
                    EducationLevel = 4,
                    Duration = 5,
                    Id = 2,
                    TuitionPerYear = 390000,
                    Description = "Сфера связи, информационных и коммуникационных технологий — одна из самых перспективных областей. Тот, кто владеет информационными технологиями, владеет будущим. " +
                    "Разработчики программного обеспечения (ПО) создают и внедряют различные информационные системы на предприятия, адаптируют их под конкретные бизнес-задачи, " +
                    "обеспечивают стабильную работу информационно-технической инфраструктуры и сервисов компании. "
                },
                new ProgramEducationalOrganization
                {
                    EducationalOrganizationId = 1,
                    EducationProgramId = 30,
                    EducationLevel = 5,
                    Duration = 2,
                    Id = 3,
                    TuitionPerYear = 430000,
                    Description = "Специальность охватывает достаточно широкий спектр сфер профессиональной деятельности, что позволяет получить знания о безопасности информационных систем, " +
                    "техническом обслуживании и ремонте компьютеров, администрировании сетей, прикладном и системном программировании, WEB-дизайне и графическом моделировании объектов. Позволяет " +
                    "получить опыт в разработке и интеграции модулей программного обеспечения, администрировании баз данных, сопровождении программного обеспечения."
                },
                new ProgramEducationalOrganization
                {
                    EducationalOrganizationId = 6,
                    EducationProgramId = 30,
                    EducationLevel = 1,
                    Duration = 4,
                    Id = 4,
                    TuitionPerYear = 140000,
                    Description = "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных " +
                    "коммерческих и бюджетных учреждений, программирование, защита информации и др.)"
                },
                new ProgramEducationalOrganization
                {
                    EducationalOrganizationId = 6,
                    EducationProgramId = 30,
                    EducationLevel = 2,
                    Duration = 3,
                    Id = 5,
                    TuitionPerYear = 150000,
                    Description = "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных " +
                    "коммерческих и бюджетных учреждений, программирование, защита информации и др.)"
                },
                new ProgramEducationalOrganization
                {
                    EducationalOrganizationId = 1,
                    EducationProgramId = 30,
                    EducationLevel = 3,
                    Duration = 4,
                    Id = 6,
                    TuitionPerYear = 350000,
                    Description = "Вы освоите программирование, научитесь разрабатывать и обслуживать программное обеспечение, проектировать и сопровождать информационные системы," +
                    " анализировать данные и обучать нейронные сети, создавать AI-инструменты. "
                }
            });
            modelBuilder.Entity<DisciplineEducationProgram>().HasData(new DisciplineEducationProgram[]
            {
                new DisciplineEducationProgram
                {
                    Id = 1,
                    DisciplineId = 1,
                    EducationProgramId = 2
                },
                new DisciplineEducationProgram
                {
                    Id = 2,
                    DisciplineId = 15,
                    EducationProgramId = 2
                },
                new DisciplineEducationProgram
                {
                    Id = 3,
                    DisciplineId = 6,
                    EducationProgramId = 2
                },
                new DisciplineEducationProgram
                {
                    Id = 4,
                    DisciplineId = 1,
                    EducationProgramId = 8
                },
                new DisciplineEducationProgram
                {
                    Id = 5,
                    DisciplineId = 15,
                    EducationProgramId = 8
                },
                new DisciplineEducationProgram
                {
                    Id = 6,
                    DisciplineId = 6,
                    EducationProgramId = 8
                },
                new DisciplineEducationProgram
                {
                    Id = 7,
                    DisciplineId = 1,
                    EducationProgramId = 30
                },
                new DisciplineEducationProgram
                {
                    Id = 8,
                    DisciplineId = 15,
                    EducationProgramId = 30
                },
                new DisciplineEducationProgram
                {
                    Id = 9,
                    DisciplineId = 6,
                    EducationProgramId = 30
                },
            });
            modelBuilder.Entity<PassingScore>().HasData(new PassingScore[]
            {
                new PassingScore
                {
                    Id = 1,
                    ProgramEducationalOrganizationId = 1,
                    IsBudget = true,
                    Score = 290,
                    Year = 2023
                },
                new PassingScore
                {
                    Id = 2,
                    ProgramEducationalOrganizationId = 1,
                    IsBudget = false,
                    Score = 180,
                    Year = 2023
                },
                new PassingScore
                {
                    Id = 3,
                    ProgramEducationalOrganizationId = 6,
                    IsBudget = false,
                    Score = 192,
                    Year = 2023
                },
                new PassingScore
                {
                    Id = 4,
                    ProgramEducationalOrganizationId = 6,
                    IsBudget = true,
                    Score = 295,
                    Year = 2023
                },
                new PassingScore
                {
                    Id = 5,
                    ProgramEducationalOrganizationId = 5,
                    IsBudget = true,
                    Score = 4.6,
                    Year = 2023
                }
                ,
                new PassingScore
                {
                    Id = 6,
                    ProgramEducationalOrganizationId = 4,
                    IsBudget = true,
                    Score = 4.3,
                    Year = 2023
                },
                new PassingScore
                {
                    Id = 7,
                    ProgramEducationalOrganizationId = 5,
                    IsBudget = false,
                    Score = 4.1,
                    Year = 2023
                }
                ,
                new PassingScore
                {
                    Id = 8,
                    ProgramEducationalOrganizationId = 4,
                    IsBudget = false,
                    Score = 3.8,
                    Year = 2023
                }

            });
        }

        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<TypeEducationalOrganization?> TypeEducationalOrganizations { get; set; }
        public DbSet<TypeContact> TypesContact { get; set; }
        public DbSet<EducationalOrganization> EducationalOrganizations { get; set; }
        public DbSet<EducationalOrganizationContact> EducationalOrganizationContacts { get; set; }
        public DbSet<EducationLevel> EducationLevel { get; set; }
        public DbSet<EducationProgram> EducationPrograms { get; set; }
        public DbSet<PassingScore> PassingScores { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<DisciplineEducationProgram> DisciplinesEducationProgram { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ProgramEducationalOrganization> ProgramsEducationalOrganization { get; set; }
    }
}
