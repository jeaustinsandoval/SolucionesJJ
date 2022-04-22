"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        AxiosProvider.EliminarCliente = function (idc) { return axios.delete("Cliente/Grid?handler=Eliminar&idc=" + idc).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.GuardarCliente = function (entity) { return axios.post("Cliente/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.EliminarSolicitud = function (id) { return axios.delete("Solicitud/Grid?handler=Eliminar&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.GuardarSolicitud = function (entity) { return axios.post("Solicitud/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map