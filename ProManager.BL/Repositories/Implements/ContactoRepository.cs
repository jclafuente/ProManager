using ProManager.BL.Data;
using ProManager.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.BL.Repositories.Implements
{
    internal class ContactoRepository : GenericRepository<Contacto>
    {
        public ContactoRepository(ProManagerContext Context) : base(Context)
        {
        }
    }
}
