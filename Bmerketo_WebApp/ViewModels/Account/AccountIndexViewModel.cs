using AutoMapper;
using Bmerketo_WebApp.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace Bmerketo_WebApp.ViewModels.Account
{
    public class AccountIndexViewModel
    {
        public AccountProfile Profile { get; set; } = null!;

    }
}
