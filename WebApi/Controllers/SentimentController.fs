namespace WebApi.Controllers

open Microsoft.AspNetCore.Mvc
open WebApi.Models
open Shared.Models.MLModel
open Microsoft.Extensions.ML

[<Route("api/[controller]")>]
[<ApiController>]
type SentimentController (predictionEngine:PredictionEnginePool<SentimentIssue, SentimentPrediction>) =
    inherit ControllerBase()
    member val PredictionEngine = predictionEngine

    [<HttpPost>]
    member this.Post([<FromBody>] sentimentRequest:SentimentDataRequest) =        
        let sampleStatement = { Label = false; Text = sentimentRequest.Text }
        let resultprediction = this.PredictionEngine.Predict(sampleStatement)
        let response = new SentimentPredictionResponse(sentimentRequest.Text, resultprediction.Prediction, resultprediction.Probability, resultprediction.Score)
        ActionResult<SentimentPredictionResponse>(response)