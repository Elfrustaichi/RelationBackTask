using Microsoft.AspNetCore.Mvc;

namespace EternaTaskRelation.Models
{
    public class Portfolio
    {
        public int CategoryId { get; set; } 
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string NavBtnUrl { get; set; }

        public Category Category { get; set; }
    }
}
