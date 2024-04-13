﻿using Data.Context;
using Microsoft.AspNetCore.Identity;
using University.Models;

namespace University.Service.IdentityService
{
    public interface IIdentityService
    {
        public Task<IdentityResult> CreateUser(CreateUserViewModel model);
        public Task<List<UserViewModel>> GetAllUsers();
        public Task<EditUserViewModel?> GetUserById(string id);
        public Task<IdentityResult> EditUser(EditUserViewModel model);
        public Task<IdentityResult> DeleteUser(string id);
    }
}
