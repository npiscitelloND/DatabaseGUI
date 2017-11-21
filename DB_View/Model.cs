using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DB_View
{
    public class ComponentContext : DbContext
    {
        public DbSet<Component> Components { get; set; }
    }

    public class Component
    {
        public string _name         { get; set; } = "";
        public string _description  { get; set; } = "";
        public string _notes        { get; set; } = "";
        public string _applications { get; set; } = "";
        public string _manufacturer { get; set; } = "";
        public string _supplier     { get; set; } = "";
    }
}
