// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
** Class:  SafeProcessHandle 
**
** A wrapper for a process handle
**
** 
===========================================================*/

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles
{
    public sealed partial class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private const int DefaultInvalidHandleValue = 0;

        [SecurityCritical]
        protected override bool ReleaseHandle()
        {
            return Interop.mincore.CloseHandle(handle);
        }
    }
}
