Namespace Enumeracion

    Public Enum enmGrupoParametro As Integer
        MaestroGrupos = 0 ' Grupos Padres

        'AUX:
        Estado = 1
        Empresas = 2
        Genero = 3
        EstadoCivil = 4
        Nacionalidad = 5
        DocumentoIdentidad = 6
        TipoMoneda = 7
        Dia = 8
        Mes = 9

        'FCB luxor lima Juego de Mesas:
        FJM_ParametrosSistema = 1
        FJM_TipoMovimiento = 21
        FJM_TipoJuegoMesa = 22
        FJM_Pits = 23
        FJM_OperacionesMesa = 24
        FJM_DenominacionesFichas = 25
        FCB_CajayConteo_Cajas = 26
        FCB_CajayConteo_Cajas_Grupo = 27


        'Configuración:
        ConfiguracionImpresorasCaja = 90
        ConfiguraciónDimensionPaginaCaja = 91

        'Seguridad:
        SEG_Modulos = 100
        SEG_TipoRol = 101
        SEG_TipoAccion = 102
        SEG_TipoAutenticacion = 103
        SEG_OpcionesMenu = 104

    End Enum

    Public Enum enmMesasId As Integer
        Ruleta = 1
        BlackJack = 2
        Poker = 3
        TexasHoldenPoker = 4
        MesasPokerBacarat = 5
    End Enum

    Public Enum enmSEGModulos As Integer
        SISTIT = 1
        SISLGI = 2
        SISLGO = 3
        SISINI = 4
        SISMIW = 5
        MODTBL = 101
        MODSEG = 102
        MODFPC = 201
        MODCYC = 202
    End Enum

    Public Enum enmMoneda As Integer
        Moneda_Soles = 1
        Moneda_Dolar = 2
    End Enum

    Public Enum enmResultadoOperacion As Integer
        OK = 1
        NONE = 0
        ERR = -1
    End Enum

    Public Enum enmTipoAccion As Integer
        LogIn = 0
        LogOut = -1
        Create = 1
        Read = 2
        Update = 3
        Delete = 4
        Print = 5
        Proceso = 6
    End Enum

    Public Enum enmSEGRol As Integer
        Administrador = 1
        Gerente = 2
        Supervisor = 3
        Operador = 4
        Observador = 5
    End Enum

    Public Enum enmSEGTipoAutenticacion As Integer
        BD = 0
        LDAP = 1
    End Enum

    Public Enum enmSEGOpcionesMenu As Integer
        btnOperaciones_Clientes = 1
        btnOperaciones_MesasRatingRegistro = 2
        btnOperaciones_MesasRatingTraslado = 3
        btnOperaciones_MesasEstimado = 4
        btnOperaciones_MesasReportes = 5
        btnOperaciones_MesasImpresionTickets = 6
        btnOperaciones_MesasMovimientos = 7
        btnOperaciones_SlotsReporte = 8
        btnOperaciones_SlotsImpresionTickets = 9
        btnSistema_Parametros = 10
        btnSistema_AuditoriaEventos = 11
        btnSistema_SeguridadUsuarios = 12
        btnSistema_SeguridadAccesos = 13
        'btnOperaciones_MesasOperaciones = 14
        'btnOperaciones_CajayConteo = 15
        btnOperaciones_MercadeoPromociones = 14
        btnOperaciones_MercadeoCortesias = 15
        btnOperaciones_MercadeoReportes = 16
        btnOperaciones_CajayConteoRegistro = 17
        btnOperaciones_CajayConteoReportes = 18
        btnOperaciones_CajayConteoImprimir = 19

    End Enum

    Public Enum enmConfigOrigen As Integer
        FIESTACONFING = 1
        LUXORCONFING = 2
        TACNACONFING = 3
        'LUXORCONFING = 3
        REGISTRY = 4
        PRUEBA = 5
    End Enum

    Public Enum enmAUXTipoUbigeo As Integer
        PAIS = 1
        DEPARTAMENTO = 2
        PROVINCIA = 3
        DISTRITO = 4
    End Enum

    Public Enum enmFJMTipoJuegoMesa As Integer
        Ruleta = 1
        BlackJack = 2
        Poker = 3
        TexasHoldemPoker = 4
        PokerBacarat = 5
    End Enum

    'De acuerdo a GRUPO_ID=30 (Fuente de datos)
    Public Enum enmFJMTipoNegocio As Integer
        Hoteles = 1
        Slots = 2
        Mesas = 3
        TWC = 4
        AyB = 5
        Otros = 9
    End Enum

    Public Enum enmFJMTipoImagen As Integer
        Pit = 0
        Inactivo = 1
        Abierto = 2
        Ver = 3
        Editar = 4
        Cerrado = 5
    End Enum

    Public Enum enmFJMTipoOperacionMesa As Integer
        Cierre = 0
        Apertura = 1
        Relleno = 2
        Credito = 3
        PagoCliente = 4
    End Enum

    Public Enum enmFCBCajaModalidadOperacion As Integer
        Efectivo = 1
        TarjetaCredito = 2
        TarjetaDebito = 3
    End Enum

    Public Enum enmFCBCajaTipoOperacion As Integer
        CanjeDineroxFichas = 1
        CanjeFichasxDinero = 2
        CanjeTicketsSlots = 3
        CanjeTicketsxFichas = 4
        CobroPremioJackpot = 5
        RetiroEfectivo = 6
    End Enum

    Public Enum enmFCBReporteOperacionCaja As Integer
        RetiroEfectivoTarjetas = 0
        RegistroVentasFichas = 1
        RegistroPagosManuales = 2
    End Enum

    Public Enum enmFCBReporteMarketing As Integer
        ClienteSlots = 0
        ClienteMesas = 1
    End Enum

    Public Enum enmImpresoraEstado As Integer
        PrinterIdle = 3
        PrinterPrinting = 4
        PrinterWarmingUp = 5
        PrinterStoppedPrinting = 6
        PrinterOffline = 7
        PrinterPaused = 8
        PrinterError = 9
        PrinterBusy = 10
        PrinterNotAvailable = 11
    End Enum

    Public Enum enmFCBTipoTurno As Integer
        Mesas = 0
        Cajas = 1
    End Enum

    Public Enum enmFCBCajaOperacionTipoTarjeta As Integer
        Visa = 1
        Mastercard = 2
    End Enum

End Namespace


