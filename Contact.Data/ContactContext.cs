﻿using Contact.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Contact.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options){}
        public DbSet<Person> People { get; set;}

    }
}
