﻿namespace RulesService.Models;

public class RulesResult
{
    public string? RuleName { get; set; }
    public bool IsSuccess { get; set; }
    public string? SuccessEvent { get; set; }
    public string? ErrorMessage { get; set; }
    public bool Enabled { get; set; } = true;
    public Dictionary<string, object>? Properties { get; set; }
    public RulesResult()
    {
            
    }

}
