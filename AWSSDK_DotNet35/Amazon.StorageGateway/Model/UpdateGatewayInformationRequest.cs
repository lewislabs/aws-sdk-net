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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGatewayInformation operation.
    /// 
    /// </summary>
    public partial class UpdateGatewayInformationRequest : AmazonWebServiceRequest
    {
        private string gatewayARN;
        private string gatewayName;
        private GatewayTimezone gatewayTimezone;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }

        /// <summary>
        /// A unique identifier for your gateway. This name becomes part of the gateway Amazon Resources Name (ARN) which is what you use as an input to
        /// other operations.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^[ -\.0-\[\]-~]*[!-\.0-\[\]-~][ -\.0-\[\]-~]*$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayName
        {
            get { return this.gatewayName; }
            set { this.gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this.gatewayName != null;
        }

        /// <summary>
        /// One of the values that represents the time zone for your gateway. The time zone is used, for example, when a time stamp is given to a
        /// snapshot.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>GMT-12:00, GMT-11:00, GMT-10:00, GMT-9:00, GMT-8:00, GMT-7:00, GMT-6:00, GMT-5:00, GMT-4:00, GMT-3:30, GMT-3:00, GMT-2:00, GMT-1:00, GMT, GMT+1:00, GMT+2:00, GMT+3:00, GMT+3:30, GMT+4:00, GMT+4:30, GMT+5:00, GMT+5:30, GMT+5:45, GMT+6:00, GMT+7:00, GMT+8:00, GMT+9:00, GMT+9:30, GMT+10:00, GMT+11:00, GMT+12:00</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public GatewayTimezone GatewayTimezone
        {
            get { return this.gatewayTimezone; }
            set { this.gatewayTimezone = value; }
        }

        // Check to see if GatewayTimezone property is set
        internal bool IsSetGatewayTimezone()
        {
            return this.gatewayTimezone != null;
        }

    }
}
    
