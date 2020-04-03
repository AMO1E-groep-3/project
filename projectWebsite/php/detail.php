<?php   
require('../header.php');
require('config.php');

$code = $_POST['code'];
$saldo = $_POST['saldo'];

$sql = "SELECT * FROM accounts WHERE code = :code"; 
$query = $db->prepare($sql);
$query->execute([
 ':code' => $code
]);

$account = $query->fetch(PDO::FETCH_ASSOC);
?>

<h1>Hey, <?= $account['name']; ?></h1>
<h3>Je staat om het punt om <?=$saldo?> euro  op te waarderen</h3>

<form action="detail.php" method="POST">
    <input type="submit">
</form>



