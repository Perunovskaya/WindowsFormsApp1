namespace WindowsFormsApp1.Ado.NET
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
        [StringLength(50)]
        public string Номер { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Дата { get; set; }

        [Required]
        [StringLength(50)]
        public string Этап_выполнения { get; set; }

        [Required]
        [StringLength(50)]
        public string Заказчик { get; set; }

        [StringLength(50)]
        public string Менеджер { get; set; }

        [StringLength(50)]
        public string Стоимость { get; set; }

        public virtual Пользователи Пользователи { get; set; }

        public virtual Пользователи Пользователи1 { get; set; }

        public virtual Заказные_изделия Заказные_изделия { get; set; }
    }
}
