namespace FirstAPI;

public class Response
{
    public string message { get; set; }
    public int statusCode { get; set; }

    public Response(string mes, int status = 200)
    {
        message = mes;
        statusCode = status;
    }
}
