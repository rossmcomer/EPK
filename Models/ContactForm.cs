using Microsoft.AspNetCore.Components;

namespace EPK.Models
{
    public partial class Contact : ComponentBase
    {
        private ContactFormModel ContactFormModel { get; set; } = new ContactFormModel();

    }

    public class ContactFormModel
    {
        public string? RecipientEmail { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
    }
}