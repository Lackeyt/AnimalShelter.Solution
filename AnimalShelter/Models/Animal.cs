using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public AnimalType Type { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public AnimalGender Gender { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Breed { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DateOfAdmittance { get; set; }
  }

  public enum AnimalGender
  {
  Unknown,
  Male,
  Female    
  }

  public enum AnimalType
  {
    Dog,
    Cat
  }
}