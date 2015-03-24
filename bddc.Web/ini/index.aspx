<%@ Page Language="vb" AutoEventWireup="false" Codebehind="index.aspx.vb" Inherits="bddc.Web.index" %>
<%@ Register TagPrefix="cc1" Namespace="skmMenu" Assembly="skmMenu" %>
<HTML>
    <HEAD>
		<title>Thunderbird Resorts - IT Perú </title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/Styles.css" type="text/css" rel="stylesheet">
		<LINK href="../css/menuStyle.css" type="text/css" rel="stylesheet">
    </HEAD>
    <body class="standar">
	    <form id="frmForm01" method="post" runat="server">
		    <table class="NavyText" cellSpacing="0" cellPadding="0" border="0" width="800" >
			    <tr height="62">
				    <td><!--#include file="../inc/header.htm"--></td>
			    </tr>
			    <tr>
				    <td><cc1:menu id="mnuMenu" runat="server" Layout="Horizontal" CssClass="menustyle"></cc1:menu></td>
			    </tr>			
			    <tr>
				    <td vAlign="top">
					    <table class="NavyTable" cellSpacing="1" cellPadding="0" border="0" width="800">
						    <tr>
							    <td class="GNRtxtTitulo01" align="center">
							        <asp:label id="lblTitulo" runat="server"> Titulo </asp:label>&nbsp;
								    <asp:Label id="lblVersion" runat="server"></asp:Label></td>
						    </tr>							
						    <tr>
							    <td class="GNRtxtTitulo02" align="center"><asp:label id="lblOpcion" runat="server">Opcion</asp:label></td>
						    </tr>
						    <tr>
							    <td align="center"><asp:label id="lblMensaje" runat="server" CssClass="GNRtxtError" Visible="False"></asp:label></td>
						    </tr>
						    <tr  height="3px">
							    <td></td>
						    </tr>
						    <tr>
				                <td align="right" height="20px">	
				                    <asp:Label ID="lblUsuariosOnline" runat="server"></asp:Label>					
				                </td>
			                </tr>
						    <tr height=220 valign=middle>
							    <td align=center height="20" >
                                    <asp:Label ID="lblBienvenida" runat="server" CssClass="BlackBold"></asp:Label>
							    </td>
						    </tr>
						    <tr height=220 valign=middle>
							    <td align=center >&nbsp;</td>
						    </tr>
					    </table>
				    </td>
			    </tr>
			    <tr>
				    <td height="200px">						
				    </td>
			    </tr>
			  
			    <tr height="25" valign="bottom">
				    <td><!--#include file="../inc/footer.htm"-->                       
                    </td>
			    </tr>
		    </table>
	    </form>
    </body>
</HTML>
