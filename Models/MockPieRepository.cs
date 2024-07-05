using System.Linq;
using System.Threading.Tasks;


namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


        public IEnumerable<Pie> AllPies =>
            new List<Pie>()
        {
        new Pie {PieId = 1, Name = "StrawberryPie", Price=15.95m , ShortDescription = "Lorem Ipsum", LongDescription = "" } ,
        new Pie {PieId = 2, Name = "Cheese Pie", Price=14.95m , ShortDescription ="Lorem Ipsum", LongDescription = "" } ,
        new Pie {PieId = 3, Name = "Rukhab Pie", Price=13.95m , ShortDescription ="Lorem Ipsum", LongDescription = "" } ,
        new Pie {PieId = 4, Name = "Pumkin Pie", Price=12.95m , ShortDescription ="Lorem Ipsum", LongDescription = "" }
};

        public IEnumerable<Pie> AllPiesOfTheWeek { get; }

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId );
    }

    
    }
}
