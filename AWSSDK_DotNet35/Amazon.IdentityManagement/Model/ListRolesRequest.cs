/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListRoles operation.
    /// <para>Lists the roles that have the specified path prefix. If there are none, the action returns an empty list. For more information about
    /// roles, go to <a href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .</para>
    /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>The returned policy is URL-encoded
    /// according to RFC 3986. For more information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html"
    /// >http://www.faqs.org/rfcs/rfc3986.html</a> .</para>
    /// </summary>
    public partial class ListRolesRequest : AmazonWebServiceRequest
    {
        private string pathPrefix;
        private string marker;
        private int? maxItems;

        /// <summary>
        /// The path prefix for filtering the results. For example: <c>/application_abc/component_xyz/</c>, which would get all roles whose path starts
        /// with <c>/application_abc/component_xyz/</c>. This parameter is optional. If it is not included, it defaults to a slash (/), listing all
        /// roles.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\u002F[\u0021-\u007F]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PathPrefix
        {
            get { return this.pathPrefix; }
            set { this.pathPrefix = value; }
        }

        // Check to see if PathPrefix property is set
        internal bool IsSetPathPrefix()
        {
            return this.pathPrefix != null;
        }

        /// <summary>
        /// Use this parameter only when paginating results, and only in a subsequent request after you've received a response where the results are
        /// truncated. Set it to the value of the <c>Marker</c> element in the response you just received.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 320</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// Use this parameter only when paginating results to indicate the maximum number of user names you want in the response. If there are
        /// additional user names beyond the maximum you specify, the <c>IsTruncated</c> response element is <c>true</c>. This parameter is optional. If
        /// you do not include it, it defaults to 100.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this.maxItems ?? default(int); }
            set { this.maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems.HasValue;
        }

    }
}
    
