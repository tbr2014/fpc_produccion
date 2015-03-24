<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PagoProv.aspx.vb" Inherits="bddc.Web.PagoProv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Thunderbird Resorts</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/Styles.css" type="text/css" rel="stylesheet">
		<LINK href="../css/menuStyle.css" type="text/css" rel="stylesheet">
</head>
<body class="standard">
<form id="Form1" method="post" runat="server">
   <TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td><!--#include file="../inc/header.htm"--></td>
				</tr>				
				<TR>
					<TD height="2"></TD>
				</TR>
				<TR>
					<TD>
						<table class="NavyTable" cellSpacing="0" cellPadding="0" width="800"
							border="0">
							<tr>
								<td colSpan="3">
									<table height="100%" cellSpacing="0" cellPadding="0" width="780" border="0">
										<tr>
											<td class="GNRtxtTitulo01" align="center"><asp:label id="lblTitulo" runat="server"> Titulo </asp:label>&nbsp;
												<asp:label id="lblVersion" runat="server"></asp:label></td>
										</tr>
										<tr>
											<td height="2"></td>
										</tr>
										<tr>
											<td class="GNRtxtTitulo02" align="center" height="15"><asp:label id="lblOpcion" runat="server">Opcion</asp:label></td>
										</tr>
										<tr>
											<td align="center"><asp:label id="lblMensaje" runat="server" CssClass="GNRtxtError"></asp:label></td>
										</tr>
										<tr>
											<td height="2"></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr vAlign="top">
								<TD style="WIDTH: 815px">
									<TABLE class="NavyText" id="Table3" cellSpacing="0" cellPadding="2" border="0">
										<tr>
											<td style="WIDTH: 50px">R.U.C.</td>
											<td>:</td>
											<td><asp:textbox id="txtNumRUC" Width="100px" MaxLength="11" cssClass="GNRtxtInputNavy" Runat="server" onkeypress="javascript:return soloNumeros(event);"></asp:textbox></td>
											<TD></TD>
										</tr>
										<tr>
											<td colSpan="3"><asp:imagebutton id="btnBuscar" style="CURSOR: hand" Runat="server" ImageUrl="../img/buscar.gif"
													AlternateText="Buscar"></asp:imagebutton></td>
											<TD></TD>
										</tr>
									</TABLE>
								</TD>
							</tr>
							<TR>
								<TD style="WIDTH: 815px" height="5" ></TD>
							</TR>
							<tr>
								<TD style="WIDTH: 815px" height="400" valign="top">
									<table cellSpacing="0" cellPadding="0" border="0">
										<tr valign="top">
											<td valign="top"><asp:datagrid id="dgResultados" runat="server" CssClass="TBLTabla01" Width="700px" GridLines="Vertical"
													AutoGenerateColumns="False" AllowSorting="True">
													<FooterStyle Font-Bold="True"></FooterStyle>
													<AlternatingItemStyle Wrap="False" CssClass="TBLTextoImpar01"></AlternatingItemStyle>
													<ItemStyle Wrap="False" CssClass="TBLTextoPar01"></ItemStyle>
													<Columns>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="10px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton2" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="1">
																		Nro.&nbsp;
																	</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<p align="center">
																	<%# DataBinder.Eval(Container.DataItem, "NroItem") %>
																</p>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="100px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton1" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="1">
																		Empresa&nbsp;
																	</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "Empresa") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="100px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton1" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="1">
																		Fecha Pago&nbsp;
																	</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "Fecha") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="100px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton3" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="2">
																		R.U.C.&nbsp;
																	</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "ProvRUC") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="200px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton4" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="3">
																		Proveedor&nbsp;
																	</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<%# DataBinder.Eval(Container.DataItem, "ProvNombre") %>
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="100px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton7" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="9">
																		No. Documento&nbsp;
																	</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<asp:Label ID="lblFecha" Text='<%# DataBinder.Eval(Container.DataItem, "ProvNumDoc") %>' Runat="server" />
															</ItemTemplate>
														</asp:TemplateColumn>
														<asp:TemplateColumn>
															<HeaderStyle Wrap="False" Width="100px" CssClass="TBLTitulo01Out"></HeaderStyle>
															<HeaderTemplate>
																<asp:LinkButton id="Linkbutton5" Runat="server" EnableViewState="True" CssClass="TBLTitulo01Enlace"
																	onmouseover="this.parentElement.className='TBLTitulo01Over';" onmouseout="this.parentElement.className='TBLTitulo01Out';"
																	OnCommand="sortColumn" CommandArgument="4">
																		Monto&nbsp;
																	</asp:LinkButton>
															</HeaderTemplate>
															<ItemTemplate>
																<p align="right">
																	<b>
																		<%# DataBinder.Eval(Container.DataItem, "VerMonto") %>
																	</b>
																</p>
															</ItemTemplate>
														</asp:TemplateColumn>
													</Columns>
													<PagerStyle Mode="NumericPages"></PagerStyle>
												</asp:datagrid></td>
										</tr>
										<tr>
											<td></td>
										</tr>
									</table>
									<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="100%" border="0">
										<TR>
											<TD align="center"><a href="http://www.fiesta-casino.pe"
													target="_blank">
                                                <IMG src="../img/fiestacasino.png" border="0" 
                                                    alt="Fiesta Casino Benavides"><IMG src="../img/sunnippon.png" border="0" 
                                                    alt="Fiesta Casino Benavides"></a></TD>
										</TR>
									</TABLE>
								</TD>
							</tr>
							<TR>
								<TD style="WIDTH: 815px"></TD>
							</TR>
						</table>
					</TD>
				</TR>
			</TABLE>
</form>

</body>
</html>
