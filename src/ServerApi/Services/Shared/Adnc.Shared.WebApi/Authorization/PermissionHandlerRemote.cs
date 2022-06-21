﻿using Adnc.Shared.Rpc.Rest.Services;

namespace Adnc.Shared.WebApi.Authentication;

public sealed class PermissionHandlerRemote : AbstractPermissionHandler
{
    private readonly IUsrRestClient _usrRestClient;

    public PermissionHandlerRemote(IUsrRestClient usrRestClient) => _usrRestClient = usrRestClient;

    protected override async Task<bool> CheckUserPermissions(long userId, IEnumerable<string> requestPermissions, string userBelongsRoleIds)
    {
        //var jwtToken = await _contextAccessor.HttpContext.GetTokenAsync("access_token");
        //var refitResult = await _authRpcService.GetCurrenUserPermissions($"Bearer {jwtToken}", userId, codes);
        var restResult = await _usrRestClient.GetCurrenUserPermissionsAsync(userId, requestPermissions, userBelongsRoleIds);
        if (!restResult.IsSuccessStatusCode)
            return false;

        return restResult.Content.IsNotNullOrEmpty();
    }
}