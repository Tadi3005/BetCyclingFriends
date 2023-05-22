<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>BetCyclingFriends</title>
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <style>
        /* CSS pour la mise en page */
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 20px;
        }

        header {
            background-color: #333;
            color: #fff;
            padding: 20px;
            text-align: center;
        }

        header h1 {
            margin: 0;
        }

        main {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        form {
            margin-bottom: 20px;
        }

        form label {
            display: block;
            margin-bottom: 10px;
            font-weight: bold;
        }

        form input[type="text"],
        form input[type="password"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        form input[type="submit"] {
            background-color: #4CAF50;
            color: #fff;
            border: none;
            padding: 10px 20px;
            font-size: 16px;
            border-radius: 4px;
            cursor: pointer;
        }

        form input[type="submit"]:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
<header>
    <h1>BetCyclingFriends</h1>
</header>
<main>
    <h2>Connexion</h2>
    <form action="login.php" method="POST">
        <label for="username">Nom d'utilisateur</label>
        <input type="text" id="username" name="username" required>

        <label for="password">Mot de passe</label>
        <input type="password" id="password" name="password" required>

        <input type="submit" value="Se connecter">
    </form>

    <h2>Inscription</h2>
    <form action="register.php" method="POST">
        <label for="username">Nom d'utilisateur</label>
        <input type="text" id="username" name="username" required>

        <label for="firstname">Prenom</label>
        <input type="text" id="firstname" name="firstname" required>

        <label for="password">Mot de passe</label>
        <input type="password" id="password" name="password" required>

        <input type="submit" value="S'inscrire">
    </form>
</main>
</body>
</html>
