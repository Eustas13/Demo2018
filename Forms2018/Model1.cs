namespace Forms2018
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Изделие> Изделие { get; set; }
        public virtual DbSet<Комплектующие> Комплектующие { get; set; }
        public virtual DbSet<Материалы> Материалы { get; set; }
        public virtual DbSet<Оборудование> Оборудование { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Поставщик> Поставщик { get; set; }
        public virtual DbSet<Спецификация_комплектующие> Спецификация_комплектующие { get; set; }
        public virtual DbSet<Спецификация_материалы> Спецификация_материалы { get; set; }
        public virtual DbSet<Спецификация_операци> Спецификация_операци { get; set; }
        public virtual DbSet<Спецификация_сборочные_единицы> Спецификация_сборочные_единицы { get; set; }
        public virtual DbSet<Тип_оборудования> Тип_оборудования { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .Property(e => e.Стоимость)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Спецификация_комплектующие)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Спецификация_материалы)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Изделие>()
                .HasMany(e => e.Спецификация_сборочные_единицы)
                .WithRequired(e => e.Изделие1)
                .HasForeignKey(e => e.Изделие)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Комплектующие>()
                .HasMany(e => e.Спецификация_комплектующие)
                .WithRequired(e => e.Комплектующие)
                .HasForeignKey(e => e.Комплектующий)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Материалы>()
                .Property(e => e.Закупочная_цена)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.Комплектующие)
                .WithOptional(e => e.Поставщик)
                .HasForeignKey(e => e.Основной_поставщик);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.Материалы)
                .WithOptional(e => e.Поставщик)
                .HasForeignKey(e => e.Основной_поставщик);

            modelBuilder.Entity<Спецификация_операци>()
                .HasOptional(e => e.Изделие1)
                .WithRequired(e => e.Спецификация_операци);

            modelBuilder.Entity<Тип_оборудования>()
                .HasMany(e => e.Оборудование)
                .WithRequired(e => e.Тип_оборудования1)
                .HasForeignKey(e => e.Тип_оборудования)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Тип_оборудования>()
                .HasMany(e => e.Спецификация_операци)
                .WithOptional(e => e.Тип_оборудования1)
                .HasForeignKey(e => e.Тип_оборудования);
        }
    }
}
