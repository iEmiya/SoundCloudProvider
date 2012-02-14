<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="callback.aspx.cs" Inherits="SoundCloudTests.callback" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
    .error{ color: red;font-size: 14px;}
    .token{ color: green;font-size: 14px;}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="error">
		<asp:Label Text="[error]" ID="errorLabel" runat="server" />
	</div>
    <div class="error">
		<asp:Label Text="[error_description]" ID="error_descriptionLabel" runat="server" />
	</div>
    <div class="token">
		<asp:Label Text="[token]" ID="tokenLabel" runat="server" />
	</div>
    </form>
</body>
</html>
