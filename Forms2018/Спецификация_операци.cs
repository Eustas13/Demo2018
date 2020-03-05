namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Спецификация_операци
    {
        [Key]
        [StringLength(150)]
        public string Изделие { get; set; }

        [Required]
        [StringLength(150)]
        public string Операция { get; set; }

        public int Порядковый_номер { get; set; }

        [StringLength(150)]
        public string Тип_оборудования { get; set; }

        [Required]
        [StringLength(50)]
        public string Время_на_операцию { get; set; }

        public virtual Изделие Изделие1 { get; set; }

        public virtual Тип_оборудования Тип_оборудования1 { get; set; }
    }
}
