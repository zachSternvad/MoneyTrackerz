# MoneyTrackerz 💸

<!-- 
En bra titel och en kort, slagkraftig slogan gör det direkt tydligt vad projektet handlar om. Emojis kan lätta upp stämningen.
-->
En modern, open-source app för att spåra utgifter, inkomster och skulder, byggd med Blazor. Ta kontroll över din ekonomi!

---

<!--
Badges ger ett proffsigt intryck och visar snabbt status på projektet. Du kan lägga till dessa senare när du har satt upp bygg-pipelines etc.
-->
![GitHub issues](https://img.shields.io/github/issues/zachSternvad/MoneyTrackerz)
![GitHub forks](https://img.shields.io/github/forks/zachSternvad/MoneyTrackerz)
![GitHub stars](https://img.shields.io/github/stars/zachSternvad/MoneyTrackerz)
![Licens](https://img.shields.io/github/license/zachSternvad/MoneyTrackerz)

## Om Projektet

<!--
Här beskriver du projektet i lite mer detalj. Vilket problem löser det? Vem är det för? Vilken teknik används?
-->
MoneyTrackerz föddes ur behovet av ett enkelt men kraftfullt verktyg för att hantera privatekonomi. Målet är att skapa en intuitiv webbapplikation där användare enkelt kan logga sina transaktioner, kategorisera dem och hålla koll på skulder. Applikationen byggs från grunden med den senaste tekniken från Microsoft.

**Teknikstack:**
* [.NET 8](https://dotnet.microsoft.com/en-us/)
* [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
* [C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/)

## ✨ Nyckelfunktioner

<!--
En punktlista över de viktigaste funktionerna ger en snabb överblick över vad appen kan göra.
-->
* **Transaktionsspårning:** Logga enkelt inkomster och utgifter.
* **Kategorisering:** Organisera dina transaktioner med anpassningsbara kategorier.
* **Skuldhantering:** Håll koll på vem du är skyldig pengar och vem som är skyldig dig.
* **Dashboard:** En visuell översikt över din ekonomiska status (planerad funktion).
* **Rapporter:** Skapa detaljerade rapporter över dina spenderarvanor (planerad funktion).

## 🚀 Kom igång

<!--
Detta är en av de viktigaste delarna. Hur får någon igång din kod på sin egen dator? Stegen måste vara supertydliga.
-->
Följ dessa steg för att få en lokal kopia av projektet att köra.

### Förutsättningar

Se till att du har följande programvara installerad:
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* En IDE som [JetBrains Rider](https://www.jetbrains.com/rider/) eller [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1.  **Klona repot**
    ```sh
    git clone [https://github.com/zachSternvad/MoneyTrackerz.git](https://github.com/zachSternvad/MoneyTrackerz.git)
    ```
2.  **Navigera till projektmappen**
    ```sh
    cd MoneyTrackerz
    ```
3.  **Återställ NuGet-paket**
    ```sh
    dotnet restore
    ```
4.  **Kör applikationen**
    ```sh
    dotnet run
    ```
    Applikationen kommer nu att vara tillgänglig på `https://localhost:7199` eller en liknande adress. Se terminalen för exakt URL.

## 🗺️ Roadmap

<!--
En roadmap visar att du har en vision för projektet. Det uppmuntrar andra att engagera sig eftersom de ser att projektet är aktivt och har en framtid.
-->
* [ ] Grundläggande CRUD (Create, Read, Update, Delete) för transaktioner.
* [ ] Implementera databas med Entity Framework Core.
* [ ] Bygga ett interaktivt UI för att lägga till och visa transaktioner.
* [ ] Utveckla en visuell dashboard med diagram.
* [ ] Lägga till användarautentisering.
