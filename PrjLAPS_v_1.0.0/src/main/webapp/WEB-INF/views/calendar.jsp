<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
	<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<meta name="description" content="">
<meta name="author" content="Mosaddek">
<meta name="keyword"
	content="FlatLab, Dashboard, Bootstrap, Admin, Template, Theme, Responsive, Fluid, Retina">
<link rel="shortcut icon" href="img/favicon.png">

<title>Calendar</title>

<!-- Bootstrap core CSS -->
<link href="<c:url value="/resources/css/bootstrap.min.css"></c:url>" rel="stylesheet">
<link href="<c:url value="/resources/css/bootstrap-reset.css"></c:url>" rel="stylesheet">
<!--external css-->
<link href="<c:url value="/resources/assets/font-awesome/css/font-awesome.css"></c:url>" rel="stylesheet" />
<link href="<c:url value="/resources/assets/fullcalendar/fullcalendar/bootstrap-fullcalendar.css"></c:url>"
	rel="stylesheet" />
<!-- Custom styles for this template -->
<link href="<c:url value="/resources/css/style.css"></c:url>" rel="stylesheet">
<link href="<c:url value="/resources/css/style-responsive.css"></c:url>" rel="stylesheet" />

<!-- HTML5 shim and Respond.js IE8 support of HTML5 tooltipss and media queries -->
<!--[if lt IE 9]>
      <script src="<c:url value="/resources/js/html5shiv.js"></c:url>"></script>
      <script src="<c:url value="/resources/js/respond.min.js"></c:url>"></script>
    <![endif]-->

</head>
<body>
 <!-- page start-->
	<div class="row">
		<aside class="col-lg-9"> <section class="panel">
		<div class="panel-body">
			<div id="calendar" class="has-toolbar"></div>
		</div>
		</section> </aside>
	</div>
			
	<<!-- js placed at the end of the document so the pages load faster -->
	<script src="<c:url value="/resources/js/jquery.js"></c:url>"></script>
	<script type="text/javascript" src="<c:url value="/resources/js/jquery-ui-1.9.2.custom.min.js"></c:url>"></script>
	<script src="<c:url value="/resources/assets/fullcalendar/fullcalendar/fullcalendar.min.js"></c:url>"></script>
	<script src="<c:url value="/resources/js/bootstrap.min.js"></c:url>"></script>
	<script class="include" type="text/javascript"
		src="<c:url value="/resources/js/jquery.dcjqaccordion.2.7.js"></c:url>"></script>
	<script src="<c:url value="/resources/js/jquery.scrollTo.min.js"></c:url>"></script>
	<script src="<c:url value="/resources/js/jquery.nicescroll.js"></c:url>" type="text/javascript"></script>
	<script src="<c:url value="/resources/js/respond.min.js"></c:url>"></script>

	<!--common script for all pages-->
	<script src="<c:url value="/resources/js/common-scripts.js"></c:url>"></script>

	<!--script for this page only-->
	<script src="<c:url value="/resources/js/external-dragging-calendar.js"></c:url>"></script>
		div class="panel-body">
			<div id="calendar" class="has-toolbar"></div>
		</div>
		</section> </aside>
	</div>
	<!-- page end--> </section> </section> <!--main content end--> </section>

</body>
</html>