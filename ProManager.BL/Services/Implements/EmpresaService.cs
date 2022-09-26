using ProManager.BL.Models;
using ProManager.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.BL.Services.Implements
{
    public class EmpresaService : GenericService<Empresa>, IEmpresaService
    {
        public EmpresaService(IEmpresaRepository Repository) : base(Repository)
        {
        }
    }
}
