<?php require('header.php'); ?>

<body>
    <div class="background">
        <header>
            <div class="logo">
                <div class="container-default">
                    <img src="img/logo.PNG" alt="logo">
                </div>
            </div>
        </header>
        <main>
            <div class="container flex flex-center">
            <h1>Login</h1>
                <form action="php/detail.php" method="POST">
                    <label for="code">Vul hier uw code in:</label>
                    <input type="text" id="code" name="code" required>

                    <label for="saldo">Voer hier uw saldo in:</label>
                    <input type="number" id="saldo" name="saldo" required value="0" min="0.01" step="0.01">

                    <input type="submit" value="Submit">
                </form>
            </div>
        </main>
        <?php require('php/footer.php'); ?>
    </div>
</body>

</html>