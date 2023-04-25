namespace EternaTaskRelation.Models
{
    public class PortfolioImage
    {
        public int PortfolioId {get; set;}

        public int Id { get; set; }

        public string Name { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
