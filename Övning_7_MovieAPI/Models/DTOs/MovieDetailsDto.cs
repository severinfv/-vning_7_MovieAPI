﻿namespace Övning_7_MovieAPI.Models.DTOs
{
    public class MovieDetailsDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Year { get; set; }
        public required int Runtime { get; set; }
        public required double Rating { get; set; }
        public IEnumerable<GenreDto> Genres { get; set; } = Enumerable.Empty<GenreDto>();
        public IEnumerable<ActorDto> Actors { get; set; } = Enumerable.Empty<ActorDto>();
        public IEnumerable<ReviewDto> Reviews { get; set; } = Enumerable.Empty<ReviewDto>();

    }
}
