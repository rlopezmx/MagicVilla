using AutoMapper;
using MagucVilla_API.Datos;
using MagucVilla_API.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagucVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class spProductos_ListadoController : ControllerBase
    {
        private readonly ILogger<spProductos_ListadoController> _logger;
        private readonly AplicationDbContext _db;
        private readonly IMapper _mapper;
        public spProductos_ListadoController(ILogger<spProductos_ListadoController> logger, AplicationDbContext db, IMapper mapper)
        {
            _logger = logger;
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<spProductos_Listado>>> Get()
        {
            _logger.LogInformation("Obtener los productos");
            var productosList = await _db.Set<spProductos_Listado>().ToArrayAsync();
            //IEnumerable<spProductos_Listado> productosList = (IEnumerable<spProductos_Listado>)_db.spProductos_Listado.ToList();
            // IEnumerable<spProductos_Listado> productosList = await _db.spProductos_Listado.ToListAsync();
            // return Ok(_mapper.Map<IEnumerable<spProductos_Listado>>(productosList));
            //return await _db.Set<spProductos_Listado>().ToArrayAsync();
            return Ok(productosList);
        }

    }
}
