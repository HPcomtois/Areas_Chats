using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chats.Models;

namespace Chats.Data
{
    public class ChatsContext : DbContext
    {
        public ChatsContext (DbContextOptions<ChatsContext> options)
            : base(options)
        {
        }

        public DbSet<Chat> Chat { get; set; } = default!;
    }
}
