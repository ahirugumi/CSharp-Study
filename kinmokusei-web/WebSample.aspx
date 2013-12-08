<%@ Page Language="C#" Inherits="kinmokuseiweb.WebSample" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>WebSample</title>
</head>
<body>
	<form id="form1" runat="server">
	 	<asp:TextBox id="textbox" Text="TextBox" runat="server" />
    	<asp:Button Text="OK" runat="server" OnClick="submit_click"/>
    	<br/>
    	<br/>
		<asp:Label id="label" Text="テスト出力" runat="server" />
    </form>
</body>
</html>
