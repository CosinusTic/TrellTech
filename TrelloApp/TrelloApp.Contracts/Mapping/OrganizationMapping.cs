using Android.Provider;
using TrelloApp.Contracts.Response;
using TrelloApp.Contracts.Models;

namespace TrelloApp.Contracts.Mapping;

public static class OrganizationMapping
{
    public static Organization MapToOrganization(this CreateOrganizationResponse response)
    {
        return new Organization()
        {
            Name = response.Name,
            Id = response.Id,
            Desc = response.Desc
        };
    }
    
    public static Organization MapToOrganization(this GetOrganizationByIdResponse response)
    {
        return new Organization()
        {
            Name = response.Name,
            Id = response.Id,
            Desc = response.Desc
        };
    }
    
    public static List<Organization> MapToOrganizations(this List<UserOrganization> response)
    {
        List<Organization> mappedData = new();
        foreach (var userOrganization in response)
        {
            mappedData.Add(new Organization()
            {
                Name = userOrganization.Name,
                Id = userOrganization.Id,
                Desc = userOrganization.Desc
            });
        }

        return mappedData;
    }
    
    public static Organization MapToOrganization(this UpdateOrganizationResponse response)
    {
        return new Organization()
        {
            Name = response.Name,
            Id = response.Id,
            Desc = response.Desc
        };
    }
}