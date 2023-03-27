using System;
using System.ComponentModel.DataAnnotations;

namespace ServerlessApi.Models;

public class Car
{
    [Key] 
    public int id { get; set; }
    public string brand { get; set; }
    public int year { get; set; }
    public string model { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
}