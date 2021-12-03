namespace CapaDatos.ModeloLocal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jugada_Temporal
    {
        [Key]
        public int Id_Jugada_Temporal { get; set; }

        [StringLength(50)]
        public string Loteria { get; set; }

        [StringLength(50)]
        public string Tipo_Jugada { get; set; }

        public decimal? Monto { get; set; }

        public int? Numero_Jugada { get; set; }

        [StringLength(50)]
        public string Jugada { get; set; }

        [StringLength(50)]
        public string Sub_Jugada { get; set; }

        public int? Quiniela { get; set; }

        public int? Pale { get; set; }

        public int? Tripleta { get; set; }

        public int? Sub_Numero { get; set; }
    }
}
