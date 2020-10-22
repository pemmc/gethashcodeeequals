using System;
namespace GetHashCodeeEquals.Entities
{
    public class Clients
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(! (obj is Clients) )
            {
                return false;

            }

            Clients other = obj as Clients;

            return Email.Equals(other.Email);

        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();

        }
    }
}
