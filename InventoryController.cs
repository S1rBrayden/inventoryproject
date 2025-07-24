[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
    private readonly IInventoryService _service;

    public InventoryController(IInventoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetItems()
    {
        var items = await _service.GetAllItemsAsync();
        return Ok(items); // JSON response
    }

    [HttpPost]
    public async Task<IActionResult> AddItem(Item item)
    {
        await _service.AddItemAsync(item);
        return CreatedAtAction(nameof(GetItems), new { id = item.Id }, item);
    }
}
