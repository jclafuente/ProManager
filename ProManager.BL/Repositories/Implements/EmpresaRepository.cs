using ProManager.BL.Data;
using ProManager.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.BL.Repositories.Implements
{
    public class EmpresaRepository : GenericRepository<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(ProManagerContext Context) : base(Context)
        {
        }
    }
}
