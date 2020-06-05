namespace WindowsFormsApp1.Ado.NET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказ()
        {
            ЗаказанныеИзделия = new HashSet<ЗаказанныеИзделия>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата { get; set; }

        [Required]
        [StringLength(50)]
        public string ЭтапВыполнения { get; set; }

        [Required]
        [StringLength(50)]
        public string Заказчик { get; set; }

        [StringLength(50)]
        public string Менеджер { get; set; }

        public decimal? Стоимость { get; set; }

        public virtual Пользователь Пользователь { get; set; }

        public virtual Пользователь Пользователь1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЗаказанныеИзделия> ЗаказанныеИзделия { get; set; }
    }
}
