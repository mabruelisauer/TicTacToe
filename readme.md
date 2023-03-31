# Tic Tac Toe

*Julia Hüttenmoser, Dean Eichmann, Manuel Brülisauer* 

*Abgegeben 31.03.2023*
## Inhalt 
- [Informationen](#informationen)
    - [Links](#links)
- [Start und Planung](#start)
    - [Planung](#plan)
    - [Start](#star)
- [Sprint 1](#sprint1)
    - [Sprintziele](#goal1)
    - [Sprint](#dok1)
    - [Review](#rev1)
    - [Retrospektive](#retro1)
- [Sprint 2](#sprint2)
    - [Sprintziele](#goal2)
    - [Sprint](#dok2)
    - [Review](#rev2)
    - [Retrospektive](#retro2)
- [Sprint 3](#sprint3)
    - [Sprintziele](#goal3)
    - [Sprint](#dok3)
    - [Review](#rev3)
    - [Retrospektive](#retro3)
- [Produktabschluss](#product)

<a id="informationen"></a>
## Informationen
Dies ist unser Vertiefungsprojekt für das Modul V320.  
Das Thema des Projektes ist Tic Tac Toe, das auf einem normalen 3x3 Feld gespielt wird,   
wobei man gewinnt wenn man der erste mit 3 gleichen Zeichen auf der Horizontalen, Vertikalen oder Diagonalen ist.

<a id="links"></a>
### Links
Hier sehen Sie die Links zu dem Projekt auf Github sowie für Azure DevOps.

>[Github Repository](https://github.com/mabruelisauer/TicTacToe)  
[Azure Scrum](https://dev.azure.com/JuliaHuettenmoser/tictactoe) (Nur mit Zugriff)

<a id="start"></a>
## Start und Planung
<a id="plan"></a>
### Planung
Am Anfang des Projektes mussten wir zuerst Planen, wie wir das Projekt angehen sollen bzw.  
wie wir anfangen wollen, was wir in welchem Sprint machen, was überhaupt zu machen ist, etc.  
Zum Glück gab uns die [Vorgabe des Projektes](./Zusatz/Projektauftrag_TicTacToe.pdf) bereits einen guten Einblick.
<a id="star"></a>
### Start
Als erstes haben wir direkt ein Repository und das Azure DevOps Projekt erstellt.  
Nach dessen konnten Dean und Julia direkt die **Product Vision** und die **User Stories** erstellen, die wir aus 
den funktionalen Anforderungen der Beschreibung des Projektes genommen haben. 

Währenddessen hat Manuel das **UseCase-Modell** erstellt:

![UseCase-Modell](./img/use_case_diagram.png)

Dann hat Dean eine provisorische Priorisierung mit einem **Wert/Risiko Diagramm** kreiert,
während Julia versucht hat ein **Klassendiagramm** zu erstellen, jedoch sind wir zum Schluss,
gekommen, dass wir lieber einmal mit dem Code anfangen und im Nachhinein das Diagramm für
die Übersicht erstellen, da es uns so leichter wirkt. Es ist sehr schwierig ein Diagramm dazu
zu erstellen, wenn man noch keine Ahnung hat, was für Klassen, Methoden und Properties
man überhaupt braucht.  
Trotz dessen ist hier ihr Prototyp zum Klassendiagramm:

![Prototyp des Klassendiagramm](./img/prototyp_klassendiagramm.png)

Nachdem wir uns dazu entschlossen haben, haben wir uns gemeinsam um die Priorisierung geeinigt.  
Dies war die schlussendliche Priorisierung die man auch auf Azure finden kann (2,2,3 anstatt ABC):

![Priorisierung](./img/Prioritising.png)

<a id="sprint1"></a>
## Sprint 1
<a id="goal1"></a>
### Sprintziele
Im ersten Sprint wollen wir zuerst uns organisieren und das ganze Projekt planen. Nachdem wir damit fertig
sind wollen wir das Grid für das Tic Tac Toe machen und eine Anzeige für das Grid.  
Also kurz:
- Organisation/ Planung
- Grid
- Anzeige für Grid

<a id="dok1"></a>
### Sprint
Die erste Hälfte des Sprints haben wir damit verbracht zu planen und alles einzurichten (wie z.B. Azure oder
GitHub). Das meiste davon wurde bereits in [Start und Planung](#start) dokumentiert.

Der Rest des Sprints wurde dafür benutzt das Grid zu erstellen, das Interface für das Spiel und die ganze
Planung für die Dokumentation zusammen zu tragen, sowie die Struktur der Dokumentation

Das Grid wird offensichtlich in der Klasse Grid erstellt wobei man 2 for-Schleifen verschachtelt und diese
die Länge von jeweils rows und columns haben.

```
            for (int i = 0; i < _table.GetLength(0); i++)
            {
                for (int j = 0; j < _table.GetLength(1); j++)
                {
                    _table[i, j] = new Field(index);
                    index++;
                }
            }
```

Das Interface wird in der gleichen Klasse in der Methode PrintGrid gemacht, wobei das System mehr oder
weniger gleich ist wie beim Grid: 2 verschachtelte for-Schleifen.

<a id="rev1"></a>
### Sprintreview
Die Matrix wurde erstellt und ein Interface dafür. Somit haben wir eine Grundstruktur für
das Spiel erstellt.

<a id="retro1"></a>
### Retrospektive
Bei diesem Sprint haben wir weniger Aufgaben gemacht, damit wir sicherstellen konnten, 
dass wir alles während der Schulzeit erledigen konnten.

Sprintbewertung:
- Manuel: 8/10, alles ging gut und wir hatten keine Fehler mit dem Grid.
- Julia: 6/10, das meiste war okay, aber das Klassendiagramm war sehr frustrierend.
- Dean: 7/10, die Planung ging sehr schnell und die Dokumentation ebenfalls





<a id="sprint2"></a>
## Sprint 2
<a id="goal2"></a>
### Sprintziele

- Spiel Neustarten
- Spiel Beenden
- Felder Besitz
- Visuelle Darstellung
<a id="dok2"></a>
### Sprint
Dieser Sprint wurde hauptsächlich in Pair-Programming gemacht, ausserdem war Dean krank. 

Zuerst wurde der Spieler switch zwischen Zügen implementiert. Dies wurde gemacht in dem man in der Game Klasse
checkt ob am Ende eines Zuges, der 2. Spieler an der Reihe war oder nicht
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
Jedoch muss man dafür zuerst die Koordinaten des Feldes haben, diese werden mit Console.ReadLine geholt
und dann mit der Funktion 'TryCreateCoordinates' zu einem Coordinate Objekt gemacht, womit die Position
des Feldes bestimmt werden kann

Dadurch erstanden jedoch auch einige Fehler, da auch falsche Koordinaten wie z.B. A4 eingegeben werden konnten.


Mit diesen zwei Methoden wird deklariert ob und wem ein Feld gehört.
Danach wird mit der Methode getRepresentation geschaut, wem dieses Feld gehört und je nach dem ein X, O oder 
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

Dann haben wir die Eingaben "neu" für einen Neustart und "ende" für die Beendung implementiert. Dies
haben wir über eine do while Schleife in der ConsoleHelper Klasse gemacht.
```
            do
            {
                string input = Console.ReadLine();
                if (input == "ende")
                {
                    return null;
                }
                if (input == "neu")
                {
                    var game = new Game();
                    game.Start();
                }
                (isValid, coordinate) = Coordinate.TryCreateCoordinate(input, gridSize);
            } while (!isValid);
```

<a id="rev2"></a>
### Sprintreview
Sehr zufrieden mit Erfüllung von Backlogs. Die wichtigsten Funktionen wurden fertig gemacht. 
Jetzt fehlt nur noch die WinCheck Funktion und das Spiel funktioniert. 

Einige Schwierigkeiten sind bei Koordinaten erschienen, die ausserhalb des Grids waren, da sie von der
GetCoordinates Funktion akzeptiert wurden und dann das Programm abgestürzt ist, was uns viel Zeit kostete.
<a id="retro2"></a>
### Sprintretroperspektive
Die Benutzung des Pair-Programming hat sehr gut funktioniert. Es ist schwierig zu zweit (oder mehr) am
gleichen Projekt zusammen zu arbeiten, da viele Sachen aufeinander aufbauen, weshalb
durch Pair-Programming beide an dem Code gleichzeitig arbeiten konnten.  
Ausserdem war es laut Teilnehmern produktiver als hätten sie allein gearbeitet.  
Leider war Dean krank, weshalb wir weniger Arbeitskraft hatten, jedoch konnten wir trotzdem alles machen,
was wir machen wollten.

Sprintbewertung:
- Manuel: 7/10, wegen den Problemen mit den Koordinaten.
- Julia: 8/10, angenehme Arbeitslast und alles hat relativ gut funktioniert.
- Dean: 4/10, konnte leider an einem grossen Teil des Sprints nicht teilnehmen da er krank war.

<a id="sprint3"></a>
## Sprint 3
<a id="goal3"></a>
### Sprintziele
Wir wollen im dritten Sprint das Projekt abschliessen, dazu gehört es noch, den WinCheck, also die
Möglichkeit zu gewinnen hinzuzufügen, den Stack für die Undo Funktion zu erstellen und einen Text für
eine Fehlermeldung und den aktiven Spieler anzugeben.

Also kurz:
- WinCheck
- Undo Funktion
- Fehlermeldung
- aktiver Spieler

<a id="dok3"></a>
### Sprint
Am Anfang des Sprints haben wir kurz die Sprintziele definiert und alle Backlogs zum jetzigen Sprint auf 
[Azure](https://dev.azure.com/JuliaHuettenmoser/tictactoe/_sprints/taskboard/tictactoe%20Team/tictactoe/Sprint%203) hinzugefügt.

Manuel hat sich an den WinCheck gesetzt, Dean an die Dokumentation sowie Fehlermeldung und Anzeige des 
aktiven Spielers und Julia hat sich an den Stack bzw. die Undo Funktion gesetzt.

#### WinCheck
Der WinCheck wurde von Manuel implementiert und hat die Funktion, zu schauen ob ein Zug eines
Spielers das Spiel beendet hat (durch gewinnen).  
Dies macht er, indem er jedes Mal wenn ein Zug gespielt wird, abgerufen wird, dann werden
alle möglichen Kombinationen gecheckt die einen Sieg ergeben könnten (Alle Reihen,
Spalten oder Diagonalen) falls dies der Fall ist, wird der Sieger angezeigt und je nach dem
hat er die Option 'gg' zu sagen und somit das Spiel zu gewinnen oder die Möglichkeit, undo zu schreiben und
somit seinen letzten Zug zu verbessern.
Zusätzlich haben wir eine CheckDraw Funktion, die das Spiel automatisch beendet, wenn alle
Felder ausgefüllt sind und somit ein Unentschieden entsteht.

#### Fehlermeldung und aktiver Spieler
Die Fehlermeldung sowie die Anzeige des aktiven Spielers waren sehr leicht zu implementieren.  
Die Anzeige wurde da implementiert, wo wir den Originaltext hatten, jetzt gibt es jedoch zusätzlich
ein kleines If, um zu sehen, welcher Spieler aktiv ist.  
Die Fehlermeldungen sind für Fälle, wo man eine nicht mögliche Koordinate angibt, oder man eine Koordinate 
angibt, die bereits besetzt ist. Beim ersten wurde die Error Message bei GetCoordinate
hinzugefügt, wohingegen das zweite bei der GameUI eingefügt wurde.

#### Klassendiagramm
Wie bereits in der Einfürung erwähnt, hatten wir Probleme, mit einem Klassendiagramm
aufzukommen und wir wussten nicht mit was oder wie anzufangen. Daher haben wir jetzt
nachträglich noch ein Klassendiagramm erstellt.  
![Klassendiagramm](./img/klassendiagramm.png)


#### Undo

<a id="rev3"></a>
### Sprintreview
Der letzte Sprint war sehr holprig für uns und wir hatten einige Probleme, die diese Woche entstanden sind. Das hat dazu geführt, dass
wir einen grossen Teil des Codes in der Game Klasse neu schreiben mussten, was uns einige Zeit kostete. Daher sind wir auch nicht
so schnell gewesen wie wir eigentlich sein wollten. Zum Glück kam uns daher Herr Kehls Anweisung, den Sprint auf Freitag zu verlängern, sehr
gut, da uns das die Zeit gegeben hat, um die verlorene Zeit auf zu hohlen. Leider hat das ganze nicht gut mit der Azure Planung funktioniert,
da es dachte der 3. Sprint hätte am Dienstag aufgehört.

<a id="retro3"></a>
### Retrospektive
Wie bereits erwähnt hatten wir einige Stolpersteine diesen Sprint, was leider auch das
Team-Moral negativ beeinträchtigt hat. Es ist sehr schwierig sich zu motivieren, wenn
man den gleichen Code 3 Mal schreiben muss oder man mehrere Stunden am gleichen Code
sitzen muss, ohne grosse Vorschritte zu machen.

Sprintbewertung:
- Manuel: 4/10, das Testing brauchte viel zu viel Zeit
- Julia: 2/10, Deepy Copy und der Stack waren extremst schwierig zu versuchen zu implementieren
- Dean: 5/10, durch späte Abschliessung des Projektes konnte die Dokumentation erst sehr spät geschrieben werden.

<a id="product"></a>
### Produktabschluss
Schlussendlich konnten die meisten Anforderungen des Produktes erfüllt werden und unserer Meinung nach wurde
das zwar nicht perfekt gemacht, aber dafür, dass wir nur 3 Wochen Zeit hatten, ist es uns gut gelungen und
das Meiste konnte implementiert werden mit bestmöglicher Einhaltung der Clean Code Prinzipien.  
Leider geling die Undo Funktion nicht, aber leider hat uns schlichtweg das Wissen und die Zeit gefehlt.