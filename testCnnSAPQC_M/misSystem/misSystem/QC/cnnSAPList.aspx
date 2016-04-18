<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="cnnSAPList.aspx.cs" Inherits="misSystem.QC.cnnSAPList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Lp600_Tm5_gradient40px">待檢驗List</div>
    <div class="Lp300-Tm350" style="font-size: 16px; font-family: Georgia;">
        <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="DocEntry" HeaderText="內部號碼" />
                <asp:BoundField DataField="DocNum" HeaderText="文件號碼" />
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" DataFormatString="{0:0.##}" ItemStyle-Width="50px">
                    <ItemStyle Width="50px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Dscription" HeaderText="Dscription" ItemStyle-Width="400px">
                    <ItemStyle Width="400px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="CardName" HeaderText="CardName" ItemStyle-Width="280px">
                    <ItemStyle Width="280px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="DocDate" HeaderText="DocDate" DataFormatString="{0:yyyy/MM/dd}" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>--%>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <%--<asp:BoundField DataField="DocEntry" HeaderText="內部號碼" />--%>
                <asp:BoundField DataField="DocNum" HeaderText="文件號碼" />
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" DataFormatString="{0:0.##}" ItemStyle-Width="50px">
                    <ItemStyle Width="50px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Dscription" HeaderText="Dscription" ItemStyle-Width="400px">
                    <ItemStyle Width="400px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Processer" HeaderText="Processer" ItemStyle-Width="280px">
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="DocDate" HeaderText="DocDate"/>
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
    </div>
</asp:Content>
