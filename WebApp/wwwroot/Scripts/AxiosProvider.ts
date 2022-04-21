
namespace App.AxiosProvider   {
    export const EliminarCliente = (id) => axios.delete<DBEntity>("Cliente/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const GuardarCliente = (entity) => axios.post<DBEntity>("Cliente/Edit", entity).then(({ data }) => data);
}




