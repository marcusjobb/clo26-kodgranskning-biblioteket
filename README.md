# Kodgranskning: förseningsavgift på bibliotekslån

Det här är en startrepo. Du ska **granska** koden, inte skriva den om från början.

## Så här gör du

1. Forka eller klona repot.
2. Kör programmet: `dotnet run`.
3. Testa det mot kravspecen nedan. Skriv ner vad programmet gör, och vad det borde göra.
4. Använd din egen checklista (se övningen i kursmaterialet) och hitta felen.

## Kravspec

- Ett lån gäller i **14 dagar**.
- Varje dag efter förfallodagen kostar **5 kr**.
- Avgiften är högst **100 kr**.
- Lämnas boken i tid är avgiften **0 kr**.

## Varningar

- Avgiften får **aldrig vara negativ**. En bok som lämnas tidigt ger ingen återbetalning.
- Programmet får **inte krascha** på felaktig inmatning.
- Hårdkoda inte 14, 5 eller 100 i beräkningen. Det ska gå att ändra på ett ställe.

## Det du lämnar in

- Din checklista, med minst fem punkter.
- En lista över fel du hittat: vad som är fel, var det står, och vilken punkt i checklistan som fångade det.
- Rättad kod, om du vill visa hur du skulle lösa det.
