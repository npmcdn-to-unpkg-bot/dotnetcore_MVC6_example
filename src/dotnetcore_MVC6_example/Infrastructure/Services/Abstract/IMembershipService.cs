﻿using dotnetcore_MVC6_example.Entities;
using PhotoGallery.Infrastructure;
using System.Collections.Generic;

namespace dotnetcore_MVC6_example.Infrastructure.Services
{
    public interface IMembershipService
    {
        MembershipContext ValidateUser(string username, string password);
        User CreateUser(string username, string email, string password, int[] roles);
        User GetUser(int userId);
        List<Role> GetUserRoles(string username);
    }
}