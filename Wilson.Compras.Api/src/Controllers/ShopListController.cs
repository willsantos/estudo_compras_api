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
    
    [HttpGet]
    public async Task<IEnumerable<ShopList>> Index()
    {
        return await _service.List();
    }
    
    [HttpGet("id")]
    public async Task<ShopList> Show(int id)
    {
        return await _service.Show(id);
    }
    

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ShopList shopList)
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