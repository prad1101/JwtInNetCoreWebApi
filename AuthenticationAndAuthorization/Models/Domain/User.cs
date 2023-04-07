namespace AuthenticationAndAuthorization.Models.Domain
{
    public class User
    {
        public Guid id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string emailaddress { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<string> role { get; set; }  



    }
}
