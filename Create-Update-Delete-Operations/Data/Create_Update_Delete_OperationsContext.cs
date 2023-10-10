using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Create_Update_Delete_Operations.Models;

namespace Create_Update_Delete_Operations.Data
{
    public class Create_Update_Delete_OperationsContext : DbContext
    {
        public Create_Update_Delete_OperationsContext (DbContextOptions<Create_Update_Delete_OperationsContext> options)
            : base(options)
        {
        }

        public DbSet<Create_Update_Delete_Operations.Models.Movie> Movie { get; set; } = default!;
    }
}
