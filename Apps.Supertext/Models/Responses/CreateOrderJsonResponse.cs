using Apps.Supertext.Dtos;

namespace Apps.Supertext.Models.Responses;

public class CreateOrderJsonResponse
{
    public IEnumerable<OrderDto> Orders { get; set; }
}