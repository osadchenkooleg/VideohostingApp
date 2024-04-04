﻿namespace VideoHosting.Data.Entities;
public class Commentary
{
    public Guid Id { get; set; }

    public string Content { get; set; }

    public DateTime DayOfCreation { get; set; }

    public Guid VideoId { get; set; }

    public virtual Video Video { get; set; }

    public string UserId { get; set; }

    public virtual User User { get; set; }
}