namespace App.AxiosProvider   {
    export const EliminarCliente = (idc) => axios.delete<DBEntity>("Cliente/Grid?handler=Eliminar&idc=" + idc).then(({ data }) => data);
    export const GuardarCliente = (entity) => axios.post<DBEntity>("Cliente/Edit", entity).then(({ data }) => data);
    export const EliminarSolicitud = (id) => axios.delete<DBEntity>("Solicitud/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const GuardarSolicitud = (entity) => axios.post<DBEntity>("Solicitud/Edit", entity).then(({ data }) => data);
}


