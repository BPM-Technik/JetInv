<?php

	echo '<h1>Protokoll:</h1>';
	// Verbindungsinfos
	$servername = "db676899327.db.1and1.com";
	$username = "dbo676899327";
	$password = "dbJetInv#007007!";
	$pwbpm = "dbBpM#007007!";

	// Verbindung erstellen
	$conn = new mysqli_connect($host_name, $user_name, $password, $database);

	// Verbindung prüfen
	if(mysqli_connect_errno())
    {
		die("<p>Verbindung zum MySQL Server fehlgeschlagen: ".mysqli_connect_error()."</p>";
    }
	
	echo "Verbindung erfolgreich aufgebaut";
	//--------------------------------
	//       Verbindung steht
	//--------------------------------
	
	$sql = $_GET["query"];
	$hsh = $_GET["hsh"];
	
	if (empty($sql]) || $hsh != $pwbpm)
	{
		die("<p>Authorisierungsfehler!</p>");
	}

	if ($conn->query($sql) == TRUE) {
		echo "SQL-Query wurde ausgeführt";
	} else {
		echo "Error: " . $sql . "<br><br>" . $conn->error;
	}

	$conn->close();
?>