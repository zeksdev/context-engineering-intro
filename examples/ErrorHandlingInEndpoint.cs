public override async Task HandleAsync(Customer request, CancellationToken ct)
{
    try
    {
            
    }
    catch (Exception ex)
    {
        Logger.LogError(ex, "Error creating customer");
        //await SendErrorsAsync(500, ct); DO NOT USE THIS
        ThrowError("Error creating customer", 500); // USE THIS
    }
}