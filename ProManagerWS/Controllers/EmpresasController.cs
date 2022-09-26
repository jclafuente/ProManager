using AutoMapper;
using ProManager.BL.Data;
using ProManager.BL.DTOs;
using ProManager.BL.Repositories.Implements;
using ProManager.BL.Services.Implements;
using ProManagerWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc.Razor;

namespace ProManager.API.Controllers
{
    public class EmpresasController : ApiController
    {
        private IMapper mapper;
        private readonly EmpresaService empresaServise = new EmpresaService(new EmpresaRepository(ProManagerContext.Create()));

        public EmpresasController() 
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll() {
            
            var empresas = await empresaServise.GetAll();
            var empresasDTO = empresas.Select(x => mapper.Map<EmpresaDTO>(x));

            return Ok(empresasDTO);
        }
    } 
}
