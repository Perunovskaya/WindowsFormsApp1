namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Фурнитура()
        {
            Склад_фурнитуры = new HashSet<Склад_фурнитуры>();
            Фурнитура_изделия = new HashSet<Фурнитура_изделия>();
        }

        [Key]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [Required]
        [StringLength(50)]
        public string Тип { get; set; }

        public double Ширина { get; set; }

        public double? Длина { get; set; }

        public decimal? Вес { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображение { get; set; }

        public decimal Цена { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад_фурнитуры> Склад_фурнитуры { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Фурнитура_изделия> Фурнитура_изделия { get; set; }
    }
}
