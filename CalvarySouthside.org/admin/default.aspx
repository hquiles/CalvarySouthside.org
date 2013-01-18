<%@ Page Title="" Language="C#" 
    AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="admin_default" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Sign In</title>

    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link rel="stylesheet" href="/assets/css/bootstrap.min.css">

    <style type="text/css">
        body
        {
            padding-top: 40px;
            padding-bottom: 40px;
            background-color: #f5f5f5;
        }
        
        .form-signin
        {
            max-width: 300px;
            padding: 19px 29px 29px;
            margin: 0 auto 20px;
            background-color: #fff;
            border: 1px solid #e5e5e5;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            -webkit-box-shadow: 0 1px 2px rgba(0,0,0,.05);
            -moz-box-shadow: 0 1px 2px rgba(0,0,0,.05);
            box-shadow: 0 1px 2px rgba(0,0,0,.05);
        }
        .form-signin .form-signin-heading, .form-signin .checkbox
        {
            margin-bottom: 10px;
        }
        .form-signin input[type="text"], .form-signin input[type="password"]
        {
            font-size: 16px;
            height: auto;
            margin-bottom: 15px;
            padding: 7px 9px;
        }
    </style>

    <!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">

    <div class="container">
        <div class="form-signin">
        <h2 class="form-signin-heading">Please sign in</h2>

        <input type="text" class="input-block-level" placeholder="Email address">
        <input type="password" class="input-block-level" placeholder="Password">

        <button class="btn btn-large btn-primary" type="submit">
            Sign in</button>
        </div>
    </div>
    <!-- /container -->

    </form>

    <script src="/assets/js/libs/jquery-1.9.0.min.js"></script>
    <script src="/assets/js/libs/bootstrap.min.js"></script>
</body>
</html>
