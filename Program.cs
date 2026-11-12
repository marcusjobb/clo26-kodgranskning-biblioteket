// Förseningsavgift på bibliotekslån
// Programmet är skrivet med medvetna fel. Granska det enligt kravspecen i README.md.

Console.Write("Antal dagar boken var utlånad: ");
int daysBorrowed = int.Parse(Console.ReadLine());

int daysLate = daysBorrowed - 14;
int fee = daysLate * 5;
if (fee > 100)
    fee = 100;

Console.WriteLine($"Avgift: {fee} kr");
