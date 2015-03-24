Public Class clsColeccion

    Public objCliDALC As DALC.CLI.clsCliente
    Public objCliBEC As BEC.CLI.clsCliente

    Public objMovDALC As DALC.CLI.clsMovimiento
    Public objMovBEC As BEC.CLI.clsMovimiento

    Public objUsuDALC As DALC.SEG.clsUsuario
    Public objUsuBEC As BEC.SEG.clsUsuario

    Public objUsuCfgDALC As DALC.SEG.clsUsuarioConfig
    Public arrUsuCfgBEC As ArrayList
    Public objUsuCfgBEC As BEC.SEG.clsUsuarioConfig

    Public objUsuUndBEC As BEC.COM.clsUnidad

    Public objAuditoria As DALC.SEG.clsUsuarioEvento

    Public objCliConsumoDALC As DALC.CLI.clsClienteConsumo
    Public objCliConsumoBEC As BEC.CLI.clsClienteConsumo

End Class
