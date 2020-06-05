namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Demo : DbContext
    {
        public Demo()
            : base("name=Demo")
        {
        }

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<ЗаказанныеИзделия> ЗаказанныеИзделия { get; set; }
        public virtual DbSet<Изделие> Изделие { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<СкладТкани> СкладТкани { get; set; }
        public virtual DbSet<СкладФурнитуры> СкладФурнитуры { get; set; }
        public virtual DbSet<Ткань> Ткань { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }
        public virtual DbSet<ФурнитураИзделия> ФурнитураИзделия { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .HasMany(e => e.ЗаказанныеИзделия)
                .WithRequired(e => e.Заказ)
                .HasForeignKey(e => e.НомерЗаказа)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.ЗаказанныеИзделия)
                .WithRequired(e => e.Изделие)
                .HasForeignKey(e => e.АртикулИзделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.ФурнитураИзделия)
                .WithRequired(e => e.Изделие)
                .HasForeignKey(e => e.АртикулИзделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Ткань)
                .WithMany(e => e.Изделие)
                .Map(m => m.ToTable("ТканиИзделия").MapLeftKey("АртикулИзделия").MapRightKey("АртикулТкани"));

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ)
                .WithOptional(e => e.Пользователь)
                .HasForeignKey(e => e.Менеджер);

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ1)
                .WithRequired(e => e.Пользователь1)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ткань>()
                .HasMany(e => e.СкладТкани)
                .WithRequired(e => e.Ткань)
                .HasForeignKey(e => e.АртикулТкани)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.СкладФурнитуры)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.АртикулФурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.ФурнитураИзделия)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.АртикулФурнитуры)
                .WillCascadeOnDelete(false);
        }
    }
}
