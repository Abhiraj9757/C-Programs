  <%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication23._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <style>
          table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
          </style>
    <div class="jumbotron">
       
       <p>Scrap your Data No need to copy paste an individual Line Everytime.</p>
            <asp:Button  Style="background-color: #eeeeee" ID="Button1" runat="server" OnClick="Button1_Click" Text="Search Using your Web Link" />

        <asp:Button Style="background-color: #eeeeee" ID="Button2" runat="server"  OnClick="Button2_Click" Text="Save Data for youself to work more on.... " />
        </div>      
    
  
</asp:Content>
