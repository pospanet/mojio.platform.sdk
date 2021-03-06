﻿using Mojio.Platform.SDK.Contracts;
using Mojio.Platform.SDK.Contracts.Client;
using Mojio.Platform.SDK.Contracts.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mojio.Platform.SDK
{
    public partial class Client
    {
        public async Task<IPlatformResponse<IUser>> Me(CancellationToken? cancellationToken = null, IProgress<ISDKProgress> progress = null)
        {
            var tokenP = IssueNewTokenAndProgressContainer(cancellationToken, progress);

            if ((await Login(Authorization, cancellationToken, progress)).Success)
            {
                return await CacheHitOrMiss($"Me.{Authorization.UserName}", () => _clientBuilder.Request<IUser>(ApiEndpoint.Api, "v2/me", tokenP.CancellationToken, tokenP.Progress), TimeSpan.FromMinutes(60));
            }
            _log.Fatal(new Exception("Authorization Failed"));
            return await Task.FromResult<IPlatformResponse<IUser>>(null);
        }
    }
}