namespace CapaDatos.ModeloLocal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cierres
    {
        [Key]
        public int Id_Cierre { get; set; }

        public decimal? Faltante { get; set; }

        public decimal? Exedente { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Banca { get; set; }

        [StringLength(50)]
        public string Unidad { get; set; }

        public int? Cantidad { get; set; }

        public decimal? Total { get; set; }

        [StringLength(50)]
        public string Estatus { get; set; }
    }
}
