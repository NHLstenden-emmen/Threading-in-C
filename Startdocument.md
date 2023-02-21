# Dungeons And Dragons

## Uitleg

Dungeons & Dragons (D&D) is een bord- en rolspel waarbij spelers eigen karakters creëren en avonturen beleven in een fantasiewereld onder leiding van een Game Master (ook wel de Dungeon Master of DM genoemd).

De DM stelt het speelveld op en beschrijft de wereld, personages en gebeurtenissen. De DM beheerst alle niet-speler personages (NPC's), monsters en obstakels die de spelers kunnen tegenkomen. De spelers beschrijven de acties van hun personage en maken beslissingen die het verhaal beïnvloeden aan de hand van diverse dobbelstenen.

Het gebruik van een scherm om het spelbord weer te geven (De map), maakt het voor de DM en spelers makkelijker om de wereld te visualiseren en de bewegingen van de personages bij te houden. Hierbij kan het ook helpen om het spel georganiseerd en soepel te laten verlopen. Veel DM's gebruiken software of online hulpmiddelen om game maps te creëren en te beheren, evenals om de personage-statistieken en andere informatie bij te houden. Het bijhouden van deze data wordt veel gedaan door middel van verschillende betaalde applicaties. Dit is waarom wij als opdracht onze eigen variant willen opstellen. Om deze eigen versie te realiseren willen wij een eigen variant van de verschillende functionaliteiten opstellen. Ook willen wij het mogelijk maken om een map op te stellen in de vorm van een grid waar de DM de positie van de spelers, enemies, loot, kamers, omgeving etc kan bijhouden om berekening uit te voeren voor bijvoorbeeld mogelijke posities voor de enemies en spelers.

## Wiremock

De applicatie bestaat uit twee schermen, scherm een (Speelscherm 1) wordt fullscreen weergegeven op het beeldscherm wat plat op tafel ligt en wat wordt gezien door alle spelers en de DM. Scherm twee (Speelscherm 2) is het scherm wat wordt gebruikt door de DM, op dit scherm staat informatie over alle gegeneerdere monsters, loot en obstakels. In dit scherm is ook een kleine weergave van de speler level, HP en andere mogelijke statistieken.

Het is met de applicatie mogelijk om de locatie van de spelers en de enemies bij te houden. De DM kan de locatie van de enemies bijhouden, en op basis van de keuzes van de spelers ook de positie van hun personages bijhouden, en hiermee kan de DM diverse berekening en generators gebruiken tijdens het spel. Bij deze berekening en generatoren kan worden gedacht aan het berekenen van het slagingspercentage, de beste positie voor de enemies (de DM bepaalt wat de enemies doen), het genereren van loot, quest en meer.

### Speelscherm 1

Op het scherm is een grid waar de personages overheen kunnen bewegen. Door middel van het invullen van deze blokjes met een bepaalde kleur wordt weergegeven of dit een beloopbaar pad is of een object zoals een muur, bergwand of een ander omgevingselement waar de spelers niet door heen kunnen bewegen.  
![image](https://user-images.githubusercontent.com/39293162/218317662-33374c55-8900-41f9-8665-8137e93a11a6.png)
Dit betekent dat de zwarte blokken muren representeren of andere obstakels waar de spelers en de monsters niet langs kunnen.
De blokjes met een blauw gekleurde rand die vanaf speler "DAA" gekleurd zijn, zijn een voorbeeld van hoe ver de speler kan lopen en movement kan gebruiken binnen deze ruimte. De movement van "DAA" is in dit geval 4 en kan zich niet diagonaal bewegen.
De blokjes die een rode rand van binnen hebben geven de movement van de speler "ROA" weer, deze speler kan maar een stap zetten.
Aan de onderkant van het spel staat een win kans berekening om een indicatie te geven of de party met de zichtbare monsters kan overleven of dat ze zich beter kunnen terug trekken (deze berekening word gemaakt op basis van de mogelijkheden van de gehele party en de distance de monsters kunnen bewegen)
![image](https://user-images.githubusercontent.com/39293162/218317884-b7cc76e4-08dd-4b63-80fe-773a7ecf7a52.png)

### Dungeon Master scherm 2

Het tweede scherm is een weergave van de spelers waarin hp, level en andere statistieken weergegeven kunnen worden.
![image](https://user-images.githubusercontent.com/39293162/218316726-ecbca92a-5f5d-4aa0-b032-3f904660c55d.png)
De volgende afbeelding is een weergave van een van de tools van de DM. Dit is een scherm waar de DM meerdere random mappen kan laten genereren, hierbij kan het formaat van de grid worden aangegeven, evenals het aantal mappen die moeten worden gegenereerd. Bij het maken van deze map kan ook gelijk loot in de map worden gegenereerd, net als het inspawnen van enemies. Op deze manier kan de DM heel makkelijk een compleet spel opbouwen.
![image](https://user-images.githubusercontent.com/39293162/218317639-abc446ef-990c-4081-baac-a10cc2caf20e.png)
In dit spel komt het vaak voor dat de DM zelf elementen toe voegt aan het spel. Daarom is er ook een mogelijkheid om zelf monsters (of groepen monsters) te genereren. De sterkte van de monsters wordt berekent op de sterkte van de party zodat de party nog wel een kans heeft om levend uit het gevecht te komen.
![image](https://user-images.githubusercontent.com/39293162/218318085-1d8a1d35-8817-4d52-8d91-fb8783a54f43.png)
Naast de mogelijkheid om monster tegen te komen, bestaan er ook veel npc's in dit spel. Spelers hebben de mogelijkheid om met deze npc's een interactie aan te gaan. Dus het moet ook mogelijk zijn om npc's op te stellen/genereren. Deze hebben vaak een unieke naam, achtergrond verhaal en andere standaard karakter informatie.
![image](https://user-images.githubusercontent.com/39293162/218318198-16dffbe1-d0c4-4dc2-bbf7-e0c9f12709f2.png)
Het laatste scherm is het instellingen scherm. Op dit scherm worden alle instellingen voor het spel ingesteld en opgeslagen. Het zou uiteindelijk ook fijn zijn als de spelvoortgang opgeslagen kan worden. Hiervoor is het handig dat er een import en export functie komt binnen de applicatie.
![image](https://user-images.githubusercontent.com/39293162/218318332-b07dc54d-0db3-40fe-8bc9-3526df6bb3b9.png)

## Moscow analyse

![image](https://user-images.githubusercontent.com/73099939/219017599-e5231ec6-c08a-46ff-a086-e0ddcc99be62.png)

## Onderdelen van het systeem

### Map generator

Een generator die op een willekeurige manier een speelveld in de vorm van een grid opsteld. Met stukken waar de spelers wel en niet overheen kunnen bewegen. Dit speelveld kan ook worden gebruikt om weer te geven welke afstand een enemy of speler kan bewegen. In dit speelveld kan de omgeving en structuren worden gegenereerd.

### Campaign generator

De campaign generator combineert alle functionaliteit om een grote campaign op te zetten. Hierbij worden verschillende levels van de campaign gegenereerd met behulp van de map generator. In deze campaign wereld, bestaande uit meerdere mappen worden ook enemies gegenereerd en geplaats, samen met loot, NPC's en quest. Op deze manier kan de Dungeon master snel een heel spel op stellen, zonder uren aan voorbereiding te hoeven doen.

### Loot generator

Een generator die loot kan genereren voor de spelers, deze loot wordt opgesteld vanuit de dataset. Dit kan voorkomen in kisten, als rewards voor quest etc. Deze loot kan worden gegenereerd op basis van het level van de spelers. Deze berekening wordt toegepast om te verzekeren dat het item niet te sterk, of te zwak is voor het punt waar de spelers zich op bevinden.

### Enemy generator

De DM selecteert het aantal enemies dat gegenereerd moet worden. Doormiddel van threading worden deze enemies opgesteld vanuit de dataset, wanneer een enemy een hoge moeilijkheidsgraad heeft is deze enemy uniek en wordt deze uit de dataset gehaald zodat hij niet nog een keer kan voorkomen (resource sharing). Wanneer een lage moeilijkheidsgraad enemy wordt opgesteld zal dit niet het geval zijn, aangezien het vaak kan voorkomen dat er bijvoorbeeld 10 goblins/bandits aanwezig zijn. Bij de enemies worden ook statistieken gegenereerd zoals difficulty, hit points, armor rating, etc.

### NPC generator

Ook is het mogelijk om npc's te genereren. Dit is van belang omdat de spelers in een campaign vaak meerdere malen in contact komen met deze npc's, en hier vaak met kunnen praten, quest aannemen en meer. Bij het genereren van de npc's wordt uit de dataset het uiterlijk, achtergrond verhaal en de andere nodige statistieken gehaald.
Om te voorkomen dat er exact dezelfde npc's ontstaan zijn sommige aspecten van de npc's uniek, dus na dat dit bepaalde aspect een keer is gebruikt wordt deze uit de dataset gehaald. Wel is het mogelijk om verbanden tussen npc's op stellen, denk bijvoorbeeld aan een familie aan de hand van dezelfde achternaam.

### Quest generator

Tijdens het spel kunnen de spelers verschillende afwijkende doelen tegenkomen die kunnen worden vervuld voor extra beloningen (aan de hand van de loot generator). Om dit niet te makkelijk te maken kan worden gebruik gemaakt van een quest generator om een alternatief doel te genereren, dit kan een simpele quest zijn, zoals het ophalen van een item, maar ook aan de hand van bijvoorbeeld een puzzel.

### Speler beurt berekening

Aangezien de omgeving van de spelers enorm kan verschillen is het soms onduidelijk welke route ze kunnen nemen aan de hand van hun statistieken. Om dit proces te versimpelen kan een berekening worden uitgevoerd die het complete veld laat zien waar de speler zich in kan voortbewegen. Dit kan voor elke speler gebeuren om zo een duidelijk overzicht te krijgen van waar de spelers heen kunnen lopen.

### Enemy positie berekening

Op basis van de statistieke van de enemies, in het specifiek de stappen die de enemy kan zetten en zijn aanval afstand. Kan de DM voor elke enemy een tegelijk een berekening uitvoeren wat de beste mogelijk positie zou zijn voor de enemy om de speler aan te vallen. Dit is dan een mogelijk positie waar de DM de enemy neer kan zetten die wordt aangegeven door de kleur van de enemy weer te geven op de mogelijke positie.

### Win kans percentage berekening

Om het mogelijk te maken de winkans te berekenen wordt een combinatie van de statistieken van de spelers en de statistieken van de enemies genomen. Door met deze statistieken een berekening uit te voeren wordt een winkans opgesteld.

### Save game state

Het moet mogelijk zijn om wanneer een save file is aangemaakt, makkelijk de huidige staat van het spel op te slaan. Op deze manier kan de Dungeon master verzekeren dat er geen progressie verloren gaat.

### Import / Export game state

Om makkelijk verder te kunnen spelen of de spel progressie te kunnen delen met anderen moet de mogelijkheid bestaan de game state te importeren of exporteren. Dit kan een soepele herstart van het spel garanderen. En op deze manier kunnen meerdere sestand van de game state bewaren om te verzekeren dat deze niet verloren gaat.

## Welke C# threading methodes worden gebruikt en hoe ze worden gebruikt:

-   (Multi)Threading;
    -   Map generator,
    -   Campaign generator,
    -   Loot generator,
    -   Enemy generator,
    -   NPC generator,
    -   Quest generator,
    -   Player Turn berekening,
-   Locking;
    -   Win kans percentage berekening,
-   Mutex;
    -   Map generator,
    -   Enemy generator,
    -   NPC generator,
-   Semaphore;
    -   Campaign generator
-   Thread pool;
-   Linq/PLinq;
-   Task Parallel Library / Async & Await;
    -   Enemy generator
    -   Loot generator
-   Multiple Asynchronized I/O calls naar een api
