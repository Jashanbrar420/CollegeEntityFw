﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CJDetails.aspx.cs" Inherits="CollegeJoining_CJDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Teacher Joinning Details</title>

    <link href="../UIFiles/css/styles.css" rel="stylesheet" />
    <script src="../UIFiles/js/jquery-1.4.2.min.js"></script>
    <link href="../UIFiles/alertmsg/jquery.alerts.css" rel="stylesheet" />
    <script src="../UIFiles/alertmsg/jquery.alerts.js"></script>

    <style type="text/css">
        .Grid {
            background-color: #fff;
            margin: 5px 0 10px 0;
            border: solid 1px #525252;
            border-collapse: collapse;
            font-family: Calibri;
            color: #474747;
            font-size: 1.0em;
        }

            .Grid td {
                /*padding: 2px;*/
                border: solid 1px #c1c1c1;
            }

            .Grid th {
                /*padding: 4px 2px;#3177C4*/
                color: #fff;
                background: #3177C4 url(../UIFiles/images/grd_header.png) repeat-x top;
                border-left: solid 1px #525252;
                font-size: 1.1em;
                height: 38px;
            }

            .Grid .alt {
                background: #fcfcfc url(../UIFiles/images/grid-alt.png) repeat-x top;
            }

            .Grid .pgr {
                background: #3177C4 url(../UIFiles/images/grd_footer.png) repeat-x top;
            }

                .Grid .pgr table {
                    margin: 3px 0;
                }

                .Grid .pgr td {
                    border-width: 0;
                    padding: 0 6px;
                    border-left: solid 1px #666;
                    font-weight: bold;
                    color: #fff;
                    line-height: 12px;
                }

                .Grid .pgr a {
                    color: Gray;
                    text-decoration: none;
                }

                    .Grid .pgr a:hover {
                        color: #000;
                        text-decoration: none;
                    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" align="left" style="vertical-align: top;"
        width="100%">
        <tr>
            <td colspan="6" style="padding-right: 10px; width: 944px;" class="Page_Header" align="left">Teacher Joining Data&nbsp;
                <asp:Button ID="btnCreateTeacherAdd" runat="server" Text="New Joinning"
                    CssClass="button-new" ValidationGroup="a" OnClick="btnCreateAdd_Click"  />
            </td>
        </tr>
        <tr>
            <td colspan="6" align="center" height="10px" style="width: 944px">
                <asp:Label ID="lblErr" runat="server" Font-Bold="True" Font-Size="14px" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6" align="left" style="height: 10px;">
                <asp:GridView Width="100%" ID="grdTeacherInfo" runat="server" AutoGenerateColumns="False"
                    CssClass="Grid" AlternatingRowStyle-CssClass="alt"
                    PagerStyle-CssClass="pgr" CellPadding="3" BorderWidth="2px"
                    HorizontalAlign="Center">
                    <Columns>
                        <asp:BoundField HeaderText="Joining ID" DataField="ID">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Collage Name" DataField="CollegeMst.CollegeName">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="10%" />
                        </asp:BoundField>
                          <asp:BoundField HeaderText="Collage Details" DataField="CollegeMst.CollegeDesc">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="5%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Teacher FirstName" DataField="TeacherMst.FirstName">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Teacher MiddletName" DataField="TeacherMst.MiddleName">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="10%" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Teacher LastName" DataField="TeacherMst.LastName">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="10%" />
                        </asp:BoundField>
                         <asp:BoundField HeaderText="Teacher Code" DataField="TeacherMst.Emp_Code">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="10%" />
                        </asp:BoundField>
                      
                        <asp:TemplateField HeaderText="View">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton4" BorderWidth="0" runat="server" ImageUrl="~/UIFiles/images/delete.png" ToolTip="Delete"
                                    Height="30" Text="Delete" OnClick="makelink_delete" CommandArgument='<%# Eval("ID").ToString()%>' />
                                  <asp:ImageButton ID="ImgEdit" BorderWidth="0" runat="server" ImageUrl="~/UIFiles/images/edit.png" ToolTip="Edit"
                                      Height="30" Text="Delete" OnClick="makelink_edit" CommandArgument='<%# Eval("ID").ToString()%>' />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Height="14px" VerticalAlign="Top" Width="10%" />
                        </asp:TemplateField>

                    </Columns>
                    <HeaderStyle HorizontalAlign="Left" />
                    <EmptyDataTemplate>
                        <asp:Label Text=" No record Found." runat="server" ID="lbl" ForeColor="Black"></asp:Label>
                    </EmptyDataTemplate>
                    <EmptyDataRowStyle HorizontalAlign="Center" Width="25%" />
                    <FooterStyle Font-Size="8pt" Height="20px" Font-Names="Verdana" Wrap="True" />
                    <RowStyle />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>




