# Tic Tac Toe

*Julia Hüttenmoser, Dean Eichmann, Manuel Brülisauer*  

## Informationen
Dies ist unser Vertiefungsprojekt für das Modul V320.  
Das Thema des Projektes ist Tic Tac Toe, das auf einem normalen 3x3 Feld gespielt wird,   
wobei man gewinnt wenn man der erste mit 3 gleichen Zeichen auf der Horizonalen, Vertikalen oder Diagonalen ist.

### Links
Hier sehen Sie die Links zu dem Projekt auf Github sowie für Azure DevOps.

>[Github Repository](https://github.com/mabruelisauer/TicTacToe)  
[Azure Scrum](https://dev.azure.com/JuliaHuettenmoser/tictactoe) (Nur mit Zugriff)

## Start und Planung
Am Anfang des Projektes mussten wir zuerst Planen, wie wir das Projekt angehen sollen bzw.  
wie wir Anfangen wollen, was wir in welchem Sprint machen, was überhaupt zu machen ist, etc.  
Zum Glück gab uns die [Vorgabe des Projektes](./Zusatz/Projektauftrag_TicTacToe.pdf) bereits einen guten Einblick.
### Durchführung
Als erstes haben wir direkt ein Repository und das Azure DevOps Projekt erstellt.  
Nachdessen konnten Dean und Julia direkt die **Product Vision** und die **User Stories** erstellen, die wir aus 
den funktionalen Anforderungen der Beschreibung des Projektes genommen haben. 

Währenddessen hat Manuel das **UseCase-Modell** erstellt:

![UseCase-Modell](./img/use_case_diagram.png)

Dann hat Dean eine provisorische Priorisierung mit einem **Wert/Risiko Diagramm** kreeiert,
während Julia versucht hat ein **Klassendiagramm** zu erstellen, jedoch sind wir zum Schluss,
gekommen, dass wir lieber einmal mit dem Code anfangen und im Nachhinein das Diagramm für
die Übersicht erstellen, da es uns so leichter wirkt. Es ist sehr schwierig ein Diagramm dazu
zu erstellen, wenn man noch keine Ahnung hat, was für Klassen, Methoden und Properties
man überhaupt braucht.  
Trotzdessen ist hier ihr Prototyp zum Klassendiagramm:

![Prototyp des Klassendiagramm](./img/prototyp_klassendiagramm.png)

Nachdem wir uns dazu entschlossen haben, haben wir uns gemeinsam um die Priorisierung geeinigt.  
Dies war die schlussendliche Priorisierung die man auch auf Azure finden kann (1,2,3 anstatt ABC):

![Priorisierung](./img/Prioritising.png)

## Sprint 1
### Sprintziele
- Organisation/ Planung
- Grid

### Sprintreview
Bei diesem Sprint haben wir weniger Aufgaben gemacht, damit wir sicherstellen konnten, dass wir alles während der Schulzeit erledigen konnten.
Ausserdem haben wir den Grid implementiert. Dieses Grid ist eine visualierung der eigenlich nicht sichtbaren Matrix.

### Retroperspektive

## Sprint 2
### Sprintziele
- Spiel Neustarten
- Spiel Beenden
- Felder Besitz
- Visuelle Darstellung
### Sprint
Dieser Sprint wurde hauptsächlich in Pair-Programming gemacht, ausserdem war Dean krank. 

Zuerst wurde der Spieler switch zwischen Zügen implementiert. Dies wurde gemacht in dem man in der Game Klasse
checkt ob am Ende eines Zuges, der 1. Spieler an der Reihe war oder nicht
```
if (_player.Player1Turn)
                {
                    _player.Player1Turn = false;
                    _player.Player2Turn = true;
                }
                else
                {
                    _player.Player1Turn = true;
                    _player.Player2Turn = false;
                }
```

Als nächstes wurde implementiert, dass beiden Spielern verschiedene Felder gehören können.
Im Code wird dies in der Field Klasse geregelt.
```
public void Player1CaptureField(Field field)
{
        field.OwnedByPlayer1 = true;
}
public void Player2CaptureField(Field field)
{
        field.OwnedByPlayer2 = true;
}
```
Mit diesen zwei Methoden wird deklariert ob und wem ein Feld gehört.
Danach wird mit der Methode getRepresentation geschaut wem dieses Feld gehört und je nach dem ein X, O oder 
einen Abstand platziert.
```
public Representation GetRepresentation()
        {   
            if (OwnedByPlayer1)
            {
                return "X";
            }
            if (OwnedByPlayer2)
            {
                return "O";
            }
            else
            {
                return " ";
            } 
        }
```


### Sprintreview
Sehr zufrieden mit erfüllung von Backlogs. Die wichtigsten Funktionen wurden fertig gemacht. 