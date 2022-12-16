namespace ModelValidation.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public ResponseFactory Post(Employee model) => ResponseFactory.Create(HttpStatusCode.OK, model, "Operation Successed");
}