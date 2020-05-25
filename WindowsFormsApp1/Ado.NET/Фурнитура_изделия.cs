namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура_изделия
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Артикул_фурнитуры { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Артикул_изделия { get; set; }

        [Required]
        [StringLength(50)]
        public string Размещение { get; set; }

        public double? Ширина { get; set; }

        public double? Длина { get; set; }

        public int? Поворот { get; set; }

        public int Количество { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
