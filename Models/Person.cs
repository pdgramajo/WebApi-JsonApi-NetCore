using JsonApiDotNetCore.Models;
namespace DOTNET_APPS.Models
{
    public class Person : Identifiable
    {
        [Attr("first-name")]
        public string FirstName { get; set; }
        
        [Attr("last-name")]
        public string LastName { get; set; }
    }
}