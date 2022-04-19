using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IProveedorService
    {
        Task<DBEntity> CREATE(ProveedorEntity entity);
        Task<DBEntity> DELETE(ProveedorEntity entity);
        Task<IEnumerable<ProveedorEntity>> GET();
        Task<IEnumerable<ProveedorEntity>> GETLISTA();
        Task<ProveedorEntity> GETBYID(ProveedorEntity entity);
        Task<DBEntity> UPDATE(ProveedorEntity entity);
    }

    public class ProveedorService : IProveedorService
    {
        private readonly IDataAccess sql;

        public ProveedorService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCRUD

        //Metodo Get
        public async Task<IEnumerable<ProveedorEntity>> GET()
        {
            try
            {
                var result = sql.QueryAsync<ProveedorEntity>("dbo.ProveedorObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<ProveedorEntity>> GETLISTA()
        {
            try
            {
                var result = sql.QueryAsync<ProveedorEntity>("dbo.ProveedorLista");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //MetodoGetById
        public async Task<ProveedorEntity> GETBYID(ProveedorEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ProveedorEntity>("dbo.ProveedorObtener", new { entity.IdProveedor });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metodo Create
        public async Task<DBEntity> CREATE(ProveedorEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.ProveedorInsertar", new
                {
                    entity.Identificacion,
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.Edad,
                    entity.FechaNacimiento
                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Metodo Update
        public async Task<DBEntity> UPDATE(ProveedorEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.ProveedorActualizar", new
                {
                    entity.IdProveedor,
                    entity.Identificacion,
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.Edad,
                    entity.FechaNacimiento
                });


                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> DELETE(ProveedorEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.ProveedorEliminar", new
                {
                    entity.IdProveedor

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
