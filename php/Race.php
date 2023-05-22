<?php
namespace BetCyclingFriends;
require_once "db_link.inc.php";

use DB\DBLink;
use Exception;

class Race
{
    private $id;
    private $name;
    private $is_stages;
    const TABLE_NAME = "race";
    public function getAllRaces (&$message)
    {
        $result = new Race();
        try {
            // Connection à la base de données
            $bdd = DBLink::connect2db(MYDB, $message);

            // Préparation de la requête
            $stmt = $bdd->prepare("SELECT * FROM " . self::TABLE_NAME);

            // Exécution de la requête
            $stmt->execute();

            // Récupération du résultat
            $result = $stmt->fetchAll(\PDO::FETCH_CLASS, 'BetCyclingFriends\Race');

        } catch (Exception $e) {
            $message .= $e->getMessage();
        }

        return $result;
    }

    public function getId()
    {
        return $this->id;
    }

    public function getName()
    {
        return $this->name;
    }
}