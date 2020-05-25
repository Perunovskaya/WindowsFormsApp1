namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Изделия
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Изделия()
        {
            Заказные_изделия = new HashSet<Заказные_изделия>();
            Ткань = new HashSet<Ткань>();
        }

        [Key]
        [StringLength(50)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(150)]
        public string Наименование { get; set; }

        public double Ширина { get; set; }

        public double Длина { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображение { get; set; }

        [StringLength(150)]
        public string Комментарий { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказные_изделия> Заказные_изделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ткань> Ткань { get; set; }
    }
}
