namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Материалы
    {
        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(100)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Единица_изметререния { get; set; }

        public int Количество { get; set; }

        [StringLength(150)]
        public string Основной_поставщик { get; set; }

        public byte[] Изображение { get; set; }

        [Required]
        [StringLength(50)]
        public string Тип_материала { get; set; }

        public decimal? Закупочная_цена { get; set; }

        [StringLength(100)]
        public string ГОСТ { get; set; }

        public double? Длина__м { get; set; }

        [StringLength(150)]
        public string Характеристика { get; set; }

        public virtual Поставщик Поставщик { get; set; }
    }
}
