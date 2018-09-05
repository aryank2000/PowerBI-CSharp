// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Groups operations.
    /// </summary>
    public partial interface IGroups
    {
        /// <summary>
        /// Returns a list of workspaces the user has access to.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Group.Read.All or
        /// Group.ReadWrite.All or Workspace.Read.All or
        /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='filter'>
        /// Filters the results, based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListGroup>> GetGroupsWithHttpMessagesAsync(string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates new workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Group.Read.All or
        /// Group.ReadWrite.All or Workspace.Read.All or
        /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='requestParameters'>
        /// Create group request parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Group>> CreateGroupWithHttpMessagesAsync(GroupCreationRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Group.Read.All or
        /// Group.ReadWrite.All or Workspace.Read.All or
        /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> DeleteGroupWithHttpMessagesAsync(string groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of users that have access to the specified
        /// workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Group.Read.All or
        /// Group.ReadWrite.All or Workspace.Read.All or
        /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListGroupUserAccessRight>> GetGroupUsersWithHttpMessagesAsync(string groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Grants the specified user permissions to the specified workspace.
        /// </summary>
        /// <remarks>
        /// **Note**: Only Admin access right is supported.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Group.Read.All or
        /// Group.ReadWrite.All or Workspace.Read.All or
        /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='userDetails'>
        /// Details of user access right
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> AddGroupUserWithHttpMessagesAsync(string groupId, GroupUserAccessRight userDetails, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified user permissions from the specified
        /// workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: Group.Read.All or
        /// Group.ReadWrite.All or Workspace.Read.All or
        /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='user'>
        /// The email adress of the user to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> DeleteUserInGroupWithHttpMessagesAsync(string groupId, string user, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Assigns **"My Workspace"** to the specified capacity.
        /// </summary>
        /// <remarks>
        /// **Note**: To perform this operation, the user must have admin or
        /// assign permissions on the capacity. To unassign **"My Workspace"**
        /// from a capacity, Empty Guid (00000000-0000-0000-0000-000000000000)
        /// should be provided as capacityId.  &lt;br/&gt;&lt;br/&gt;**Required
        /// scope**: Capacity.ReadWrite.All and Workspace.ReadWrite.All.
        /// &lt;br/&gt;To set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='requestParameters'>
        /// Assign to capacity parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> AssignMyWorkspaceToCapacityWithHttpMessagesAsync(AssignToCapacityRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Assigns the specified workspace to the specified capacity.
        /// </summary>
        /// <remarks>
        /// **Note**: To perform this operation, the user must be admin on the
        /// specified workspace and have admin or assign permissions on the
        /// capacity. To unassign the specified workspace from a capacity,
        /// Empty Guid (00000000-0000-0000-0000-000000000000) should be
        /// provided as capacityId.  &lt;br/&gt;&lt;br/&gt;**Required scope**:
        /// Capacity.ReadWrite.All and Workspace.ReadWrite.All. &lt;br/&gt;To
        /// set the permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='requestParameters'>
        /// Assign to capacity parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> AssignToCapacityWithHttpMessagesAsync(string groupId, AssignToCapacityRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of workspaces for the organization.
        /// </summary>
        /// <remarks>
        /// **Note:** The user must have administrator rights (such as Office
        /// 365 Global Administrator or Power BI Service Administrator) to call
        /// this API. &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All
        /// or Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline
        /// </param>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataResponseListGroup>> GetGroupsAsAdminWithHttpMessagesAsync(string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified workspace properties.
        /// </summary>
        /// <remarks>
        /// **Note**: This API is currently limited to updating workspaces in
        /// the new workspace experience. Only name and description can be
        /// updated, and name must be unique inside an organization. The user
        /// must have administrator rights (such as Office 365 Global
        /// Administrator or Power BI Service Administrator) to call this API.
        /// &lt;br/&gt;&lt;br/&gt;**Required scope**:
        /// Tenant.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
        /// [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='groupProperties'>
        /// The properties to update
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> UpdateGroupAsAdminWithHttpMessagesAsync(string groupId, Group groupProperties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Grants user permissions to the specified workspace.
        /// </summary>
        /// <remarks>
        /// **Note:** This API is currently limited to updating workspaces in
        /// the new workspace experience. The user must have administrator
        /// rights (such as Office 365 Global Administrator or Power BI Service
        /// Administrator) to call this API. &lt;br/&gt;&lt;br/&gt;**Required
        /// scope**: Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
        /// scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='userDetails'>
        /// Details of user access right
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> AddUserAsAdminWithHttpMessagesAsync(string groupId, GroupUserAccessRight userDetails, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes user permissions to the specified workspace.
        /// </summary>
        /// <remarks>
        /// **Note:** This API is currently limited to updating workspaces in
        /// the new workspace experience. The user must have administrator
        /// rights (such as Office 365 Global Administrator or Power BI Service
        /// Administrator) to call this API. &lt;br/&gt;&lt;br/&gt;**Required
        /// scope**: Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
        /// scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='user'>
        /// The user principal name (UPN) of the user to remove (usually the
        /// user's email)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> DeleteUserAsAdminWithHttpMessagesAsync(string groupId, string user, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Restores a deleted workspace.
        /// </summary>
        /// <remarks>
        /// **Note**: This API is currently limited to restoring workspaces in
        /// the new workspace experience. The user must have administrator
        /// rights (such as Office 365 Global Administrator or Power BI Service
        /// Administrator) to call this API. &lt;br/&gt;&lt;br/&gt;**Required
        /// scope**: Tenant.ReadWrite.All&lt;br/&gt;To set the permissions
        /// scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace id
        /// </param>
        /// <param name='groupRestoreRequest'>
        /// Details of the group restore request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<object>> RestoreDeletedGroupAsAdminWithHttpMessagesAsync(string groupId, GroupRestoreRequest groupRestoreRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
