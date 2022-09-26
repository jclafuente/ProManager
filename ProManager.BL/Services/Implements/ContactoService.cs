using ProManager.BL.Models;
using ProManager.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.BL.Services.Implements
{
    internal class ContactoService : GenericService<Contacto>
    {
        public ContactoService(IContactoRepository Repository) : base(Repository)
        {
        }
    }
}
