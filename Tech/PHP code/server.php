<?php
$dbusername = "proftaak";
$dbpassword = "04juLi20003!";
$server = "https://192.168.160.210/phpmyadmin";

$dbconnect = mysqli_connect($server, $dbusername, $dbpassword);
$dbselect = mysqli_select_db("Test", $dbconnect);

$sql = ....;

mysqli_query($sql);
    // Prepare variables for database connection
// enter database username, I used "arduino" in step 2.2
// IMPORTANT: if you are using XAMPP enter "localhost", but if you have an online website enter its address, ie."www.yourwebsite.com"

// Connect to your database



 // Prepare the SQL statement
?>
