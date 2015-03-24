<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EnConstruccion.aspx.vb" Inherits="itpe.EnConstruccion" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Sistema de Techo Propio (STP)</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/Styles.css" type="text/css" rel="stylesheet">
		<LINK href="../css/menuStyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body leftMargin="0" topMargin="0" class="standar">
		<form id="frm1" runat="server">
			<table class="NavyText" cellSpacing="0" cellPadding="0" width="800" border="0">
				<tr>
					<td><!--#include file="../inc/header.htm"--></td>
				</tr>
				<tr height="3">
					<td></td>
				</tr>
				<TR>
					<TD>
						<table class="NavyTable" height="100%" cellSpacing="1" cellPadding="0"
							width="800" border="0">
							<tr>
								<td class="GNRtxtTitulo01" align="center">
									<asp:label id="lblTitulo" runat="server"> Titulo </asp:label>
									<asp:Label id="lblVersion" runat="server"></asp:Label>
								</td>
							</tr>					
							<tr>
								<td class="GNRtxtTitulo02" align="center">
									<asp:label id="lblOpcion" runat="server">Opcion</asp:label></td>
							</tr>
							<tr>
								<td height="3"></td>
							</tr>
							<tr>
								<td class="NavyText" align="center">
									<asp:Label id="lblMensaje" runat="server"></asp:Label></td>
							</tr>
							<tr>
								<td height="15"></td>
							</tr>
							<tr height="100">
								<td align="center" valign="top">
									<P>
										<img src="../img/construccion.gif">
									</P>
									<P><INPUT class="NavyBold" type="button" value="Volver" onclick="javascript:history.back();"></P>
								</td>
							</tr>
						</table>
					</TD>
				</TR>
			</table>
		</form>
	</body>
</HTML>
