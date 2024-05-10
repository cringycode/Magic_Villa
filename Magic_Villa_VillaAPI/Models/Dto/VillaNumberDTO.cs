using Microsoft.Build.Framework;

namespace Magic_Villa_VillaAPI.Models.Dto;

public class VillaNumberDTO
{
    [Required] public int VillaNo { get; set; }

    public string SpecialDetails { get; set; }
}