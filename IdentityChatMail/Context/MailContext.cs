using IdentityChatMail.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatMail.Context
{
    public class MailContext: IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NBRMDOS; initial Catalog=EmailChatDb;integrated Security=true;trust server certificate=true");

        }
    }
}
