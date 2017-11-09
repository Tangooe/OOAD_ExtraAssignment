using System;
using System.Collections.Generic;
using System.Linq;

namespace OOAD_ExtraAssignment
{
    public class FakePartyRepository : IPartyService
    {
        private readonly List<Party> _parties = new List<Party>
        {
            new Party("Emil Ekman", "9206242993", PartyType.Company),
            new Party("Another Person", "9105121234", PartyType.Private)
        };

        public Party Get(string term)
        {
            return _parties.FirstOrDefault(p => p.SocialSecurityNumber == term) ??
                   throw new InvalidOperationException("NotFound");
        }
    }
}