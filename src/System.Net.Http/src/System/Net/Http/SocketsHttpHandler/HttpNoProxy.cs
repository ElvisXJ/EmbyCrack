// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Net.Http
{
    internal sealed class HttpNoProxy : IWebProxy
    {
        public ICredentials Credentials { get; set; }
        public Uri GetProxy(Uri destination) => null;
        public bool IsBypassed(Uri host) => true;
    }
}
