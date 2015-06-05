'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Option Explicit On
Option Strict On

Imports bddc.BEC.COM

Namespace CLI
	Public Class clsCliente
		Inherits COM.clsAuditoria

        Private intClienteId As Integer
		Private strClienteCodigo As String
		Private strClienteTitulo As String
		Private strClienteNombres As String
		Private strClienteApePat As String
		Private strClienteApeMat As String
		Private intClienteTipoDocId As Integer
		Private strClienteTipoDoc As String
		Private strClienteNumDoc As String
		Private intClienteGeneroId As Integer
		Private strClienteTelefonoFijo As String
		Private strClienteTelefonoMovil As String
		Private strClienteEmail As String
		Private strClienteFecNac As String
		Private strClienteNacionalidad As String
		Private strClienteProfesion As String
		Private strDomicilioCiudad As String
		Private strDomicilioDireccion As String
		Private strDomicilioPais As String
		Private strDomicilioReferencia As String
		Private strDomicilioTelefono As String
		Private strEmpresaRUC As String
		Private strEmpresaArea As String
		Private strEmpresaDireccion As String
		Private strEmpresaNombre As String
		Private strEmpresaPais As String
		Private strEmpresaPuesto As String
		Private strEmpresaTelefono As String
		Private strPreferenciasFJM As String
		Private strClienteComentarios As String
		Private decClientePuntaje As Decimal
		Private strClienteTier As String
        Private intClienteEstadoId As Integer
        Private strClienteDistrito As String
        Private strClienteProvincia As String
        Private strClienteDepartamento As String

		Public Sub New()

				intClienteId = 0
				strClienteCodigo = ""
			    strClienteNumDoc = ""
			    strClienteTitulo = ""
			    strClienteApePat = ""
				strClienteApeMat = ""
			    strClienteNombres = ""
			    strClienteTelefonoMovil = ""
			    strClienteTelefonoFijo = ""
			    strClienteEmail = ""
            strClienteFecNac = ""
            strClienteNacionalidad = ""
            strClienteComentarios = ""
			    strClienteProfesion = ""
            strEmpresaNombre = ""
            strEmpresaRUC = ""
			    strEmpresaArea = ""
			    strEmpresaPuesto = ""
			    strEmpresaDireccion = ""
			    strEmpresaTelefono = ""
			    strEmpresaPais = ""
			    strDomicilioDireccion = ""
			    strDomicilioCiudad = ""
			    strDomicilioPais = ""
			    strDomicilioReferencia = ""
			    strDomicilioTelefono = ""
		End Sub

		Public Property ClienteId() As Integer
			Get
				Return intClienteId
			End Get
			Set(ByVal Value as Integer)
				intClienteId = Value
			End Set
		End Property

		Public Property ClienteCodigo() As String
			Get
				Return strClienteCodigo
			End Get
			Set(ByVal Value as String)
				strClienteCodigo = Value
			End Set
		End Property

		Public Property ClienteTitulo() As String
			Get
				Return strClienteTitulo
			End Get
			Set(ByVal Value as String)
				strClienteTitulo = Value
			End Set
		End Property

		Public Property ClienteApePat() As String
			Get
				Return strClienteApePat
			End Get
			Set(ByVal Value as String)
				strClienteApePat = Value
			End Set
		End Property

		Public Property ClienteApeMat() As String
			Get
				Return strClienteApeMat
			End Get
			Set(ByVal Value as String)
				strClienteApeMat = Value
			End Set
		End Property

		Public Property ClienteNombres() As String
			Get
				Return strClienteNombres
			End Get
			Set(ByVal Value as String)
				strClienteNombres = Value
			End Set
		End Property

		Public Property ClienteNumDoc() As String
			Get
				Return strClienteNumDoc
			End Get
			Set(ByVal Value as String)
				strClienteNumDoc = Value
			End Set
		End Property

		Public Property ClienteTelefonoMovil() As String
			Get
				Return strClienteTelefonoMovil
			End Get
			Set(ByVal Value as String)
				strClienteTelefonoMovil = Value
			End Set
		End Property

		Public Property ClienteTelefonoFijo() As String
			Get
				Return strClienteTelefonoFijo
			End Get
			Set(ByVal Value as String)
				strClienteTelefonoFijo = Value
			End Set
		End Property

		Public Property ClienteEmail() As String
			Get
				Return strClienteEmail
			End Get
			Set(ByVal Value as String)
				strClienteEmail = Value
			End Set
		End Property

		Public Property ClienteFecNac() As String
			Get
				Return strClienteFecNac
			End Get
			Set(ByVal Value as String)
				strClienteFecNac = Value
			End Set
		End Property

		Public Property ClienteGeneroId() As Integer
			Get
				Return intClienteGeneroId
			End Get
			Set(ByVal Value as Integer)
				intClienteGeneroId = Value
			End Set
		End Property

		Public Property ClienteProfesion() As String
			Get
				Return strClienteProfesion
			End Get
			Set(ByVal Value as String)
				strClienteProfesion = Value
			End Set
		End Property

		Public Property ClienteNacionalidad() As String
			Get
				Return strClienteNacionalidad
			End Get
			Set(ByVal Value as String)
				strClienteNacionalidad = Value
			End Set
		End Property

		Public Property DomicilioDireccion() As String
			Get
				Return strDomicilioDireccion
			End Get
			Set(ByVal Value as String)
				strDomicilioDireccion = Value
			End Set
		End Property

		Public Property DomicilioCiudad() As String
			Get
				Return strDomicilioCiudad
			End Get
			Set(ByVal Value as String)
				strDomicilioCiudad = Value
			End Set
		End Property

		Public Property DomicilioPais() As String
			Get
				Return strDomicilioPais
			End Get
			Set(ByVal Value as String)
				strDomicilioPais = Value
			End Set
		End Property

		Public Property DomicilioReferencia() As String
			Get
				Return strDomicilioReferencia
			End Get
			Set(ByVal Value as String)
				strDomicilioReferencia = Value
			End Set
		End Property

		Public Property DomicilioTelefono() As String
			Get
				Return strDomicilioTelefono
			End Get
			Set(ByVal Value as String)
				strDomicilioTelefono = Value
			End Set
		End Property

		Public Property EmpresaRUC() As String
			Get
				Return strEmpresaRUC
			End Get
			Set(ByVal Value as String)
				strEmpresaRUC = Value
			End Set
		End Property

		Public Property EmpresaArea() As String
			Get
				Return strEmpresaArea
			End Get
			Set(ByVal Value as String)
				strEmpresaArea = Value
			End Set
		End Property

		Public Property EmpresaNombre() As String
			Get
				Return strEmpresaNombre
			End Get
			Set(ByVal Value as String)
				strEmpresaNombre = Value
			End Set
		End Property

		Public Property EmpresaPuesto() As String
			Get
				Return strEmpresaPuesto
			End Get
			Set(ByVal Value as String)
				strEmpresaPuesto = Value
			End Set
		End Property

		Public Property EmpresaDireccion() As String
			Get
				Return strEmpresaDireccion
			End Get
			Set(ByVal Value as String)
				strEmpresaDireccion = Value
			End Set
		End Property

		Public Property EmpresaTelefono() As String
			Get
				Return strEmpresaTelefono
			End Get
			Set(ByVal Value as String)
				strEmpresaTelefono = Value
			End Set
		End Property

		Public Property EmpresaPais() As String
			Get
				Return strEmpresaPais
			End Get
			Set(ByVal Value as String)
				strEmpresaPais = Value
			End Set
		End Property

		Public Property ClientePuntaje() As Decimal
			Get
				Return decClientePuntaje
			End Get
			Set(ByVal Value as Decimal)
				decClientePuntaje = Value
			End Set
		End Property

		Public Property ClienteComentarios() As String
			Get
				Return strClienteComentarios
			End Get
			Set(ByVal Value as String)
				strClienteComentarios = Value
			End Set
		End Property

		Public Property PreferenciasFJM() As String
			Get
				Return strPreferenciasFJM
			End Get
			Set(ByVal Value as String)
				strPreferenciasFJM = Value
			End Set
		End Property

		Public Property ClienteEstadoId() As Integer
			Get
				Return intClienteEstadoId
			End Get
			Set(ByVal Value as Integer)
				intClienteEstadoId = Value
			End Set
		End Property

		Public Property ClienteTier() As String
			Get
				Return strClienteTier
			End Get
			Set(ByVal Value as String)
				strClienteTier = Value
			End Set
		End Property

		Public Property ClienteTipoDocId() As Integer
			Get
				Return intClienteTipoDocId
			End Get
			Set(ByVal Value as Integer)
				intClienteTipoDocId = Value
			End Set
		End Property

		Public Property ClienteTipoDoc() As String
			Get
				Return strClienteTipoDoc
			End Get
			Set(ByVal Value as String)
				strClienteTipoDoc = Value
			End Set
		End Property

        Public Property ClienteDistrito() As String
            Get
                Return strClienteDistrito
            End Get
            Set(ByVal Value As String)
                strClienteDistrito = Value
            End Set
        End Property

        Public Property ClienteProvincia() As String
            Get
                Return strClienteProvincia
            End Get
            Set(ByVal Value As String)
                strClienteProvincia = Value
            End Set
        End Property

        Public Property ClienteDepartamento() As String
            Get
                Return strClienteDepartamento
            End Get
            Set(ByVal Value As String)
                strClienteDepartamento = Value
            End Set
        End Property

	End Class ' clsCliente

End Namespace ' CLI