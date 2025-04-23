using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt002_Data
    {
        public List<XCOMP_Rpt002_Info> consultar_data(int idempresa, int idsucursal, decimal IdSolicitudCompra)
        {
            try
            {
                List<XCOMP_Rpt002_Info> listadatos = new List<XCOMP_Rpt002_Info>();

                using (EntitiesCompra_reporte_Ge ESolicitud = new EntitiesCompra_reporte_Ge())
                {
                    var select = from j in ESolicitud.vwCOMP_Rpt002
                                 where j.IdEmpresa == idempresa
                                 && j.IdSucursal == idsucursal
                                 && j.IdSolicitudCompra == IdSolicitudCompra
                                 select j;

                    foreach (var rpt in select)
                    {
                        XCOMP_Rpt002_Info itemInfo = new XCOMP_Rpt002_Info
                        {
                            IdRow = rpt.IdRow,
                            IdEmpresa = rpt.IdEmpresa,
                            IdSucursal = rpt.IdSucursal,
                            IdSolicitudCompra = rpt.IdSolicitudCompra,
                            IdPersona_Solicita = rpt.IdPersona_Solicita,
                            IdProyecto = rpt.IdProyecto,
                            cod_proyecto = rpt.cod_proyecto,
                            nom_proyecto = rpt.nom_proyecto,
                            IdOferta = rpt.IdOferta,
                            nom_oferta = rpt.nom_oferta,
                            IdEstadoAprobacion = rpt.IdEstadoAprobacion,
                            nom_EstadoAprobacion = rpt.nom_EstadoAprobacion,
                            nom_empresa = rpt.nom_empresa,
                            nom_sucursal = rpt.nom_sucursal,
                            fecha = rpt.fecha,
                            observacion = rpt.observacion,
                            Secuencia = rpt.Secuencia,
                            Secuencia_Oferta = rpt.Secuencia_Oferta,
                            cod_rubro = rpt.cod_rubro,
                            nom_rubro = rpt.nom_rubro,
                            nom_rubro_2 = (rpt.cod_rubro == null) ? "" : ("[" + rpt.cod_rubro.Trim() + "]-" + rpt.nom_rubro.Trim()),
                            IdProducto = rpt.IdProducto,
                            nom_producto = rpt.nom_producto,
                            do_observacion = rpt.do_observacion,
                            do_Cantidad = rpt.do_Cantidad,
                            em_ruc = rpt.em_ruc,
                            em_direccion = rpt.em_direccion,
                            em_telefonos = rpt.em_telefonos,
                            IdPunto_cargo = rpt.IdPunto_cargo,
                            nom_punto_cargo = rpt.nom_punto_cargo,
                            IdCentroCosto = rpt.IdCentroCosto,
                            nom_Centro_Costo = rpt.nom_Centro_Costo,
                            IdSubCentroCosto = rpt.IdSubCentroCosto,
                            nom_SubCentroCosto = rpt.nom_SubCentroCosto,
                            IdUnidadMedida = rpt.IdUnidadMedida,
                            nom_unidad = rpt.nom_unidad,
                            nom_unidad_alterno = rpt.nom_unidad_alterno,
                            nom_personaSol = rpt.nom_personaSol,
                            pr_codigo = rpt.pr_codigo,
                            IdUsuarioAprobo = rpt.IdUsuarioAprobo,
                            nom_usuario_aprob = rpt.nom_usuario_aprob
                        };

                        listadatos.Add(itemInfo);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCOMP_Rpt002_Info>();
            }
        }
    }
}