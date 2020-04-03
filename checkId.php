<?php

$id = $_GET['id'];

$servername = "127.0.0.1";
$dbname = "project";
$username = "root";
$password = "";
$dsn = "mysql:host=$servername;dbname=$dbname;";

$pdo = new pdo($dsn, $username, $password);

$arr = [];
$stmt = $pdo->prepare("SELECT * FROM accounts WHERE id = '$id'OR email = '2'");
$stmt->execute([]);
$arr = $stmt->fetch(PDO::FETCH_ASSOC);
if(!$arr){
	
} 
else{
	$json = json_encode($arr, JSON_FORCE_OBJECT); 
   
	// Display the output 
	echo($json); 
}
$stmt = null;
$pdo = null;

?>