﻿namespace VideoHosting.Api.Application.Credentials.Models;

public class UserLoginGetModel
{
    public string Id { get; set; }

    public string Email { get; set; }
    
    public string PhoneNumber { get; set; }
}