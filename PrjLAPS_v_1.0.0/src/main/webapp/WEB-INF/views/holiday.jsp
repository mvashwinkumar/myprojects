<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
	<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Holiday Form</title>
<link href="<c:url value="/resources/css/laps.css"></c:url>" rel="stylesheet" />
<!-- Bootstrap core CSS -->
<link href="<c:url value="/resources/css/bootstrap.min.css"></c:url>" rel="stylesheet">
<link href="<c:url value="/resources/css/bootstrap-reset.css"></c:url>" rel="stylesheet">
<!-- external css-->
<link href="<c:url value="/resources/assets/font-awesome/css/font-awesome.css"></c:url>" rel="stylesheet" />

<link rel="stylesheet" type="text/css"
	href="<c:url value="/resources/assets/bootstrap-datepicker/css/datepicker.css"></c:url>" />
<link rel="stylesheet" type="text/css"
	href="<c:url value="/resources/assets/bootstrap-colorpicker/css/colorpicker.css"></c:url>" />
<link rel="stylesheet" type="text/css"
	href="<c:url value="/resources/assets/bootstrap-daterangepicker/daterangepicker.css"></c:url>" />

<!-- Custom styles for this template -->
<link href="<c:url value="/resources/css/style.css"></c:url>" rel="stylesheet">
<link href="<c:url value="/resources/css/style-responsive.css"></c:url>" rel="stylesheet" />
</head>
<body>
	<div class="row">
		<div class="col-lg-12">
			<section class="panel"> <header class="panel-heading">
			Holiday Form </header>
			<div class="panel-body">
				<form class="form-horizontal" role="form">
					<div class="form-group">
						<label class="col-lg-2 col-sm-2 ">Holiday
							Date</label>
						<div class="col-lg-3">
							<input
								class="form-control form-control-inline input-medium default-date-picker"
								style="width: 100px;" size="16" type="text" value="" required>
						</div>
					</div>
					<div class="form-group">
						<label class="col-lg-2 col-sm-2 ">Description</label>
						<div class="col-lg-3">
							<input type="email" class="form-control" id="inputEmail1"
								placeholder="Description" required>
						</div>
					</div>
					<div class="form-group">
						<div class="col-lg-offset-2 col-lg-10">
							<button type="submit" class="btn btn-primary">Save</button>
						</div>
					</div>
				</form>
			</div>
			</section>
		</div>
	</div>
	<script src="<c:url value="/resources/js/jquery.js"></c:url>"></script>
	<script src="<c:url value="/resources/js/bootstrap.min.js"></c:url>"></script>
	<script src="<c:url value="/resources/js/jquery.scrollTo.min.js"></c:url>"></script>
	<script src="<c:url value="/resources/js/jquery.nicescroll.js"></c:url>" type="text/javascript"></script>

	<script src="<c:url value="/resources/js/jquery-ui-1.9.2.custom.min.js"></c:url>"></script>
	<script class="include" type="text/javascript"
		src="<c:url value="/resources/js/jquery.dcjqaccordion.2.7.js"></c:url>"></script>
	<!--common script for all pages-->
	<script src="<c:url value="/resources/js/common-scripts.js"></c:url>"></script>

	<script type="text/javascript"
		src="<c:url value="/resources/assets/bootstrap-datepicker/js/bootstrap-datepicker.js"></c:url>"></script>
	<script type="text/javascript"
		src="<c:url value="/resources/assets/bootstrap-datetimepicker/js/bootstrap-datetimepicker.js"></c:url>"></script>
	<script type="text/javascript"
		src="<c:url value="/resources/assets/bootstrap-daterangepicker/moment.min.js"></c:url>"></script>
	<script type="text/javascript"
		src="<c:url value="/resources/assets/bootstrap-daterangepicker/daterangepicker.js"></c:url>"></script>
	<script type="text/javascript"
		src="<c:url value="/resources/assets/bootstrap-timepicker/js/bootstrap-timepicker.js"></c:url>"></script>
</body>
</html>