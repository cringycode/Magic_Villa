using Magic_Villa_VillaAPI.Models.Dto;

namespace Magic_Villa_VillaAPI.Data;

public static class VillaStore
{
    public static List<VillaDTO> villaList = new List<VillaDTO>
    {
        new VillaDTO { Id = 1, Name = "Pool Villa",Sqm = 1000,Occupancy = 4},
        new VillaDTO { Id = 2, Name = "Beach View",Sqm = 740,Occupancy = 3 }
    };
}