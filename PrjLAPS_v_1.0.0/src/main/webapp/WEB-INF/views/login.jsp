<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
	<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<meta name="description" content="">
<meta name="author" content="Mosaddek">
<meta name="keyword"
	content="FlatLab, Dashboard, Bootstrap, Admin, Template, Theme, Responsive, Fluid, Retina">
<link rel="shortcut icon" href="img/favicon.png">

<title>FlatLab - Flat & Responsive Bootstrap Admin Template</title>

<!-- Bootstrap core CSS -->
<link href="<c:url value="/resources/css/bootstrap.min.css"></c:url>" rel="stylesheet">
<link href="<c:url value="/resources/css/bootstrap-reset.css"></c:url>" rel="stylesheet">
<!--external css-->
<link href="<c:url value="/resources/assets/font-awesome/css/font-awesome.css"></c:url>" rel="stylesheet" />
<!-- Custom styles for this template -->
<link href="<c:url value="/resources/css/style.css"></c:url>" rel="stylesheet">
<link href="<c:url value="/resources/css/style-responsive.css"></c:url>" rel="stylesheet" />

<!-- HTML5 shim and Respond.js IE8 support of HTML5 tooltipss and media queries -->
<!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->
</head>
<body class="login-body">
	<div class="container">
		<form class="form-signin" action="/laps/calendar">
			<h2 class="form-signin-heading">sign in now</h2>
			<div class="login-wrap">
				<input type="text" class="form-control" placeholder="User ID"
					autofocus> <input type="password" class="form-control"
					placeholder="Password"> <label class="checkbox"> <input
					type="checkbox" value="remember-me"> Remember me <span
					class="pull-right"> <a href="#"> Forgot Password?</a></span>
				</label>
				<button class="btn btn-lg btn-login btn-block" type="submit">Sign
					in</button>
			</div>
		</form>
	</div>
</body>
</html>