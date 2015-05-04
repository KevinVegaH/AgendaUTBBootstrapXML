<%@ Page Title="" Language="C#" MasterPageFile="~/Web/principal.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AppAgendaUTBBoostrapXML.Web.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 370px;
           
        }
         table{
         border-radius: 20px 20px 20px 20px;
            height: 826px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
    <table >
        <tr><td class="auto-style1">
     <center>
        <div class="jumbotron">
        <h2>Crear Personas</h2>
        <div class="form-group">


            <div class="control-group">
                <label class="control-label">Id</label>
                <div class="controls">
                     <asp:TextBox ID="txtId" runat="server" class="input-lg"  ></asp:TextBox>
                </div>
             </div>
             <div class="control-group">
                <label class="control-label" >Nombres</label>
                <div class="controls">
                     <asp:TextBox ID="txtNombres" runat="server" class="input-lg"  ></asp:TextBox>
                </div>
             </div>
        
                <div class="control-group">
                <label class="control-label" >Apellidos</label>
                <div class="controls">
                     <asp:TextBox ID="txtApellidos" runat="server" class="input-lg"  ></asp:TextBox>
                </div>
             </div>
              <div class="control-group">
                <label class="control-label" >Email P</label>
                <div class="controls">
                     <asp:TextBox ID="txtEmailP" runat="server" class="input-lg"  ></asp:TextBox>
                </div>
             </div>
             <div class="control-group">
                <label class="control-label" >Email W</label>
                <div class="controls">
                     <asp:TextBox ID="txtEmailW" runat="server" class="input-lg"  ></asp:TextBox>
                </div>
             </div>
                <div class="control-group">
                <label class="control-label" >Telefono P</label>
                <div class="controls">
                     <asp:TextBox ID="txtTelefonoP" runat="server" class="input-lg"  ></asp:TextBox>
                </div>
             </div>
             <div class="control-group">
                <label class="control-label" >Telefono W</label>
                <div class="controls">
                     <asp:TextBox ID="txtTelefonoW" runat="server" class="input-lg"  ></asp:TextBox>
                </div>
             </div>
            <br />
            <div class="control-group">

                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-group-lg btn-success" OnClick="btnGuardar_Click"/>

             </div>
        </div>
    </div>
    </center>
        </td>
            </tr>
        </table>
       <hr/>
       </center>
</asp:Content>
