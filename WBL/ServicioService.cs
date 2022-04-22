using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IServicioService
    {
        Task<IEnumerable<ServicioEntity>> GETLISTA();
    }

    public class ServicioService : IServicioService
    {
        private readonly IDataAccess sql;

        public ServicioService(IDataAccess _sql)
        {
            sql = _sql;
        }

        //Metodo Get Lista
        public async Task<IEnumerable<ServicioEntity>> GETLISTA()
        {
            try
            {
                var result = sql.QueryAsync<ServicioEntity>("dbo.ServicioLista");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
