//*****************************************************************************
//* Project: Firefly (Microsoft Hackaton 2020)
//* Description: AOLUSS REST Client
//* Author: Mark West (mark.west@microsoft.com)
//*****************************************************************************

/* 
 * NASA AOLUSS Operator interface
 *
 * this OAS document describes the operator interface for the AOLUSS.
 *
 * OpenAPI spec version: 2.1.8
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AolussClientLib.Client.SwaggerDateConverter;

namespace AolussClientLib.Model
{
    /// <summary>
    /// ModelPriorityElements
    /// </summary>
    [DataContract]
        public partial class ModelPriorityElements :  IEquatable<ModelPriorityElements>, IValidatableObject
    {
        /// <summary>
        /// Defines PriorityLevel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PriorityLevelEnum
        {
            /// <summary>
            /// Enum EMERGENCY for value: EMERGENCY
            /// </summary>
            [EnumMember(Value = "EMERGENCY")]
            EMERGENCY = 1,
            /// <summary>
            /// Enum ALERT for value: ALERT
            /// </summary>
            [EnumMember(Value = "ALERT")]
            ALERT = 2,
            /// <summary>
            /// Enum CRITICAL for value: CRITICAL
            /// </summary>
            [EnumMember(Value = "CRITICAL")]
            CRITICAL = 3,
            /// <summary>
            /// Enum WARNING for value: WARNING
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING = 4,
            /// <summary>
            /// Enum NOTICE for value: NOTICE
            /// </summary>
            [EnumMember(Value = "NOTICE")]
            NOTICE = 5,
            /// <summary>
            /// Enum INFORMATIONAL for value: INFORMATIONAL
            /// </summary>
            [EnumMember(Value = "INFORMATIONAL")]
            INFORMATIONAL = 6        }
        /// <summary>
        /// Gets or Sets PriorityLevel
        /// </summary>
        [DataMember(Name="priority_level", EmitDefaultValue=false)]
        public PriorityLevelEnum PriorityLevel { get; set; }
        /// <summary>
        /// Defines PriorityStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PriorityStatusEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,
            /// <summary>
            /// Enum PUBLICSAFETY for value: PUBLIC_SAFETY
            /// </summary>
            [EnumMember(Value = "PUBLIC_SAFETY")]
            PUBLICSAFETY = 2,
            /// <summary>
            /// Enum EMERGENCYAIRBORNEIMPACT for value: EMERGENCY_AIRBORNE_IMPACT
            /// </summary>
            [EnumMember(Value = "EMERGENCY_AIRBORNE_IMPACT")]
            EMERGENCYAIRBORNEIMPACT = 3,
            /// <summary>
            /// Enum EMERGENCYGROUNDIMPACT for value: EMERGENCY_GROUND_IMPACT
            /// </summary>
            [EnumMember(Value = "EMERGENCY_GROUND_IMPACT")]
            EMERGENCYGROUNDIMPACT = 4,
            /// <summary>
            /// Enum EMERGENCYAIRANDGROUNDIMPACT for value: EMERGENCY_AIR_AND_GROUND_IMPACT
            /// </summary>
            [EnumMember(Value = "EMERGENCY_AIR_AND_GROUND_IMPACT")]
            EMERGENCYAIRANDGROUNDIMPACT = 5        }
        /// <summary>
        /// Gets or Sets PriorityStatus
        /// </summary>
        [DataMember(Name="priority_status", EmitDefaultValue=false)]
        public PriorityStatusEnum PriorityStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriorityElements" /> class.
        /// </summary>
        /// <param name="priorityLevel">priorityLevel (required).</param>
        /// <param name="priorityStatus">priorityStatus (required).</param>
        public ModelPriorityElements(PriorityLevelEnum priorityLevel = default(PriorityLevelEnum), PriorityStatusEnum priorityStatus = default(PriorityStatusEnum))
        {
            // to ensure "priorityLevel" is required (not null)
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (priorityLevel == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new InvalidDataException("priorityLevel is a required property for ModelPriorityElements and cannot be null");
            }
            else
            {
                this.PriorityLevel = priorityLevel;
            }
            // to ensure "priorityStatus" is required (not null)
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (priorityStatus == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new InvalidDataException("priorityStatus is a required property for ModelPriorityElements and cannot be null");
            }
            else
            {
                this.PriorityStatus = priorityStatus;
            }
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelPriorityElements {\n");
            sb.Append("  PriorityLevel: ").Append(PriorityLevel).Append("\n");
            sb.Append("  PriorityStatus: ").Append(PriorityStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelPriorityElements);
        }

        /// <summary>
        /// Returns true if ModelPriorityElements instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelPriorityElements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelPriorityElements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PriorityLevel == input.PriorityLevel ||
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    (this.PriorityLevel != null &&
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    this.PriorityLevel.Equals(input.PriorityLevel))
                ) && 
                (
                    this.PriorityStatus == input.PriorityStatus ||
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    (this.PriorityStatus != null &&
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    this.PriorityStatus.Equals(input.PriorityStatus))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (this.PriorityLevel != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    hashCode = hashCode * 59 + this.PriorityLevel.GetHashCode();
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (this.PriorityStatus != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    hashCode = hashCode * 59 + this.PriorityStatus.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
