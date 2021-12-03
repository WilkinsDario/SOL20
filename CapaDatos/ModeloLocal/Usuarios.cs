namespace CapaDatos.ModeloLocal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [Key]
        public int Id_Usuario { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Contrasena { get; set; }

        [StringLength(20)]
        public string Estatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Banca { get; set; }

        [StringLength(50)]
        public string Acceso { get; set; }
    }
}
