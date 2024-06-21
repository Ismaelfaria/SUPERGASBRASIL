﻿using SUPERGASBRASIL_API.Entities.Enum;

namespace SUPERGASBRASIL_API.Mappers.Models.InputModel
{
    public class Employees_InputModel
    {
        public string Name { get; set; }
        public long Cpf { get; set; }
        public DateTime DateOfBirth { get; set; }
        public EPositions Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
    }
}
