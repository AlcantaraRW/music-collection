namespace Alcantara.MusicCollection.Domain.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; }
        public string Email { get; }
        public string Password { get; private set; }
        public string AccessToken { get; private set; }

        public User SetPassword(string password)
        {
            Password = password;
            return this;
        }

        public User SetAccessToken(string accessToken)
        {
            AccessToken = accessToken;
            return this;
        }
    }
}
