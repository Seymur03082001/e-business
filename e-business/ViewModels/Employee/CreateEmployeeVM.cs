﻿namespace e_business.ViewModels.Employee
{
    public class CreateEmployeeVM
    {
        public string Name { get; set; }
        public string? Surname { get; set; }
        public IFormFile Image { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public int PositionId { get; set; }
    }
}
