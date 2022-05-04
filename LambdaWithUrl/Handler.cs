using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Serialization.Json;

namespace LambdaWithUrl;

public class Handler
{
    [LambdaSerializer(typeof(JsonSerializer))]
    public IEnumerable<String> Handle(APIGatewayProxyRequest apiGatewayProxyRequest)
    {
        return apiGatewayProxyRequest?.QueryStringParameters?.Values ?? new String[0];
    }
}