namespace Catalogo.Model.Entities
{
    public class Movie
    {
        private Guid _id;
        private string _title;
        private int _duration;
        private string _gender;
        private string _url;

        public Movie(string title, int duration, string gender, string url)
        {
            _title = title;
            _duration = duration;
            _gender = gender;
            _url = url;
        }
    }
}
