using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Solicitud
{
    public class GridModel : PageModel
    {
        private readonly ISolicitudService solicitud;

        public GridModel(ISolicitudService solicitud)
        {
            this.solicitud = solicitud;
        }

        public IEnumerable<SolicitudEntity> GridList { get; set; } = new List<SolicitudEntity>();

        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await solicitud.GET();
                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        public async Task<JsonResult> OnDeleteEliminar(int id)
        {
            try
            {
                var result = await solicitud.DELETE(new()
                { IdSolicitud = id });
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }
        }
    }
}
