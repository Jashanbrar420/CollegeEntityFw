﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CollegeEdit.aspx.cs" Inherits="College_CollegeEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>College Edition</title>
    <link href="../UIFiles/css/styles.css" rel="stylesheet" />
    <script src="../UIFiles/js/jquery-1.4.2.min.js"></script>
    <link href="../UIFiles/alertmsg/jquery.alerts.css" rel="stylesheet" />
    <script src="../UIFiles/alertmsg/jquery.alerts.js"></script>

    <script type="text/javascript">
        function numbersonly(e, decimal) {

            var key;
            var keychar;
            if (window.event) {
                key = window.event.keyCode;
            }
            else if (e) {
                key = e.which;
            }
            else {
                return true;
            }
            keychar = String.fromCharCode(key);
            if ((key == null) || (key == 0) || (key == 8) || (key == 9) || (key == 13) || (key == 27)) {
                return true;
            }
            else if ((("0123456789").indexOf(keychar) > -1)) {
                return true;
            }
            else if (decimal && (keychar == ".")) {
                return true;
            }
            else
                return false;
        }

        function checkfield() {
            

            var txtCollName = $('#<%=txtCollName.ClientID%>').val();
            if (txtCollName == "") {
                jAlert('Kindly Enter Address1', 'Alert Dialog');
                $('#<%=txtCollName.ClientID%>').focus();
                return false;
            }

         

            
       

             var ddlstate = $('#<%=ddlstate.ClientID %> option:selected').val();
            if (ddlstate == "" || ddlstate == "0") {
                jAlert('Kindly Select State.', 'Alert Dialog');
                $('#<%=ddlstate.ClientID%>').focus();
                return false;
            }

            var txtDetails = $('#<%=txtDetails.ClientID%>').val();
            if (txtDetails == "") {
                jAlert('Kindly Enter Pincode', 'Alert Dialog');
                $('#<%=txtDetails.ClientID%>').focus();
                return false;
            }

        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="border-collapse: collapse; border-width: 0" width="100%" border="0"
        cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <br />
                <table width="100%" cellpadding="0" cellspacing="0">
                    <tr>
                        <td style="width: 60%; padding-left: 20px;" class="Page_Header"><b>Collage Edition</b> </td>
                    </tr>
                </table>
                <table style="border-collapse: collapse; border-width: 0" width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="center">
                            <br />
                            <table border='0' cellpadding="4" width="90%">
                                <tr>
                                    <td class="Display_Caption" align="left">Collage Name</td>
                                    <td align="left">
                                        <asp:TextBox ID="txtCollName" runat="server" CssClass="textbox" Width="135px" ></asp:TextBox>
                                    </td>
                                    <td class="Display_Caption" align="left">State</td>
                                    <td align="left">
                                         <asp:DropDownList ID="ddlstate" runat="server" CssClass="ddl_style" Width="135px">
                                         </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    
                                    <td class="Display_Caption" align="left">Collage Details</td>
                                    <td align="left">
                                        <asp:TextBox ID="txtDetails" runat="server" CssClass="textbox" TextMode="MultiLine" Width="135px" ></asp:TextBox>
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="6" align="center">
                                        <asp:Button ID="btnUpdate" runat="server" CssClass="button-new"
                                            Text="Update Collage" OnClientClick="return checkfield();" OnClick="btnUpdate_Click" ></asp:Button>&nbsp;
                                       &nbsp;&nbsp; <asp:Button ID="btnbak" runat="server" Text="Back" CssClass="button-new" OnClick="btnbak_Click"/><br />
                                        <asp:Label ID="lblErrMsg1" runat="server" Text="" ForeColor="red" Font-Bold="true"
                                            Visible="false"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>


