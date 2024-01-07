using Microsoft.AspNetCore.Mvc;
using SentimentConsole;
using static SentimentConsole.SentimentModel;

namespace SentimentApi.Controllers;

[ApiController]
[Route("/api/predict")]
public class SentimentsController : ControllerBase
{
    [HttpPost]
    public IActionResult MakePrediction([FromBody] ModelInput input)
    {
        // Make a single prediction on the sample data and print results
        var predictionResult = SentimentModel.Predict(input);
        
        return Ok(predictionResult);
    }
}
