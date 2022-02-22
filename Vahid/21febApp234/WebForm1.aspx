<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_21feb2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body align="center" style="background-color:azure">
  <form id="forms" runat="server">
    <div>


        <div>
            <h2>ASP.NET Assignments</h2>
        </div>
        
    <div id="secondQuestion">

        <table align="center" border="2px">
            <tr><td colspan="2"><h5>Time & Age</h5></td> </tr>
            <tr>
                <td>
                 <asp:Label  runat="server"> Current Date & Time : </asp:Label>
                   </td><td>
                            
              <asp:Label ID="resCurrentTime" runat="server" Font-Size="Large"></asp:Label></td>

                </tr>
            <tr>
             
                <td colspan="2">
                 <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px" OnSelectionChanged="Calendar1_SelectionChanged1">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                        <DayStyle BackColor="#CCCCCC" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    </asp:Calendar>

                    </td>
                </tr>
            <tr>
                <td colspan="1">
                     <asp:Label runat="server"> Age : </asp:Label>
                    </td>
                <td colspan="1"> 
                    <asp:Label id="Age1" runat="server" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Current Date & Time" Width="135px" />
                             
                             </td>
               </tr>

            </table>

    </div>
        <br><br><br>
         <div id="secondQuestionPart2">

        <table align="center" border="2px">
            <tr><td colspan="2"><h5>Gross Salary</h5></td> </tr>
               
            <tr><td>
          <asp:Label  runat="server">Basic Salary : </asp:Label>
                  </td><td>
              <asp:TextBox ID="basic" runat="server" TextMode="number"></asp:TextBox></td></tr>
              <tr><td>
          <asp:Label  runat="server">Travel Allowance : </asp:Label>
                  </td><td>
              <asp:TextBox ID="travel" runat="server" TextMode="number"></asp:TextBox></td></tr>
              <tr><td>
          <asp:Label  runat="server">Dear Allowance : </asp:Label>
                  </td><td>
              <asp:TextBox ID="dear" runat="server" TextMode="number"></asp:TextBox></td></tr>
              <tr><td>
          <asp:Label  runat="server">Professional Tax : </asp:Label>
                  </td><td>
              <asp:TextBox ID="professional" runat="server" TextMode="number"></asp:TextBox></td></tr>


            <tr>
                <td colspan="1">
                     <asp:Label runat="server"> Gross Monthly Salary : </asp:Label>
                    </td>
                <td colspan="1"> 
                    <asp:Label id="grossSalary" runat="server" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                          
                    <asp:Button ID="getSalary" runat="server" Text="Calculate Salary" Width="114px" OnClick="getSalary_Click" />
                          
                    </td>
               </tr>

            </table>

    </div>
        <br><br><br>
    <div id="thirdQuestion">
     
        <table align="center" border="2px">
            <tr>
                <td colspan="2">
                    <h4>Electronic Voting Machine</h4>
                    </td>
            </tr>
            <br>
            <tr><br><td>
        <asp:Label  runat="server">Enter Your Age : </asp:Label>
         </td><td>
             
                 
              <asp:TextBox ID="voter_age" runat="server" TextMode="number"></asp:TextBox></td></tr>
          

                <tr>
                      <td colspan="2">
                      <asp:Button ID="vote_button" runat="server" CssClass="auto-style1" Text="Vote Me" onclick="getVote" Height="33px" Width="110px"/>
                    </td>
                </tr>
                 <tr>
                <td>
                     <asp:Label runat="server"> Result : </asp:Label>
                    </td>
                    <td>
                        <asp:Label id="voter_res" Display="Dynamic" runat="server" Font-Size="Large"></asp:Label>
                    </td>
                    </tr>
                </table>
            

        
    </div>
    <div id="fourthQuestion">
 
        <table align="center" border="2px">
            <tr>
                <td colspan="2">
                    <h4>Addition of two Numbers</h4>
                    </td>
            </tr>
            <br>
            <tr><br><td>
        <asp:Label  runat="server">Enter First Number : </asp:Label>
         </td><td>
             
                 
              <asp:TextBox ID="num1" runat="server" TextMode="number"></asp:TextBox></td></tr>
             <tr><td>
        <asp:Label runat="server">Enter Second Number : </asp:Label>
         </td><td>
             
                    <asp:TextBox ID="num2" runat="server"></asp:TextBox> </td></tr>

            <tr>
                <td colspan="2">
                      <asp:Button ID="SumButton" runat="server" CssClass="auto-style1" Text="Add" onclick="getSum" Height="33px" Width="110px"/>
                    </td>
                </tr>
            <tr>
                <td>
                     <asp:Label runat="server"> Result : </asp:Label>
                    </td>
                <td>
                    <asp:Label id="sum" runat="server" Font-Size="Large"></asp:Label>
                </td>
            </tr>
                </table>
      
    </div> <!-- 4th ques end -->
  
 




    </div>

            </form>





    
</body>
</html>
