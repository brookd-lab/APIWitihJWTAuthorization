using Microsoft.AspNetCore.Authorization;

namespace API
{
    public class MinimumAgeRequirement: IAuthorizationRequirement
    {
        public readonly int MinimumAge;
        public MinimumAgeRequirement(int minimumAge)
        {
            MinimumAge = minimumAge;   
        }
    }
}
