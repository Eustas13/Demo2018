namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Изделие
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Изделие()
        {
            Заказ = new HashSet<Заказ>();
            Спецификация_комплектующие = new HashSet<Спецификация_комплектующие>();
            Спецификация_материалы = new HashSet<Спецификация_материалы>();
            Спецификация_сборочные_единицы = new HashSet<Спецификация_сборочные_единицы>();
        }

        [Key]
        [StringLength(150)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Размеры { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }

        public virtual Спецификация_операци Спецификация_операци { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_комплектующие> Спецификация_комплектующие { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_материалы> Спецификация_материалы { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_сборочные_единицы> Спецификация_сборочные_единицы { get; set; }
    }
}
