using System;

namespace OOAD_ExtraAssignment
{
    public class Party
    {
        public Party(string name, string ssn, PartyType type)
        {
            Id = new Guid();
            Name = name;
            SocialSecurityNumber = ssn;
            PartyType = type;
        }

        public Guid Id { get; }
        public string Name { get; }
        public string SocialSecurityNumber { get; }
        public PartyType PartyType { get; }
    }
}
