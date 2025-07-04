﻿namespace Övning_7_MovieAPI.Data.raw
{
    public class CsvRecord
    {
        public int Rank { get; set; }
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;  
        public string Description { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string Actors { get; set; } = null!;
        public string Year { get; set; } = null!;
        public int Runtime { get; set; }
        public double Rating { get; set; }
    }
}
