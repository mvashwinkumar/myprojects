<?xml version="1.0" encoding="UTF-8" ?>

<%@ taglib uri="http://www.opensymphony.com/sitemesh/decorator"
	prefix="decorator"%>
	<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<meta name="description" content="">
<meta name="author" content="Mosaddek">
<meta name="keyword"
	content="FlatLab, Dashboard, Bootstrap, Admin, Template, Theme, Responsive, Fluid, Retina">
<link rel="shortcut icon" href="<c:url value="/resources/img/favicon.png"></c:url>">
<title><decorator:title default="LAPS" /></title>
<c:set var="contextPath" value="${pageContext.request.contextPath}"/>
<decorator:head />
</head>
<body>
	<section id="container" class="">
		<!--header start-->
		<header class="header white-bg">
			<div class="sidebar-toggle-box">
				<div data-original-title="Toggle Navigation" data-placement="right"
					class="icon-reorder tooltips"></div>
			</div>
			<!--logo start-->
			<a href="index.html" class="logo">Flat<span>lab</span></a>
			<!--logo end-->
			<div class="nav notify-row" id="top_menu">
				<!--  notification start -->
				
			</div>
			<div class="top-nav ">
				<ul class="nav pull-right top-menu">
					<!-- user login dropdown start-->
					<li class="dropdown"><a data-toggle="dropdown"
						class="dropdown-toggle" href="#"> <img alt=""
							src="<c:url value="/resources/img/avatar1_small.jpg"></c:url>"><span class="username">Jhon
								Doue</span> <b class="caret"></b>
					</a>
						<ul class="dropdown-menu extended logout">
							<div class="log-arrow-up"></div>
							<li><a href="#"><i class=" icon-suitcase"></i>Profile</a></li>
							<li><a href="#"><i class="icon-cog"></i> Settings</a></li>
							<li><a href="#"><i class="icon-bell-alt"></i>
									Notification</a></li>
							<li><a href="login.html"><i class="icon-key"></i> Log
									Out</a></li>
						</ul></li>
					<!-- user login dropdown end -->
				</ul>
			</div>
		</header>
		<!--header end-->
		<!--sidebar start-->
		<aside>
			<div id="sidebar" class="nav-collapse ">
				<!-- sidebar menu start-->
				<ul class="sidebar-menu" id="nav-accordion">
					<li><a href="${contextPath }/calendar"> <i class="icon-calendar"></i>
							<span>My Calendar</span>
					</a></li>
					<li><a href="${contextPath }/leavelist"> <i
							class="icon-leaf"></i> <span>Leave</span>
					</a></li>
					<li><a href="${contextPath }/showappliedleave"> <i class="icon-legal"></i> <span>Leave
								Approval</span>
					</a></li>
					<li><a href="${contextPath }/holidaylist"> <i class="icon-calendar"></i> <span>
								Holiday </span>
					</a></li>
					<li><a href="${contextPath }/userlist"> <i class="icon-user"></i> <span>
								Users</span>
					</a></li>
				</ul>
				<!-- sidebar menu end-->
			</div>
		</aside>
		<!--sidebar end-->
		<!--main content start-->
		<section id="main-content">
			<section class="wrapper">
				<decorator:body />
			</section>
		</section>
		<!--main content end-->
	</section>

	<script src="<c:url value="/resources/js/advanced-form-components.js"></c:url>"></script>
</body>
</html>