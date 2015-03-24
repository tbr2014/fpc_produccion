<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Login.aspx.vb" Inherits="itpe.Login" %>
<%@ Register TagPrefix="cc1" Namespace="skmMenu" Assembly="skmMenu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Thunderbird Resorts - IT Perú </title>	
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/Styles.css" type="text/css" rel="stylesheet">
		<LINK href="../css/menuStyle.css" type="text/css" rel="stylesheet">
		<script language="JavaScript" src="../inc/ValidForm.js"></script>
	</HEAD>
	<body class="standar">
		<form id="frm1" method="post" runat="server">
			<table class="NavyText" cellSpacing="0" cellPadding="0" width="800" border="0">
				<tr height="62">
					<td><!--#include file="../inc/header.htm"--></td>
				</tr>				
				<TR>
					<TD>
						<table class="NavyTable" cellSpacing="0" cellPadding="0" width="800" border="0">
							<tr>
								<td colSpan="3">
									<table height="100%" cellSpacing="1" cellPadding="0" width="800" border="0">
										<tr>
											<td class="GNRtxtTitulo01" align="center">
												<asp:label id="lblTitulo" runat="server"> Titulo </asp:label>&nbsp;<asp:Label id="lblVersion" runat="server"></asp:Label>
											</td>
										</tr>						
										<tr>
											<td class="GNRtxtTitulo02" align="center"><asp:label id="lblOpcion" runat="server">Opcion</asp:label></td>
										</tr>
										 <tr height="3px"><td></td>
						                </tr>
										<tr>
											<td class="NavyText" align="center"  height="20"><asp:Label id="lblMensaje" runat="server"></asp:Label></td>
										</tr>
									</table>
								</td>
							</tr>
							<tr height="100">
								<td align="center" valign="top">
									<table cellSpacing="1" cellPadding="1" border="1" class="Texto">
										<tr>
											<td>Usuario</td>
											<td>
												<asp:TextBox id="txtUsuario" runat="server" MaxLength="50" 
                                                    CssClass="GNRtxtInputNavy" tabIndex="1" Width="160px"></asp:TextBox>
											</td>
										</tr>
										<tr>
											<td>Contraseña</td>
											<td>
												<asp:TextBox id="txtPassword" runat="server" MaxLength="20" TextMode="Password" CssClass="GNRtxtInputNavy"
													tabIndex="2" Width="160px"></asp:TextBox>
											</td>
										</tr>
										<tr>
											<td align="center" colspan="2">
                                                <asp:CheckBox ID="chkInicioAuto" runat="server" 
                                                    Text="Iniciar Automáticamente" />
                                            </td>
										</tr>
										<tr>
											<td colspan="2" align="center">
												<asp:Button id="btnAceptar" runat="server" Text="Aceptar" tabIndex="3" CssClass="ButtomText"
													Width="80px"></asp:Button>
												<INPUT type="button" value="Cerrar" onclick="window.close();" class="ButtomText" style="WIDTH: 80px; HEIGHT: 19px">
											    <asp:Label ID="lblLogin" runat="server" Visible="False"></asp:Label>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</TD>
				</TR>
			</table>
		</form>
	</body>
</HTML>
