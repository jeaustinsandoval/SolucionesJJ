using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Cliente
{
    public class EditModel : PageModel
    {
        private readonly IClienteService cliente;

        public EditModel(IClienteService cliente)
        {
            this.cliente = cliente;
            
        }

        [BindProperty(SupportsGet = true)] 
        public int? id { get; set; }

        [BindProperty] //
        [FromBody]

        public ClienteEntity Entity { get; set; } = new ClienteEntity();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await cliente.GETBYID(new()
                    {
                        IdCliente = id
                    });

                }

                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                var result = new DBEntity();
                //update
                if (Entity.IdCliente.HasValue) 
                {
                    result = await cliente.UPDATE(Entity);



                }
                else //Si el idContacto no tiene valor (false) el metodo inserta
                {
                    result = await cliente.CREATE(Entity);


                }

                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }


    }
}
