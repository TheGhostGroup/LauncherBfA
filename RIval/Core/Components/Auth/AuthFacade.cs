﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIval.Core.Components.Auth
{
    public class AuthFacade : Singleton<AuthFacade>
    {
        public Types.AuthResult Attempt(string user, string password)
        {
            return default;
        }
    }
}