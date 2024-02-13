using Microsoft.AspNetCore.Authorization;

namespace API
{
    public class MinimumAgeHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            MinimumAgeRequirement requirement)
        {
            var ageClaim = context.User.Claims.FirstOrDefault(c => c.Type == "age");
            if (int.Parse(ageClaim.Value)! >= requirement.MinimumAge) context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
