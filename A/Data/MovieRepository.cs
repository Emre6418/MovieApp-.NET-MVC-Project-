using A.Models;

namespace A.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() {
                    Id=1,
                    Name="John Wick 4",
                    ShortDescription="John Wick 4",
                    Description="John Wick uncovers a path to defeating The High Table. But before he can earn his freedom, Wick must face off against a new enemy with powerful alliances across the globe and forces that turn old friends into foes.",
                    ImageUrl="1.jfif",
                    CategoryId=3
                },
                new Movie() {
                    Id=2,
                    Name="Dungeons Dragons",
                    ShortDescription="Dungeons Dragons",
                    Description="A charming thief and a band of unlikely adventurers embark on an epic quest to retrieve a lost relic, but things go dangerously awry when they run afoul of the wrong people.",
                    ImageUrl="2.jfif",
                    CategoryId=2
                },
                new Movie() {
                    Id=3,
                    Name="Knights of the Zodiac",
                    ShortDescription="Knights of the Zodiac",
                    Description="When a goddess of war reincarnates in the body of a young girl, street orphan Seiya discovers that he is destined to protect her and save the world. But only if he can face his own past and become a Knight of the Zodiac.\r\n\r\n",
                    ImageUrl="3.jfif",
                    CategoryId=2,
                },
                new Movie() {
                    Id=4,
                    Name="The Covenant",
                    ShortDescription="The Covenan",
                    Description="During the war in Afghanistan, a local interpreter risks his own life to carry an injured sergeant across miles of grueling terrain.",
                    ImageUrl="4.jfif",
                    CategoryId =1
                },
                new Movie() {
                    Id=5,
                    Name="Awareness",
                    ShortDescription="Awareness",
                    Description="A teenager who lives with his father on the outskirts by running small scams using Ian's ability to generate visual illusions upon unsuspecting victims. Things get complicated when his powers get out of control in public.",
                    ImageUrl="5.jfif",
                    CategoryId=5
                },
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }
    }
}
