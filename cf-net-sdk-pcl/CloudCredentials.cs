﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2
{
    /// <summary>
    /// Credentials of the target cloud
    /// </summary>
    public class CloudCredentials
    {
        /// <summary>
        /// UserName 
        /// </summary>
        public string User {
            get;
            set;
        }

        /// <summary>
        /// Password
        /// </summary>
        public string Password{
            get;
            set;
        }
    }
}
