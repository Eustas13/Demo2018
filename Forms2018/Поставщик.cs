namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поставщик
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщик()
        {
            Комплектующие = new HashSet<Комплектующие>();
            Материалы = new HashSet<Материалы>();
        }

        [Key]
        [StringLength(150)]
        public string Наименование { get; set; }

        [StringLength(150)]
        public string Адрес { get; set; }

        [Required]
        [StringLength(50)]
        public string Срок_доставки { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Комплектующие> Комплектующие { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Материалы> Материалы { get; set; }
    }
}
