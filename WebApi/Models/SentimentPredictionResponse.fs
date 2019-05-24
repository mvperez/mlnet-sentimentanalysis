namespace WebApi.Models

type SentimentPredictionResponse(text:string, prediction:bool, probability:float32, score:float32) =
    member val Text = text
    member val Probabilty = probability
    member val Prediction = prediction
    member val Score =  score