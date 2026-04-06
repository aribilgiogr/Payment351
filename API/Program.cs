using API.Models;
using Business;
using Core.Abstracts.IManagements;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiServices(builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Payment API Çalýþýyor!");

// 1. Ödeme Alma Uç Noktasý (Endpoint)
app.MapPost("/api/payments/process", async (ProcessPaymentRequest request, IPaymentManager paymentManager) =>
{
    // paymentManager üzerinden yazdýðýmýz metodu çaðýrýyoruz
    var result = await paymentManager.ProcessPaymentAsync(request.OrderNumber, request.TotalAmount, request.Currency);

    // Ýþlem baþarýlýysa 200 OK, deðilse 400 Bad Request dönüyoruz
    return result.IsSuccess ? Results.Ok(result) : Results.BadRequest(result);
});

// 2. Ödeme Ýade Uç Noktasý (Endpoint)
app.MapPost("/api/payments/refund", async (RefundPaymentRequest request, IPaymentManager paymentManager) =>
{
    var result = await paymentManager.RefundPaymentAsync(request.OrderNumber, request.Amount, request.Currency);

    return result.IsSuccess ? Results.Ok(result) : Results.BadRequest(result);
});

app.Run();
