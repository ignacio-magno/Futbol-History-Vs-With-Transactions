using Fulbo;
using Fulbo.Domain;

namespace TestProject1.Integration;

public class Seed
{
    [Test]
    public void SeedFutbol()
    {
        var manchesterUnited = new Equipo()
        {
            Name = "Manchester United",
            Futbolistas = new List<Futbolista>()
            {
                new Futbolista("David de Gea", "Adán", 1),
                new Futbolista("Tom Heaton", "Heaton", 22),
                new Futbolista("Radek Vítek", "Vítek", 40),
                new Futbolista("Victor Lindelöf", "Lindelöf", 2),
                new Futbolista("Phil Jones", "Jones", 4),
                new Futbolista("Harry Maguire", "Maguire", 5),
                new Futbolista("Raphaël Varane", "Varane", 3),
                new Futbolista("Diogo Dalot", "Dalot", 28),
                new Futbolista("Luke Shaw", "Shaw", 23),
                new Futbolista("Aaron Wan-Bissaka", "Wan-Bissaka", 29),
                new Futbolista("Tyrell Malacia", "Malacia", 12),
                new Futbolista("Lisandro Martínez", "Martínez", 27),
                new Futbolista("Marc Jurado", "Jurado", 35),
                new Futbolista("Rhys Bennett", "Bennett", 41),
                new Futbolista("Brandon Williams", "Williams", 34),
                new Futbolista("Fred", "Frederico", 17),
                new Futbolista("Bruno Fernandes", "Fernandes", 18),
                new Futbolista("Scott McTominay", "McTominay", 39),
                new Futbolista("Casemiro", "Fernandes", 8),
                new Futbolista("Facundo Pellistri", "Pellistri", 75),
                new Futbolista("Donny van de Beek", "van de Beek", 30),
                new Futbolista("Christian Eriksen", "Eriksen", 21),
                new Futbolista("Zidane Iqbal", "Iqbal", 42),
                new Futbolista("Kobbie Mainoo", "Mainoo", 44),
                new Futbolista("Marcel Sabitzer", "Sabitzer", 25),
                new Futbolista("Alejandro Garnacho", "Garnacho", 77),
                new Futbolista("Marcus Rashford", "Rashford", 10),
                new Futbolista("Jadon Sancho", "Sancho", 25),
                new Futbolista("Anthony Elanga", "Elanga", 36),
                new Futbolista("Anthony Martial", "Martial", 9),
                new Futbolista("Antony", "Martins", 20),
                new Futbolista("Wout Weghorst", "Weghorst", 26),
            }
        };

        var manchesterCity = new Equipo()
        {
            Name = "Manchester City",
            Futbolistas = new List<Futbolista>()
            {
                new Futbolista("Ederson Moraes", "Silva", 1),
                new Futbolista("Scott Carson", "Griffiths", 31),
                new Futbolista("Stefan Ortega Moreno", "Ortega", 13),
                new Futbolista("Kyle Walker", "Peters", 2),
                new Futbolista("Rúben Dias", "Camilo", 3),
                new Futbolista("John Stones", "John", 5),
                new Futbolista("Nathan Aké", "Dos Santos", 4),
                new Futbolista("Aymeric Laporte", "Gurmendi", 14),
                new Futbolista("Rico Lewis", "Lewis", 26),
                new Futbolista("Manuel Akanji", "Ricardo", 25),
                new Futbolista("Ilkay Gündogan", "Gündoğan", 8),
                new Futbolista("Jack Grealish", "Grealish", 10),
                new Futbolista("Rodrigo", "Hernández", 19),
                new Futbolista("Kevin De Bruyne", "De Bruyne", 17),
                new Futbolista("Bernardo Silva", "Silva", 20),
                new Futbolista("Phil Foden", "Foden", 47),
                new Futbolista("Cole Palmer", "Palmer", 80),
                new Futbolista("Kalvin Phillips", "Phillips", 46),
                new Futbolista("Yangel Herrera", "Herrera", 21),
                new Futbolista("Sergio Gómez", "Gómez", 22),
                new Futbolista("Ben Knight", "Knight", 77),
                new Futbolista("Nico O'Reilly", "O'Reilly", 78),
                new Futbolista("Shea Charles", "Charles", 81),
                new Futbolista("Alex Robertson", "Robertson", 82),
                new Futbolista("Máximo Perrone", "Perrone", 83),
                new Futbolista("Riyad Mahrez", "Mahrez", 7),
                new Futbolista("Erling Haaland", "Haaland", 9),
                new Futbolista("Julián Álvarez", "Álvarez", 11)
            }
        };

        var tottenham = new Equipo()
        {
            Name = "Tottenham",
            Futbolistas = new List<Futbolista>()
            {
                new Futbolista("Hugo Lloris", "Lorenzo", 1),
                new Futbolista("Brandon Austin", "Austin", 33),
                new Futbolista("Fraser Forster", "Forster", 31),
                new Futbolista("Cristian Romero", "Gabriel", 17),
                new Futbolista("Eric Dier", "Dier", 15),
                new Futbolista("Davinson Sánchez", "Davinson", 6),
                new Futbolista("Emerson Royal", "Emerson", 22),
                new Futbolista("Ben Davies", "Davies", 23),
                new Futbolista("Japhet Tanganga", "Tanganga", 34),
                new Futbolista("Clément Lenglet", "Lenglet", 34),
                new Futbolista("Pierre-Emile Højbjerg", "Højbjerg", 5),
                new Futbolista("Ryan Sessegnon", "Sessegnon", 21),
                new Futbolista("Dejan Kulusevski", "Kulusevski", 7),
                new Futbolista("Oliver Skipp", "Skipper", 29),
                new Futbolista("Rodrigo Bentancur", "Bentancur", 28),
                new Futbolista("Ivan Perišić", "Perišić", 14),
                new Futbolista("Richarlison", "de Andrade", 9),
                new Futbolista("Pape Matar Sarr", "Sarr", 35),
                new Futbolista("Yves Bissouma", "Bissouma", 20),
                new Futbolista("Son Heung-Min", "Heung-min", 7),
                new Futbolista("Harry Kane", "Kane", 10),
                new Futbolista("Lucas Moura", "Moura", 11),
            }
        };

        var chelsea = new Equipo()
        {
            Name = "Chelsea",
            Futbolistas = new List<Futbolista>()
            {
                new Futbolista("Kepa Arrizabalaga", "Reina", 1),
                new Futbolista("Marcus Bettinelli", "Bettinelli", 13),
                new Futbolista("Édouard Mendy", "Mendy", 24),
                new Futbolista("Ben Chilwell", "Chilwell", 21),
                new Futbolista("Thiago Silva", "Silva", 6),
                new Futbolista("Antonio Rüdiger", "Rüdiger", 22),
                new Futbolista("Trevoh Chalobah", "Chalobah", 16),
                new Futbolista("Kalidou Koulibaly", "Koulibaly", 26),
                new Futbolista("Reece James", "James", 25),
                new Futbolista("Cesar Azpilicueta", "Azpilicueta", 28),
                new Futbolista("Marcos Alonso", "Alonso", 3),
                new Futbolista("N'Golo Kante", "Kante", 7),
                new Futbolista("Mateo Kovacic", "Kovacic", 8),
                new Futbolista("Ruben Loftus-Cheek", "Loftus-Cheek", 12),
                new Futbolista("Mason Mount", "Mount", 19),
                new Futbolista("Denis Zakaria", "Zakaria", 29),
                new Futbolista("Conor Gallagher", "Gallagher", 27),
                new Futbolista("Carney Chukwuemeka", "Chukwuemeka", 32),
                new Futbolista("Lewis Hall", "Hall", 33),
                new Futbolista("Pierre-Emerick Aubameyang", "Aubameyang", 14),
                new Futbolista("Christian Pulisic", "Pulisic", 10),
                new Futbolista("Raheem Sterling", "Sterling", 7),
                new Futbolista("Armando Broja", "Broja", 23),
                new Futbolista("Hakim Ziyech", "Ziyech", 22),
                new Futbolista("Davide Zappacosta", "Zappacosta", 20),
                new Futbolista("Kai Havertz", "Havertz", 29),
                new Futbolista("Noni Madueke", "Madueke", 30),
            }
        };

        var liverpool = new Equipo()
        {
            Name = "Liverpool",
            Futbolistas = new List<Futbolista>()
            {
                new Futbolista("Alisson Becker", "Silva", 1),
                new Futbolista("Adrian", "San Miguel", 22),
                new Futbolista("Caoimhin Kelleher", "Kelleher", 62),
                new Futbolista("Virgil van Dijk", "van Dijk", 4),
                new Futbolista("Ibrahima Konaté", "Konaté", 5),
                new Futbolista("Joe Gomez", "Gomez", 15),
                new Futbolista("Konstantinos Tsimikas", "Tsimikas", 21),
                new Futbolista("Andrew Robertson", "Robertson", 26),
                new Futbolista("Joël Matip", "Matip", 32),
                new Futbolista("Trent Alexander-Arnold", "Arnold", 66),
                new Futbolista("Fabinho Tavares", "Tavares", 3),
                new Futbolista("Jordan Henderson", "Henderson", 14),
                new Futbolista("Naby Keïta", "Keita", 8),
                new Futbolista("Alex Oxlade-Chamberlain", "Chamberlain", 17),
                new Futbolista("Curtis Jones", "Jones", 48),
                new Futbolista("Harvey Elliott", "Elliott", 67),
                new Futbolista("Fabio Carvalho", "Carvalho", 28),
                new Futbolista("Roberto Firmino", "Firmino", 9),
                new Futbolista("Mohamed Salah", "Mohamed", 11),
                new Futbolista("Sadio Mané", "Mané", 10),
                new Futbolista("Luis Díaz", "Díaz", 23),
                new Futbolista("Darwin Núñez", "Núñez", 27),
            }
        };

        var realDeMadrid = new Equipo()
        {
            Name = "Real Madrid",
            Futbolistas = new List<Futbolista>()
            {
                new Futbolista("Thibaut Courtois", "Mignolet", 1),
                new Futbolista("Andriy Lunin", "Lunin", 13),
                new Futbolista("David Alaba", "Alaba", 4),
                new Futbolista("Eder Militão", "Militão", 35),
                new Futbolista("Nacho Fernández", "Fernández", 6),
                new Futbolista("David Alaba", "Alaba", 4),
                new Futbolista("Ferland Mendy", "Mendy", 23),
                new Futbolista("Marcelo", "Vieira da Silva", 12),
                new Futbolista("Alvaro Odriozola", "Odriozola", 22),
                new Futbolista("Luka Modric", "Modrić", 10),
                new Futbolista("Toni Kroos", "Kroos", 8),
                new Futbolista("Casemiro", "Fernandes", 16),
                new Futbolista("Federico Valverde", "Valverde", 25),
                new Futbolista("Eduardo Camavinga", "Camavinga", 28),
                new Futbolista("Dani Ceballos", "Ceballos", 19),
                new Futbolista("Marco Asensio", "Barceló", 11),
                new Futbolista("Vinicius Júnior", "Junior", 20),
                new Futbolista("Rodrygo Goes", "Goes", 21),
                new Futbolista("Karim Benzema", "Benzema", 9),
                new Futbolista("Gareth Bale", "Bale", 18),
                new Futbolista("Mariano Díaz", "Díaz", 24),
                new Futbolista("Borja Mayoral", "Mayoral", 24)
            }
        };

        var interMilan = new Equipo()
        {
            Name = "Inter Milan",
            Futbolistas = new List<Futbolista>()
            {
                new Futbolista("Samir Handanovic", "Handanovič", 1),
                new Futbolista("Andre Onana", "Onana", 25),
                new Futbolista("Stefan de Vrij", "de Vrij", 6),
                new Futbolista("Milan Skriniar", "Skriniar", 37),
                new Futbolista("Alessandro Bastoni", "Bastoni", 95),
                new Futbolista("Davinson Sánchez", "Davinson", 23),
                new Futbolista("Federico Dimarco", "Dimarco", 24),
                new Futbolista("Denzel Dumfries", "Dumfries", 22),
                new Futbolista("Ivan Perisic", "Perisic", 14),
                new Futbolista("Hakan Calhanoglu", "Calhanoglu", 20),
                new Futbolista("Nicolò Barella", "Barella", 23),
                new Futbolista("Marcelo Brozovic", "Brozović", 7),
                new Futbolista("Arturo Vidal", "Vidal", 8),
                new Futbolista("Roberto Gagliardini", "Gagliardini", 27),
                new Futbolista("Stefano Sensi", "Sensi", 25),
                new Futbolista("Henrikh Mkhitaryan", "Mkhitaryan", 27),
                new Futbolista("Edin Džeko", "Džeko", 9),
                new Futbolista("Lautaro Martínez", "Martínez", 10),
                new Futbolista("Romelu Lukaku", "Lukaku", 9),
            }
        };


        var database = new DatabaseContext();

        database.Equipos.Add(chelsea);
        database.Equipos.Add(liverpool);
        database.Equipos.Add(realDeMadrid);
        database.Equipos.Add(interMilan);
        database.Equipos.Add(tottenham);
        database.Equipos.Add(manchesterCity);
        database.Equipos.Add(manchesterUnited);
        database.SaveChanges();
    }
}