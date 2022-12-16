namespace ModelValidation.AttributeValidation;
public class ResponseResultModel
{

    /// <summary>
    /// RequestId
    /// </summary>
    public string RequestId { get; set; }

    /// <summary>
    /// Gets or Set
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Gets or Set
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// Gets or Set ValidationMessages
    /// </summary>
    public List<string>? ValidationMessages { get; set; }

    public ResponseResultModel(ModelStateDictionary modelState)
    {
        RequestId = Guid.NewGuid().ToString();
        Success = false;
        Data = new();
        ValidationMessages = modelState.Keys
            .SelectMany(key => modelState[key].Errors.Select(x => x.ErrorMessage))
            .ToList();
    }
}