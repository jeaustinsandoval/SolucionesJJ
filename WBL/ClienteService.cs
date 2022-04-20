﻿using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClienteEntity
    {
        Task<DBEntity> CREATE(ClienteEntity entity);
        Task<DBEntity> DELETE(ClienteEntity entity);
        Task<IEnumerable<ClienteEntity>> GET();
        Task<IEnumerable<ClienteEntity>> GETLISTA();
        Task<ClienteEntity> GETBYID(ClienteEntity entity);
        Task<DBEntity> UPDATE(ClienteEntity entity);
    }

    public class ClienteEntity : IClienteEntity
    {
        private readonly IDataAccess sql;

        public ClienteEntity(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCRUD

        //Metodo Get
        public async Task<IEnumerable<ClienteEntity>> GET()
        {
            try
            {
                var result = sql.QueryAsync<ClienteEntity>("dbo.ClienteObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<ClienteEntity>> GETLISTA()
        {
            try
            {
                var result = sql.QueryAsync<ClienteEntity>("dbo.ClienteLista");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //MetodoGetById
        public async Task<ClienteEntity> GETBYID(ClienteEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ClienteEntity>("dbo.ClienteObtener", new { entity.IdCliente });
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metodo Create
        public async Task<DBEntity> CREATE(ClienteEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.ClienteInsertar", new
                {
                    entity.,
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
        public async Task<DBEntity> UPDATE(ClienteEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.ClienteActualizar", new
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
        public async Task<DBEntity> DELETE(ClienteEntity entity)
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