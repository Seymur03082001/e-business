﻿using e_business.Models;

namespace e_business
{
    public class CreatePositionVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public IFormFile Image { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public int PositionId { get; set; }
    }
}
