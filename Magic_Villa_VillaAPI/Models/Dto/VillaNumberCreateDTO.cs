﻿using Microsoft.Build.Framework;

namespace Magic_Villa_VillaAPI.Models.Dto;

public class VillaNumberCreateDTO
{
    [Required] public int VillaNo { get; set; }
    [Required] public int VillaID { get; set; }
    public string SpecialDetails { get; set; }
}