namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Комплектующие
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Комплектующие()
        {
            Спецификация_комплектующие = new HashSet<Спецификация_комплектующие>();
        }

        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(100)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Единица_измерения { get; set; }

        [Required]
        [StringLength(50)]
        public string Количество { get; set; }

        [StringLength(150)]
        public string Основной_поставщик { get; set; }

        public byte[] Изображение { get; set; }

        [Required]
        [StringLength(50)]
        public string Тип_комплектующих { get; set; }

        [Required]
        [StringLength(50)]
        public string Закупочная_цена { get; set; }

        public double? Вес { get; set; }

        public virtual Поставщик Поставщик { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификация_комплектующие> Спецификация_комплектующие { get; set; }
    }
}
