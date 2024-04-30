using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Data.Context
{
    /// <summary>
    /// Специальности
    /// </summary>
    [Table("Specialization")]
    public class Specialization
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Название обязательное поле")]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("is_deleted")]
        public bool IsDeleted { get; set; } = false;

        [Column("Description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// Тип образовательной организации
    /// </summary>
    [Table("TypeEducationalOrganization")]
    public class TypeEducationalOrganization
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("is_deleted")]
        public bool IsDeleted { get; set; } = false;

        [Column("Description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// Тип контакта
    /// </summary>
    [Table("TypeContact")]
    public class TypeContact
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("is_deleted")]
        public bool IsDeleted { get; set; } = false;

        [Column("Description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// Образовательная организация
    /// </summary>
    [Table("EducationalOrganization")]
    public class EducationalOrganization
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("Address")]
        public string Address { get; set; }

        [Required]
        [Column("Image")]
        public string Image { get; set; }

        [Required]
        [ForeignKey("TypeEducationalOrganization")]
        [Column("TypeId")]
        public int TypeId { get; set; }

        [Required]
        [ForeignKey("City")]
        [Column("CityId")]
        public int CityId { get; set; }

        [Required]
        [Column("is_deleted")]
        public bool IsDeleted { get; set; } = false;

        [Column("Description")]
        public string? Description { get; set; }

        public virtual TypeEducationalOrganization? TypeEducationalOrganization { get; set; }
        public virtual City? City { get; set; }
    }

    /// <summary>
    /// Контакты образовательной организации
    /// </summary>
    [Table("EducationalOrganizationContact")]
    public class EducationalOrganizationContact
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Value")]
        public string Value { get; set; }

        [Required]
        [ForeignKey("TypeContact")]
        [Column("TypeContactId")]
        public int TypeContactId { get; set; }

        [Required]
        [ForeignKey("EducationalOrganization")]
        [Column("EducationalOrganizationId")]
        public int EducationalOrganizationId { get; set; }

        public virtual TypeContact? TypeContact { get; set; }

        public virtual EducationalOrganization? EducationalOrganization { get; set; }
    }

    /// <summary>
    /// Уровень образования
    /// </summary>
    [Table("EducationLevel")]
    public class EducationLevel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("is_deleted")]
        public bool IsDeleted { get; set; } = false;

    }

    /// <summary>
    /// Программы обучения
    /// </summary>
    [Table("EducationProgram")]
    public class EducationProgram
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [ForeignKey("Specialization")]
        [Column("SpecializationId")]
        public int EducationalOrganizationSpecializationId { get; set; }

        [Required]
        [Column("Image")]
        public string? Image { get; set; }

        [Required]
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; } = false;

        [Column("Description")]
        public string? Description { get; set; }
        public virtual Specialization? Specialization { get; set; }
    }

    /// <summary>
    /// Программы обучения спецальности вуза
    /// </summary>
    [Table("ProgramEducationalOrganization")]
    public class ProgramEducationalOrganization
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [ForeignKey("EducationProgram")]
        [Column("EducationProgramId")]
        public int EducationProgramId { get; set; }

        [Required]
        [ForeignKey("Level")]
        [Column("EducationLevelId")]
        public int EducationLevel { get; set; }

        [Required]
        [ForeignKey("EducationalOrganization")]
        [Column("EducationalOrganizationId")]
        public int EducationalOrganizationId { get; set; }

        [Required]
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; } = false;

        [Column("Duration")]
        public int Duration { get; set; }

        [Column("TuitionPerYear")]
        public decimal TuitionPerYear { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        public virtual EducationLevel? Level { get; set; }
        public virtual EducationProgram? EducationProgram { get; set; }
        public virtual EducationalOrganization? EducationalOrganization { get; set; }
    }

    /// <summary>
    /// Минимальные вступительные баллы
    /// </summary>
    [Table("PassingScore")]
    public class PassingScore
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ProgramEducationalOrganization")]
        [Column("ProgramEducationalOrganizationId")]
        public int ProgramEducationalOrganizationId { get; set; }

        [Required]
        [Column("Score")]
        public double Score { get; set; }

        [Required]
        [Column("Year")]
        public short Year { get; set; }

        [Required]
        [Column("IsBudget")]
        public bool IsBudget { get; set; } = true;

        public virtual ProgramEducationalOrganization? ProgramEducationalOrganization { get; set; }
    }

    /// <summary>
    /// Предметы
    /// </summary>
    [Table("Discipline")]
    public class Discipline
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; } = false;
    }

    /// <summary>
    /// Предметы для поступления
    /// </summary>
    [Table("DisciplineEducationProgram")]
    public class DisciplineEducationProgram
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [ForeignKey("EducationProgram")]
        [Column("EducationProgramId")]
        public int EducationProgramId { get; set; }

        [Required]
        [ForeignKey("Discipline")]
        [Column("DisciplineId")]
        public int DisciplineId { get; set; }

        public virtual EducationProgram? EducationProgram { get; set; }
        public virtual Discipline? Discipline { get; set; }
    }

    /// <summary>
    /// Список городов
    /// </summary>
    [Table("City")]
    public class City
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; } = false;
    }

    [Table("Role")]
    public class Roles : IdentityRole
    {
        
    }

    [Table("User")]
    public class User : IdentityUser
    {
        [Required]
        [Column("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Column("MiddleName")]
        public string MiddleName { get; set; }

        [Required]
        [Column("LastName")]
        public string LastName { get; set; }
    }

    
    public class UserRoles : IdentityUserRole<string>
    {

    }
}