<?php

$code = $_POST['code'];
$saldo = $_POST['saldo'];

if(empty($code) || empty($saldo)){
    function phpAlert($msg) {
        echo '<script type="text/javascript">alert("' . $msg . '")</script>';
    }

    header("Location: ../index.html");
}

?>





