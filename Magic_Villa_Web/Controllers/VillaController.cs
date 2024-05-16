using AutoMapper;
using Magic_Villa_Web.Models;
using Magic_Villa_Web.Models.Dto;
using Magic_Villa_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Newtonsoft.Json;

namespace Magic_Villa_Web.Controllers
{
    public class VillaController : Controller
    {
        #region DI

        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }

        #endregion

        #region INDEX

        public async Task<IActionResult> IndexVilla()
        {
            List<VillaDTO> list = new();
            var response = await _villaService.GetAll<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        #endregion

        #region CREATE

        public async Task<IActionResult> CreateVilla()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVilla(VillaCreateDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _villaService.Create<APIResponse>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(IndexVilla));
                }
            }

            return View(model);
        }

        #endregion

        #region UPDATE

        public IActionResult UpdateVilla()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region DELETE

        public IActionResult DeleteVilla()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}