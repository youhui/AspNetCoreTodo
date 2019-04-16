using System;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreTodo.Models
{
    public class ManageUsersViewModel
    {
        public ManageUsersViewModel()
        {
        }

        public IdentityUser[] Administrators { get; set; }

        public IdentityUser[] Everyone { get; set; }
    }
}
