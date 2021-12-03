namespace CapaDatos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Horarios
    {
        [Key]
        public int Id_Horario { get; set; }

        [StringLength(50)]
        public string Loteria { get; set; }

        [StringLength(20)]
        public string Estatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public int? Hora { get; set; }

        public int? Minutos { get; set; }

        [StringLength(50)]
        public string Tanda { get; set; }
    }
}
