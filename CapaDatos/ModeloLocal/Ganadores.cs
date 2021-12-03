namespace CapaDatos.ModeloLocal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ganadores
    {
        [Key]
        public int Id_Ganadores { get; set; }

        [StringLength(50)]
        public string Loteria { get; set; }

        public int? Primera { get; set; }

        public int? Segunda { get; set; }

        public int? Tercera { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
