# Dokumentation PokeAPI

## Lokal installieren und laufen lassen
Das Projekt klonen
```
git clone 
```

### Falls Sie Visual Studio haben
- Die Solution auf VS öffnen
- Auf "Run" in der obéren Leiste drücken

### Falls Sie das Projekt durch die dotnet CLI laufen lassen wollen:
- Das Projekt builden
```
dotnet build
```
- Das Projekt laufen lassen
```
dotnet run
```

## Feature Future
Für die Zukunft ist geplant, die Seiten und Komponenten, die sich noch in Entwicklung befinden, fertigzustellen. Dazu gehören:
- **Login-Seite** mit Authentifizierung via E-Mail und Passwort  
- **Details der Pokémons** (Stats, Abilities und Moves)  
- **Not-Found-Seite**, falls ein Pokémon nicht gefunden wird  
Darüber hinaus besteht die Idee, Pokémon-Karten durch Scannen mit dem Smartphone hochzuladen und in die private Sammlung zu übertragen.

## Was lief gut
- **Figma**  
  Figma (*ein cloudbasiertes Design-Tool*) hat sich als äußerst effektiv erwiesen. Entwickler konnten die Seiten schnell nach den Designs in Figma umsetzen, ohne umfangreiche Vorüberlegungen zur Gestaltung der Benutzeroberflächen.
- **Mudblazor**  
  Der Entwicklungsprozess mit Mudblazor verlief reibungslos. Die Nutzung vorgefertigter HTML-Blöcke ermöglichte einen schnellen und unkomplizierten Aufbau der Komponenten.

## Was lief schlecht
- **Styling in Mudblazor**  
  Während Mudblazor leistungsstark für den Aufbau der Seite war, erwies sich das Styling der Komponenten als herausfordernd. Mudblazor setzt bevorzugt eigene Style-Komponenten anstelle von CSS ein, was die Anpassung erschwerte.
- **Teamarbeit**  
  Die Zusammenarbeit im Team war nicht optimal. Aufgrund der engen Zeitplanung mit dem Kunden fanden nicht regelmäßig Meetings statt, wodurch das Projekt für längere Zeit aufgeschoben wurde.

## Ziel unseres Projekts
Das Projektziel war die Erstellung **sechs verschiedener Seiten** für die PokeAPI:
1. **Create an Account-Seite**  
   - Registrierung mit E-Mail-Adresse  
   - Passwort setzen und aktivieren  
2. **Login-Seite**  
   - Anmeldung mit E-Mail-Adresse und Passwort zur Verwaltung der Pokémon-Collection  
3. **Pokémon Collection**  
   - Übersicht über alle verfügbaren Pokémon  
4. **Detailseite eines Pokémon**  
   - Anzeige von **Status**, **Fähigkeiten**, **Strategien**  
   - Geplante Hinzufügung einer **Entwicklungsphase**, um Evolutionsmöglichkeiten darzustellen  
5. **My Collection-Seite**  
   - Individuelle Übersicht über die persönlichen Pokémon  
6. **Not-Found-Seite**  
   - Anzeige, falls ein gesuchtes Pokémon nicht gefunden wurde  

## Verwendete Frameworks
- **GitHub**
- **Figma**
- **Mudblazor**

## Verwendete Sprachen
- **C#**
- **CSS**
- **HTML**

