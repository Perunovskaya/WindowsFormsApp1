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

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Заказные_изделия> Заказные_изделия { get; set; }
        public virtual DbSet<Изделия> Изделия { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Поступление_материалов> Поступление_материалов { get; set; }
        public virtual DbSet<Склад_ткани> Склад_ткани { get; set; }
        public virtual DbSet<Склад_фурнитуры> Склад_фурнитуры { get; set; }
        public virtual DbSet<Ткань> Ткань { get; set; }
        public virtual DbSet<Фурнитура> Фурнитура { get; set; }
        public virtual DbSet<Фурнитура_изделия> Фурнитура_изделия { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .HasOptional(e => e.Заказные_изделия)
                .WithRequired(e => e.Заказ);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Заказные_изделия)
                .WithRequired(e => e.Изделия)
                .HasForeignKey(e => e.Артикул_изделия)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделия>()
                .HasMany(e => e.Ткань)
                .WithMany(e => e.Изделия)
                .Map(m => m.ToTable("Ткани_изделия").MapLeftKey("Артикул_изделия").MapRightKey("Артикул_ткани"));

            modelBuilder.Entity<Пользователи>()
                .HasMany(e => e.Заказ)
                .WithOptional(e => e.Пользователи)
                .HasForeignKey(e => e.Менеджер);

            modelBuilder.Entity<Пользователи>()
                .HasMany(e => e.Заказ1)
                .WithRequired(e => e.Пользователи1)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Поступление_материалов>()
                .Property(e => e.Закупочная_Цена)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Поступление_материалов>()
                .Property(e => e.Сумма)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Ткань>()
                .Property(e => e.Цена)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Ткань>()
                .HasMany(e => e.Склад_ткани)
                .WithRequired(e => e.Ткань)
                .HasForeignKey(e => e.Артикул_ткани)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Вес)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Фурнитура>()
                .Property(e => e.Цена)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Склад_фурнитуры)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.Артикул_фурнитуры)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Фурнитура>()
                .HasMany(e => e.Фурнитура_изделия)
                .WithRequired(e => e.Фурнитура)
                .HasForeignKey(e => e.Артикул_фурнитуры)
                .WillCascadeOnDelete(false);
        }
    }
}
