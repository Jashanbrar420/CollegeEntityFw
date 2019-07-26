<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Teacherview.aspx.cs" Inherits="Teacher_Teacherview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Teacher Profile</title>

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Profile</h2>

    <div>
        <hr />
        <div class="container">
            <div class="row">
                <div class="col-md-2">
                  <asp:Image ID="empImg" runat="server" style='max-width: 150px; max-height: 150px;' />
                </div>
                <div class="col-md-3">
                    <h3><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></h3><br/>
                <i class="icon-mail">&nbsp;</i> Email : <asp:Label ID="lblemail" runat="server" Text="EmailSample@gmail.com"></asp:Label><br/>
                <i class="icon-phone">&nbsp;</i> Mobile No. :<asp:Label ID="lblMobile" runat="server" Text="999999999"></asp:Label>
                </div>
            </div>
            <div class="order-1">&nbsp;</div>
            <div class="row">
                <div class="col-md-3">DateOfBirth -  <asp:Label ID="lblDOB" runat="server" Text="10-Jan-1991"></asp:Label></div>
                <div class="col-md-3">JoiningDate -  <asp:Label ID="lblJoinDate" runat="server" Text="11-Apr-2018"></asp:Label></div>
                <div class="col-md-2">Gender -  <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label></div>
            </div>
            <div class="order-1">&nbsp;</div>
            <asp:Button ID="Button1" runat="server" CssClass="button-new" Text="Back" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>