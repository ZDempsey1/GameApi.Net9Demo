namespace GameApi.Net9Demo.Models
{
    public class VideoGameDetails
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int VideoGameId { get; set; }
    }
}
