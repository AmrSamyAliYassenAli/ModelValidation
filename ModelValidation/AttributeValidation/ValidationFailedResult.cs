namespace ModelValidation.AttributeValidation;
public class ValidationFailedResult : ObjectResult
{
	public ValidationFailedResult(ModelStateDictionary modelState)
         : base(new ResponseResultModel(modelState))
    {
        StatusCode = StatusCodes.Status422UnprocessableEntity;
    }
}