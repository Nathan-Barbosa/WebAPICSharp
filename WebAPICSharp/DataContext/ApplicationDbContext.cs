﻿using Microsoft.EntityFrameworkCore;
using WebApiCSharp.Models;

namespace WebAPICSharp.DataContext
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {           
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
