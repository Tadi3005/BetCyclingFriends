<?php
include "php/Player.php";

use BetCyclingFriends\Player;

$message = "";
$player = new Player();
$players = $player->getAllPlayers($message);
?>
<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Accueil</title>
    <link rel="stylesheet" type="text/css" href="css/style.css">
</head>
<body>
<?php include "inc/head.inc.php" ?>
<main>

</main>
</body>
</html>