using ISchool.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISchool.DAL.Context
{
    public interface IDbContext : IDisposable
    {

        DbSet<Person> Persons { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teacher { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        Database Database { get; }

    }
}
