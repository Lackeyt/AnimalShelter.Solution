using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public Gender AnimalGender { get; set; }
    public DateTime DateOfAdmittance { get; set; }
    public string Breed { get; set; }    
  }

  public enum Gender
  {
  Male,
  Female    
  }
}