#region License

// The MIT License (MIT)
// 
// Copyright (c) 2017 Werner Strydom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#endregion

namespace Vema.Data
{
    /// <summary>
    ///     Represents an identity store
    /// </summary>
    /// <remarks>
    ///     Identity stores contains identities that are used to sign into other systems. An example would be an Azure Active
    ///     Directory. If a user has credentials in that directory, the user can then login to the Azure Portal.
    ///     Another example may include an LDAP server. Users can access a computer using the credentials stored in that
    ///     directory.
    /// </remarks>
    public class IdentityStore
    {
        /// <summary>
        ///     Gets or sets the internal id of the identity store
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the display name of the identity store
        /// </summary>
        public string DisplayName { get; set; }
    }
}