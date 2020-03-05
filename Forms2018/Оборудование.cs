namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Оборудование
    {
        [Key]
        [StringLength(150)]
        public string Маркировка { get; set; }

        [Required]
        [StringLength(150)]
        public string Тип_оборудования { get; set; }

        [StringLength(150)]
        public string Характеристики { get; set; }

        public virtual Тип_оборудования Тип_оборудования1 { get; set; }
    }
}
