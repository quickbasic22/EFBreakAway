using Microsoft.EntityFrameworkCore;

namespace EFBreakAway
{
    class Lodging
    {
        public int LodgingId { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }
        public Destination Destinations { get; set; }
    }
}