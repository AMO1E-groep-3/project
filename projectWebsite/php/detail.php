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
$id = $account['id'];
$oldSaldo = $account['saldo'];
$newSaldo = $oldSaldo + $saldo;

if(empty($code) || empty($saldo)){
    header("Location: ../index.php");
}
else{
    $sql = "UPDATE `accounts` SET `saldo` = $newSaldo WHERE `accounts`.`id` = $id";
    $query = $db->query($sql);
}
?>

<h1>Hey, <?= $account['name']; ?></h1>
<h3>Je saldo is met <?=$saldo?> euro opgewaardeerd!</h3>




