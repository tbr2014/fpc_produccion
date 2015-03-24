<%@ Page Language="vb" AutoEventWireup="false" Codebehind="frmClienteReg.aspx.vb" Inherits="bddc.Web.frmClienteReg" %>
<%@ Register TagPrefix="cc1" Namespace="skmMenu" Assembly="skmMenu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>T Wellness Center</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK rel="stylesheet" type="text/css" href="../css/Styles.css">
		<LINK rel="stylesheet" type="text/css" href="../css/menuStyle.css">
		<script language="JavaScript" src="../inc/ValidForm.js"></script>
		<script language="JavaScript" src="../calendar/calendar.js"></script>
		<script language="javascript">	
			function initPage()
			{
				verTab(0);				
			}		
			
			function verTab(tab) 
			{
				
				//return;
				//alert(document.getElementById("hdTabActivo").value);
				
				if (tab==0)
				{
					if (document.getElementById("hdTabActivo").value == "")	 
						tab = 1;
					else
						tab = document.getElementById("hdTabActivo").value;	
				}		
				
				//alert(tab);
				document.getElementById("hdTabActivo").value = tab;
												 
				for (i=1;i<4;i++) {				
					if ( !(!(document.getElementById('td' + i))) )   
					{
						if (i==tab)
						{
							eval("document.getElementById('td" + i + "').className = 'tabOver'");
							eval("document.getElementById('tab" + i + "').style.visibility = 'visible'");
							eval("document.getElementById('tab" + i + "').style.display = 'inline'");
						}
						else
						{
							eval("document.getElementById('td" + i + "').className = 'tabOut'");
							eval("document.getElementById('tab" + i + "').style.visibility = 'hidden'");
							eval("document.getElementById('tab" + i + "').style.display = 'none'");
							//eval("document.getElementById('tab" + i + "').style.height = '0'");
						}
					}
				}				
													
			} 
		</script>
	</HEAD>
	<body class="standar" onload="initPage();" leftMargin="0" topMargin="0">
		<form id="frm1" encType="multipart/form-data" method="post" runat="server">
			<table class="NavyText" border="0" cellSpacing="0" cellPadding="0" width="800">
				<tr height="62">
					<td><!--#include file="../inc/header.htm"--></td>
				</tr>
				<tr>
					<td><cc1:menu id="mnuMenu" runat="server" Layout="Horizontal" CssClass="menustyle"></cc1:menu></td>
				</tr>
				<tr height="400">
					<td vAlign="top">
						<table class="NavyTable" border="0" cellSpacing="2" cellPadding="0" width="800px">
							<tr>
								<td style="HEIGHT: 13px" class="GNRtxtTitulo01" align="center"><asp:label id="lblTitulo" runat="server"> Titulo </asp:label>&nbsp;<asp:label id="lblVersion" runat="server"></asp:label></td>
							</tr>
							<tr>
								<td style="HEIGHT: 16px" class="GNRtxtTitulo02" align="center"><asp:label id="lblOpcion" runat="server">Opcion</asp:label></td>
							</tr>
							<tr>
								<td class="NavyText" height="20" align="center"><asp:label id="lblMensaje" runat="server" CssClass="GNRtxtError"></asp:label></td>
							</tr>
							<TR>
								<TD class="NavyText" height="20" align="left"><asp:validationsummary id="vsResumen" 
                                        runat="server"></asp:validationsummary></TD>
							</TR>
							<TR>
								<TD vAlign="top" align="left"><asp:imagebutton style="CURSOR: hand" id="btnGuardar" tabIndex="3" ImageUrl="../img/Grabar.gif" ToolTip="Grabar"
										Runat="server"></asp:imagebutton><asp:imagebutton style="CURSOR: hand" id="btnBuscar" tabIndex="1" runat="server" ImageUrl="../img/buscar.gif"
										ToolTip="Buscar" CausesValidation="False"></asp:imagebutton>
                                    <INPUT style="WIDTH: 0px; overflow: hidden;" id="hdTabActivo" class="NavyText" 
                                        name="hdTabActivo" runat="server">
								</TD>
							</TR>
							<tr>
								<td>
									<TABLE id="tbTabs" class="NavyText" border="0" cellSpacing="0" cellPadding="0" height="25" width="800">
										<TR>
											<TD id="td1" class="tabOut" onclick="JavaScript:verTab(1);" width="250"  align="center"
												runat="server">Registro de datos
											</TD>
											<TD id="td2" class="tabOut" onclick="JavaScript:verTab(2);" width="250"  align="center"
												runat="server">Adquisiciones de Paquetes/Productos
											</TD>
											<TD id="td3" class="tabOut" onclick="JavaScript:verTab(3);"  align="center"
												runat="server">Archivo de Foto
											</TD>
										</TR>
									</TABLE>
								</td>
							</tr>
							<tr>
								<td id="tab1" class="BordeTab" vAlign="top" runat="server">
									<TABLE id="Table1" class="NavyText" border="0" cellSpacing="0" cellPadding="2" width="800px">
										<TR>
											<TD class="tabTitulo" colSpan="6">Registro de Datos</TD>
											<TD class="tabTitulo" colSpan="3" align="center" width="800"><asp:label id="lblTipoCliente" runat="server" CssClass="TextoEstadoCliente"></asp:label>&nbsp;<asp:label id="lblClienteCodigo" runat="server" CssClass="TextoEstadoCliente">0000</asp:label></TD>
										</TR>
										<TR>
											<TD width="100" ></TD>
											<TD width="4" ></TD>
											<TD width="100" ><asp:label id="lblClienteId" runat="server" Visible="false"></asp:label></TD>
											<TD width="80" ></TD>
											<TD style="WIDTH: 9px; HEIGHT: 13px" ></TD>
											<TD width="160" ></TD>
											<TD width="90" ></TD>
											<TD  width="4"></TD>
											<TD width="150"  align="center"></TD>
										</TR>
										<TR>
											<TD >Documento</TD>
											<TD >:</TD>
											<TD ><asp:dropdownlist id="ddlTipoDoc" runat="server" CssClass="GNRtxtInputNavy" 
                                                    Width="60px" TabIndex="1"></asp:dropdownlist><asp:textbox id="txtNroDoc" 
                                                    runat="server" CssClass="GNRtxtInputNavy" Width="80px" MaxLength="10" 
                                                    TabIndex="2"></asp:textbox></TD>
											<TD ></TD>
											<TD style="WIDTH: 9px; HEIGHT: 16px" id="Td6" onclick="JavaScript:verTab(2);" 
												runat="server"></TD>
											<TD >&nbsp;
											</TD>
											<TD ></TD>
											<TD ></TD>
											<TD ></TD>
										</TR>
										<TR>
											<TD vAlign="top">Nombres</TD>
											<TD vAlign="top" width="9">:</TD>
											<TD vAlign="top"><asp:textbox id="txtNombres" runat="server" 
                                                    CssClass="GNRtxtInputNavy" ToolTip="Ingresar Nombres"
													Width="150px" TabIndex="3"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" CssClass="redBold" ErrorMessage="Ingrese Nombre(s)"
													ControlToValidate="txtNombres">*</asp:requiredfieldvalidator></TD>
											<TD vAlign="top" align="right">Ape. Paterno
											</TD>
											<TD style="WIDTH: 9px; HEIGHT: 22px" vAlign="top" width="9">:</TD>
											<TD vAlign="top"><asp:textbox id="txtApePat" runat="server" 
                                                    CssClass="GNRtxtInputNavy" ToolTip="Ingresa Apellido Paterno"
													Width="150px" TabIndex="4"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" CssClass="redBold" ErrorMessage="Ingrese Apellido Paterno"
													ControlToValidate="txtApePat">*</asp:requiredfieldvalidator></TD>
											<TD vAlign="top" align="right">&nbsp;Ape. Materno&nbsp;
											</TD>
											<TD style="WIDTH: 8px; HEIGHT: 22px" vAlign="top" width="8">:</TD>
											<TD vAlign="top"><asp:textbox id="txtApeMat" runat="server" 
                                                    CssClass="GNRtxtInputNavy" ToolTip="Ingresa Apellido Materno"
													Width="148px" TabIndex="5"></asp:textbox></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 85px; HEIGHT: 20px" width="85">Fecha Nacim.</TD>
											<TD width="9">:</TD>
											<TD><asp:textbox id="txtFecNac" runat="server" CssClass="GNRtxtInputNavy" 
                                                    onkeyup = "ValidateDate(this, event.keyCode)" 
                                                    onkeydown = "return DateFormat(this, event.keyCode)" onblur="javascript:checkDt(this)" 
                                                    Width="80px" MaxLength="10" TabIndex="6"></asp:textbox><IMG style="CURSOR: hand" id="Img1" title="Seleccionar fecha" onclick="getDateTime(txtFecNac,true,false);"
													border="0" align="absMiddle" src="../calendar/calendar.gif" width="21" height="19"><asp:RegularExpressionValidator 
                                                    ID="revFecNac" runat="server" 
                                                    ControlToValidate="txtFecNac" CssClass="redbold" 
                                                    ErrorMessage="Formato de Fecha dd/mm/aaaa" 
                                                    ValidationExpression="^([01]\d)/([0-3]\d)/(\d{4})$" Enabled="False">*</asp:RegularExpressionValidator>
											</TD>
											<TD align="right">&nbsp;Sexo
											</TD>
											<TD style="WIDTH: 9px; HEIGHT: 22px" width="9">:</TD>
											<TD style="WIDTH: 161px"><asp:dropdownlist id="ddlSexo" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="120px" TabIndex="7"></asp:dropdownlist></TD>
											<TD align="right">&nbsp;Est. Civil
											</TD>
											<TD style="WIDTH: 8px; HEIGHT: 22px" width="8">:</TD>
											<TD><asp:dropdownlist id="ddlEstCivil" runat="server" CssClass="GNRtxtInputNavy" 
                                                    Width="152px" TabIndex="8"></asp:dropdownlist></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 85px; HEIGHT: 20px" vAlign="top" width="85">Direccion</TD>
											<TD style="WIDTH: 9px; HEIGHT: 22px" vAlign="top" width="9">:</TD>
											<TD colSpan="4" align="left"><asp:textbox id="txtDireccion" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="400px" MaxLength="500"
													TextMode="MultiLine" Rows="3" TabIndex="9"></asp:textbox></TD>
											<TD vAlign="top" align="right">Nacionalidad</TD>
											<TD vAlign="top" align="left">:</TD>
											<TD vAlign="top" align="left"><asp:dropdownlist id="ddlNacionalidad" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="152px" TabIndex="10"></asp:dropdownlist></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 85px; HEIGHT: 20px" width="85">Telf. Casa</TD>
											<TD style="WIDTH: 9px; HEIGHT: 21px" width="9">:</TD>
											<TD><asp:textbox id="txtTelfCasa" runat="server" CssClass="GNRtxtInputNavy" 
                                                    Width="120px" TabIndex="11"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator4" runat="server" CssClass="redBold" ErrorMessage="Ingrese Teléfono de Casa"
													ControlToValidate="txtTelfCasa">*</asp:requiredfieldvalidator></TD>
											<TD align="right">Telf. Trabajo
											</TD>
											<TD style="WIDTH: 9px; HEIGHT: 21px" width="9">:</TD>
											<TD><asp:textbox id="txtTelfTrabajo" runat="server" CssClass="GNRtxtInputNavy" 
                                                    TabIndex="12"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator5" runat="server" CssClass="redBold" ErrorMessage="Ingrese Teléfono de Trabajo"
													ControlToValidate="txtTelfTrabajo">*</asp:requiredfieldvalidator></TD>
											<TD align="right">Telf. Celular&nbsp;
											</TD>
											<TD style="WIDTH: 8px; HEIGHT: 21px" width="8">:</TD>
											<TD><asp:textbox id="txtTelfCelular" runat="server" CssClass="GNRtxtInputNavy" 
                                                    TabIndex="13"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator6" runat="server" CssClass="redBold" ErrorMessage="Ingrese Teléfono Celular"
													ControlToValidate="txtTelfCelular">*</asp:requiredfieldvalidator></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 85px; HEIGHT: 21px" width="85">Email</TD>
											<TD style="WIDTH: 9px; HEIGHT: 21px" width="9">:</TD>
											<TD style="WIDTH: 309px; HEIGHT: 21px" width="309" colSpan="2">
                                                <asp:textbox id="txtEmail" runat="server" CssClass="GNRtxtInputNavy" 
                                                    Width="280px" TabIndex="14"></asp:textbox></TD>
											<TD style="WIDTH: 9px; HEIGHT: 21px" width="9"></TD>
											<TD><asp:dropdownlist id="ddlEstadoProspecto" runat="server" CssClass="GNRtxtInputNavy" Visible="False"
													Width="70px"></asp:dropdownlist></TD>
											<TD style="HEIGHT: 21px" align="right"></TD>
											<TD style="WIDTH: 8px; HEIGHT: 21px" width="8"></TD>
											<TD style="HEIGHT: 21px"><asp:dropdownlist id="ddlTipoCliente" runat="server" CssClass="GNRtxtInputNavy" Visible="False" Width="100px"></asp:dropdownlist></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 85px; HEIGHT: 63px" vAlign="top" width="85">Observaciones</TD>
											<TD style="WIDTH: 9px; HEIGHT: 63px" vAlign="top" width="9">:</TD>
											<TD style="HEIGHT: 63px" vAlign="top" colSpan="4">
                                                <asp:textbox id="txtObservaciones" runat="server" CssClass="GNRtxtInputNavy" 
                                                    Width="350px" MaxLength="500"
													TextMode="MultiLine" Rows="4" TabIndex="15"></asp:textbox></TD>
											<TD vAlign="top" align="right">Como se enteró&nbsp;?</TD>
											<TD style="HEIGHT: 63px" vAlign="top">:</TD>
											<TD style="HEIGHT: 63px" vAlign="top" rowSpan="2">
                                                <asp:radiobuttonlist id="rblMedios" runat="server" CssClass="GNRtxtInputNavy" 
                                                    TabIndex="17"></asp:radiobuttonlist></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 85px; HEIGHT: 65px" vAlign="top" width="85">Referidos</TD>
											<TD style="WIDTH: 9px; HEIGHT: 65px" vAlign="top" width="9">:</TD>
											<TD style="HEIGHT: 65px" vAlign="top" colSpan="4"><asp:textbox id="txtReferidos" 
                                                    runat="server" CssClass="GNRtxtInputNavy" Width="350px" MaxLength="500"
													TextMode="MultiLine" Rows="4" TabIndex="16"></asp:textbox></TD>
											<TD vAlign="top"></TD>
											<TD width="8"></TD>
										</TR>
										<TR>
											<TD vAlign="top" width="85">Creación</TD>
											<TD style="WIDTH: 9px; HEIGHT: 26px" vAlign="top" width="8">:</TD>
											<TD style="HEIGHT: 26px" vAlign="top" colSpan="7" align="left">
                                                <asp:label id="lblAudCreacion" runat="server" CssClass="NavyBold"></asp:label>&nbsp;- 
                                                Ult.modificación: <asp:label id="lblAudActualizacion" runat="server" 
                                                    CssClass="NavyBold"></asp:label></TD>
										</TR>
									</TABLE>
									<TABLE class="NavyText" border="0" cellSpacing="0" cellPadding="2" width="800">
										<TR>
											<TD class="tabTitulo" height="20" colSpan="3">Datos Adicionales</TD>
										</TR>
										<TR>
											<TD width="100"></TD>
											<TD width="2"></TD>
											<TD width="700"></TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 21px" vAlign="top">Razon Social</TD>
											<TD style="HEIGHT: 21px" vAlign="top">:</TD>
											<TD style="WIDTH: 292px; HEIGHT: 21px"><asp:textbox id="txtRazonSocial" 
                                                    runat="server" CssClass="GNRtxtInputNavy" Width="328px" MaxLength="100" 
                                                    TabIndex="18"></asp:textbox></TD>
										</TR>
										<TR>
											<TD style="HEIGHT: 21px" vAlign="top">RUC</TD>
											<TD style="HEIGHT: 21px" vAlign="top">:</TD>
											<TD style="WIDTH: 292px; HEIGHT: 21px"><asp:textbox id="txtRuc" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="100px" MaxLength="11" TabIndex="19"></asp:textbox></TD>
										</TR>
										<TR>
											<TD vAlign="top">Cargo</TD>
											<TD vAlign="top">:</TD>
											<TD style="WIDTH: 292px"><asp:textbox id="txtCargo" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="240px" MaxLength="50" TabIndex="20"></asp:textbox></TD>
										</TR>
										<TR>
											<TD vAlign="top">Comentarios</TD>
											<TD vAlign="top">:</TD>
											<TD style="WIDTH: 506px"><asp:textbox id="txtComentariosCliente" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="500px"
													MaxLength="500" TextMode="MultiLine" Rows="3" TabIndex="21"></asp:textbox></TD>
										</TR>
									</TABLE>
								</td>
							</tr>
							<tr>
								<td id="tab2" class="BordeTab" vAlign="top" runat="server">
									<TABLE id="Table2" class="NavyText" border="0" cellSpacing="0" cellPadding="2" width="800">
										<TR>
											<TD class="tabTitulo" colSpan="6">Lista de Adquisiciones</TD>
										<TR>
											<TD height="5" colSpan="6"></TD>
										</TR>
										<TR>
											<TD colSpan="6"><asp:datagrid id="dgAdquisiciones" runat="server" CssClass="TBLTabla01" GridLines="Vertical" AutoGenerateColumns="False"
													AllowSorting="True" AllowPaging="True">
													<AlternatingItemStyle Wrap="False" CssClass="TBLTextoImpar01"></AlternatingItemStyle>
													<ItemStyle Wrap="False" CssClass="TBLTextoPar01"></ItemStyle>
													<Columns>
														<asp:BoundColumn Visible="False" DataField="AdquisicionId" ReadOnly="True" HeaderText="AdquisicionId"></asp:BoundColumn>
														<asp:TemplateColumn>
															<HeaderStyle Width="10px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<ItemStyle VerticalAlign="Middle"></ItemStyle>
															<ItemTemplate>
																<IMG id="imgVerAdq" onmouseover="JavaScript:highlightRow(this);" style="CURSOR: hand"
																	onmouseout="JavaScript:unhighlightRow(this);" alt="Ver" src="../img/btnver.gif" runat="server">
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="250px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton2" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="11">
																					Paquete/Producto&nbsp;<%# indicador(11)%>
																				</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "AdquisicionPaqPro") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="75px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton3" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="11">
																					Precio US$&nbsp;<%# indicador(11)%>
																				</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<div align="right"><%# DataBinder.Eval(Container.DataItem, "AdquisicionPrecio", "{0:n}") %></div>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="10px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton5" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="11">
																					Cant.&nbsp;<%# indicador(11)%>
																				</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<div align="center"><%# DataBinder.Eval(Container.DataItem, "AdquisicionCantidad") %></div>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="80px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton9" onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	CssClass="TBLTitulo01Enlace" Runat="server" OnCommand="sortColumn" CommandArgument="3" EnableViewState="True">
																					Fecha Inicio&nbsp;<%# indicador(3)%>
																				</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "AdquisicionFechaInicio") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="80px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton14" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" Runat="server"
																	OnCommand="sortColumn" CommandArgument="4" EnableViewState="True">
																					Fecha Fin&nbsp;<%# indicador(4)%>
																				</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "AdquisicionFechaFin") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="120px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton15" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" Runat="server"
																	OnCommand="sortColumn" CommandArgument="5" EnableViewState="True">
																					Vendido por&nbsp;<%# indicador(5)%>
																				</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "AudUsuario") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="70px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton16" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" Runat="server"
																	OnCommand="sortColumn" CommandArgument="14" EnableViewState="True">
																					Fecha Reg.&nbsp;<%# indicador(14)%>
																				</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<asp:Label id=lblFecha Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "AudFechaReg", "{0:d}") %>'>
																</asp:Label>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="10px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<ItemTemplate>
																<asp:Image id="imgActivo" runat="server" ImageUrl="../img/activo.gif"></asp:Image>
																<asp:Image id="imgInactivo" runat="server" ImageUrl="../img/inactivo.gif"></asp:Image>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="20px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<ItemTemplate>
																<IMG id="imgBorrar" onmouseover="JavaScript:highlightRow(this);" style="CURSOR: hand"
																	onmouseout="JavaScript:unhighlightRow(this);" alt="Eliminar" src="../img/btnBorrar.jpg"
																	runat="server">
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:BoundColumn Visible="False" DataField="AdquisicionEstadoId" HeaderText="AdquisicionEstadoId"></asp:BoundColumn>
													</Columns>
													<PagerStyle Mode="NumericPages"></PagerStyle>
												</asp:datagrid></TD>
										</TR>
									</TABLE>
									<TABLE class="NavyText" border="0" cellSpacing="0" cellPadding="2" width="800">
										<TR>
											<TD height="10" vAlign="top" width="100"></TD>
											<TD vAlign="top" width="4"></TD>
											<TD height="10" vAlign="top" colSpan="4" align="left"><asp:label id="lblPaqProId" runat="server" Visible="False"></asp:label><asp:label id="lblAdqId" runat="server" Visible="False"></asp:label><asp:label id="lblAdqTipoId" runat="server" Visible="False"></asp:label></TD>
										</TR>
										<TR id="trAdquisicionNombre" runat="server">
											<TD height="10" vAlign="top" width="100">Producto/Paquete</TD>
											<TD vAlign="top" width="4">:</TD>
											<TD height="10" vAlign="top" colSpan="4" align="left"><asp:textbox style="Z-INDEX: 0" id="txtAdquisicionDescripcion" runat="server" CssClass="GNRtxtInputNavy"
													Width="420px" ReadOnly="True"></asp:textbox></TD>
										</TR>
										<TR id="trPaqueteDetalle" runat="server">
											<TD height="10" vAlign="top">Contenido</TD>
											<TD height="10" vAlign="top">:</TD>
											<TD height="10" vAlign="top" colSpan="4" align="left"><asp:datagrid id="dgPaqueteDetalle" runat="server" CssClass="TBLTabla01" Width="420px" GridLines="Vertical"
													AutoGenerateColumns="False" AllowSorting="True">
													<FooterStyle Font-Bold="True"></FooterStyle>
													<AlternatingItemStyle Wrap="False" CssClass="TBLTextoImpar01"></AlternatingItemStyle>
													<ItemStyle Wrap="False" CssClass="TBLTextoPar01"></ItemStyle>
													<Columns>
														<asp:BoundColumn Visible="False" DataField="ProductoId" ReadOnly="True" HeaderText="ProductoId"></asp:BoundColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="50px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton17" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" OnCommand="sortColumn"
																	Runat="server" CommandArgument="11" EnableViewState="True">Tipo&nbsp;<%# indicador(11)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "ProductoTipo") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="300px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton18" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" OnCommand="sortColumn"
																	Runat="server" CommandArgument="11" EnableViewState="True">Descripcion&nbsp;<%# indicador(11)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "ProductoDescripcion") %>
															</ItemTemplate>
														</asp:TemplateColumn>
													</Columns>
													<PagerStyle Mode="NumericPages"></PagerStyle>
												</asp:datagrid><BR>
												<asp:button id="btnAdquisicionComprar" runat="server" CssClass="navybold" Text="Comprar"></asp:button></TD>
										</TR>
									</TABLE>
									<TABLE id="tblAdquisicionDetalle" class="NavyText" border="0" cellSpacing="0" cellPadding="2"
										width="800" runat="server">
										<TR>
											<TD height="10" vAlign="top" width="100" align="left">Fecha de Inicio
											</TD>
											<TD style="WIDTH: 4px" height="20">:</TD>
											<TD height="20">
                                                <asp:textbox id="txtFechaInicio" runat="server" 
                                                    CssClass="GNRtxtInputFecha" Width="80px" TabIndex="1"></asp:textbox><IMG style="CURSOR: hand" id="Img2" title="Seleccionar fecha" onclick="getDateTime(txtFechaInicio,true,false);"
													border="0" align="absMiddle" src="../calendar/calendar.gif" width="21" height="19"></TD>
											<TD height="20" align="right">Cantidad</TD>
											<TD height="20">:</TD>
											<TD height="20"><asp:textbox id="txtAdquisicionCantidad" runat="server" 
                                                    CssClass="GNRtxtNumeroNavy" Width="40px" ReadOnly="True">1</asp:textbox></TD>
										</TR>
										<TR>
											<TD height="20">Forma de Pago</TD>
											<TD style="WIDTH: 4px" height="20">:</TD>
											<TD height="20">
                                                <asp:dropdownlist id="ddlFormaPago" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="137px" AutoPostBack="True" TabIndex="2"></asp:dropdownlist></TD>
											<TD height="20" align="right">Nro. de Tarjeta</TD>
											<TD height="20">:</TD>
											<TD height="20"><asp:textbox id="txtNroTarjetaCliente" runat="server" 
                                                    CssClass="GNRtxtInputNavy" Width="212px" TabIndex="3"></asp:textbox></TD>
										</TR>
										<TR id="trAdquisicionEditar" runat="server">
											<TD height="20">Congelamiento</TD>
											<TD style="WIDTH: 4px" height="20">:</TD>
											<TD height="20"><asp:textbox id="txtDiasCongelamiento" runat="server" 
                                                    CssClass="GNRtxtNumeroNavy" Width="40px" TabIndex="4"></asp:textbox>&nbsp;dia(s)</TD>
											<TD height="20" align="right">Alarma</TD>
											<TD height="20">:</TD>
											<TD height="20"><asp:checkbox id="chkAlarma" runat="server"></asp:checkbox></TD>
										</TR>
										<TR id="trTiempoAdicional" runat="server">
											<TD height="20">Tiempo Adicional</TD>
											<TD style="WIDTH: 4px" height="20">:</TD>
											<TD height="20"><asp:textbox id="txtDiasAdicionales" runat="server" 
                                                    CssClass="GNRtxtNumeroNavy" Width="40px" TabIndex="5">0</asp:textbox>&nbsp;dia(s)</TD>
											<TD height="20" align="right">Fecha Venc. Pago</TD>
											<TD height="20">:</TD>
											<TD height="20" id=tdFechaVenc runat=server>
                                                <asp:textbox id="txtFechaVenc" runat="server" 
                                                    CssClass="GNRtxtInputFecha" Width="80px" TabIndex="6"></asp:textbox>
                                                <IMG style="CURSOR: hand" id="imgFecVenc" title="Seleccionar fecha" onclick="getDateTime(txtFechaVenc,true,false);"
													border="0" align="absMiddle" src="../calendar/calendar.gif" width="21" height="19"></TD>
										</TR>
										<TR>
											<TD colSpan="6"></TD>
										</TR>
									</TABLE>
									<TABLE id="tblAsistencias" class="NavyText" border="0" cellSpacing="0" cellPadding="2"
										width="800" runat="server">
										<TR>
											<TD class="tabTitulo" height="20">Asistencias de Membresía</TD>
											<TD class="tabTitulo" height="20">Asistencias del Sesiones</TD>
										</TR>
										<TR>
											<TD width="100"><asp:listbox id="lbAsistMembresia" runat="server" CssClass="GNRtxtNumeroDisable" Rows="10"></asp:listbox></TD>
											<TD width="100"><asp:listbox id="lbAsistSesiones" runat="server" CssClass="GNRtxtNumeroDisable" Rows="10"></asp:listbox></TD>
										</TR>
										<TR>
											<TD vAlign="top" colSpan="3"></TD>
										</TR>
										<TR>
											<TD vAlign="middle" width="200" align="left"># Asistencias:
												<asp:textbox id="txtNumAsistMembresia" runat="server" CssClass="GNRtxtNumeroDisable" Width="40px"
													ReadOnly="True"></asp:textbox></TD>
											<TD vAlign="middle" width="200" align="left"># Asistencias:
												<asp:textbox id="txtNumAsistSesiones" runat="server" CssClass="GNRtxtNumeroDisable" Width="40px"
													ReadOnly="True"></asp:textbox></TD>
										</TR>
									</TABLE>
									<TABLE class="NavyText" border="0" cellSpacing="0" cellPadding="2" width="800">
										<TR>
											<TD class="tabTitulo" height="20" colSpan="6">Adquisición de Paquetes y/o Productos</TD>
										</TR>
										<TR>
											<TD width="100" align="left">Seleccionar</TD>
											<TD width="4">:</TD>
											<TD width="300"><asp:radiobuttonlist id="rblOpciones" runat="server" CssClass="navytext" Width="180px" RepeatDirection="Horizontal"
													AutoPostBack="True">
													<asp:ListItem Value="Paquetes">Paquetes</asp:ListItem>
													<asp:ListItem Value="Productos">Productos</asp:ListItem>
												</asp:radiobuttonlist></TD>
											<td></td>
										</TR>
										<TR id="trBuscarItem" runat="server">
											<TD width="100" align="left"></TD>
											<TD width="4"></TD>
											<TD colSpan="4" align="right">Buscar
												<asp:textbox id="txtBuscarItem" runat="server" CssClass="GNRtxtInputNavy" Width="120px"></asp:textbox>&nbsp;<asp:imagebutton id="imgbtnBuscarAdquisicion" runat="server" ImageUrl="../img/look.png"></asp:imagebutton></TD>
										</TR>
										<TR id="trPaquetes" runat="server">
											<TD vAlign="top">Paquetes</TD>
											<TD vAlign="top">:</TD>
											<TD colSpan="4"><asp:datagrid id="dgPaquetes" runat="server" CssClass="TBLTabla01" GridLines="Vertical" AutoGenerateColumns="False"
													AllowSorting="True" AllowPaging="True" PageSize="30">
													<FooterStyle Font-Bold="True"></FooterStyle>
													<AlternatingItemStyle Wrap="False" CssClass="TBLTextoImpar01"></AlternatingItemStyle>
													<ItemStyle Wrap="False" CssClass="TBLTextoPar01"></ItemStyle>
													<Columns>
														<asp:BoundColumn Visible="False" DataField="PaqueteId" ReadOnly="True" HeaderText="PaqueteId"></asp:BoundColumn>
														<asp:TemplateColumn Visible="False">
															<HeaderStyle Width="20px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<ItemStyle VerticalAlign="Middle"></ItemStyle>
															<ItemTemplate>
																<IMG id="imgVerPaq" onmouseover="JavaScript:highlightRow(this);" style="CURSOR: hand"
																	onmouseout="JavaScript:unhighlightRow(this);" alt="Ver" src="../img/btnver.gif" runat="server">
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="200px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton10" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" OnCommand="sortColumn"
																	Runat="server" CommandArgument="1" EnableViewState="True">Descripcion&nbsp;<%# indicador(1)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "PaqueteDescripcion") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="70px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton11" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" OnCommand="sortColumn"
																	Runat="server" EnableViewState="True" CommandArgument="2">
																								Precio US$&nbsp;<%# indicador(2)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<div align="right"><%# DataBinder.Eval(Container.DataItem, "PaquetePrecio") %></div>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="70px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton12" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" Runat="server"
																	OnCommand="sortColumn" CommandArgument="3" EnableViewState="True">
																								Inicio&nbsp;<%# indicador(3)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "PaqueteFechaInicio") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="70px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton13" onmouseover="this.parentElement.className='TBLTitulo01Over';"
																	onmouseout="this.parentElement.className='TBLTitulo01Out';" CssClass="TBLTitulo01Enlace" Runat="server"
																	OnCommand="sortColumn" EnableViewState="True" CommandArgument="4">
																								Fin&nbsp;<%# indicador(4)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "PaqueteFechaFin") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="10px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<ItemTemplate>
																<asp:HyperLink id="hlkPaquete" runat="server" CssClass="enlace" NavigateUrl="#">Seleccionar</asp:HyperLink>
															</ItemTemplate>
														</asp:TemplateColumn>
													</Columns>
													<PagerStyle Mode="NumericPages"></PagerStyle>
												</asp:datagrid></TD>
										</TR>
										<TR id="trProductos" runat="server">
											<TD vAlign="top">Productos</TD>
											<TD vAlign="top">:
											</TD>
											<TD vAlign="top" colSpan="4" align="left"><asp:datagrid id="dgProductos" runat="server" CssClass="TBLTabla01" GridLines="Vertical" AutoGenerateColumns="False"
													AllowSorting="True" AllowPaging="True" PageSize="30">
													<FooterStyle Font-Bold="True"></FooterStyle>
													<AlternatingItemStyle Wrap="False" CssClass="TBLTextoImpar01"></AlternatingItemStyle>
													<ItemStyle Wrap="False" CssClass="TBLTextoPar01"></ItemStyle>
													<Columns>
														<asp:BoundColumn Visible="False" DataField="ProductoId" ReadOnly="True" HeaderText="ProductoId"></asp:BoundColumn>
														<asp:TemplateColumn Visible="False">
															<HeaderStyle Width="20px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<ItemStyle VerticalAlign="Middle"></ItemStyle>
															<ItemTemplate>
																<IMG id="imgVerProd" onmouseover="JavaScript:highlightRow(this);" style="CURSOR: hand"
																	onmouseout="JavaScript:unhighlightRow(this);" alt="Ver" src="../img/btnver.gif" runat="server">
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="200px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton1" onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	CssClass="TBLTitulo01Enlace" OnCommand="sortColumn" Runat="server" CommandArgument="11" EnableViewState="True">Descripcion&nbsp;<%# indicador(11)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "ProductoDescripcion") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="70px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton8" onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	CssClass="TBLTitulo01Enlace" OnCommand="sortColumn" Runat="server" EnableViewState="True" CommandArgument="3">
																								Precio USD&nbsp;<%# indicador(3)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<div align="right"><%# DataBinder.Eval(Container.DataItem, "ProductoPrecio") %></div>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="20px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton4" onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	CssClass="TBLTitulo01Enlace" Runat="server" OnCommand="sortColumn" CommandArgument="5" EnableViewState="True">
																								Cant&nbsp;<%# indicador(5)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<div align="right"><%# DataBinder.Eval(Container.DataItem, "ProductoCantidad") %></div>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="70px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton7" onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	CssClass="TBLTitulo01Enlace" Runat="server" OnCommand="sortColumn" EnableViewState="True" CommandArgument="15">
																								Und. Med.&nbsp;<%# indicador(15)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "ProductoUnidadMedida") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="90px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton6" onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	CssClass="TBLTitulo01Enlace" Runat="server" OnCommand="sortColumn" EnableViewState="True" CommandArgument="15">
																								Duración (días)&nbsp;<%# indicador(15)%>
																							</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<div align="right"><%# DataBinder.Eval(Container.DataItem, "ProductoDuracion") %></div>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:BoundColumn Visible="False" DataField="ProductoEstado" HeaderText="ProductoEstado"></asp:BoundColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="10px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<ItemTemplate>
																<asp:HyperLink id="hlkProducto" runat="server" CssClass="enlace" NavigateUrl="#">Seleccionar</asp:HyperLink>
															</ItemTemplate>
														</asp:TemplateColumn>
													</Columns>
													<PagerStyle Mode="NumericPages"></PagerStyle>
												</asp:datagrid></TD>
										</TR>
									</TABLE>
								</td>
							</tr>
							<tr>
								<td id="tab3" class="BordeTab" vAlign="top" runat="server">
									<TABLE id="Table3" class="NavyText" border="0" cellSpacing="0" cellPadding="2" width="800">
										<TR>
											<TD class="tabTitulo" colSpan="6">Archivo de Foto</TD>
										<TR>
											<TD height="5" width="150" align="center"><asp:image id="imgFoto" runat="server"></asp:image></TD>
											<TD height="5" vAlign="top"><INPUT id="txtFileUpload" class="navytext" size="60" type="file" runat="server">&nbsp;&nbsp;
												<asp:button id="btnGrabarFoto" runat="server" CssClass="navybold" ToolTip="Guardar Foto" Text="Guardar Foto"></asp:button></TD>
										</TR>
										</TABLE>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			</TD></TR><tr vAlign="bottom" height="25">
				<td><!--#include file="../inc/footer.htm"--></td>
			</tr>
			</TABLE></form>
	</body>
</HTML>
