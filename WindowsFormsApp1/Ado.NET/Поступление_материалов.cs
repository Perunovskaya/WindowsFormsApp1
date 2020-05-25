namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поступление_материалов
    {
        [Key]
        [StringLength(50)]
        public string Материал { get; set; }

        public int Количество { get; set; }

        public decimal Закупочная_Цена { get; set; }

        public decimal Сумма { get; set; }
    }
}
