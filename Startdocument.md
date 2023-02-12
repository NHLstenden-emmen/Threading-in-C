# Dungeons And Dragons

## Generaal uitleg 
Dungeons & Dragons (D&D) is een tafel rolspel waarbij spelers personages creëren en avonturen beleven in een fantasiewereld onder leiding van een Game Master (ook wel de Dungeon Master of DM genoemd).

De DM stelt het toneel op en beschrijft de wereld, personages en gebeurtenissen. De DM beheersen alle niet-speler personages (NPC's), monsters en obstakels die de spelers zullen tegenkomen. De spelers beschrijven de acties van hun personage en maken beslissingen die het verhaal beïnvloeden.

Het gebruik van een display om het spelbord weer te geven (De map), maakt het voor de DM en spelers gemakkelijker om de wereld te visualiseren en de bewegingen van de personages te volgen. Het kan ook helpen om het spel georganiseerd en soepel te laten verlopen. Veel DM's gebruiken software of online hulpmiddelen om hun game maps te creëren en te beheren, evenals om de personage-statistieken en andere informatie bij te houden, dit wordt veel gedaan door middel van meerdere betaalde applicaties. Dit is dan ook waarom wij dit als opdracht willen maken door alle verschillende functionaliteiten te vergemakkelijken en gebruik te maken van miniatuur figuurtjes om de personages in de gamewereld te vertegenwoordigen.

## Wiremock
De applicatie bestaat uit twee schermen, een scherm (Speel scherm 1) wordt full screen weer gegeven op het beeldscherm wat plat op tafel ligt en wat wordt gezien door alle spelers en de DM. Speel scherm twee is het scherm wat wordt gebruikt door de DM, op dit scherm staat informatie over alle gegeneerdere monsters, loot en obstakels In dit scherm is ook een kleine weergave van de spelers hun level en HP.

Het de spelers kunnen hun eigen personage over het board verplaatsen door middel van het bewegen van de miniatuur figuurtjes. Dit wordt dan ook niet in de applicatie verwerkt om de speelvrijheid van de spelers intact te houden.
### Speel scherm 1
Op het scherm is een grid waar de personages overheen kunnen bewegen.  Door middel van het invullen van deze blokjes met een bepaalde kleur wordt weer gegeven of dit beloopbaar pad is of een object zo als een muur of berg, wand waar de spelers niet door heen kunnen bewegen.  
![image](https://user-images.githubusercontent.com/39293162/218317662-33374c55-8900-41f9-8665-8137e93a11a6.png)
De zwarte blokken representeren muren of andere obstakels waar de speler en monster niet overhene kan bewegen door gewoon te lopen: 
De blokjes in uit cirkelent vanaf "DAA" is een voorbeeld van hoe ver de speler kan lopen en movement gebruiken binnen de ruimte. de movement van "DAA" is in dit geval 4 en kan zich niet diargornaal bewegen. 
De blokjes die rood van binnen hebben representeert de movement van de speler "ROA" deze speler kan maar een stap zetten.
Aan de onder kant van het spel staat een win kans berekening om een indentatie te geven of de party met de zichtbare monsters kan overleven of dat ze zich beter kunnen terug trekken (deze berekening word gemaakt op basis van de mogelijkheden van de gehele party en de distance de monsters kunnen bewegen)
![image](https://user-images.githubusercontent.com/39293162/218317884-b7cc76e4-08dd-4b63-80fe-773a7ecf7a52.png)



### DM scherm 2
Het volgende scherm is een weer gave van de spelers waarin de hp, level en andere stats weer gegeven kunnen worden.
![image](https://user-images.githubusercontent.com/39293162/218316726-ecbca92a-5f5d-4aa0-b032-3f904660c55d.png)
De volgende afbeelding is van het map scherm waarin meerdere opties voor speel mappen worden gegenereerd hierin worden meerdere mappen tergerlijkert tijd gegenereerd. ook heeft dit scherm de optie om bij het generen van de map loot te generen voor de spelers wat gewonnen / gevonden kan worden. naast deze optie is er ook een manier om automaties monsters bij de map te genreren op basis van de challange rating van de party.
![image](https://user-images.githubusercontent.com/39293162/218317639-abc446ef-990c-4081-baac-a10cc2caf20e.png)
Omdat het ook leuk is om soms een extra monster handmatig toetevoegen is er ook een optie om monsters te genreren / monster groepen. De sterkte van de monsters wordt berekent op de sterkte van de party zodat de party nog wel een kans heeft om levent uit het gevecht te komen.
![image](https://user-images.githubusercontent.com/39293162/218318085-1d8a1d35-8817-4d52-8d91-fb8783a54f43.png)
Naast dat er allemaal monsters in de wereld lopen lopen er ook veel npc's waar de spelers mee kunnen interacten (zo als in een bar of winkel), Deze npc's hebben hierom dan ook een naam nodig en een is het handig voor de DM dat ze een backstory hebben en stnadaard character informatie.
![image](https://user-images.githubusercontent.com/39293162/218318198-16dffbe1-d0c4-4dc2-bbf7-e0c9f12709f2.png)
In het laatste scherm is het settings scherm hierin worden alle settings voor de game in gesteld en opgeslagen. Het zou uit eindelijk ook fijn zijn als de game progress opgelsagen kan worden hierom is het handig dat er een import en export functie komt binnen de applicatie.
![image](https://user-images.githubusercontent.com/39293162/218318332-b07dc54d-0db3-40fe-8bc9-3526df6bb3b9.png)



## Onderdelen van het systeem

### Simple manier voor progresie opslag
weer gave van het level van de speler 

### Event generator (encounter als je onderweg bent etc.)
Als de spelers onderweg zijn van punt a naar b is er een rol om te kijken of er een obstakel op de weg is met deze generator kan je een kapot wagen of mensen die in de bosjes wachten om je aan te vallen of gewoon een random monster tegen komt

### Npc generator hoe die er uit ziet backstory abilitys etc
Het achtergrondverhaal van de npc wordt gegenereerd en wat voor werk deze persoon doet etc. dit wordt dan op gelsagen en mogelijk gelinkt aan mensen die deze persoon kent

### Loot generator  
De loot die gegenereerd op basis van het level dat het item niet te sterk is, maar wel leuk of gek genoeg is voor de spelers om te gebruiken en te gebruiken.

### Map generator
Die een grid maakt van blokjes waar de spelers op kunnen staan en overheen kunnen lopen, dit grid kan dan ook gebruikt worden om weer te geven hoe vereen monster kan lopen of een speler kan lopen, dit geld dan ook voor het generen van terrein, generator en structuren 

### Quest generator voor als de spelers iets geheel anders doen dan wat zou moeten gebeuren

### puzzel generator om een deur of chest open te maken 

## Waar gebruik van wordt gemaakt:
Schrijf hier nog even hoe dit wordt gebruikt en waarbij
– (Multi)Threading; 
– Locking; 
– Mutex; 
– Semaphore; 
– Thread pool; 
– Task Parallel Library / Async & Await; 
– Linq/PLinq;
– Asynchronous I/O.

