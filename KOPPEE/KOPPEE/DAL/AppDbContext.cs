﻿using Microsoft.EntityFrameworkCore;

namespace KOPPEE.DAL
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

    }
}