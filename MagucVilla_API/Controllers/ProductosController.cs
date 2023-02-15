using AutoMapper;
using MagucVilla_API.Datos;
using MagucVilla_API.Modelos;
using MagucVilla_API.Modelos.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagucVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly AplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProductosController(ILogger<ProductosController> logger, AplicationDbContext db, IMapper mapper)
        {
            _logger = logger;
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<ProductosDto>>> GetProductos()
        {
            _logger.LogInformation("Obtener los productos");

            IEnumerable<Productos> productosList = await _db.Productos.ToListAsync();

            return Ok(_mapper.Map<IEnumerable<Productos>>(productosList));
        }

        [HttpGet("id", Name ="GetProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductosDto>> GetProducto(int id)
        {
            if(id == 0)
            {
                _logger.LogError("El id del producto no puede ser cero.");
                return BadRequest();
            }
            var productos = await _db.Productos.FirstOrDefaultAsync(p => p.Id == id);

            if(productos == null)
            {
                _logger.LogError("El id no existe.");
                return NotFound();
            }
            return Ok(_mapper.Map<ProductosDto>(productos));
        }
    }
}
