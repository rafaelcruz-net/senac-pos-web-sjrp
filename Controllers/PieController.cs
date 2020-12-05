using Microsoft.AspNetCore.Mvc;
using senac_sjrp.Repository;

[Route("[controller]")]
public class PieController : Controller
{
    private readonly IPieRepository _pieRepository;

    public PieController(IPieRepository repository)
    {
        this._pieRepository = repository;
    }

    public IActionResult Index()
    {
        var result = this._pieRepository.GetAllPies();

        return View(result);
    }
}