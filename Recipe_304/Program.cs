using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information
using System;
using SystemAcl.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class Program : IConsoleWriter
{
    private readonly ExampleDbContext _context;
    public Program(ExampleDbContext context)
    {
        _context = context;
    }

    public async Task Run()
    {
        _context.Database.ExecuteSqlInterpolated($"INSERT INTO shohin(shohin_id, shohin_mei, shohin_bunrui) " _
                                                    "VALUWS({},{},{})");
        
        var result = 
    }
}
