

/// <summary>
/// tipo =IdCatalogo_tipo = TIPO_CONTA_CTA = 6,
/// Tabla: in_Catalogo
/// </summary>
public enum ein_TipoContabilizacion_Cta_Inven_Costo
{   ///BODEGA
    CONT_X_BOD,
    //CATEGRORIA/LINEA/GRUPO/SUBGRUPO
    CONT_X_CAT_LIN,
    //PRODUCTO X BODEGA
    CONT_X_PRO_X_BD,
    //PRODUCTO X MOTIVO
    CONT_X_PRO_X_MOTIVO_INV,
    //CATEGRORIA/LINEA/GRUPO/SUBGRUPO/CC/SCC
    C_CA_LI_GR_CC_S,
}
/// <summary>
/// tipo =IdCatalogo_tipo = INVEN_O_CONSU= 7,
/// Tabla: in_Catalogo
/// </summary>
public enum ein_Inventario_O_Consumo
{   //CONSUMO
    TIC_CONSU,
    INVENTARIO,
    TIC_CONSU_PRO,
    TIC_INVEN,
    TIC_PRODUCCION,
    TIC_NC,
    TIC_TRANS,
    TIC_VAR_MT
}

public enum ein_Tipo_Ing_Egr
{
    ING,
    EGR
}

public enum eFormas_de_Contabilizar
{ 
X_MOTIVO_INV,
X_PARAM,
X_BODEGA,
X_PROD_BOD_X_SUBGR,
X_SUBGRUPO
}