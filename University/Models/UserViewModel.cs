using Data.Context;

namespace University.Models
{
    public class UserViewModel
    {
        public User User { get; set; } // Информация о пользователе
        public IList<string> Roles { get; set; } // Список ролей пользователя
    }
}
