using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using exercicio8.Services;
using exercicio8.Models;

namespace exercicio8.Controllers
{
    [Route("[controller]")]
    public class ClientesController : Controller
    {
        private readonly ILogger<ClientesController> _logger;
        private ClientesService _clientesService;
        public ClientesController(ILogger<ClientesController> logger, ClientesService clientesService)
        {
            _logger = logger;
            _clientesService = clientesService;
        }

        [HttpPost("pessoafisica")]
        public IActionResult CriarClientePessoaFisica([FromBody] Cliente cliente)
        {
            

            _clientesService.CriarConta(cliente);
            return Created(Request.Path, cliente);
        }
        [HttpGet]
        public ActionResult Get(){
            
            var clientes = _clientesService.Get();
            return Ok(clientes);
        }
    }
}