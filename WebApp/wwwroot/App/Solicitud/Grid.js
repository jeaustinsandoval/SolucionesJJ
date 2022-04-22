"use strict";
var GridSolicitud;
(function (GridSolicitud) {
    function OnclickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando");
                App.AxiosProvider.EliminarSolicitud(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "El registro se eliminó correctamente", icon: "success" }).
                            then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    GridSolicitud.OnclickEliminar = OnclickEliminar;
    $("#GridView").DataTable();
})(GridSolicitud || (GridSolicitud = {}));
//# sourceMappingURL=Grid.js.map