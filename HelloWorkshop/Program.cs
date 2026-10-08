// Console.WriteLine("Hello,Warsztacie Programisty!");
// Console.WriteLine("Tymek");
// Console.WriteLine("Informatka");
// Console.Write("Chce sie nauczyc programowac");

using System.Runtime.CompilerServices;

// string imie ="Tymek";
// string wiek = "18";
// string gra = "Nba 2k";
// Console.WriteLine("\t\t\"WIZYTOWKA\"\t\t");
// Console.WriteLine($"imie:{imie}");
// Console.WriteLine($"wiek:{wiek}");
// Console.WriteLine($"gra:{gra}");Tymek

// Console.Write("Podaj swoj wiek:18 ");
// string wpisanyWiek = Console.ReadLine()!;

// Console.WriteLine("Jaka jest liczba kilometrow do celu?");
// int  liczbaKilometrow = int.Parse( Console.ReadLine()!);
// Console.WriteLine("Jaka jest liczba kilometrow pokonywana kazdego dnia?");
// int liczbaKilometrowNaDzien = int.Parse(Console.ReadLine()!);
// int liczbaDni = liczbaKilometrow / liczbaKilometrowNaDzien;
// Console.WriteLine($"Liczba dni potrzebna do pokonania {liczbaKilometrow} kilometrow wynosi: {liczbaDni} dni");30

// Console.WriteLine("Ile mam lacznie monet?");
// int zlotych = 5;
// int srebrnych = 10;
// int miedzianych = 20;
// int jednaZlota = 100*miedzianych;
// int jednaSrebrna = 10*miedzianych;
// Console.WriteLine("Ile mam lacznie monet zlotych?");
// int liczbaMonetWyrazonychWzlotych = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile mam lacznie monet srebrnych?");
// int liczbaMonetWyrazonychWsrebrnych = int.Parse(Console.ReadLine());
// Console.WriteLine("Ile mam lacznie monet miedzianych?");
// int liczbaMonetWyrazonychWmiedzianych = int.Parse(Console.ReadLine());

// int wynik = liczbaMonetWyrazonychWzlotych * 100 + liczbaMonetWyrazonychWsrebrnych * 10 + liczbaMonetWyrazonychWmiedzianych;
// Console.WriteLine($"Wartosc wynosi: {wynik}");

// Console.WriteLine("==Ekwipunek==");
// Console.WriteLine("Podaj imie bohatera");
// string imie =(Console.ReadLine());
// Console.WriteLine("Podaj symbol bohatera");
// char symbol =char.Parse(Console.ReadLine());
// Console.WriteLine("Podaj poziom doswiadczenia");
// int poziom =int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj liczbe sztuk zlota");
// int zloto =int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj wage plecaka w kilogramach");
// double waga =double.Parse(Console.ReadLine());
// Console.WriteLine("Podaj informacje czy bohater ma mape");
// bool mapa =bool.Parse(Console.ReadLine());
// Console.WriteLine("==Ekwipunek==");
// Console.WriteLine($"imie :{imie}");
// Console.WriteLine($"symbol :{symbol}");
// Console.WriteLine($"poziom :{poziom}");
// Console.WriteLine($"zloto :{zloto}");
// Console.WriteLine($"waga :{waga}");
//  waga = waga +2;
// Console.WriteLine($"waga :{waga}");

// Console.WriteLine("Podaj poczatkowa liczbe punktow doswiadczenia.");
// int doswiadczenie =int.Parse(Console.ReadLine());
// Console.WriteLine("Podaj poczatkowa liczbe zlota");
// int zloto =int.Parse(Console.ReadLine());
// doswiadczenie = doswiadczenie +25;
// Console.WriteLine($"doswiadczenie :{doswiadczenie}");
// doswiadczenie *=2;
// Console.WriteLine($"doswiadczenie :{doswiadczenie}");
// zloto -=8;
// Console.WriteLine($"Oplata za wejscie na arene. zloto :{zloto}");
// zloto +=15;
// Console.WriteLine($"Nagroda zloto :{zloto}");

// Console.WriteLine("Ile masz racji zywnosciowych");
// int racje =int.Parse(Console.ReadLine());
// Console.WriteLine("Ile jest czlonkow druzyny?");
// int czlonkowieDruzyny =int.Parse(Console.ReadLine());
// Console.WriteLine("Ile dni trwa wyprawa?");
// int dniWyprawy =int.Parse(Console.ReadLine());

// int racjeNaCzlonka =(racje/czlonkowieDruzyny);
// int resztki =(racje%czlonkowieDruzyny);
// double racjeDziennieNaDruzyne =(racje/dniWyprawy);
// double racjeDziennieNaJednaOsobe =(racje/czlonkowieDruzyny/dniWyprawy);

// Console.WriteLine($"Kazdy czlonek otrzyma {racjeNaCzlonka} racji.");
// Console.WriteLine($"Po rownym podziale pozostanie {resztki} racji.");
// Console.WriteLine($"Dziennie na druzyne przypada {racjeDziennieNaDruzyne} racji.");
// Console.WriteLine($"Srednio na jedna osobe przypada {racjeDziennieNaJednaOsobe} racji.");

Console.WriteLine("Ile masz punktow zycia?");
int punktyZycia =int.Parse(Console.ReadLine());
Console.WriteLine("Ile masz eliksirow?");
int eliksiry =int.Parse(Console.ReadLine());
Console.WriteLine("Czy masz klucz?");
bool klucz =bool.Parse(Console.ReadLine());
Console.WriteLine("Czy masz mape?");
bool mapa =bool.Parse(Console.ReadLine());
bool czyZyje = punktyZycia>0;
bool MaPelneZdrowie = punktyZycia==100;
bool MaZaopatrzenie = eliksiry>=1;
bool MaPrzedmiotNawigacyjny = klucz==true||mapa==true;
bool gotowyDoWyprawy = czyZyje && MaZaopatrzenie && MaPrzedmiotNawigacyjny;

Console.WriteLine($"Zyje: {czyZyje}");
Console.WriteLine($"Ma pelne zdrowie: {MaPelneZdrowie}");
Console.WriteLine($"Ma zaopatrzenie: {MaZaopatrzenie}");
Console.WriteLine($"Ma klucz lub mape: {MaPrzedmiotNawigacyjny}");
Console.WriteLine($"Gotowy do wyprawy: {gotowyDoWyprawy}");
