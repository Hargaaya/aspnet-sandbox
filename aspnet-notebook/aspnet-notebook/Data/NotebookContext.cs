using Microsoft.EntityFrameworkCore;
using aspnet_notebook.Models;

namespace aspnet_notebook.Data
{
    public class NotebookContext : DbContext
    {
        public NotebookContext(DbContextOptions<NotebookContext> options) : base(options) {

        }

        public DbSet<NotebookItem> NotebookItems { get; set; }
    }
}
