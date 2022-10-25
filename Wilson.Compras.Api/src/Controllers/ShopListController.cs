using Microsoft.AspNetCore.Mvc;
using Wilson.Compras.Api.Models;
using Wilson.Compras.Api.Services;

namespace Wilson.Compras.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShopListController : ControllerBase
{
    private readonly ShopListService _service;

    public ShopListController(ShopListService service)
    {
        _service = service;
    }
    
    [HttpGet(Name = "QUENAMEEHESSE")]
    public async Task<IEnumerable<ShopList>> Get()
    {
        return await _service.List();
    }
    
    

    [HttpPost]
    public async Task<IActionResult> post([FromBody] ShopList shopList)
    {
        try
        {
            await _service.Add(shopList);
            return Ok("Cadastrado com sucesso!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        
    }
}