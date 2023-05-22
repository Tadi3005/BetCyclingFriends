<?php
namespace BetCyclingFriends;
require_once "db_link.inc.php";

use DB\DBLink;
use Exception;

class Player
{
    private $id;
    private $pseudo;
    private $firstname;
    private $password;

    const TABLE_NAME = "player";

    public function getAllPlayers(&$message)
    {
        $result = new Player();
        try {
            // Connection à la base de données
            $bdd = DBLink::connect2db(MYDB, $message);

            // Préparation de la requête
            $stmt = $bdd->prepare("SELECT * FROM " . self::TABLE_NAME);

            // Exécution de la requête
            $stmt->execute();

            // Récupération du résultat
            $result = $stmt->fetchAll(\PDO::FETCH_CLASS, 'BetCyclingFriends\Player');

        } catch (Exception $e) {
            $message .= $e->getMessage();
        }

        return $result;
    }

    public function getFirstname()
    {
        return $this->firstname;
    }
}