<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CollegeEntityWeb._Default" %>

<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Home Page</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">


    <!-- <link href="https://fonts.googleapis.com/css?family=Droid+Sans" rel="stylesheet"> -->
    <!-- Animate.css -->
    <link href="UIFiles/css/animate.css" rel="stylesheet" />
    <!-- Icomoon Icon Fonts-->
    <link rel="stylesheet" href="UIFiles/css/icomoon.css">
    <!-- Themify Icons-->
    <link rel="stylesheet" href="UIFiles/css/themify-icons.css">
    <!-- Bootstrap  -->
    <link rel="stylesheet" href="UIFiles/css/bootstrap.css">
    <!-- Magnific Popup -->
    <link rel="stylesheet" href="UIFiles/css/magnific-popup.css">
    <!-- Owl Carousel  -->
    <link rel="stylesheet" href="UIFiles/css/owl.carousel.min.css">
    <link rel="stylesheet" href="UIFiles/css/owl.theme.default.min.css">
    <!-- Flexslider -->
    <link rel="stylesheet" href="UIFiles/css/flexslider.css">
    <!-- Theme style  -->
    <link rel="stylesheet" href="UIFiles/css/style.css">

    <!-- Modernizr JS -->
    <script src="UIFiles/js/modernizr-2.6.2.min.js"></script>
    <!-- FOR IE9 below -->
    <!--[if lt IE 9]>
    <script src="UIFiles/js/respond.min.js"></script>
    <![endif]-->

</head>
<body>
    <div class="ubea-loader"></div>

    <div id="page">
        <nav class="ubea-nav" role="navigation">
            <div class="ubea-container">
                <div class="row">
                    <div class="col-sm-4 col-xs-12">
                        <div id="ubea-logo"><a href="../Default">Teacher ledger</a></div>
                    </div>
                    <div class="col-xs-8 text-right menu-1">
                        <ul>
                            <li><a href="../Teacher/TeacherDetails">Teacher</a></li>
                            <li><a href="../Department/DepDetails">Department</a></li>
                            <li><a href="../State/StateDetails">State</a></li>
                            <li><a href="../College/CollegeDetails">College</a></li>
                             <li><a href="../CollegeJoining/CJDetails">College Joining</a></li>
                            <li><a href="../Enroll/EnrollDetails"> Enrollment</a></li>
                        </ul>
                    </div>
                </div>

            </div>
        </nav>

        <div id="ubea-hero" class="js-fullheight" data-section="home">
            <div class="flexslider js-fullheight">
                <ul class="slides">
                    <li style="background-image:url(../../UIFiles/images/image1.jpg);">
                        <div class="overlay"></div>
                        <div class="container">
                            <div class="col-md-10 col-md-offset-1 text-center js-fullheight slider-text">
                                <div class="slider-text-inner">
                                    <h2>Teacher Managment.</h2>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li style="background-image: url(../../UIFiles/images/image2.jpg);">
                        <div class="overlay"></div>
                        <div class="container">
                            <div class="col-md-10 col-md-offset-1 text-center js-fullheight slider-text">
                                <div class="slider-text-inner">
                                    <h2>College</h2>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li style="background-image: url(../../UIFiles/images/image3.jpg);">
                        <div class="overlay"></div>
                        <div class="container">
                            <div class="col-md-10 col-md-offset-1 text-center js-fullheight slider-text">
                                <div class="slider-text-inner">
                                    <h2>Ledger Software</h2>
                                </div>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>

        <footer id="ubea-footer" role="contentinfo">
            <div class="ubea-container">

                <div class="row copyright">
                    <div class="col-md-12">
                        <p class="pull-left">
                            <small class="block">&copy; 2019. All Rights Reserved.</small>
                        </p>
                    </div>
                </div>

            </div>
        </footer>
    </div>

    <div class="gototop js-top">
        <a href="#" class="js-gotop"><i class="icon-arrow-up"></i></a>
    </div>

    <!-- jQuery -->
    <script src="UIFiles/js/jquery.min.js"></script>
    <!-- jQuery Easing -->
    <script src="UIFiles/js/jquery.easing.1.3.js"></script>
    <!-- Bootstrap -->
    <script src="UIFiles/js/bootstrap.min.js"></script>
    <!-- Waypoints -->
    <script src="UIFiles/js/jquery.waypoints.min.js"></script>
    <!-- Carousel -->
    <script src="UIFiles/js/owl.carousel.min.js"></script>
    <!-- countTo -->
    <script src="UIFiles/js/jquery.countTo.js"></script>
    <!-- Flexslider -->
    <script src="UIFiles/js/jquery.flexslider-min.js"></script>
    <!-- Magnific Popup -->
    <script src="UIFiles/js/jquery.magnific-popup.min.js"></script>
    <script src="UIFiles/js/magnific-popup-options.js"></script>
    <!-- Main -->
    <script src="UIFiles/js/main.js"></script>

</body>
</html>