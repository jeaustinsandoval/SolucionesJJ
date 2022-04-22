"use strict";
var GridCliente;
(function (GridCliente) {
    function OnclickEliminar(idc) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando");
                App.AxiosProvider.EliminarCliente(idc).then(function (data) {
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
    GridCliente.OnclickEliminar = OnclickEliminar;
    $("#GridView").DataTable();
})(GridCliente || (GridCliente = {}));
//# sourceMappingURL=Grid.js.map