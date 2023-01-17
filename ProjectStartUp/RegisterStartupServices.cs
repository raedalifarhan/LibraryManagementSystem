using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.DbContexts;
using LibraryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.ProjectStartUp
{
    public static class RegisterStartupServices
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            // Add services to the container.
            builder.Services.AddScoped<IBookService, BookService>();

            builder.Services.AddDbContext<ApplicationDbContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDb"))
            );

            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddControllersWithViews();

            return builder;
        }
    }
}