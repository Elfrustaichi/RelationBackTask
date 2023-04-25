using EternaTaskRelation.Models;

namespace EternaTaskRelation.ViewModels
{
    public class HomeViewModel
    {
        public List<Feature> Features { get; set; }

        public List<Position> Positions { get; set; }

        public List<Slider> Sliders { get; set; }

        public List<TeamMember> TeamMembers { get; set; }
    }
}
