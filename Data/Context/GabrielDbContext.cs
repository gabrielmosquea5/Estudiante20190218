using System;
using Estudiante20190218.Data.Models;
using Microsoft.EntityFrameworkCore;
using Estudiante.Data.Models;

namespace  Estudiante20190218.Data.Context;


public class GabrielDbContext:DbContext
{

    public GabrielDbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<P> Pe {get; set;} = null!;
    public virtual DbSet<Estudiantes> Estudiante {get; set;} = null!;
}
