namespace CapaDatos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Valor_Premios
    {
        [Key]
        public int Id_Valor_Premio { get; set; }

        public int? Primera { get; set; }

        public int? Segunda { get; set; }

        public int? Tercera { get; set; }

        public int? Super_Pale { get; set; }

        public int? Pale_Uno { get; set; }

        public int? Pale_Dos { get; set; }

        public int? Tripleta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        public int? Tripleta_2 { get; set; }
    }
}
