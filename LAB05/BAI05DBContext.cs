using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05
{
    public class BAI05DBContext : DbContext
    {
        public DbSet<Email> Email {  get; set; }
        public DbSet<MonAn> MonAn { get; set; }

        public BAI05DBContext() : base("name=BAI05Context")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasKey(em => em.Id_Email);

            modelBuilder.Entity<MonAn>()
                .HasKey(ma => ma.Id_MonAn);

            modelBuilder.Entity<Email>()
                .HasMany(em => em.MonAn)
                .WithRequired(ma => ma.Email)
                .HasForeignKey(ma => ma.Id_Email)
                .WillCascadeOnDelete(false);    // the bound entity wont be erased if the the other side of the bind is deleted

            base.OnModelCreating(modelBuilder);
        }
    }


    public class Email
    {
        public int Id_Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsRead { get; set; }
        public string sender { get; set; }
        public ICollection<MonAn> MonAn { get; set; }

        public Email()
        {
            MonAn = new HashSet<MonAn>();
        }
    }

    public class MonAn
    {
        public int Id_MonAn { get; set; }
        public string TenMonAn { get; set; }
        public string imageURI { get; set; }

        public int Id_Email { get; set; }

        // nav property
        public virtual Email Email { get; set; }
    }
}
