using AutoMapper;
using ProManager.BL.Data;
using ProManager.BL.DTOs;
using ProManager.BL.Models;
using ProManager.BL.Repositories.Implements;
using ProManager.BL.Services.Implements;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc.Razor;

namespace ProManager.API.Controllers
{
    /// <summary>
    /// RestController para manejo de las empresas
    /// </summary>
    [Authorize]
    [RoutePrefix("api/Empresas")]
    public class EmpresasController : ApiController
    {
        private IMapper mapper;
        private readonly EmpresaService empresaServise = new EmpresaService(new EmpresaRepository(ProManagerContext.Create()));

        /// <summary>
        /// Constructor
        /// </summary>
        public EmpresasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        /// <summary>
        /// Obtiene los objetos de empresas 
        /// </summary>
        /// <returns>Listado de los objetos de empresas</returns>
        /// <response code="200">OK. Devuelve el listado de objetos solicitado.</response>
        [HttpGet]
        [ResponseType(typeof(IEnumerable<EmpresaDTO>))]
        public async Task<IHttpActionResult> GetAll()
        {

            var empresas = await empresaServise.GetAll();

            if (empresas == null)
                return NotFound();

            var empresasDTO = empresas.Select(x => mapper.Map<EmpresaDTO>(x));

            return Ok(empresasDTO);
        }

        /// <summary>
        /// Obtiene una empresa por su Id. 
        /// </summary>
        /// <remarks>
        /// Aquí una descripción mas larga si fuera necesario. Obtiene un objeto por su Id.
        /// </remarks>
        /// <param name="id">Id de la empresa</param>
        /// <returns>Empresa correspondiente al Id ingresado</returns>
        /// <response code="200">Ok. Devuelve el objeto solicitado.</response>
        /// <response code="404">Not Found. No se ha encontrado el objeto Solicitado.</response>
        [HttpGet]
        [ResponseType(typeof(EmpresaDTO))]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var empresa = await empresaServise.GetById(id);
            if (empresa == null)
                return NotFound();

            var empresaDTO = mapper.Map<EmpresaDTO>(empresa);

            return Ok(empresaDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostEmpresa(EmpresaDTO empresaDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var empresa = mapper.Map<Empresa>(empresaDTO);
                empresa = await empresaServise.Insert(empresa);
                return Ok(empresaDTO);
            }
            catch (Exception ex) { return InternalServerError(ex); }


        }

    }
}
