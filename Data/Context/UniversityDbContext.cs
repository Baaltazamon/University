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
    },
    new Specialization
    {
        Id = 9,
        Name = "Строительство"
    },
    new Specialization
    {
        Id = 10,
        Name = "Электротехника и электроника"
    },
    new Specialization
    {
        Id = 11,
        Name = "Энергетика и электротехника"
    },
    new Specialization
    {
        Id = 12,
        Name = "Техника и технологии наземного транспорта"
    },
    new Specialization
    {
        Id = 13,
        Name = "Техника и технологии водного транспорта"
    },
    new Specialization
    {
        Id = 14,
        Name = "Техника и технологии воздушного транспорта"
    },
    new Specialization
    {
        Id = 15,
        Name = "Экономика"
    },
    new Specialization
    {
        Id = 16,
        Name = "Управление в технических системах"
    },
    new Specialization
    {
        Id = 17,
        Name = "Психология"
    },
    new Specialization
    {
        Id = 18,
        Name = "Социология"
    },
    new Specialization
    {
        Id = 19,
        Name = "Философия"
    },
    new Specialization
    {
        Id = 20,
        Name = "Политология"
    },
    new Specialization
    {
        Id = 21,
        Name = "Юриспруденция"
    },
    new Specialization
    {
        Id = 22,
        Name = "История"
    },
    new Specialization
    {
        Id = 23,
        Name = "Филология"
    },
    new Specialization
    {
        Id = 24,
        Name = "Журналистика"
    },
    new Specialization
    {
        Id = 25,
        Name = "Культурология"
    },
    new Specialization
    {
        Id = 26,
        Name = "Искусствоведение"
    },
    new Specialization
    {
        Id = 27,
        Name = "Дизайн"
    },
    new Specialization
    {
        Id = 28,
        Name = "Физическая культура и спорт"
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
                new EducationProgram { Id = 31, Name = "02.03.01 Математика и компьютерные науки", EducationalOrganizationSpecializationId = 2, Image = "" },
                new EducationProgram { Id = 32, Name = "02.03.02 Фундаментальная информатика и информационные технологии", EducationalOrganizationSpecializationId = 3, Image = "" },
                new EducationProgram { Id = 33, Name = "02.03.03 Математическое и программное обеспечение вычислительных машин и комплексов", EducationalOrganizationSpecializationId = 3, Image = "" },
                new EducationProgram { Id = 34, Name = "02.03.04 Прикладная математика и информатика", EducationalOrganizationSpecializationId = 2, Image = "" },
                new EducationProgram { Id = 35, Name = "03.03.01 Прикладная математика и физика", EducationalOrganizationSpecializationId = 4, Image = "" },
                new EducationProgram { Id = 36, Name = "03.03.02 Физика", EducationalOrganizationSpecializationId = 4, Image = "" },
                new EducationProgram { Id = 37, Name = "03.03.03 Радиофизика", EducationalOrganizationSpecializationId = 4, Image = "" },
                new EducationProgram { Id = 38, Name = "03.03.04 Физика конденсированного состояния", EducationalOrganizationSpecializationId = 4, Image = "" },
                new EducationProgram { Id = 39, Name = "03.03.05 Лазерная физика", EducationalOrganizationSpecializationId = 4, Image = "" },
                new EducationProgram { Id = 40, Name = "03.03.06 Астрономия", EducationalOrganizationSpecializationId = 4, Image = "" },
                new EducationProgram { Id = 41, Name = "04.03.01 Химия", EducationalOrganizationSpecializationId = 5, Image = "" },
                new EducationProgram { Id = 42, Name = "04.03.02 Химическая технология", EducationalOrganizationSpecializationId = 5, Image = "" },
                new EducationProgram { Id = 43, Name = "04.03.03 Физическая химия", EducationalOrganizationSpecializationId = 5, Image = "" },
                new EducationProgram { Id = 44, Name = "04.03.04 Неорганическая химия", EducationalOrganizationSpecializationId = 5, Image = "" },
                new EducationProgram { Id = 45, Name = "05.03.01 Геология", EducationalOrganizationSpecializationId = 6, Image = "" },
                new EducationProgram { Id = 46, Name = "05.03.02 Геофизика", EducationalOrganizationSpecializationId = 6, Image = "" },
                new EducationProgram { Id = 47, Name = "05.03.03 География", EducationalOrganizationSpecializationId = 6, Image = "" },
                new EducationProgram { Id = 48, Name = "05.03.04 Метеорология", EducationalOrganizationSpecializationId = 6, Image = "" },
                new EducationProgram { Id = 49, Name = "05.03.05 Картография и геоинформатика", EducationalOrganizationSpecializationId = 6, Image = "" },
                new EducationProgram { Id = 50, Name = "06.03.01 Биология", EducationalOrganizationSpecializationId = 7, Image = "" },
                new EducationProgram { Id = 51, Name = "06.03.02 Биотехнология", EducationalOrganizationSpecializationId = 7, Image = "" },
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
        "и стажировку в лучших ядерных центрах Германии, США.",
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
        " и воспитательном процессах.",
        Address = "Хибинский проезд, дом 10",
        Image = "kst.png"
    },
    new EducationalOrganization
    {
        Id = 7,
        Name = "Санкт-Петербургский государственный университет",
        CityId = 2,
        TypeId = 2,
        Description = "Санкт-Петербургский государственный университет (СПбГУ) — один из крупнейших и старейших вузов России. Университет предоставляет образование на уровне мировых стандартов, " +
        "и многие его выпускники стали выдающимися учеными, политиками и деятелями искусства. В СПбГУ функционируют современные научные лаборатории и центры.",
        Address = "Университетская наб., д. 7/9",
        Image = "spbu.png"
    },
    new EducationalOrganization
    {
        Id = 8,
        Name = "Новосибирский государственный университет",
        CityId = 3,
        TypeId = 2,
        Description = "Новосибирский государственный университет (НГУ) — один из ведущих научных и образовательных центров России, расположенный в научном центре Академгородок. " +
        "НГУ активно сотрудничает с институтами Сибирского отделения РАН, что обеспечивает высокий уровень подготовки специалистов в области науки и технологий.",
        Address = "ул. Пирогова, д. 2",
        Image = "nsu.png"
    },
    new EducationalOrganization
    {
        Id = 9,
        Name = "Уральский федеральный университет",
        CityId = 4,
        TypeId = 2,
        Description = "Уральский федеральный университет имени первого Президента России Б.Н. Ельцина (УрФУ) — один из крупнейших федеральных университетов России, " +
        "входит в топ-10 вузов страны. Университет предлагает широкий спектр образовательных программ, активно ведет научные исследования и международное сотрудничество.",
        Address = "ул. Мира, д. 19",
        Image = "urfu.png"
    },
    new EducationalOrganization
    {
        Id = 10,
        Name = "Нижегородский государственный университет им. Н.И. Лобачевского",
        CityId = 5,
        TypeId = 2,
        Description = "Нижегородский государственный университет имени Н.И. Лобачевского (ННГУ) — ведущий классический университет России, основанный в 1916 году. " +
        "Университет предлагает программы бакалавриата, магистратуры и аспирантуры по различным направлениям, активно развивает научные исследования.",
        Address = "пр. Гагарина, д. 23",
        Image = "unn.png"
    },
    new EducationalOrganization
    {
        Id = 11,
        Name = "Казанский (Приволжский) федеральный университет",
        CityId = 6,
        TypeId = 2,
        Description = "Казанский (Приволжский) федеральный университет (КФУ) — один из старейших и крупнейших вузов России, основанный в 1804 году. " +
        "КФУ предлагает широкий спектр образовательных программ и активно участвует в международных научных проектах.",
        Address = "ул. Кремлевская, д. 18",
        Image = "kfu.png"
    },
    new EducationalOrganization
    {
        Id = 12,
        Name = "Южно-Уральский государственный университет",
        CityId = 7,
        TypeId = 2,
        Description = "Южно-Уральский государственный университет (ЮУрГУ) — один из крупнейших и ведущих технических университетов России, " +
        "расположенный в Челябинске. Университет активно занимается научными исследованиями и разработками, предлагает программы бакалавриата, магистратуры и аспирантуры.",
        Address = "пр. Ленина, д. 76",
        Image = "susurgu.png"
    },
    new EducationalOrganization
    {
        Id = 13,
        Name = "Омский государственный технический университет",
        CityId = 8,
        TypeId = 2,
        Description = "Омский государственный технический университет (ОмГТУ) — один из ведущих технических вузов Сибири, " +
        "предлагающий образовательные программы в области инженерии, информационных технологий и менеджмента.",
        Address = "пр. Мира, д. 11",
        Image = "omgtu.png"
    },
    new EducationalOrganization
    {
        Id = 14,
        Name = "Самарский государственный университет",
        CityId = 9,
        TypeId = 2,
        Description = "Самарский государственный университет (СамГУ) — один из ведущих вузов Поволжья, " +
        "предлагающий образовательные программы в области естественных, гуманитарных и социальных наук.",
        Address = "ул. Академика Павлова, д. 1",
        Image = "ssu.png"
    },
    new EducationalOrganization
    {
        Id = 15,
        Name = "Ростовский государственный университет",
        CityId = 10,
        TypeId = 2,
        Description = "Ростовский государственный университет (РГУ) — крупный вуз на юге России, " +
        "предлагающий образовательные программы в различных областях науки и техники.",
        Address = "ул. Большая Садовая, д. 105",
        Image = "rsu.png"
    },
    new EducationalOrganization
    {
        Id = 16,
        Name = "Уфимский государственный авиационный технический университет",
        CityId = 11,
        TypeId = 2,
        Description = "Уфимский государственный авиационный технический университет (УГАТУ) — ведущий технический вуз Башкортостана, " +
        "специализирующийся на подготовке специалистов в области авиационной техники и технологий.",
        Address = "ул. К. Маркса, д. 12",
        Image = "ugatu.png"
    },
    new EducationalOrganization
    {
        Id = 17,
        Name = "Сибирский федеральный университет",
        CityId = 12,
        TypeId = 2,
        Description = "Сибирский федеральный университет (СФУ) — один из крупнейших вузов России, расположенный в Красноярске. " +
        "Университет предлагает образовательные программы в области естественных, технических и гуманитарных наук.",
        Address = "ул. Свободный проспект, д. 79",
        Image = "sfu.png"
    },
    new EducationalOrganization
    {
        Id = 18,
        Name = "Воронежский государственный университет",
        CityId = 13,
        TypeId = 2,
        Description = "Воронежский государственный университет (ВГУ) — крупный классический университет, " +
        "предлагающий образовательные программы в различных областях науки и техники.",
        Address = "ул. Университетская пл., д. 1",
        Image = "vsu.png"
    },
    new EducationalOrganization
    {
        Id = 19,
        Name = "Пермский государственный национальный исследовательский университет",
        CityId = 14,
        TypeId = 2,
        Description = "Пермский государственный национальный исследовательский университет (ПГНИУ) — один из ведущих вузов Урала, " +
        "предлагающий образовательные программы в области естественных, технических и гуманитарных наук.",
        Address = "ул. Букирева, д. 15",
        Image = "pstu.png"
    },
    new EducationalOrganization
    {
        Id = 20,
        Name = "Волгоградский государственный технический университет",
        CityId = 15,
        TypeId = 2,
        Description = "Волгоградский государственный технический университет (ВолгГТУ) — крупный технический вуз, " +
        "предлагающий образовательные программы в области инженерии, информационных технологий и менеджмента.",
        Address = "пр. Ленина, д. 28",
        Image = "vstu.png"
    }
});
            modelBuilder.Entity<EducationalOrganizationContact>().HasData(new EducationalOrganizationContact[]
{
    // Московский государственный университет им. М.В. Ломоносова
    new EducationalOrganizationContact
    {
        Id = 1,
        TypeContactId = 1,
        Value = "info@msu.ru",
        EducationalOrganizationId = 1
    },
    new EducationalOrganizationContact
    {
        Id = 2,
        TypeContactId = 2,
        Value = "(495) 939-10-00",
        EducationalOrganizationId = 1
    },
    new EducationalOrganizationContact
    {
        Id = 3,
        TypeContactId = 3,
        Value = "http://www.msu.ru",
        EducationalOrganizationId = 1
    },

    // Московский физико-технический институт
    new EducationalOrganizationContact
    {
        Id = 4,
        TypeContactId = 1,
        Value = "info@mipt.ru",
        EducationalOrganizationId = 2
    },
    new EducationalOrganizationContact
    {
        Id = 5,
        TypeContactId = 2,
        Value = "(495) 408-48-00",
        EducationalOrganizationId = 2
    },
    new EducationalOrganizationContact
    {
        Id = 6,
        TypeContactId = 3,
        Value = "http://www.mipt.ru",
        EducationalOrganizationId = 2
    },

    // Национальный исследовательский ядерный университет «МИФИ»
    new EducationalOrganizationContact
    {
        Id = 7,
        TypeContactId = 1,
        Value = "rector@mephi.ru",
        EducationalOrganizationId = 3
    },
    new EducationalOrganizationContact
    {
        Id = 8,
        TypeContactId = 2,
        Value = "(499) 324-84-17",
        EducationalOrganizationId = 3
    },
    new EducationalOrganizationContact
    {
        Id = 9,
        TypeContactId = 2,
        Value = "(495) 785-55-25",
        EducationalOrganizationId = 3
    },
    new EducationalOrganizationContact
    {
        Id = 10,
        TypeContactId = 3,
        Value = "http://www.mephi.ru",
        EducationalOrganizationId = 3
    },

    // Московский государственный технический университет им. Н.Э. Баумана
    new EducationalOrganizationContact
    {
        Id = 11,
        TypeContactId = 1,
        Value = "bauman@bmstu.ru",
        EducationalOrganizationId = 4
    },
    new EducationalOrganizationContact
    {
        Id = 12,
        TypeContactId = 2,
        Value = "(499) 263-63-91",
        EducationalOrganizationId = 4
    },
    new EducationalOrganizationContact
    {
        Id = 13,
        TypeContactId = 3,
        Value = "http://www.bmstu.ru",
        EducationalOrganizationId = 4
    },

    // Медицинский колледж Управления делами Президента Российской Федерации
    new EducationalOrganizationContact
    {
        Id = 14,
        TypeContactId = 1,
        Value = "info@prezcollege.ru",
        EducationalOrganizationId = 5
    },
    new EducationalOrganizationContact
    {
        Id = 15,
        TypeContactId = 2,
        Value = "(495) 123-45-67",
        EducationalOrganizationId = 5
    },
    new EducationalOrganizationContact
    {
        Id = 16,
        TypeContactId = 3,
        Value = "http://www.prezcollege.ru",
        EducationalOrganizationId = 5
    },

    // Колледж современных технологий имени Героя Советского Союза М.Ф. Панова
    new EducationalOrganizationContact
    {
        Id = 17,
        TypeContactId = 1,
        Value = "info@kst.edu.ru",
        EducationalOrganizationId = 6
    },
    new EducationalOrganizationContact
    {
        Id = 18,
        TypeContactId = 2,
        Value = "(495) 987-65-43",
        EducationalOrganizationId = 6
    },
    new EducationalOrganizationContact
    {
        Id = 19,
        TypeContactId = 3,
        Value = "http://www.kst.edu.ru",
        EducationalOrganizationId = 6
    },

    // Санкт-Петербургский государственный университет
    new EducationalOrganizationContact
    {
        Id = 20,
        TypeContactId = 1,
        Value = "info@spbu.ru",
        EducationalOrganizationId = 7
    },
    new EducationalOrganizationContact
    {
        Id = 21,
        TypeContactId = 2,
        Value = "(812) 328-20-00",
        EducationalOrganizationId = 7
    },
    new EducationalOrganizationContact
    {
        Id = 22,
        TypeContactId = 3,
        Value = "http://www.spbu.ru",
        EducationalOrganizationId = 7
    },

    // Новосибирский государственный университет
    new EducationalOrganizationContact
    {
        Id = 23,
        TypeContactId = 1,
        Value = "info@nspu.ru",
        EducationalOrganizationId = 8
    },
    new EducationalOrganizationContact
    {
        Id = 24,
        TypeContactId = 2,
        Value = "(383) 217-02-22",
        EducationalOrganizationId = 8
    },
    new EducationalOrganizationContact
    {
        Id = 25,
        TypeContactId = 3,
        Value = "http://www.nspu.ru",
        EducationalOrganizationId = 8
    },

    // Уральский федеральный университет
    new EducationalOrganizationContact
    {
        Id = 26,
        TypeContactId = 1,
        Value = "info@urfu.ru",
        EducationalOrganizationId = 9
    },
    new EducationalOrganizationContact
    {
        Id = 27,
        TypeContactId = 2,
        Value = "(343) 375-46-46",
        EducationalOrganizationId = 9
    },
    new EducationalOrganizationContact
    {
        Id = 28,
        TypeContactId = 3,
        Value = "http://www.urfu.ru",
        EducationalOrganizationId = 9
    },

    // Нижегородский государственный университет им. Н.И. Лобачевского
    new EducationalOrganizationContact
    {
        Id = 29,
        TypeContactId = 1,
        Value = "info@unn.ru",
        EducationalOrganizationId = 10
    },
    new EducationalOrganizationContact
    {
        Id = 30,
        TypeContactId = 2,
        Value = "(831) 462-30-00",
        EducationalOrganizationId = 10
    },
    new EducationalOrganizationContact
    {
        Id = 31,
        TypeContactId = 3,
        Value = "http://www.unn.ru",
        EducationalOrganizationId = 10
    },

    // Казанский (Приволжский) федеральный университет
    new EducationalOrganizationContact
    {
        Id = 32,
        TypeContactId = 1,
        Value = "info@kpfu.ru",
        EducationalOrganizationId = 11
    },
    new EducationalOrganizationContact
    {
        Id = 33,
        TypeContactId = 2,
        Value = "(843) 233-70-00",
        EducationalOrganizationId = 11
    },
    new EducationalOrganizationContact
    {
        Id = 34,
        TypeContactId = 3,
        Value = "http://www.kpfu.ru",
        EducationalOrganizationId = 11
    },

    // Южно-Уральский государственный университет
    new EducationalOrganizationContact
    {
        Id = 35,
        TypeContactId = 1,
        Value = "info@susu.ru",
        EducationalOrganizationId = 12
    },
    new EducationalOrganizationContact
    {
        Id = 36,
        TypeContactId = 2,
        Value = "(351) 267-94-94",
        EducationalOrganizationId = 12
    },
    new EducationalOrganizationContact
    {
        Id = 37,
        TypeContactId = 3,
        Value = "http://www.susu.ru",
        EducationalOrganizationId = 12
    },

    // Омский государственный технический университет
    new EducationalOrganizationContact
    {
        Id = 38,
        TypeContactId = 1,
        Value = "info@omgtu.ru",
        EducationalOrganizationId = 13
    },
    new EducationalOrganizationContact
    {
        Id = 39,
        TypeContactId = 2,
        Value = "(3812) 65-28-00",
        EducationalOrganizationId = 13
    },
    new EducationalOrganizationContact
    {
        Id = 40,
        TypeContactId = 3,
        Value = "http://www.omgtu.ru",
        EducationalOrganizationId = 13
    },

    // Самарский государственный университет
    new EducationalOrganizationContact
    {
        Id = 41,
        TypeContactId = 1,
        Value = "info@ssau.ru",
        EducationalOrganizationId = 14
    },
    new EducationalOrganizationContact
    {
        Id = 42,
        TypeContactId = 2,
        Value = "(846) 267-47-67",
        EducationalOrganizationId = 14
    },
    new EducationalOrganizationContact
    {
        Id = 43,
        TypeContactId = 3,
        Value = "http://www.ssau.ru",
        EducationalOrganizationId = 14
    },

    // Ростовский государственный университет
    new EducationalOrganizationContact
    {
        Id = 44,
        TypeContactId = 1,
        Value = "info@rsu.ru",
        EducationalOrganizationId = 15
    },
    new EducationalOrganizationContact
    {
        Id = 45,
        TypeContactId = 2,
        Value = "(863) 264-24-00",
        EducationalOrganizationId = 15
    },
    new EducationalOrganizationContact
    {
        Id = 46,
        TypeContactId = 3,
        Value = "http://www.rsu.ru",
        EducationalOrganizationId = 15
    },

    // Уфимский государственный авиационный технический университет
    new EducationalOrganizationContact
    {
        Id = 47,
        TypeContactId = 1,
        Value = "info@ugatu.ru",
        EducationalOrganizationId = 16
    },
    new EducationalOrganizationContact
    {
        Id = 48,
        TypeContactId = 2,
        Value = "(347) 273-55-00",
        EducationalOrganizationId = 16
    },
    new EducationalOrganizationContact
    {
        Id = 49,
        TypeContactId = 3,
        Value = "http://www.ugatu.ru",
        EducationalOrganizationId = 16
    },

    // Сибирский федеральный университет
    new EducationalOrganizationContact
    {
        Id = 50,
        TypeContactId = 1,
        Value = "info@sfu-kras.ru",
        EducationalOrganizationId = 17
    },
    new EducationalOrganizationContact
    {
        Id = 51,
        TypeContactId = 2,
        Value = "(391) 206-22-22",
        EducationalOrganizationId = 17
    },
    new EducationalOrganizationContact
    {
        Id = 52,
        TypeContactId = 3,
        Value = "http://www.sfu-kras.ru",
        EducationalOrganizationId = 17
    },

    // Воронежский государственный университет
    new EducationalOrganizationContact
    {
        Id = 53,
        TypeContactId = 1,
        Value = "info@vsu.ru",
        EducationalOrganizationId = 18
    },
    new EducationalOrganizationContact
    {
        Id = 54,
        TypeContactId = 2,
        Value = "(473) 220-72-00",
        EducationalOrganizationId = 18
    },
    new EducationalOrganizationContact
    {
        Id = 55,
        TypeContactId = 3,
        Value = "http://www.vsu.ru",
        EducationalOrganizationId = 18
    },

    // Пермский государственный национальный исследовательский университет
    new EducationalOrganizationContact
    {
        Id = 56,
        TypeContactId = 1,
        Value = "info@psu.ru",
        EducationalOrganizationId = 19
    },
    new EducationalOrganizationContact
    {
        Id = 57,
        TypeContactId = 2,
        Value = "(342) 239-68-22",
        EducationalOrganizationId = 19
    },
    new EducationalOrganizationContact
    {
        Id = 58,
        TypeContactId = 3,
        Value = "http://www.psu.ru",
        EducationalOrganizationId = 19
    },

    // Волгоградский государственный технический университет
    new EducationalOrganizationContact
    {
        Id = 59,
        TypeContactId = 1,
        Value = "info@volgatech.net",
        EducationalOrganizationId = 20
    },
    new EducationalOrganizationContact
    {
        Id = 60,
        TypeContactId = 2,
        Value = "(8442) 23-90-09",
        EducationalOrganizationId = 20
    },
    new EducationalOrganizationContact
    {
        Id = 61,
        TypeContactId = 3,
        Value = "http://www.volgatech.net",
        EducationalOrganizationId = 20
    }
});


            modelBuilder.Entity<ProgramEducationalOrganization>().HasData(new ProgramEducationalOrganization[]
            {
                // Программы обучения для Московского государственного университета им. М.В. Ломоносова
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 1,
        EducationProgramId = 31,
        EducationLevel = 3,
        Duration = 4,
        Id = 1,
        TuitionPerYear = 390000,
        Description = "Программа обучения по математике и компьютерным наукам (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 1,
        EducationProgramId = 32,
        EducationLevel = 4,
        Duration = 5,
        Id = 2,
        TuitionPerYear = 390000,
        Description = "Программа обучения по фундаментальной информатике и информационным технологиям (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 1,
        EducationProgramId = 33,
        EducationLevel = 5,
        Duration = 2,
        Id = 3,
        TuitionPerYear = 430000,
        Description = "Программа обучения по математическому и программному обеспечению вычислительных машин и комплексов (магистратура)."
    },
    
    // Программы обучения для Московского физико-технического института
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 2,
        EducationProgramId = 34,
        EducationLevel = 3,
        Duration = 4,
        Id = 4,
        TuitionPerYear = 400000,
        Description = "Программа обучения по прикладной математике и информатике (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 2,
        EducationProgramId = 35,
        EducationLevel = 5,
        Duration = 2,
        Id = 5,
        TuitionPerYear = 450000,
        Description = "Программа обучения по прикладной математике и физике (магистратура)."
    },
    
    // Программы обучения для Национального исследовательского ядерного университета «МИФИ»
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 3,
        EducationProgramId = 7,
        EducationLevel = 3,
        Duration = 4,
        Id = 6,
        TuitionPerYear = 350000,
        Description = "Программа обучения по программированию (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 3,
        EducationProgramId = 12,
        EducationLevel = 4,
        Duration = 5,
        Id = 7,
        TuitionPerYear = 380000,
        Description = "Программа обучения по информационной безопасности (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 3,
        EducationProgramId = 26,
        EducationLevel = 5,
        Duration = 2,
        Id = 8,
        TuitionPerYear = 400000,
        Description = "Программа обучения по киберфизическим системам (магистратура)."
    },
    
    // Программы обучения для Московского государственного технического университета им. Н.Э. Баумана
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 4,
        EducationProgramId = 12,
        EducationLevel = 3,
        Duration = 4,
        Id = 9,
        TuitionPerYear = 380000,
        Description = "Программа обучения по информационной безопасности (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 4,
        EducationProgramId = 18,
        EducationLevel = 4,
        Duration = 5,
        Id = 10,
        TuitionPerYear = 420000,
        Description = "Программа обучения по интеллектуальным системам и технологиям (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 4,
        EducationProgramId = 26,
        EducationLevel = 5,
        Duration = 2,
        Id = 11,
        TuitionPerYear = 450000,
        Description = "Программа обучения по киберфизическим системам (магистратура)."
    },
    
    // Программы обучения для Медицинского колледжа Управления делами Президента Российской Федерации
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 5,
        EducationProgramId = 50,
        EducationLevel = 1,
        Duration = 3,
        Id = 12,
        TuitionPerYear = 200000,
        Description = "Программа обучения по биологии (профессия)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 5,
        EducationProgramId = 51,
        EducationLevel = 2,
        Duration = 3,
        Id = 13,
        TuitionPerYear = 220000,
        Description = "Программа обучения по биотехнологии (специальность)."
    },
    
    // Программы обучения для Колледжа современных технологий имени Героя Советского Союза М.Ф. Панова
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 6,
        EducationProgramId = 30,
        EducationLevel = 1,
        Duration = 4,
        Id = 14,
        TuitionPerYear = 140000,
        Description = "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных коммерческих и бюджетных учреждений, программирование, защита информации и др.)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 6,
        EducationProgramId = 30,
        EducationLevel = 2,
        Duration = 3,
        Id = 15,
        TuitionPerYear = 150000,
        Description = "Специалист занимается разработкой, созданием и обслуживанием информационных систем (обслуживание серверной системы, верстка сайтов, администрирование базы данных коммерческих и бюджетных учреждений, программирование, защита информации и др.)."
    },
    
    // Программы обучения для Санкт-Петербургского государственного университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 7,
        EducationProgramId = 11,
        EducationLevel = 3,
        Duration = 4,
        Id = 16,
        TuitionPerYear = 360000,
        Description = "Программа обучения по информационным системам и технологиям в бизнесе (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 7,
        EducationProgramId = 12,
        EducationLevel = 4,
        Duration = 5,
        Id = 17,
        TuitionPerYear = 390000,
        Description = "Программа обучения по информационной безопасности (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 7,
        EducationProgramId = 19,
        EducationLevel = 5,
        Duration = 2,
        Id = 18,
        TuitionPerYear = 420000,
        Description = "Программа обучения по технологиям управления организацией (магистратура)."
    },
    
    // Программы обучения для Новосибирского государственного университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 8,
        EducationProgramId = 5,
        EducationLevel = 3,
        Duration = 4,
        Id = 19,
        TuitionPerYear = 350000,
        Description = "Программа обучения по программной инженерии (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 8,
        EducationProgramId = 6,
        EducationLevel = 4,
        Duration = 5,
        Id = 20,
        TuitionPerYear = 370000,
        Description = "Программа обучения по информационным системам и технологиям в экономике (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 8,
        EducationProgramId = 9,
        EducationLevel = 5,
        Duration = 2,
        Id = 21,
        TuitionPerYear = 400000,
        Description = "Программа обучения по математическому обеспечению и администрированию информационных систем (магистратура)."
    },
    
    // Программы обучения для Уральского федерального университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 9,
        EducationProgramId = 17,
        EducationLevel = 3,
        Duration = 4,
        Id = 22,
        TuitionPerYear = 360000,
        Description = "Программа обучения по информатике и вычислительной технике (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 9,
        EducationProgramId = 18,
        EducationLevel = 4,
        Duration = 5,
        Id = 23,
        TuitionPerYear = 380000,
        Description = "Программа обучения по интеллектуальным системам и технологиям (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 9,
        EducationProgramId = 21,
        EducationLevel = 5,
        Duration = 2,
        Id = 24,
        TuitionPerYear = 420000,
        Description = "Программа обучения по программному обеспечению информационных технологий (магистратура)."
    },
    
    // Программы обучения для Нижегородского государственного университета им. Н.И. Лобачевского
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 10,
        EducationProgramId = 10,
        EducationLevel = 3,
        Duration = 4,
        Id = 25,
        TuitionPerYear = 350000,
        Description = "Программа обучения по информационным системам и технологиям в здравоохранении (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 10,
        EducationProgramId = 15,
        EducationLevel = 4,
        Duration = 5,
        Id = 26,
        TuitionPerYear = 380000,
        Description = "Программа обучения по антикризисному управлению (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 10,
        EducationProgramId = 20,
        EducationLevel = 5,
        Duration = 2,
        Id = 27,
        TuitionPerYear = 400000,
        Description = "Программа обучения по программному обеспечению экономической деятельности (магистратура)."
    },
    
    // Программы обучения для Казанского (Приволжского) федерального университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 11,
        EducationProgramId = 13,
        EducationLevel = 3,
        Duration = 4,
        Id = 28,
        TuitionPerYear = 340000,
        Description = "Программа обучения по информационным технологиям в юриспруденции (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 11,
        EducationProgramId = 14,
        EducationLevel = 4,
        Duration = 5,
        Id = 29,
        TuitionPerYear = 360000,
        Description = "Программа обучения по наноинженерии (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 11,
        EducationProgramId = 16,
        EducationLevel = 5,
        Duration = 2,
        Id = 30,
        TuitionPerYear = 400000,
        Description = "Программа обучения по управлению инновациями (магистратура)."
    },
    
    // Программы обучения для Южно-Уральского государственного университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 12,
        EducationProgramId = 8,
        EducationLevel = 3,
        Duration = 4,
        Id = 31,
        TuitionPerYear = 330000,
        Description = "Программа обучения по веб-технологиям (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 12,
        EducationProgramId = 24,
        EducationLevel = 4,
        Duration = 5,
        Id = 32,
        TuitionPerYear = 350000,
        Description = "Программа обучения по прикладному программированию (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 12,
        EducationProgramId = 27,
        EducationLevel = 5,
        Duration = 2,
        Id = 33,
        TuitionPerYear = 370000,
        Description = "Программа обучения по технологиям промышленного программирования (магистратура)."
    },
    
    // Программы обучения для Омского государственного технического университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 13,
        EducationProgramId = 19,
        EducationLevel = 3,
        Duration = 4,
        Id = 34,
        TuitionPerYear = 340000,
        Description = "Программа обучения по технологиям управления организацией (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 13,
        EducationProgramId = 22,
        EducationLevel = 4,
        Duration = 5,
        Id = 35,
        TuitionPerYear = 360000,
        Description = "Программа обучения по программно-аппаратным комплексам защиты информации (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 13,
        EducationProgramId = 28,
        EducationLevel = 5,
        Duration = 2,
        Id = 36,
        TuitionPerYear = 380000,
        Description = "Программа обучения по технологиям программирования систем и сетей (магистратура)."
    },
    
    // Программы обучения для Самарского государственного университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 14,
        EducationProgramId = 29,
        EducationLevel = 3,
        Duration = 4,
        Id = 37,
        TuitionPerYear = 350000,
        Description = "Программа обучения по информационным системам (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 14,
        EducationProgramId = 23,
        EducationLevel = 4,
        Duration = 5,
        Id = 38,
        TuitionPerYear = 370000,
        Description = "Программа обучения по компьютерному моделированию и комплексной автоматизации проектирования (специалитет)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 14,
        EducationProgramId = 25,
        EducationLevel = 5,
        Duration = 2,
        Id = 39,
        TuitionPerYear = 390000,
        Description = "Программа обучения по программированию в интеллектуальных робототехнических системах (магистратура)."
    },
    
    // Программы обучения для Ростовского государственного университета
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 15,
        EducationProgramId = 15,
        EducationLevel = 3,
        Duration = 4,
        Id = 40,
        TuitionPerYear = 330000,
        Description = "Программа обучения по антикризисному управлению (бакалавриат)."
    },
    new ProgramEducationalOrganization
    {
        EducationalOrganizationId = 15,
        EducationProgramId = 20,
        EducationLevel = 4,
        Duration = 5,
        Id = 41,
        TuitionPerYear = 350000,
        Description = "Программа обучения по программному обеспечению экономической деятельности (специалитет)."
    }
            });
            modelBuilder.Entity<DisciplineEducationProgram>().HasData(new DisciplineEducationProgram[]
{
    // Программа: 01.05.01 Фундаментальные математика и механика
    new DisciplineEducationProgram
    {
        Id = 1,
        DisciplineId = 1, // Математика (профильный уровень)
        EducationProgramId = 1
    },
    new DisciplineEducationProgram
    {
        Id = 2,
        DisciplineId = 15, // Русский язык
        EducationProgramId = 1
    },
    new DisciplineEducationProgram
    {
        Id = 3,
        DisciplineId = 6, // Информатика
        EducationProgramId = 1
    },

    // Программа: 09.03.01 Прикладная информатика
    new DisciplineEducationProgram
    {
        Id = 4,
        DisciplineId = 1,
        EducationProgramId = 2
    },
    new DisciplineEducationProgram
    {
        Id = 5,
        DisciplineId = 15,
        EducationProgramId = 2
    },
    new DisciplineEducationProgram
    {
        Id = 6,
        DisciplineId = 6,
        EducationProgramId = 2
    },

    // Программа: 09.03.02 Информационные системы и технологии
    new DisciplineEducationProgram
    {
        Id = 7,
        DisciplineId = 1,
        EducationProgramId = 3
    },
    new DisciplineEducationProgram
    {
        Id = 8,
        DisciplineId = 15,
        EducationProgramId = 3
    },
    new DisciplineEducationProgram
    {
        Id = 9,
        DisciplineId = 6,
        EducationProgramId = 3
    },

    // Программа: 09.03.03 Прикладная информатика в экономике
    new DisciplineEducationProgram
    {
        Id = 10,
        DisciplineId = 1,
        EducationProgramId = 4
    },
    new DisciplineEducationProgram
    {
        Id = 11,
        DisciplineId = 15,
        EducationProgramId = 4
    },
    new DisciplineEducationProgram
    {
        Id = 12,
        DisciplineId = 5, // Обществознание
        EducationProgramId = 4
    },

    // Программа: 09.03.04 Программная инженерия
    new DisciplineEducationProgram
    {
        Id = 13,
        DisciplineId = 1,
        EducationProgramId = 5
    },
    new DisciplineEducationProgram
    {
        Id = 14,
        DisciplineId = 15,
        EducationProgramId = 5
    },
    new DisciplineEducationProgram
    {
        Id = 15,
        DisciplineId = 6,
        EducationProgramId = 5
    },

    // Программа: 09.03.05 Информационные системы и технологии (в экономике)
    new DisciplineEducationProgram
    {
        Id = 16,
        DisciplineId = 1,
        EducationProgramId = 6
    },
    new DisciplineEducationProgram
    {
        Id = 17,
        DisciplineId = 15,
        EducationProgramId = 6
    },
    new DisciplineEducationProgram
    {
        Id = 18,
        DisciplineId = 5,
        EducationProgramId = 6
    },

    // Программа: 09.03.06 Программирование
    new DisciplineEducationProgram
    {
        Id = 19,
        DisciplineId = 1,
        EducationProgramId = 7
    },
    new DisciplineEducationProgram
    {
        Id = 20,
        DisciplineId = 15,
        EducationProgramId = 7
    },
    new DisciplineEducationProgram
    {
        Id = 21,
        DisciplineId = 6,
        EducationProgramId = 7
    },

    // Программа: 09.03.07 Веб-технологии
    new DisciplineEducationProgram
    {
        Id = 22,
        DisciplineId = 1,
        EducationProgramId = 8
    },
    new DisciplineEducationProgram
    {
        Id = 23,
        DisciplineId = 15,
        EducationProgramId = 8
    },
    new DisciplineEducationProgram
    {
        Id = 24,
        DisciplineId = 6,
        EducationProgramId = 8
    },

    // Программа: 09.03.08 Математическое обеспечение и администрирование информационных систем
    new DisciplineEducationProgram
    {
        Id = 25,
        DisciplineId = 1,
        EducationProgramId = 9
    },
    new DisciplineEducationProgram
    {
        Id = 26,
        DisciplineId = 15,
        EducationProgramId = 9
    },
    new DisciplineEducationProgram
    {
        Id = 27,
        DisciplineId = 6,
        EducationProgramId = 9
    },

    // Программа: 09.03.09 Информационные системы и технологии (в здравоохранении)
    new DisciplineEducationProgram
    {
        Id = 28,
        DisciplineId = 1,
        EducationProgramId = 10
    },
    new DisciplineEducationProgram
    {
        Id = 29,
        DisciplineId = 15,
        EducationProgramId = 10
    },
    new DisciplineEducationProgram
    {
        Id = 30,
        DisciplineId = 6,
        EducationProgramId = 10
    },

    // Программа: 09.03.10 Информационные системы и технологии (в бизнесе)
    new DisciplineEducationProgram
    {
        Id = 31,
        DisciplineId = 1,
        EducationProgramId = 11
    },
    new DisciplineEducationProgram
    {
        Id = 32,
        DisciplineId = 15,
        EducationProgramId = 11
    },
    new DisciplineEducationProgram
    {
        Id = 33,
        DisciplineId = 5,
        EducationProgramId = 11
    },

    // Программа: 09.03.11 Информационная безопасность
    new DisciplineEducationProgram
    {
        Id = 34,
        DisciplineId = 1,
        EducationProgramId = 12
    },
    new DisciplineEducationProgram
    {
        Id = 35,
        DisciplineId = 15,
        EducationProgramId = 12
    },
    new DisciplineEducationProgram
    {
        Id = 36,
        DisciplineId = 6,
        EducationProgramId = 12
    },

    // Программа: 09.03.12 Информационные технологии в юриспруденции
    new DisciplineEducationProgram
    {
        Id = 37,
        DisciplineId = 1,
        EducationProgramId = 13
    },
    new DisciplineEducationProgram
    {
        Id = 38,
        DisciplineId = 15,
        EducationProgramId = 13
    },
    new DisciplineEducationProgram
    {
        Id = 39,
        DisciplineId = 5,
        EducationProgramId = 13
    },

    // Программа: 09.03.13 Наноинженерия
    new DisciplineEducationProgram
    {
        Id = 40,
        DisciplineId = 1,
        EducationProgramId = 14
    },
    new DisciplineEducationProgram
    {
        Id = 41,
        DisciplineId = 15,
        EducationProgramId = 14
    },
    new DisciplineEducationProgram
    {
        Id = 42,
        DisciplineId = 2, // Физика
        EducationProgramId = 14
    },

    // Программа: 09.03.14 Антикризисное управление
    new DisciplineEducationProgram
    {
        Id = 43,
        DisciplineId = 1,
        EducationProgramId = 15
    },
    new DisciplineEducationProgram
    {
        Id = 44,
        DisciplineId = 15,
        EducationProgramId = 15
    },
    new DisciplineEducationProgram
    {
        Id = 45,
        DisciplineId = 5,
        EducationProgramId = 15
    },

    // Программа: 09.03.15 Управление инновациями
    new DisciplineEducationProgram
    {
        Id = 46,
        DisciplineId = 1,
        EducationProgramId = 16
    },
    new DisciplineEducationProgram
    {
        Id = 47,
        DisciplineId = 15,
        EducationProgramId = 16
    },
    new DisciplineEducationProgram
    {
        Id = 48,
        DisciplineId = 5,
        EducationProgramId = 16
    },

    // Программа: 09.03.16 Информатика и вычислительная техника
    new DisciplineEducationProgram
    {
        Id = 49,
        DisciplineId = 1,
        EducationProgramId = 17
    },
    new DisciplineEducationProgram
    {
        Id = 50,
        DisciplineId = 15,
        EducationProgramId = 17
    },
    new DisciplineEducationProgram
    {
        Id = 51,
        DisciplineId = 6,
        EducationProgramId = 17
    },

    // Программа: 09.03.17 Интеллектуальные системы и технологии
    new DisciplineEducationProgram
    {
        Id = 52,
        DisciplineId = 1,
        EducationProgramId = 18
    },
    new DisciplineEducationProgram
    {
        Id = 53,
        DisciplineId = 15,
        EducationProgramId = 18
    },
    new DisciplineEducationProgram
    {
        Id = 54,
        DisciplineId = 6,
        EducationProgramId = 18
    },

    // Программа: 09.03.18 Технологии управления организацией
    new DisciplineEducationProgram
    {
        Id = 55,
        DisciplineId = 1,
        EducationProgramId = 19
    },
    new DisciplineEducationProgram
    {
        Id = 56,
        DisciplineId = 15,
        EducationProgramId = 19
    },
    new DisciplineEducationProgram
    {
        Id = 57,
        DisciplineId = 5,
        EducationProgramId = 19
    },

    // Программа: 09.03.19 Программное обеспечение экономической деятельности
    new DisciplineEducationProgram
    {
        Id = 58,
        DisciplineId = 1,
        EducationProgramId = 20
    },
    new DisciplineEducationProgram
    {
        Id = 59,
        DisciplineId = 15,
        EducationProgramId = 20
    },
    new DisciplineEducationProgram
    {
        Id = 60,
        DisciplineId = 5,
        EducationProgramId = 20
    },

    // Программа: 09.03.20 Программное обеспечение информационных технологий
    new DisciplineEducationProgram
    {
        Id = 61,
        DisciplineId = 1,
        EducationProgramId = 21
    },
    new DisciplineEducationProgram
    {
        Id = 62,
        DisciplineId = 15,
        EducationProgramId = 21
    },
    new DisciplineEducationProgram
    {
        Id = 63,
        DisciplineId = 6,
        EducationProgramId = 21
    },

    // Программа: 09.03.21 Программно-аппаратные комплексы защиты информации
    new DisciplineEducationProgram
    {
        Id = 64,
        DisciplineId = 1,
        EducationProgramId = 22
    },
    new DisciplineEducationProgram
    {
        Id = 65,
        DisciplineId = 15,
        EducationProgramId = 22
    },
    new DisciplineEducationProgram
    {
        Id = 66,
        DisciplineId = 6,
        EducationProgramId = 22
    },

    // Программа: 09.03.22 Компьютерное моделирование и комплексная автоматизация проектирования
    new DisciplineEducationProgram
    {
        Id = 67,
        DisciplineId = 1,
        EducationProgramId = 23
    },
    new DisciplineEducationProgram
    {
        Id = 68,
        DisciplineId = 15,
        EducationProgramId = 23
    },
    new DisciplineEducationProgram
    {
        Id = 69,
        DisciplineId = 6,
        EducationProgramId = 23
    },

    // Программа: 09.03.23 Прикладное программирование
    new DisciplineEducationProgram
    {
        Id = 70,
        DisciplineId = 1,
        EducationProgramId = 24
    },
    new DisciplineEducationProgram
    {
        Id = 71,
        DisciplineId = 15,
        EducationProgramId = 24
    },
    new DisciplineEducationProgram
    {
        Id = 72,
        DisciplineId = 6,
        EducationProgramId = 24
    },

    // Программа: 09.03.24 Программирование в интеллектуальных робототехнических системах
    new DisciplineEducationProgram
    {
        Id = 73,
        DisciplineId = 1,
        EducationProgramId = 25
    },
    new DisciplineEducationProgram
    {
        Id = 74,
        DisciplineId = 15,
        EducationProgramId = 25
    },
    new DisciplineEducationProgram
    {
        Id = 75,
        DisciplineId = 6,
        EducationProgramId = 25
    },

    // Программа: 09.03.25 Киберфизические системы
    new DisciplineEducationProgram
    {
        Id = 76,
        DisciplineId = 1,
        EducationProgramId = 26
    },
    new DisciplineEducationProgram
    {
        Id = 77,
        DisciplineId = 15,
        EducationProgramId = 26
    },
    new DisciplineEducationProgram
    {
        Id = 78,
        DisciplineId = 6,
        EducationProgramId = 26
    },

    // Программа: 09.03.26 Технологии промышленного программирования
    new DisciplineEducationProgram
    {
        Id = 79,
        DisciplineId = 1,
        EducationProgramId = 27
    },
    new DisciplineEducationProgram
    {
        Id = 80,
        DisciplineId = 15,
        EducationProgramId = 27
    },
    new DisciplineEducationProgram
    {
        Id = 81,
        DisciplineId = 6,
        EducationProgramId = 27
    },

    // Программа: 09.03.27 Технологии программирования систем и сетей
    new DisciplineEducationProgram
    {
        Id = 82,
        DisciplineId = 1,
        EducationProgramId = 28
    },
    new DisciplineEducationProgram
    {
        Id = 83,
        DisciplineId = 15,
        EducationProgramId = 28
    },
    new DisciplineEducationProgram
    {
        Id = 84,
        DisciplineId = 6,
        EducationProgramId = 28
    },

    // Программа: 09.03.28 Информационные системы
    new DisciplineEducationProgram
    {
        Id = 85,
        DisciplineId = 1,
        EducationProgramId = 29
    },
    new DisciplineEducationProgram
    {
        Id = 86,
        DisciplineId = 15,
        EducationProgramId = 29
    },
    new DisciplineEducationProgram
    {
        Id = 87,
        DisciplineId = 6,
        EducationProgramId = 29
    },

    // Программа: 09.02.07 Информационные системы и программирование
    new DisciplineEducationProgram
    {
        Id = 88,
        DisciplineId = 1,
        EducationProgramId = 30
    },
    new DisciplineEducationProgram
    {
        Id = 89,
        DisciplineId = 15,
        EducationProgramId = 30
    },
    new DisciplineEducationProgram
    {
        Id = 90,
        DisciplineId = 6,
        EducationProgramId = 30
    }
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
        ProgramEducationalOrganizationId = 7,
        IsBudget = true,
        Score = 4.6,
        Year = 2023
    },
    new PassingScore
    {
        Id = 6,
        ProgramEducationalOrganizationId = 8,
        IsBudget = true,
        Score = 4.3,
        Year = 2023
    },
    new PassingScore
    {
        Id = 7,
        ProgramEducationalOrganizationId = 7,
        IsBudget = false,
        Score = 4.1,
        Year = 2023
    },
    new PassingScore
    {
        Id = 8,
        ProgramEducationalOrganizationId = 8,
        IsBudget = false,
        Score = 3.8,
        Year = 2023
    },
    // Добавим минимальные баллы для остальных программ обучения
    new PassingScore
    {
        Id = 9,
        ProgramEducationalOrganizationId = 2,
        IsBudget = true,
        Score = 310,
        Year = 2023
    },
    new PassingScore
    {
        Id = 10,
        ProgramEducationalOrganizationId = 2,
        IsBudget = false,
        Score = 200,
        Year = 2023
    },
    new PassingScore
    {
        Id = 11,
        ProgramEducationalOrganizationId = 3,
        IsBudget = true,
        Score = 300,
        Year = 2023
    },
    new PassingScore
    {
        Id = 12,
        ProgramEducationalOrganizationId = 3,
        IsBudget = false,
        Score = 210,
        Year = 2023
    },
    new PassingScore
    {
        Id = 13,
        ProgramEducationalOrganizationId = 4,
        IsBudget = true,
        Score = 320,
        Year = 2023
    },
    new PassingScore
    {
        Id = 14,
        ProgramEducationalOrganizationId = 4,
        IsBudget = false,
        Score = 230,
        Year = 2023
    },
    new PassingScore
    {
        Id = 15,
        ProgramEducationalOrganizationId = 5,
        IsBudget = true,
        Score = 290,
        Year = 2023
    },
    new PassingScore
    {
        Id = 16,
        ProgramEducationalOrganizationId = 5,
        IsBudget = false,
        Score = 180,
        Year = 2023
    },
    new PassingScore
    {
        Id = 17,
        ProgramEducationalOrganizationId = 9,
        IsBudget = true,
        Score = 310,
        Year = 2023
    },
    new PassingScore
    {
        Id = 18,
        ProgramEducationalOrganizationId = 9,
        IsBudget = false,
        Score = 190,
        Year = 2023
    },
    new PassingScore
    {
        Id = 19,
        ProgramEducationalOrganizationId = 10,
        IsBudget = true,
        Score = 300,
        Year = 2023
    },
    new PassingScore
    {
        Id = 20,
        ProgramEducationalOrganizationId = 10,
        IsBudget = false,
        Score = 185,
        Year = 2023
    },
    new PassingScore
    {
        Id = 21,
        ProgramEducationalOrganizationId = 11,
        IsBudget = true,
        Score = 295,
        Year = 2023
    },
    new PassingScore
    {
        Id = 22,
        ProgramEducationalOrganizationId = 11,
        IsBudget = false,
        Score = 180,
        Year = 2023
    },
    new PassingScore
    {
        Id = 23,
        ProgramEducationalOrganizationId = 12,
        IsBudget = true,
        Score = 285,
        Year = 2023
    },
    new PassingScore
    {
        Id = 24,
        ProgramEducationalOrganizationId = 12,
        IsBudget = false,
        Score = 175,
        Year = 2023
    },
    new PassingScore
    {
        Id = 25,
        ProgramEducationalOrganizationId = 13,
        IsBudget = true,
        Score = 290,
        Year = 2023
    },
    new PassingScore
    {
        Id = 26,
        ProgramEducationalOrganizationId = 13,
        IsBudget = false,
        Score = 185,
        Year = 2023
    },
    new PassingScore
    {
        Id = 27,
        ProgramEducationalOrganizationId = 14,
        IsBudget = true,
        Score = 280,
        Year = 2023
    },
    new PassingScore
    {
        Id = 28,
        ProgramEducationalOrganizationId = 14,
        IsBudget = false,
        Score = 170,
        Year = 2023
    },
    new PassingScore
    {
        Id = 29,
        ProgramEducationalOrganizationId = 15,
        IsBudget = true,
        Score = 275,
        Year = 2023
    },
    new PassingScore
    {
        Id = 30,
        ProgramEducationalOrganizationId = 15,
        IsBudget = false,
        Score = 165,
        Year = 2023
    },
    new PassingScore
    {
        Id = 31,
        ProgramEducationalOrganizationId = 16,
        IsBudget = true,
        Score = 290,
        Year = 2023
    },
    new PassingScore
    {
        Id = 32,
        ProgramEducationalOrganizationId = 16,
        IsBudget = false,
        Score = 180,
        Year = 2023
    },
    new PassingScore
    {
        Id = 33,
        ProgramEducationalOrganizationId = 17,
        IsBudget = true,
        Score = 285,
        Year = 2023
    },
    new PassingScore
    {
        Id = 34,
        ProgramEducationalOrganizationId = 17,
        IsBudget = false,
        Score = 175,
        Year = 2023
    },
    new PassingScore
    {
        Id = 35,
        ProgramEducationalOrganizationId = 18,
        IsBudget = true,
        Score = 290,
        Year = 2023
    },
    new PassingScore
    {
        Id = 36,
        ProgramEducationalOrganizationId = 18,
        IsBudget = false,
        Score = 180,
        Year = 2023
    },
    new PassingScore
    {
        Id = 37,
        ProgramEducationalOrganizationId = 19,
        IsBudget = true,
        Score = 295,
        Year = 2023
    },
    new PassingScore
    {
        Id = 38,
        ProgramEducationalOrganizationId = 19,
        IsBudget = false,
        Score = 185,
        Year = 2023
    },
    new PassingScore
    {
        Id = 39,
        ProgramEducationalOrganizationId = 20,
        IsBudget = true,
        Score = 300,
        Year = 2023
    },
    new PassingScore
    {
        Id = 40,
        ProgramEducationalOrganizationId = 20,
        IsBudget = false,
        Score = 190,
        Year = 2023
    },
    new PassingScore
    {
        Id = 41,
        ProgramEducationalOrganizationId = 21,
        IsBudget = true,
        Score = 310,
        Year = 2023
    },
    new PassingScore
    {
        Id = 42,
        ProgramEducationalOrganizationId = 21,
        IsBudget = false,
        Score = 200,
        Year = 2023
    },
    new PassingScore
    {
        Id = 43,
        ProgramEducationalOrganizationId = 22,
        IsBudget = true,
        Score = 320,
        Year = 2023
    },
    new PassingScore
    {
        Id = 44,
        ProgramEducationalOrganizationId = 22,
        IsBudget = false,
        Score = 210,
        Year = 2023
    },
    new PassingScore
    {
        Id = 45,
        ProgramEducationalOrganizationId = 23,
        IsBudget = true,
        Score = 315,
        Year = 2023
    },
    new PassingScore
    {
        Id = 46,
        ProgramEducationalOrganizationId = 23,
        IsBudget = false,
        Score = 205,
        Year = 2023
    },
    new PassingScore
    {
        Id = 47,
        ProgramEducationalOrganizationId = 24,
        IsBudget = true,
        Score = 310,
        Year = 2023
    },
    new PassingScore
    {
        Id = 48,
        ProgramEducationalOrganizationId = 24,
        IsBudget = false,
        Score = 200,
        Year = 2023
    },
    new PassingScore
    {
        Id = 49,
        ProgramEducationalOrganizationId = 25,
        IsBudget = true,
        Score = 320,
        Year = 2023
    },
    new PassingScore
    {
        Id = 50,
        ProgramEducationalOrganizationId = 25,
        IsBudget = false,
        Score = 210,
        Year = 2023
    }
});

			modelBuilder.Entity<Feedback>().HasData(new Feedback[]
{
    // Московский государственный университет им. М.В. Ломоносова
    new Feedback
	{
		Id = 1,
		Name = "Мария Стеклова",
		TextFeedback = "Закончила бакалавриат в МГУ по специальности математика и компьютерные науки. Преподаватели - настоящие профессионалы с огромным опытом. Учиться было сложно, но очень интересно!",
		EducationalOrganizationId = 1
	},
	new Feedback
	{
		Id = 2,
		Name = "Алексей Иванов",
		TextFeedback = "Учился в магистратуре по фундаментальной информатике. Программа очень насыщенная, требовалось много усилий, но это того стоило. Спасибо преподавателям за их поддержку!",
		EducationalOrganizationId = 1
	},

    // Московский физико-технический институт
    new Feedback
	{
		Id = 3,
		Name = "Екатерина Петрова",
		TextFeedback = "Закончила бакалавриат по прикладной математике и информатике в МФТИ. Учиться было непросто, но преподаватели всегда помогали и поддерживали. Отличный вуз!",
		EducationalOrganizationId = 2
	},
	new Feedback
	{
		Id = 4,
		Name = "Дмитрий Смирнов",
		TextFeedback = "Получил степень магистра по прикладной математике и физике. Преподаватели - эксперты в своей области, учебный процесс был сложным, но интересным.",
		EducationalOrganizationId = 2
	},

    // Национальный исследовательский ядерный университет «МИФИ»
    new Feedback
	{
		Id = 5,
		Name = "Ольга Сидорова",
		TextFeedback = "Училась на бакалавриате по программированию в МИФИ. Преподаватели очень компетентные, но учиться было нелегко. Университет предоставляет отличные возможности для развития.",
		EducationalOrganizationId = 3
	},
	new Feedback
	{
		Id = 6,
		Name = "Иван Кузнецов",
		TextFeedback = "Заканчиваю магистратуру по киберфизическим системам. Преподаватели всегда готовы помочь, но учебная нагрузка значительная. Это отличный опыт!",
		EducationalOrganizationId = 3
	},

    // Московский государственный технический университет им. Н.Э. Баумана
    new Feedback
	{
		Id = 7,
		Name = "Анастасия Воронцова",
		TextFeedback = "Закончила бакалавриат по информационной безопасности в МГТУ. Учеба была очень сложной, но преподаватели - профессионалы своего дела, всегда помогали разобраться.",
		EducationalOrganizationId = 4
	},
	new Feedback
	{
		Id = 8,
		Name = "Сергей Михайлов",
		TextFeedback = "Получил степень магистра по интеллектуальным системам и технологиям. Учиться было трудно, но очень интересно благодаря опытным преподавателям.",
		EducationalOrganizationId = 4
	},

    // Медицинский колледж Управления делами Президента Российской Федерации
    new Feedback
	{
		Id = 9,
		Name = "Наталья Николаева",
		TextFeedback = "Закончила колледж по биотехнологии. Преподаватели обладают большим опытом, учиться было непросто, но знания полученные здесь бесценны.",
		EducationalOrganizationId = 5
	},
	new Feedback
	{
		Id = 10,
		Name = "Виктор Павлов",
		TextFeedback = "Учился на биологическом направлении. Преподаватели отличные, учёба давалась тяжело, но я доволен результатом.",
		EducationalOrganizationId = 5
	},

    // Колледж современных технологий имени Героя Советского Союза М.Ф. Панова
    new Feedback
	{
		Id = 11,
		Name = "Елена Новикова",
		TextFeedback = "Получила профессию по информационным системам. Преподаватели помогали на каждом шагу, учиться было интересно и познавательно.",
		EducationalOrganizationId = 6
	},
	new Feedback
	{
		Id = 12,
		Name = "Михаил Петров",
		TextFeedback = "Закончила колледж по специальности информационные системы и программирование. Учеба была насыщенной и сложной, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 6
	},

    // Санкт-Петербургский государственный университет
    new Feedback
	{
		Id = 13,
		Name = "Андрей Смирнов",
		TextFeedback = "Получил бакалавра по информационным системам и технологиям в бизнесе. Преподаватели - профессионалы, учеба была сложной, но это стоило того.",
		EducationalOrganizationId = 7
	},
	new Feedback
	{
		Id = 14,
		Name = "Анна Васильева",
		TextFeedback = "Училась на специалитете по информационной безопасности. Учеба была непростой, но преподаватели всегда были готовы помочь.",
		EducationalOrganizationId = 7
	},

    // Новосибирский государственный университет
    new Feedback
	{
		Id = 15,
		Name = "Оксана Федорова",
		TextFeedback = "Закончила бакалавриат по программной инженерии. Преподаватели отличные, учебный процесс насыщенный, учиться было сложно, но интересно.",
		EducationalOrganizationId = 8
	},
	new Feedback
	{
		Id = 16,
		Name = "Евгений Иванов",
		TextFeedback = "Учился на специалитете по информационным системам и технологиям в экономике. Преподаватели всегда помогали, учиться было непросто.",
		EducationalOrganizationId = 8
	},

    // Уральский федеральный университет
    new Feedback
	{
		Id = 17,
		Name = "Валерия Петрова",
		TextFeedback = "Закончила бакалавриат по информатике и вычислительной технике. Учиться было трудно, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 9
	},
	new Feedback
	{
		Id = 18,
		Name = "Александр Сидоров",
		TextFeedback = "Получил магистра по программному обеспечению информационных технологий. Учеба была сложной, но преподаватели помогали на каждом этапе.",
		EducationalOrganizationId = 9
	},

    // Нижегородский государственный университет им. Н.И. Лобачевского
    new Feedback
	{
		Id = 19,
		Name = "Ксения Смирнова",
		TextFeedback = "Закончила бакалавриат по информационным системам в здравоохранении. Учеба была интересной и сложной, преподаватели отличные.",
		EducationalOrganizationId = 10
	},
	new Feedback
	{
		Id = 20,
		Name = "Владимир Петров",
		TextFeedback = "Учился на специалитете по антикризисному управлению. Преподаватели профессионалы своего дела, учеба была насыщенной и трудной.",
		EducationalOrganizationId = 10
	},

    // Казанский (Приволжский) федеральный университет
    new Feedback
	{
		Id = 21,
		Name = "Елизавета Павлова",
		TextFeedback = "Закончила бакалавриат по информационным технологиям в юриспруденции. Учиться было сложно, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 11
	},
	new Feedback
	{
		Id = 22,
		Name = "Максим Иванов",
		TextFeedback = "Учился на специалитете по наноинженерии. Преподаватели - профессионалы, учебный процесс был сложным, но интересным.",
		EducationalOrganizationId = 11
	},

    // Южно-Уральский государственный университет
    new Feedback
	{
		Id = 23,
		Name = "Ольга Смирнова",
		TextFeedback = "Закончила бакалавриат по веб-технологиям. Учеба была сложной, но преподаватели всегда помогали разобраться в трудных темах.",
		EducationalOrganizationId = 12
	},
	new Feedback
	{
		Id = 24,
		Name = "Игорь Кузнецов",
		TextFeedback = "Получил магистра по технологиям промышленного программирования. Преподаватели - профессионалы, учебный процесс был трудным, но интересным.",
		EducationalOrganizationId = 12
	},

    // Омский государственный технический университет
    new Feedback
	{
		Id = 25,
		Name = "Елена Иванова",
		TextFeedback = "Закончила бакалавриат по технологиям управления организацией. Учеба была сложной, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 13
	},
	new Feedback
	{
		Id = 26,
		Name = "Алексей Смирнов",
		TextFeedback = "Учился на специалитете по программно-аппаратным комплексам защиты информации. Преподаватели отличные, учебный процесс был насыщенным.",
		EducationalOrganizationId = 13
	},

    // Самарский государственный университет
    new Feedback
	{
		Id = 27,
		Name = "Оксана Новикова",
		TextFeedback = "Закончила бакалавриат по информационным системам. Учеба была сложной, но преподаватели всегда помогали.",
		EducationalOrganizationId = 14
	},
	new Feedback
	{
		Id = 28,
		Name = "Евгений Петров",
		TextFeedback = "Учился на специалитете по компьютерному моделированию и комплексной автоматизации проектирования. Преподаватели профессионалы, учебный процесс был трудным, но интересным.",
		EducationalOrganizationId = 14
	},

    // Ростовский государственный университет
    new Feedback
	{
		Id = 29,
		Name = "Мария Смирнова",
		TextFeedback = "Закончила бакалавриат по антикризисному управлению. Учеба была сложной, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 15
	},
	new Feedback
	{
		Id = 30,
		Name = "Владимир Кузнецов",
		TextFeedback = "Учился на магистратуре по киберфизическим системам. Преподаватели профессионалы, учебный процесс был насыщенным.",
		EducationalOrganizationId = 15
	},

    // Уфимский государственный авиационный технический университет
    new Feedback
	{
		Id = 31,
		Name = "Анна Петрова",
		TextFeedback = "Закончила бакалавриат по информатике и вычислительной технике. Учеба была сложной, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 16
	},
	new Feedback
	{
		Id = 32,
		Name = "Иван Васильев",
		TextFeedback = "Получил магистра по программно-аппаратным комплексам защиты информации. Преподаватели отличные, учебный процесс был трудным.",
		EducationalOrganizationId = 16
	},

    // Сибирский федеральный университет
    new Feedback
	{
		Id = 33,
		Name = "Наталья Смирнова",
		TextFeedback = "Закончила бакалавриат по фундаментальной математике и механике. Учеба была сложной, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 17
	},
	new Feedback
	{
		Id = 34,
		Name = "Сергей Иванов",
		TextFeedback = "Учился на специалитете по управлению инновациями. Преподаватели - профессионалы, учебный процесс был трудным, но интересным.",
		EducationalOrganizationId = 17
	},

    // Воронежский государственный университет
    new Feedback
	{
		Id = 35,
		Name = "Марина Кузнецова",
		TextFeedback = "Закончила бакалавриат по информационным системам. Учеба была сложной, но преподаватели всегда помогали разобраться в трудных темах.",
		EducationalOrganizationId = 18
	},
	new Feedback
	{
		Id = 36,
		Name = "Александр Смирнов",
		TextFeedback = "Получил магистра по программно-аппаратным комплексам защиты информации. Преподаватели профессионалы, учебный процесс был интересным.",
		EducationalOrganizationId = 18
	},

    // Пермский государственный национальный исследовательский университет
    new Feedback
	{
		Id = 37,
		Name = "Ирина Петрова",
		TextFeedback = "Закончила бакалавриат по химии. Учеба была сложной, но преподаватели всегда поддерживали.",
		EducationalOrganizationId = 19
	},
	new Feedback
	{
		Id = 38,
		Name = "Дмитрий Васильев",
		TextFeedback = "Учился на магистратуре по физической химии. Преподаватели - профессионалы, учебный процесс был насыщенным и интересным.",
		EducationalOrganizationId = 19
	},

    // Волгоградский государственный технический университет
    new Feedback
	{
		Id = 39,
		Name = "Ольга Смирнова",
		TextFeedback = "Закончила бакалавриат по информационным системам. Учеба была сложной, но преподаватели всегда помогали.",
		EducationalOrganizationId = 20
	},
	new Feedback
	{
		Id = 40,
		Name = "Алексей Петров",
		TextFeedback = "Учился на специалитете по программно-аппаратным комплексам защиты информации. Преподаватели профессионалы, учебный процесс был трудным, но интересным.",
		EducationalOrganizationId = 20
	}
});

		}


		public DbSet<Specialization> Specializations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TypeEducationalOrganization> TypeEducationalOrganizations { get; set; }
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
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
