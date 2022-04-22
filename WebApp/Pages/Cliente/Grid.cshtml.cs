using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Cliente
{
    public class GridModel : PageModel
    {
        private readonly IClienteService cliente;

        public GridModel(IClienteService cliente)
        {
            this.cliente = cliente;
        }

        public IEnumerable<ClienteEntity> GridList { get; set; } = new List<ClienteEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await cliente.GET();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public async Task<JsonResult> OnDeleteEliminar(int idc)
        {
            try
            {
                var result = await cliente.DELETE(new()
                { IdCliente = idc });
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }
    }
}
