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
    <section id="classement">
        <h2>Classement</h2>
        <table>
            <thead>
                <tr>
                    <th>Position</th>
                    <th>Joueur</th>
                    <th>Points</th>
                </tr>
            </thead>
            <tbody>
                <?php for($i = 0; $i < count($players); $i++): // TODO Modifier pour que ce soit dans l'ordre du classement ?>
                <tr>
                    <td><?php echo $i + 1 ?></td>
                    <td><?php echo $players[$i]->getFirstname() ?></td>
                    <td>150 <?php // TODO Mettre les points du joueurs ?></td>
                </tr>
                <?php endfor; ?>
            </tbody>
        </table>
    </section>
</main>
</body>
</html>
