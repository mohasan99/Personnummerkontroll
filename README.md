Det här programmet hjälper dig att kontrollera om ett svenskt personnummer är korrekt.

Så här gör du:

1.	Starta programmet. Du kommer se en välkomsttext som hälsar dig välkommen.

2.	Skriv in det personnummer du vill kontrollera. Du kan skriva det på flera sätt, till exempel med 12 siffror (199001011234) eller med 10 siffror och bindestreck (900101-1234).

3.	Tryck på Enter.

4.	Programmet svarar direkt:
•	Om det lyser grönt och står "Giltigt" så stämmer numret.
•	Om det lyser rött och står "Ogiltigt" så är det något fel på numret.

5.	Du kan fortsätta skriva in nya nummer direkt efteråt.

6.	När du är klar skriver du ordet "avsluta" för att stänga ner programmet.

För dig som vill köra eller testa programmet (Utvecklare)
Här följer instruktioner för hur du startar projektet på din egen dator:

Köra programmet lokalt För att starta programmet på din dator öppnar du en terminal, går till mappen där koden finns och skriver: dotnet run.

Köra tester För att kontrollera att all logik fungerar som den ska har vi skapat automatiska tester. Du kör dessa genom att skriva: dotnet test. Då ser du direkt om alla funktioner i programmet är gröna och fungerar.

Använda programmet med Docker Om du vill köra programmet via en container (Docker) så kan du ladda ner den färdiga versionen från DockerHub. Du använder då kommandot "docker pull" följt av namnet på containern, och startar den sedan med "docker run". Detta gör att du kan köra programmet utan att behöva ha några andra verktyg installerade.
