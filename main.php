<?php
include "php/Player.php";
include "php/Race.php";

use BetCyclingFriends\Player;
use BetCyclingFriends\Race;

$message = "";
$player = new Player();
$players = $player->getAllPlayers($message);

$race = new Race();
$races = $race->getAllRaces($message);
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
        <table>
            <!-- Header du tableau -->
            <thead>
                <tr>
                    <th>Nom de la course</th>
                    <?php foreach ($players as $player): ?>
                        <th>Points de <p id="name_player"><?php echo $player->getFirstname() ?></p> </th>
                    <?php endforeach; ?>
                    <th>Vainqueur de la course</th>
                    <th>Parier</th>
                </tr>
            </thead>

            <!-- Corps du tableau -->
            <tbody>
                <!-- Ligne des course -->
                <?php foreach ($races as $race): ?>
                <tr>
                    <td><a class="course-link" href="race.php?<?= $race->getId() ?>"><?= $race->getName() ?></a></td>
                    <?php foreach($players as $player): ?>
                    <td></td>
                    <?php endforeach; ?>
                    <td></td>
                    <td class="parier-cell"><button type="submit" name="parier" class="parier-button" disabled>Parier</button></td>
                </tr>
                <?php endforeach; ?>

                <!-- Ligne de total -->
                <tr>
                    <th></th>
                    <?php foreach ($players as $player) : ?>
                    <th>Points totaux de <?php echo $player->getFirstname() ?></th>
                    <?php endforeach; ?>
                </tr>
                <tr>
                    <td></td>
                    <?php foreach ($players as $player) : ?>
                    <td></td>
                    <?php endforeach; ?>
                </tr>
            </tbody>

        </table>
    </main>
</body>
</html>
