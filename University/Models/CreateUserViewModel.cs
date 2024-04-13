using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Email обязательное поле")]
        [EmailAddress(ErrorMessage = "Неверный Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password обязательное поле")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Имя обязательное поле")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Фамилия обязательное поле")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Телефон обязательное поле")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Логин обязательное поле")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Тип пользователя обязательное поле")]
        public string Role { get; set; }
    }
}
