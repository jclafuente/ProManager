namespace ProManager.BL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contacto")]
    public partial class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(255)]
        public string nombre { get; set; }

        [StringLength(255)]
        public string apellido { get; set; }

        [StringLength(255)]
        public string correo { get; set; }

        [StringLength(255)]
        public string telefono { get; set; }

        public long? empresa_id { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
