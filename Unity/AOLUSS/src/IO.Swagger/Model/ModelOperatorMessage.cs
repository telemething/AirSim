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
    /// ModelOperatorMessage
    /// </summary>
    [DataContract]
        public partial class ModelOperatorMessage :  IEquatable<ModelOperatorMessage>, IValidatableObject
    {
        /// <summary>
        /// Defines Severity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SeverityEnum
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
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// Defines MessageType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MessageTypeEnum
        {
            /// <summary>
            /// Enum UNPLANNEDLANDING for value: UNPLANNED_LANDING
            /// </summary>
            [EnumMember(Value = "UNPLANNED_LANDING")]
            UNPLANNEDLANDING = 1,
            /// <summary>
            /// Enum UNCONTROLLEDLANDING for value: UNCONTROLLED_LANDING
            /// </summary>
            [EnumMember(Value = "UNCONTROLLED_LANDING")]
            UNCONTROLLEDLANDING = 2,
            /// <summary>
            /// Enum OPERATIONNONCONFORMING for value: OPERATION_NONCONFORMING
            /// </summary>
            [EnumMember(Value = "OPERATION_NONCONFORMING")]
            OPERATIONNONCONFORMING = 3,
            /// <summary>
            /// Enum OPERATIONROGUE for value: OPERATION_ROGUE
            /// </summary>
            [EnumMember(Value = "OPERATION_ROGUE")]
            OPERATIONROGUE = 4,
            /// <summary>
            /// Enum OPERATIONCONFORMING for value: OPERATION_CONFORMING
            /// </summary>
            [EnumMember(Value = "OPERATION_CONFORMING")]
            OPERATIONCONFORMING = 5,
            /// <summary>
            /// Enum OPERATIONCLOSED for value: OPERATION_CLOSED
            /// </summary>
            [EnumMember(Value = "OPERATION_CLOSED")]
            OPERATIONCLOSED = 6,
            /// <summary>
            /// Enum CONTINGENCYPLANINITIATED for value: CONTINGENCY_PLAN_INITIATED
            /// </summary>
            [EnumMember(Value = "CONTINGENCY_PLAN_INITIATED")]
            CONTINGENCYPLANINITIATED = 7,
            /// <summary>
            /// Enum CONTINGENCYPLANCANCELLED for value: CONTINGENCY_PLAN_CANCELLED
            /// </summary>
            [EnumMember(Value = "CONTINGENCY_PLAN_CANCELLED")]
            CONTINGENCYPLANCANCELLED = 8,
            /// <summary>
            /// Enum PERIODICPOSITIONREPORTSSTART for value: PERIODIC_POSITION_REPORTS_START
            /// </summary>
            [EnumMember(Value = "PERIODIC_POSITION_REPORTS_START")]
            PERIODICPOSITIONREPORTSSTART = 9,
            /// <summary>
            /// Enum PERIODICPOSITIONREPORTSEND for value: PERIODIC_POSITION_REPORTS_END
            /// </summary>
            [EnumMember(Value = "PERIODIC_POSITION_REPORTS_END")]
            PERIODICPOSITIONREPORTSEND = 10,
            /// <summary>
            /// Enum UNAUTHORIZEDAIRSPACEPROXIMITY for value: UNAUTHORIZED_AIRSPACE_PROXIMITY
            /// </summary>
            [EnumMember(Value = "UNAUTHORIZED_AIRSPACE_PROXIMITY")]
            UNAUTHORIZEDAIRSPACEPROXIMITY = 11,
            /// <summary>
            /// Enum UNAUTHORIZEDAIRSPACEENTRY for value: UNAUTHORIZED_AIRSPACE_ENTRY
            /// </summary>
            [EnumMember(Value = "UNAUTHORIZED_AIRSPACE_ENTRY")]
            UNAUTHORIZEDAIRSPACEENTRY = 12,
            /// <summary>
            /// Enum OTHERSEEFREETEXT for value: OTHER_SEE_FREE_TEXT
            /// </summary>
            [EnumMember(Value = "OTHER_SEE_FREE_TEXT")]
            OTHERSEEFREETEXT = 13        }
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="message_type", EmitDefaultValue=false)]
        public MessageTypeEnum MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelOperatorMessage" /> class.
        /// </summary>
        /// <param name="messageId">messageId (required).</param>
        /// <param name="gufi">The referenced flight GUFI..</param>
        /// <param name="timeSent">timeSent (required).</param>
        /// <param name="severity">severity (required).</param>
        /// <param name="messageType">messageType (required).</param>
        /// <param name="prevMessageId">prevMessageId.</param>
        /// <param name="freeText">freeText.</param>
        public ModelOperatorMessage(Guid? messageId = default(Guid?), Guid? gufi = default(Guid?), DateTime? timeSent = default(DateTime?), SeverityEnum severity = default(SeverityEnum), MessageTypeEnum messageType = default(MessageTypeEnum), Guid? prevMessageId = default(Guid?), string freeText = default(string))
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for ModelOperatorMessage and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }
            // to ensure "timeSent" is required (not null)
            if (timeSent == null)
            {
                throw new InvalidDataException("timeSent is a required property for ModelOperatorMessage and cannot be null");
            }
            else
            {
                this.TimeSent = timeSent;
            }
            // to ensure "severity" is required (not null)
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (severity == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new InvalidDataException("severity is a required property for ModelOperatorMessage and cannot be null");
            }
            else
            {
                this.Severity = severity;
            }
            // to ensure "messageType" is required (not null)
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (messageType == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new InvalidDataException("messageType is a required property for ModelOperatorMessage and cannot be null");
            }
            else
            {
                this.MessageType = messageType;
            }
            this.Gufi = gufi;
            this.PrevMessageId = prevMessageId;
            this.FreeText = freeText;
        }
        
        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public Guid? MessageId { get; set; }

        /// <summary>
        /// The referenced flight GUFI.
        /// </summary>
        /// <value>The referenced flight GUFI.</value>
        [DataMember(Name="gufi", EmitDefaultValue=false)]
        public Guid? Gufi { get; set; }

        /// <summary>
        /// Gets or Sets TimeSent
        /// </summary>
        [DataMember(Name="time_sent", EmitDefaultValue=false)]
        public DateTime? TimeSent { get; set; }



        /// <summary>
        /// Gets or Sets PrevMessageId
        /// </summary>
        [DataMember(Name="prev_message_id", EmitDefaultValue=false)]
        public Guid? PrevMessageId { get; set; }

        /// <summary>
        /// Gets or Sets FreeText
        /// </summary>
        [DataMember(Name="free_text", EmitDefaultValue=false)]
        public string FreeText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelOperatorMessage {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Gufi: ").Append(Gufi).Append("\n");
            sb.Append("  TimeSent: ").Append(TimeSent).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  PrevMessageId: ").Append(PrevMessageId).Append("\n");
            sb.Append("  FreeText: ").Append(FreeText).Append("\n");
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
            return this.Equals(input as ModelOperatorMessage);
        }

        /// <summary>
        /// Returns true if ModelOperatorMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelOperatorMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelOperatorMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Gufi == input.Gufi ||
                    (this.Gufi != null &&
                    this.Gufi.Equals(input.Gufi))
                ) && 
                (
                    this.TimeSent == input.TimeSent ||
                    (this.TimeSent != null &&
                    this.TimeSent.Equals(input.TimeSent))
                ) && 
                (
                    this.Severity == input.Severity ||
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    (this.Severity != null &&
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.MessageType == input.MessageType ||
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    (this.MessageType != null &&
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.PrevMessageId == input.PrevMessageId ||
                    (this.PrevMessageId != null &&
                    this.PrevMessageId.Equals(input.PrevMessageId))
                ) && 
                (
                    this.FreeText == input.FreeText ||
                    (this.FreeText != null &&
                    this.FreeText.Equals(input.FreeText))
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
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Gufi != null)
                    hashCode = hashCode * 59 + this.Gufi.GetHashCode();
                if (this.TimeSent != null)
                    hashCode = hashCode * 59 + this.TimeSent.GetHashCode();
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (this.Severity != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (this.MessageType != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.PrevMessageId != null)
                    hashCode = hashCode * 59 + this.PrevMessageId.GetHashCode();
                if (this.FreeText != null)
                    hashCode = hashCode * 59 + this.FreeText.GetHashCode();
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
