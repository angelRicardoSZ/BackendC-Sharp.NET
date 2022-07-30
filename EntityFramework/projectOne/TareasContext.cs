using Microsoft.EntityFrameworkCore;
using projectone.Models;
namespace projectone;
public class TareasContext: DbContext
{
    public DbSet<Categoria> Categorias {get; set;}
    public DbSet<Tarea> Tareas {get; set;}

    public TareasContext(DbContextOptions<TareasContext> options) :base(options){}
}
