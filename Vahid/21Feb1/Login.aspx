<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_21febWeb1.Login"   %>

<!DOCTYPE html>  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<title></title>  
<style type="text/css">  
.auto-style1 {  
     width: 100%;  
      }  
    .auto-style5 {
        width: 112px;
    }
</style>  
</head>  
<body>  

    
<!-- Sidebar -->
<div class="w3-sidebar w3-light-grey w3-bar-block" style="width:15%">
  <h3 class="w3-bar-item">Menu</h3>
  <a href="/WebForm1.aspx" class="w3-bar-item w3-button">Home</a>
  <a href="#" class="w3-bar-item w3-button">Services</a>
  <a href="/AboutUS.aspx" class="w3-bar-item w3-button">About us</a>
</div>

<!-- Page Content -->
<div style="margin-left:15%">

<div class="w3-container w3-teal">
  <h1>Welcome to NCS</h1>
</div>

<img src="images/header-logo.jpg" alt="header" style="width:100%; height:120px"/>

<div class="w3-container">
<h2>Welcome Onboard</h2>

</div>

</div>


<form id="loginForm" runat="server">  
<div style="margin-left:25%"> 
    <h3 class="auto-style5" >Login</h3>
  <table class="auto-style1">  
    <tr>  
    <td>  
    <asp:Label ID="Label6" runat="server" Text="Email ID"></asp:Label>  
  
    </td>  
    <td>  
    <asp:TextBox ID="EmailID" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email is required!" ForeColor="Red" ControlToValidate="EmailID"></asp:RequiredFieldValidator>

    </td>  
    </tr>  
   
    <tr>  
    <td>  
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>  
    <td>  
    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox></td>  
    </tr>  
  
    <tr>  
    <td>  
    </td>  
    <td>  
    <br />  
    <asp:Button ID="loginButton" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="Login_Button_Click" style="height: 26px"/>  
    </td>  
    </tr>  
      
    </table>  

    <asp:Label ID="message" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>  
    </div>  
    </form>  
    
</body>  
</html>
