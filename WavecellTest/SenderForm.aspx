<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SenderForm.aspx.cs" Inherits="WavecellTest.SenderForm" %>
<%@ Register Assembly="TimePicker" Namespace="MKB.TimePicker" TagPrefix="cc1" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
     <table style="width:100%">
        <tr>
            <td style="width:50px">Source:</td>
            <td style="width:50px">
                <asp:TextBox ID="txtSource" runat="server" MaxLength="20" onkeypress="return IsAlphaNumeric(event);" ondrop="return false;"
        onpaste="return false;"></asp:TextBox>

                    <script type="text/javascript">
                        var specialKeys = new Array();
                        specialKeys.push(8); //Backspace
                        specialKeys.push(9); //Tab
                        specialKeys.push(46); //Delete
                        specialKeys.push(36); //Home
                        specialKeys.push(35); //End
                        specialKeys.push(37); //Left
                        specialKeys.push(39); //Right
                        function IsAlphaNumeric(e) {
                            var keyCode = e.keyCode == 0 ? e.charCode : e.keyCode;
                            var ret = ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 65 && keyCode <= 90) || (keyCode >= 97 && keyCode <= 122) || (specialKeys.indexOf(e.keyCode) != -1 && e.charCode != e.keyCode));
                            //document.getElementById("error").style.display = ret ? "none" : "inline";
                            return ret;
                        }
                    </script>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtSource" ForeColor="Red"
            ErrorMessage="Source is required."></asp:RequiredFieldValidator>
            </td>
            
        </tr>
        <tr>
            <td style="width:50px">Destination:</td>
            <td style="width:50px">
                <asp:TextBox ID="txtDes" runat="server" onkeyup="integersOnly(this)"></asp:TextBox>

                <script type="text/javascript">
                    function integersOnly(obj) {
                        obj.value = obj.value.replace(/[^0-9-+ ]/g, '');
                        //obj.value = obj.value.replace(/[^0-9-.]/g, '');
                    }
                </script>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtDes" ForeColor="Red"
            ErrorMessage="Destination is required."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width:50px">Body:</td>
            <td>
                <asp:TextBox ID="txtBody" runat="server" Height="186px" maxsize="500"
                    TextMode="MultiLine" Width="175px" MaxLength="2"></asp:TextBox>

                    <script>
                        $("textarea[maxsize]").each(function () {
                            $(this).attr('maxlength', $(this).attr('maxsize'));
                            $(this).removeAttr('maxsize');
                        });
                    </script>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtBody" ForeColor="Red"
            ErrorMessage="Body is required."></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width:50px">Date:</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server" Width="85px"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td style="width:50px">Time:</td>
            <td>
                <%--<asp:TextBox ID="txtTime" runat="server"></asp:TextBox>--%>
                <cc1:TimeSelector ID="TimeSelector1" runat="server" EnableClock="true" DisplaySeconds="false">
                </cc1:TimeSelector>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSend" runat="server" Text="Send Message" 
                    onclick="btnSend_Click" />
            </td>
            
        </tr>
       
    </table>
    
   
</asp:Content>

