<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Voting.aspx.cs" Inherits="_21feb2.Voting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Electronic Voting Machine</h2>
            <h3>Vote Below </h3>
            <select>
            <option>AI</option>
                <option>ML</option>
                <option>IOT</option>

            </select><br><br>
              <asp:Button ID="vote_button" runat="server" CssClass="auto-style1" Text="Vote" onclick="getVote" Height="33px" Width="110px"/>
                  <asp:Label id="vote_res" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
