using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Price = 100, Title = "Sefiller1" },
                new Book { Id = 2, Price = 110, Title = "Sefiller2" },
                new Book { Id = 3, Price = 120, Title = "Sefiller3" },
                new Book { Id = 4, Price = 130, Title = "Sefiller4" }
                );
        }
    }
}
