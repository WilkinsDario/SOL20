namespace CapaDatos.ModeloLocal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ganadores_Diarios
    {
        [Key]
        public int Id_Ganadores_Diario { get; set; }

        public int? Numero_Jugada { get; set; }

        [StringLength(50)]
        public string Loteria { get; set; }

        [StringLength(50)]
        public string Tipo_Jugada { get; set; }

        [StringLength(50)]
        public string Jugada { get; set; }

        public decimal? Monto { get; set; }

        public decimal? Premio { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Banca { get; set; }

        [StringLength(50)]
        public string Estatus { get; set; }
    }
}
