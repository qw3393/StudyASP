using Microsoft.AspNetCore.Mvc;

namespace StudyASPMVCWebApp.Controllers;

public class CameraController : Controller
{
    public IActionResult Capture()
    {
        return View();
    }
}