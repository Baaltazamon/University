using System.Security.Claims;
using Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Models;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace University.Service.IdentityService
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;

        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUser(CreateUserViewModel model)
        {
            var user = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                PhoneNumber = model.Phone,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return await _userManager.AddToRoleAsync(user, model.Role);
            }
            return result;
        }

        public async Task<List<UserViewModel>> GetAllUsers()
        {
            var results = await _userManager.Users.ToListAsync();
            var userViewModels = new List<UserViewModel>();
            foreach (var user in results)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var userViewModel = new UserViewModel
                {
                    User = user,
                    Roles = roles
                };
                userViewModels.Add(userViewModel);
            }
            return userViewModels;
        }

        public async Task<EditUserViewModel?> GetUserById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return null;
            }
            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };
            var roles = await _userManager.GetRolesAsync(user);
            model.Role = roles.First();
            return model;
        }

        public async Task<IdentityResult> EditUser(EditUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            
            user.UserName = model.UserName;
            user.FirstName = model.FirstName;
            user.MiddleName = model.MiddleName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);
            var currentRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, currentRoles);
            await _userManager.AddToRoleAsync(user, model.Role);
            return result;
        }

        public async Task<IdentityResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id); 
            return await _userManager.DeleteAsync(user);
        }

        public async Task<bool> CreateStartUsers()
        {
            var res = await _userManager.Users.CountAsync();
            if (res > 0)
                return true;
            var admin = new User
            {
                UserName = "admin",
                Email = "admin@mail.ru",
                FirstName = "Виктор",
                MiddleName = "Дмитриевич",
                LastName = "Земский",
                PhoneNumber = "89158529647",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false
            };
            var result = await _userManager.CreateAsync(admin, "Admin1!");
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(admin, "АДМИНИСТРАТОР");
            }

            var moder1 = new User
            {
                UserName = "moder1",
                Email = "moder1@mail.ru",
                FirstName = "Иван",
                MiddleName = "Иванович",
                LastName = "Иванов",
                PhoneNumber = "89813854842",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = true
            };
            result = await _userManager.CreateAsync(moder1, "Moder1!");
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(moder1, "МОДЕРАТОР");
            }
            var moder2 = new User
            {
                UserName = "moder2",
                Email = "moder2@mail.ru",
                FirstName = "Пётр",
                MiddleName = "Петрович",
                LastName = "Петров",
                PhoneNumber = "89134128850",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = true
            };
            result = await _userManager.CreateAsync(moder2, "Moder2!");
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(moder2, "МОДЕРАТОР");
            }
            var moder3 = new User
            {
                UserName = "moder3",
                Email = "moder3@mail.ru",
                FirstName = "Максим",
                MiddleName = "Максимович",
                LastName = "Максимов",
                PhoneNumber = "89657824598",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = true
            };
            result = await _userManager.CreateAsync(moder3, "Moder3!");
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(moder3, "МОДЕРАТОР");
            }

            return true;
        }

        public async Task<User> GetUserByName(string name)
        {
            return await _userManager.FindByNameAsync(name);
        }

        public async Task<string> GetUserRole(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            return roles.First();
        }
    }
}
