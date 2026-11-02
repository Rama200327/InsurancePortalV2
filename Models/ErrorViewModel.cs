namespace InsuraV2.Models
{
    public class ErrorViewModel
    {
        // Stores the id of current requiest
        public string? RequestId { get; set; }


        //this called (Computed Property) it means : if (requiestId موجود ) -> return true , if (requiestId is empty ) -> return false
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    //this model for display error's data, not for error handling !
}
