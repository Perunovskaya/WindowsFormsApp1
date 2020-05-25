namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Склад_ткани
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Рулон { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Артикул_ткани { get; set; }

        public double Ширина { get; set; }

        public double Длина { get; set; }

        public virtual Ткань Ткань { get; set; }
    }
}
