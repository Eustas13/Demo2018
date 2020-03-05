namespace Forms2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователи
    {
        [Required]
        [StringLength(150)]
        public string ФИО { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Логин { get; set; }

        [Required]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(150)]
        public string Роль { get; set; }

        public byte[] Фото { get; set; }
    }
}
