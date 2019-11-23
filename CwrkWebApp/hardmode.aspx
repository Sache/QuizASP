<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hardmode.aspx.cs" Inherits="CwrkWebApp.hardmode"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="loggedAs" runat="server" OnClick="loggedAs_Click" Text="LOGOUT:" />


    <br />
    <br />
    <asp:Label ID="q1" runat="server" Text="Question 1:" BorderStyle="Solid" BorderWidth="1px"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ans1" DataValueField="ans1">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans1] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q2" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 2:"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="ans2" DataValueField="ans2">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans2] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q3" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 3:"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="ans3" DataValueField="ans3">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans3] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q4" runat="server" BorderStyle="Inset" BorderWidth="1px" Text="Question 4:"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="ans4" DataValueField="ans4">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans4] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q5" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 5:"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList5" runat="server" DataSourceID="SqlDataSource5" DataTextField="ans5" DataValueField="ans5">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans5] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q6" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 6:"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList6" runat="server" DataSourceID="SqlDataSource6" DataTextField="ans6" DataValueField="ans6">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans6] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q7" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 7:"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList7" runat="server" DataSourceID="SqlDataSource7" DataTextField="ans7" DataValueField="ans7">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans7] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q8" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 8:"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList8" runat="server" DataSourceID="SqlDataSource8" DataTextField="ans8" DataValueField="ans8">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans8] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q9" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 9:"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList9" runat="server" DataSourceID="SqlDataSource9" DataTextField="ans9" DataValueField="ans9">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4 [ans9] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="q10" runat="server" BorderStyle="Solid" BorderWidth="1px" Text="Question 10:"></asp:Label>
    <br />
    <asp:RadioButtonList ID="RadioButtonList10" runat="server" DataSourceID="SqlDataSource10" DataTextField="ans10" DataValueField="ans10">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:projectDBConnectionString %>" ProviderName="<%$ ConnectionStrings:projectDBConnectionString.ProviderName %>" SelectCommand="SELECT TOP 4  [ans10] FROM [age14plus]"></asp:SqlDataSource>
    <br />
    <asp:Button ID="sbmtbtn" runat="server" Height="49px" OnClick="sbmtbtn_Click" Text="Submit" Width="121px" BorderColor="#339966" />
    <br />
    <br />
    <asp:Label ID="score1" runat="server" Font-Bold="True"></asp:Label>
    <br />



</asp:Content>