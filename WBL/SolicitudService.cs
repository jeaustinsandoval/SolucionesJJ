using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ISolicitudService
    {
        Task<DBEntity> CREATE(SolicitudEntity entity);
        Task<DBEntity> DELETE(SolicitudEntity entity);
        Task<IEnumerable<SolicitudEntity>> GET();
        Task<SolicitudEntity> GETBYID(SolicitudEntity entity);
        Task<IEnumerable<SolicitudEntity>> GETLISTA();
        Task<DBEntity> UPDATE(SolicitudEntity entity);
    }

    public class SolicitudService : ISolicitudService
    {
        private readonly IDataAccess sql;

        public SolicitudService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCRUD

        //Metodo Get
        public async Task<IEnumerable<SolicitudEntity>> GET()
        {
            try
            {
                var result = sql.QueryAsync<SolicitudEntity>("dbo.SolicitudObtener", "IdSolicitud,IdCliente,IdServicio, ");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<SolicitudEntity>> GETLISTA()
        {
            try
            {
                var result = sql.QueryAsync<SolicitudEntity>("dbo.ServicioLista");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //MetodoGetById
        public async Task<SolicitudEntity> GETBYID(SolicitudEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<SolicitudEntity>("dbo.SolicitudObtener", new { entity.IdSolicitud });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metodo Create
        public async Task<DBEntity> CREATE(SolicitudEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.SolicitudInsertar", new
                {
                    entity.IdCliente,
                    entity.IdServicio,
                    entity.Cantidad,
                    entity.Monto,
                    entity.FechaEntrega,
                    entity.UsuarioEntrega,
                    entity.Observaciones
                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Metodo Update
        public async Task<DBEntity> UPDATE(SolicitudEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.SolicitudActualizar", new
                {
                    entity.IdSolicitud,
                    entity.IdCliente,
                    entity.IdServicio,
                    entity.Cantidad,
                    entity.Monto,
                    entity.FechaEntrega,
                    entity.UsuarioEntrega,
                    entity.Observaciones
                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> DELETE(SolicitudEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.SolicitudEliminar", new
                {
                    entity.IdSolicitud

                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion
    }
}
