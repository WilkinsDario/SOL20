namespace CapaDatos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Limite")]
    public partial class Limite
    {
        [Key]
        public int Id_Limite { get; set; }

        public int? Quiniela { get; set; }

        public int? Pale { get; set; }

        public int? Tripleta { get; set; }

        public int? Super_Pale { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public decimal? Monto_Quiniela { get; set; }

        public decimal? Monto_Pale { get; set; }

        public decimal? Monto_Tripleta { get; set; }

        public decimal? Monto_SuperPale { get; set; }
    }
}
