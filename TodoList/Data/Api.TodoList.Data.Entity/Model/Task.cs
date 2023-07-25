﻿namespace Api.TodoList.Data.Entity.Model;

public class Task
{
    public int IdTask { get; set; }

    public int IdUser { get; set; }

    public int IdStatus { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateDue { get; set; }
}
