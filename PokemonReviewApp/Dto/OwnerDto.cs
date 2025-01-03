﻿namespace PokemonReviewApp.Dto
{
    public class OwnerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return FirstName + LastName; } }
        public string Gym { get; set; }
    }
}
