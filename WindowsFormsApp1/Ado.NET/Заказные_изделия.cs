namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказные_изделия
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Номер_изделия { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Артикул_изделия { get; set; }

        public int Количество { get; set; }

        public virtual Заказ Заказ { get; set; }

        public virtual Изделия Изделия { get; set; }
    }
}
