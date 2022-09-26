using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.BL.DTOs
{
    public class EmpresaDTO
    {
        [Required(ErrorMessage = "El campo ID de la empresa es requerida")]
        public long id { get; set; }

        [Required(ErrorMessage = "El campo RUC de la empresa es requerida")]
        [StringLength(13)]
        public string ruc { get; set; }
        
        [Required(ErrorMessage = "El campo Nombre de la empresa es requerida")]
        public string nombre { get; set; }
        
        [Required(ErrorMessage = "El campo Direccion de la empresa es requerida")]
        public string direccion { get; set; }
        
        public string telefono { get; set; }
        
        public string web { get; set; }
        
        public string logo { get; set; }

    }
}
