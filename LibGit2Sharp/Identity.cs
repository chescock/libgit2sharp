using LibGit2Sharp.Core;

namespace LibGit2Sharp
{
    public sealed class Identity
    {
        private readonly string _name;
        private readonly string _email;

        public Identity(string name, string email)
        {
            Ensure.ArgumentNotNullOrEmptyString(name, "name");
            Ensure.ArgumentNotNullOrEmptyString(email, "email");

            _name = name;
            _email = email;
        }

        public string Email
        {
            get { return _email; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
