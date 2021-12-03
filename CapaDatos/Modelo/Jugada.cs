namespace CapaDatos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Jugada")]
    public partial class Jugada
    {
        [Key]
        public int Id_Jugada { get; set; }

        public decimal? Total { get; set; }

        public int? Numero_Jugada { get; set; }

        [StringLength(50)]
        public string Numero_Ticket { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Estatus { get; set; }

        [StringLength(50)]
        public string Loteria { get; set; }

        [StringLength(50)]
        public string Tipo_Jugada { get; set; }

        [Column("Jugada")]
        [StringLength(50)]
        public string Jugada1 { get; set; }

        public decimal? Monto { get; set; }

        [StringLength(20)]
        public string Tanda { get; set; }

        public int? Quiniela { get; set; }

        public int? Pale { get; set; }

        public int? Tripleta { get; set; }

        [StringLength(50)]
        public string Banca { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        public int? Sub_Numero { get; set; }
    }
}
