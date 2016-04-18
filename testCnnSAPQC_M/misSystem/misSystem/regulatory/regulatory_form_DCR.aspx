<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regulatory_form_DCR.aspx.cs" Inherits="misSystem.regulatory.regulatory_form_DCR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../CssFile/Regu_Form_dcr.css" rel="stylesheet" />
    <title>DCR Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="dcr_middle">
            <div id="dcrFormTittle">文件更改申請單 (DCR Form) </div>
            <br />
            <br />
            <div id="fillTextID">
                Change Proposed by (申請人)：<asp:Label ID="lbl_proposedPerson" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Change Proposed Date (申請日期)：<asp:Label ID="lbl_proposedDate" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                Production Product (產品)： Model (型號)&nbsp;<asp:DropDownList ID="drop_product" runat="server" DataTextField="description" DataValueField="id"></asp:DropDownList>
                <br />
                <br />
                R&D Project (專案項目)：Name (名稱)&nbsp;<asp:TextBox ID="tb_projectName" runat="server"></asp:TextBox>
                <br />
                <br />
                Priority (優先)：&nbsp;<asp:DropDownList ID="drop_priority" runat="server" DataTextField="description" DataValueField="code"></asp:DropDownList>
                <br />
                <br />
                <table border="1">
                    <tr>
                        <td>零件/文件編號</td>
                        <td style="width:50px">新版次</td>
                        <td>文件名稱</td>
                        <td>修改原因</td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="tb_docNum_1" runat="server"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_newVersion_1" runat="server" onkeyup="this.value=this.value.replace(/[^0-9]/g,'')" Width="50px"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_docName_1" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:DropDownList ID="drop_changeReason_1" runat="server" AutoPostBack="true" 
                                OnSelectedIndexChanged="drop_changeReason_1_SelectedIndexChanged" 
                                DataValueField="No" DataTextField="NoDescription" OnInit="drop_changeReason_1_Init" 
                                AppendDataBoundItems ="true"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                            <asp:TextBox ID="tb_other_1" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="tb_docNum_2" runat="server"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_newVersion_2" runat="server" onkeyup="this.value=this.value.replace(/[^0-9]/g,'')" Width="50px"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_docName_2" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:DropDownList ID="drop_changeReason_2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drop_changeReason_2_SelectedIndexChanged" DataValueField="No" DataTextField="NoDescription" AppendDataBoundItems ="true"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                            <asp:TextBox ID="tb_other_2" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="tb_docNum_3" runat="server"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_newVersion_3" runat="server" onkeyup="this.value=this.value.replace(/[^0-9]/g,'')" Width="50px"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_docName_3" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:DropDownList ID="drop_changeReason_3" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="drop_changeReason_3_SelectedIndexChanged" DataValueField="No" DataTextField="NoDescription" AppendDataBoundItems ="true"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                            <asp:TextBox ID="tb_other_3" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="tb_docNum_4" runat="server"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_newVersion_4" runat="server" onkeyup="this.value=this.value.replace(/[^0-9]/g,'')" Width="50px"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_docName_4" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:DropDownList ID="drop_changeReason_4" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="drop_changeReason_4_SelectedIndexChanged" DataValueField="No" DataTextField="NoDescription" AppendDataBoundItems ="true"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                            <asp:TextBox ID="tb_other_4" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="tb_docNum_5" runat="server"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_newVersion_5" runat="server" onkeyup="this.value=this.value.replace(/[^0-9]/g,'')" Width="50px"></asp:TextBox></td>
                        <td><asp:TextBox ID="tb_docName_5" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:DropDownList ID="drop_changeReason_5" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="drop_changeReason_5_SelectedIndexChanged" DataValueField="No" DataTextField="NoDescription" AppendDataBoundItems ="true"><asp:ListItem Value="0">請選擇</asp:ListItem></asp:DropDownList>
                            <asp:TextBox ID="tb_other_5" runat="server" Visible="false"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                更改涉及文件：
                <br /><asp:CheckBox ID="CheckBox_affectDoc_1" runat="server" Text="QM"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_2" runat="server" Text="QP"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_3" runat="server" Text="QF"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_4" runat="server" Text="程序"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_5" runat="server" Text="說明書"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_6" runat="server" Text="撥料單"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_7" runat="server" Text="手冊"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_8" runat="server" Text="圖紙"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_9" runat="server" Text="BOM"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_10" runat="server" Text="MCR"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_11" runat="server" Text="軟件"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_12" runat="server" Text="標籤"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_13" runat="server" Text="工具設備"/>
                <br /><asp:CheckBox ID="CheckBox_affectDoc_14" runat="server" Text="其他"/>
                <br /><br /><br />

                <asp:Button ID="btn_DCR_submint" runat="server" Text="送出" OnClick="btn_DCR_submint_Click" />
            </div>
        </div>
    </form>
</body>
</html>
