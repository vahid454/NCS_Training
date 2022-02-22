<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUS.aspx.cs" Inherits="_21febWeb1.AboutUS" %>





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

    
    <form id="form1" runat="server">

    
<!-- Sidebar -->
<div class="w3-sidebar w3-light-grey w3-bar-block" style="width:15%">
  <h3 class="w3-bar-item">Menu</h3>
  <a href="/WebForm1.aspx" class="w3-bar-item w3-button">Home</a>
  <a href="#" id="check_service" onclick="CheckService" class="w3-bar-item w3-button">Services</a>
  <a href="/AboutUS.aspx" class="w3-bar-item w3-button">About us</a>
</div>

<!-- Page Content -->
<div style="margin-left:15%">

<div class="w3-container w3-teal">
 <span> <h1>Welcome to NCS</h1> 
     <asp:Label style="margin-left:80%; margin-top:1%" ID="name" runat="server" Font-Size="Large" ForeColor="cyan"></asp:Label>
     </span>
</div>

<img src="images/header-logo.jpg" alt="header" style="width:100%; height:120px"/>

<div class="w3-container">
<h2>Welcome Onboard</h2>
   <h3>About US </h3><br>
    <h4>We work on these technologies</h4>
   <ul>
        <li><h5>SAP Portals</h5> </li>
        <li><h5>Artificial Intelligence</h5> </li>
        <li><h5>Machine Learning</h5> </li>
        <li><h5>Internet of Things</h5> </li>
    </ul>
    <br>
    <h4>Our motive is to deliver the industry best</h4>
    <br>
    <p>NCSI Technologies India</p>
    <p>Address - 1, Hinjewadi Pune</p>
</div>

</div>


 
    
    </form>


 
    
</body>  
</html>
