namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        [Key]
        [StringLength(150)]
        public string ФИО { get; set; }

        [StringLength(150)]
        public string Дата_рождения { get; set; }

        [StringLength(150)]
        public string Домашний_адрес { get; set; }

        [StringLength(150)]
        public string Образование { get; set; }

        [StringLength(150)]
        public string Квалификация { get; set; }

        [StringLength(150)]
        public string Список_производственных_операция { get; set; }
    }
}
