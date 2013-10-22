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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBParameterGroup operation.
    /// <para> Modifies the parameters of a DB parameter group. To modify more than one parameter, submit a list of the following:
    /// <c>ParameterName</c> ,
    /// <c>ParameterValue</c> , and <c>ApplyMethod</c> . A maximum of 20 parameters can be modified in a single request. </para>
    /// <para><b>NOTE:</b> The apply-immediate method can be used only for dynamic parameters; the pending-reboot method can be used with MySQL and
    /// Oracle DB instances for either dynamic or static parameters. For Microsoft SQL Server DB instances, the pending-reboot method can be used
    /// only for static parameters. </para>
    /// </summary>
    public partial class ModifyDBParameterGroupRequest : AmazonWebServiceRequest
    {
        private string dBParameterGroupName;
        private List<Parameter> parameters = new List<Parameter>();

        /// <summary>
        /// The name of the DB parameter group. Constraints: <ul> <li>Must be the name of an existing DB parameter group</li> <li>Must be 1 to 255
        /// alphanumeric characters</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul>
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;
        }

        /// <summary>
        /// An array of parameter names, values, and the apply method for the parameter update. At least one parameter name, value, and apply method
        /// must be supplied; subsequent arguments are optional. A maximum of 20 parameters may be modified in a single request. Valid Values (for the
        /// application method): <c>immediate | pending-reboot</c> <note>You can use the immediate value with dynamic parameters only. You can use the
        /// pending-reboot value for both dynamic and static parameters, and changes are applied when DB instance reboots. </note>
        ///  
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this.parameters.Count > 0;
        }

    }
}
    
