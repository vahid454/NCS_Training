<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormsControlls.WebControls"  %>

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
.auto-style2 {  
     width: 278px;  
       }  
.auto-style3 {  
      width: 278px;  
      height: 23px;  
        }  
.auto-style4 {  
      height: 23px;  
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
<p>You first need to register yourself for getting the services.</p>

</div>

</div>


<form id="form1" runat="server">  
<div style="margin-left:25%"> 
    <h3 class="auto-style5" >Registration</h3>
  <table class="auto-style1">  
    <tr>  
        <td>Name</td>  
    <td>  
    <asp:TextBox ID="username" runat="server" required="true"></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="username" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is required!" ForeColor="Red"></asp:RequiredFieldValidator>
     &nbsp;</td>  
    </tr>  

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
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label></td>  
    <td>  
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label></td>  
    <td>  
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />  
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" /></td>  
    </tr>  
    <tr>  
    <td>  
        City</td>  
    <td>  
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="132px"> 
            <asp:ListItem Value="01">Sarangpur</asp:ListItem>
            <asp:ListItem Value="02">Ujjain</asp:ListItem> 
            <asp:ListItem Value="03">Indore</asp:ListItem> 
            <asp:ListItem Value="04">Bhopal</asp:ListItem> 
            <asp:ListItem Value="05">Gwalior</asp:ListItem> 
            <asp:ListItem Value="06">Jabalpur</asp:ListItem> 
            </asp:DropDownList></td>  
                </tr>  
      <tr>  
    <td>  
        Phone</td>  
    <td>  
    <asp:TextBox ID="TextBox4" runat="server" TextMode="Phone"></asp:TextBox>
    
          </td>  
    </tr>  
    <tr>  
    <td>  
    </td>  
    <td>  
    <br />  
    <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="Button1_Click"/>  
    </td>  
    </tr>  
      <tr><td>  
    </td> 
          <td><a href="/Login.aspx">Already having an account?</a></td>
          </tr>
    </table>  
    <asp:Label ID="message" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>  
    </div>  
    </form>  
  
</body>  
</html>
