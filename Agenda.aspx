<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="AgendaContactos.Agenda2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 503px;
        }
        #buscarbtn {
            width: 89px;
            position:relative;
            top:76px;
            
        }
        #contactos {
            margin-right:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color:aquamarine">
        <div style="height: 467px; width: 461px" id="div1">
            <p>Texto y/o ciudad</p>
            <input type="text" id="info" value="Introduzca texto y/o ciudad..." class="form-control" runat="server"/>
            <asp:Button id="buscarbtn" Text="Buscar" OnClick="buscar_Click" runat="server"/>
        </div>
        <div style="background-color:darkseagreen; position:relative; top: -462px; left: 470px; height: 312px; width: 461px;" id="div2">  
             <p style="position:relative;"><b>Contacto/s</b></p>
            <asp:DropDownList CssClass="form-control" runat="server" ID="contactos" Width="152px"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
