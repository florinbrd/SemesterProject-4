using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Datamodel
{
    public class Room
    {
        [Key] public string LocationCode { get; set;}
        public string Description { get; set; }
        public int CurrentCapacity { get; set; }
        public int TotalCapacity { get; set; }
        
        // required measurements of the room 
        
        public int Light { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Co2 { get; set; }
        
        public ICollection<Artwork> ArtworkList { get; set; }
        [NotMapped]  
        public RoomMeasurement measurements { get; set; }
   
        
        
        
        
        
    }
}