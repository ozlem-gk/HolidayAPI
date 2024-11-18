namespace HolidayAPI
{
    public static class StaticHoliday
    {
        public static List<Holiday> Holidays = new List<Holiday>
        {
            new Holiday { Date = new DateTime(2023, 01, 01), LocalName = "Neujahr", Name = "New Year's Day", CountryCode = "DE", Type = "national", States = null },
            new Holiday { Date = new DateTime(2023, 01, 06), LocalName = "Heilige Drei Könige", Name = "Epiphany", CountryCode = "DE", Type = "religious", States = new List<string> { "Baden-Württemberg", "Bavaria", "Saxony-Anhalt" } },
            new Holiday { Date = new DateTime(2023, 03, 08), LocalName = "Internationaler Frauentag", Name = "International Women's Day", CountryCode = "DE", Type = "international", States = new List<string> { "Berlin", "Mecklenburg-Western Pomerania" } },
            new Holiday { Date = new DateTime(2023, 04, 07), LocalName = "Karfreitag", Name = "Good Friday", CountryCode = "DE", Type = "religious", States = null },
            new Holiday { Date = new DateTime(2023, 04, 09), LocalName = "Ostersonntag", Name = "Easter Sunday", CountryCode = "DE", Type = "religious", States = new List<string> { "Brandenburg" } },
            new Holiday { Date = new DateTime(2023, 04, 10), LocalName = "Ostermontag", Name = "Easter Monday", CountryCode = "DE", Type = "religious", States = null },
            new Holiday { Date = new DateTime(2023, 05, 01), LocalName = "Tag der Arbeit", Name = "Labour Day", CountryCode = "DE", Type = "national", States = null },
            new Holiday { Date = new DateTime(2023, 05, 18), LocalName = "Christi Himmelfahrt", Name = "Ascension Day", CountryCode = "DE", Type = "religious", States = null },
            new Holiday { Date = new DateTime(2023, 05, 28), LocalName = "Pfingstsonntag", Name = "Pentecost", CountryCode = "DE", Type = "religious", States = new List<string> { "Brandenburg", "Hesse" } },
            new Holiday { Date = new DateTime(2023, 05, 29), LocalName = "Pfingstmontag", Name = "Whit Monday", CountryCode = "DE", Type = "religious", States = null },
            new Holiday { Date = new DateTime(2023, 06, 08), LocalName = "Fronleichnam", Name = "Corpus Christi", CountryCode = "DE", Type = "religious", States = new List<string> { "Baden-Württemberg", "Bavaria", "Hesse", "North Rhine-Westphalia", "Rhineland-Palatinate", "Saarland" } },
            new Holiday { Date = new DateTime(2023, 08, 15), LocalName = "Mariä Himmelfahrt", Name = "Assumption Day", CountryCode = "DE", Type = "religious", States = new List<string> { "Saarland" } },
            new Holiday { Date = new DateTime(2023, 09, 20), LocalName = "Weltkindertag", Name = "World Children's Day", CountryCode = "DE", Type = "school", States = new List<string> { "DE-TH" } },
            new Holiday { Date = new DateTime(2023, 10, 03), LocalName = "Tag der Deutschen Einheit", Name = "German Unity Day", CountryCode = "DE", Type = "national", States = null },
            new Holiday { Date = new DateTime(2023, 10, 31), LocalName = "Reformationstag", Name = "Reformation Day", CountryCode = "DE", Type = "religious", States = new List<string> { "Brandenburg", "Mecklenburg-Western Pomerania", "Saxony", "Saxony-Anhalt", "DE-TH", "Bremen", "Hamburg", "Lower Saxony", "Schleswig-Holstein" } },
            new Holiday { Date = new DateTime(2023, 11, 01), LocalName = "Allerheiligen", Name = "All Saints' Day", CountryCode = "DE", Type = "religious", States = new List<string> { "Baden-Württemberg", "Bavaria", "North Rhine-Westphalia", "Rhineland-Palatinate", "Saarland" } },
            new Holiday { Date = new DateTime(2023, 11, 22), LocalName = "Buß- und Bettag", Name = "Repentance and Prayer Day", CountryCode = "DE", Type = "religious", States = new List<string> { "Saxony" } },
            new Holiday { Date = new DateTime(2023, 12, 25), LocalName = "Erster Weihnachtstag", Name = "Christmas Day", CountryCode = "DE", Type = "religious", States = null },
            new Holiday { Date = new DateTime(2023, 12, 26), LocalName = "Zweiter Weihnachtstag", Name = "St. Stephen's Day", CountryCode = "DE", Type = "religious", States = null }
        };
      
    }
}
