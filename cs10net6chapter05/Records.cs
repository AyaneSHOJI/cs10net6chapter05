using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

// for avoir inti error
namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { }
}

namespace Packt.Shared
{
    public class ImmutablePerson
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
    }
}