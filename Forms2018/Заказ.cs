namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Номер { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Дата { get; set; }

        [Required]
        [StringLength(150)]
        public string Наименование_заказа { get; set; }

        [Required]
        [StringLength(150)]
        public string Изделие { get; set; }

        [Required]
        [StringLength(150)]
        public string Заказчик { get; set; }

        [StringLength(150)]
        public string Ответственный_менеджер { get; set; }

        public decimal? Стоимость { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Планования_дата_завершения { get; set; }

        public double? Схемы_чертежи_заказа { get; set; }

        public virtual Изделие Изделие1 { get; set; }
    }
}
