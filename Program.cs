            // 1. Utwórz instancje planet
            Planeta tatooine = new Planeta("Tatooine",3);
            Planeta alderaan = new Planeta("Alderaan",0);
            Planeta corellia = new Planeta("Corellia",null); // brak pewności co do danych
            Planeta stewjon = new Planeta("Stewjon",null); // brak danych

            // 1. Utwórz postacie
            PostacStarWars anakin = new PostacStarWars("Anakin Skywalker", "Czlowiek", "Mezczyzna", tatooine, PostacStarWars.StronaKonfliktu.REPUBLIKA);
            PostacStarWars leia = new PostacStarWars("Leia Organa", "Czlowiek", "Kobieta", alderaan, PostacStarWars.StronaKonfliktu.REPUBLIKA);
            PostacStarWars han = new PostacStarWars("Han Solo", "Czlowiek", "Mezczyzna", corellia, PostacStarWars.StronaKonfliktu.REPUBLIKA);
            PostacStarWars obiWan = new PostacStarWars("Obi-Wan Kenobi", "Czlowiek", "Mezczyzna", stewjon, PostacStarWars.StronaKonfliktu.REPUBLIKA);

            // Dodanie do kolekcji
            var postacie = new PostacieStarWars();
            postacie.Dodaj(anakin);
            postacie.Dodaj(leia);
            postacie.Dodaj(han);
            postacie.Dodaj(obiWan);

            // 2. Wyświetl informacje o postaciach
            Console.WriteLine("Lista postaci:");
            Console.WriteLine(postacie.ToString());

            // 3. Zmiana imienia Anakina i strony konfliktu
            anakin.Imie = "Darth Vader";
            anakin._StronaKonfliktu = PostacStarWars.StronaKonfliktu.IMPERIUM;

            // 4. Ponowne wyświetlenie
            Console.WriteLine("Po zmianie Anakina:");
            Console.WriteLine(postacie.ToString());

            // 5. Zmiana liczby księżyców Corelli
            corellia.LiczbaKsiezycow = 3;

            // 6. Ponowne wyświetlenie
            Console.WriteLine("Po zmianie liczby księżyców Corelli:");
            Console.WriteLine(postacie.ToString());

            // 7. Sprawdzenie głębokiej kopii (konstruktor kopiujący musi kopiować planetę)
            // np. uzyskaj listę kobiet i zmodyfikuj jedną planetę – oryginał nie powinien się zmienić

            // 8. Użycie metody oznaczonej jako [Obsolete]
#pragma warning disable CS0618 // ignorowanie ostrzeżenia
            var kobiety = postacie.ZwrocPostaciPoPlci("Kobieta");
#pragma warning restore CS0618

            // 9. Wyświetlenie kobiet przez rozszerzenie List<T>
            Console.WriteLine("Lista kobiet:");
            Console.WriteLine(kobiety.ZwrocInfoOLiscie());

            // 10. Metoda anonimowa do pobrania ludzi (gatunek == "Czlowiek")
            var ludzie = postacie.ZwrocPostaciPo(delegate (PostacStarWars p) { return p.Gatunek; }, "Czlowiek");



            // 11. Wyświetlenie ludzi przez rozszerzenie List<T>
            Console.WriteLine("Lista ludzi:");
            Console.WriteLine(ludzie.ZwrocInfoOLiscie());