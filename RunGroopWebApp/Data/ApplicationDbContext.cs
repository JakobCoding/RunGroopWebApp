﻿using Microsoft.EntityFrameworkCore;

namespace RunGroopWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {
            
        }
    }
}