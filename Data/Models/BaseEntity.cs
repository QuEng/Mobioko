﻿namespace Mobioko.Data.Models;

public class BaseEntity<TKey>
{
    public TKey Id { get; set; }
}