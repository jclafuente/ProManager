using AutoMapper;
using ProManager.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProManager.BL.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Empresa, EmpresaDTO>(); // GET
                cfg.CreateMap<EmpresaDTO, Empresa>(); // POST-PUT

                cfg.CreateMap<Contacto, ContactoDTO>(); // GET
                cfg.CreateMap<ContactoDTO, Contacto>(); // POST-PUT
            });
        }
    }
}
