using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.API.PInzPermissions
{
    public class PermissionDescription
    {
        public string Name { get; }
        public string Description { get; }
        public string Group { get; }

        public PermissionDescription(string name, string descripton, string group)
        {
            Name = name;
            Description = descripton;
            Group = group;
        }
    }
}
