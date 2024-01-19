using System.ComponentModel.DataAnnotations;

namespace Catalogo.Communication.Response
{
    public record ResponseMovie
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public int Duration { get; set; } = int.MaxValue;
        [Required]
        public string Gender { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
}
