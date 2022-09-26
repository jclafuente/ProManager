using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.BL.DTOs
{
    public class ContactoDTO
    {
        [Required(ErrorMessage = "El campo ID de la empresa es requerida")]
        public long id { get; set; }

        [Required(ErrorMessage = "El campo nombre de la empresa es requerida")]
        [StringLength(255)]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo apellido de la empresa es requerida")]
        [StringLength(255)]
        public string apellido { get; set; }

        [Required(ErrorMessage = "El campo correo de la empresa es requerida")]
        public string correo { get; set; }

        [Required(ErrorMessage = "El campo telefono de la empresa es requerida")]
        public string telefono { get; set; }

        public string fullName
        {
            get { return string.Format("{0} {1}", nombre, apellido); }
        }
    }
}
