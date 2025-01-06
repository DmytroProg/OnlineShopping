﻿namespace OnlineShopping.DTOs.Outputs;

public class UserDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
}