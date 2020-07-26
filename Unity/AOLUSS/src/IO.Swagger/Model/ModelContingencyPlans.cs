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
    /// ModelContingencyPlans
    /// </summary>
    [DataContract]
        public partial class ModelContingencyPlans :  IEquatable<ModelContingencyPlans>, IValidatableObject
    {
        /// <summary>
        /// Defines ContingencyResponse
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ContingencyResponseEnum
        {
            /// <summary>
            /// Enum LANDING for value: LANDING
            /// </summary>
            [EnumMember(Value = "LANDING")]
            LANDING = 1,
            /// <summary>
            /// Enum LOITERING for value: LOITERING
            /// </summary>
            [EnumMember(Value = "LOITERING")]
            LOITERING = 2,
            /// <summary>
            /// Enum RETURNTOBASE for value: RETURN_TO_BASE
            /// </summary>
            [EnumMember(Value = "RETURN_TO_BASE")]
            RETURNTOBASE = 3,
            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 4        }
        /// <summary>
        /// Gets or Sets ContingencyResponse
        /// </summary>
        [DataMember(Name="contingency_response", EmitDefaultValue=false)]
        public ContingencyResponseEnum ContingencyResponse { get; set; }
        /// <summary>
        /// Defines ContingencyLocationDescription
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ContingencyLocationDescriptionEnum
        {
            /// <summary>
            /// Enum PREPROGRAMMED for value: PREPROGRAMMED
            /// </summary>
            [EnumMember(Value = "PREPROGRAMMED")]
            PREPROGRAMMED = 1,
            /// <summary>
            /// Enum OPERATORUPDATED for value: OPERATOR_UPDATED
            /// </summary>
            [EnumMember(Value = "OPERATOR_UPDATED")]
            OPERATORUPDATED = 2,
            /// <summary>
            /// Enum UAIDENTIFIED for value: UA_IDENTIFIED
            /// </summary>
            [EnumMember(Value = "UA_IDENTIFIED")]
            UAIDENTIFIED = 3,
            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 4        }
        /// <summary>
        /// Gets or Sets ContingencyLocationDescription
        /// </summary>
        [DataMember(Name="contingency_location_description", EmitDefaultValue=false)]
        public ContingencyLocationDescriptionEnum ContingencyLocationDescription { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelContingencyPlans" /> class.
        /// </summary>
        /// <param name="contingencyId">contingencyId (required).</param>
        /// <param name="contingencyCause">contingencyCause (required).</param>
        /// <param name="contingencyResponse">contingencyResponse (required).</param>
        /// <param name="contingencyPolygon">contingencyPolygon (required).</param>
        /// <param name="loiterAltitude">loiterAltitude.</param>
        /// <param name="relativePreference">relativePreference.</param>
        /// <param name="contingencyLocationDescription">contingencyLocationDescription (required).</param>
        /// <param name="relevantOperationVolumes">relevantOperationVolumes.</param>
        /// <param name="validTimeBegin">validTimeBegin (required).</param>
        /// <param name="validTimeEnd">validTimeEnd (required).</param>
        /// <param name="freeText">freeText.</param>
        public ModelContingencyPlans(int? contingencyId = default(int?), List<string> contingencyCause = default(List<string>), ContingencyResponseEnum contingencyResponse = default(ContingencyResponseEnum), GeojsonPolygon2D contingencyPolygon = default(GeojsonPolygon2D), ModelAltitudeFixm loiterAltitude = default(ModelAltitudeFixm), decimal? relativePreference = default(decimal?), ContingencyLocationDescriptionEnum contingencyLocationDescription = default(ContingencyLocationDescriptionEnum), List<int?> relevantOperationVolumes = default(List<int?>), DateTime? validTimeBegin = default(DateTime?), DateTime? validTimeEnd = default(DateTime?), string freeText = default(string))
        {
            // to ensure "contingencyId" is required (not null)
            if (contingencyId == null)
            {
                throw new InvalidDataException("contingencyId is a required property for ModelContingencyPlans and cannot be null");
            }
            else
            {
                this.ContingencyId = contingencyId;
            }
            // to ensure "contingencyCause" is required (not null)
            if (contingencyCause == null)
            {
                throw new InvalidDataException("contingencyCause is a required property for ModelContingencyPlans and cannot be null");
            }
            else
            {
                this.ContingencyCause = contingencyCause;
            }
            // to ensure "contingencyResponse" is required (not null)
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (contingencyResponse == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new InvalidDataException("contingencyResponse is a required property for ModelContingencyPlans and cannot be null");
            }
            else
            {
                this.ContingencyResponse = contingencyResponse;
            }
            // to ensure "contingencyPolygon" is required (not null)
            if (contingencyPolygon == null)
            {
                throw new InvalidDataException("contingencyPolygon is a required property for ModelContingencyPlans and cannot be null");
            }
            else
            {
                this.ContingencyPolygon = contingencyPolygon;
            }
            // to ensure "contingencyLocationDescription" is required (not null)
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (contingencyLocationDescription == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new InvalidDataException("contingencyLocationDescription is a required property for ModelContingencyPlans and cannot be null");
            }
            else
            {
                this.ContingencyLocationDescription = contingencyLocationDescription;
            }
            // to ensure "validTimeBegin" is required (not null)
            if (validTimeBegin == null)
            {
                throw new InvalidDataException("validTimeBegin is a required property for ModelContingencyPlans and cannot be null");
            }
            else
            {
                this.ValidTimeBegin = validTimeBegin;
            }
            // to ensure "validTimeEnd" is required (not null)
            if (validTimeEnd == null)
            {
                throw new InvalidDataException("validTimeEnd is a required property for ModelContingencyPlans and cannot be null");
            }
            else
            {
                this.ValidTimeEnd = validTimeEnd;
            }
            this.LoiterAltitude = loiterAltitude;
            this.RelativePreference = relativePreference;
            this.RelevantOperationVolumes = relevantOperationVolumes;
            this.FreeText = freeText;
        }
        
        /// <summary>
        /// Gets or Sets ContingencyId
        /// </summary>
        [DataMember(Name="contingency_id", EmitDefaultValue=false)]
        public int? ContingencyId { get; set; }

        /// <summary>
        /// Gets or Sets ContingencyCause
        /// </summary>
        [DataMember(Name="contingency_cause", EmitDefaultValue=false)]
        public List<string> ContingencyCause { get; set; }


        /// <summary>
        /// Gets or Sets ContingencyPolygon
        /// </summary>
        [DataMember(Name="contingency_polygon", EmitDefaultValue=false)]
        public GeojsonPolygon2D ContingencyPolygon { get; set; }

        /// <summary>
        /// Gets or Sets LoiterAltitude
        /// </summary>
        [DataMember(Name="loiter_altitude", EmitDefaultValue=false)]
        public ModelAltitudeFixm LoiterAltitude { get; set; }

        /// <summary>
        /// Gets or Sets RelativePreference
        /// </summary>
        [DataMember(Name="relative_preference", EmitDefaultValue=false)]
        public decimal? RelativePreference { get; set; }


        /// <summary>
        /// Gets or Sets RelevantOperationVolumes
        /// </summary>
        [DataMember(Name="relevant_operation_volumes", EmitDefaultValue=false)]
        public List<int?> RelevantOperationVolumes { get; set; }

        /// <summary>
        /// Gets or Sets ValidTimeBegin
        /// </summary>
        [DataMember(Name="valid_time_begin", EmitDefaultValue=false)]
        public DateTime? ValidTimeBegin { get; set; }

        /// <summary>
        /// Gets or Sets ValidTimeEnd
        /// </summary>
        [DataMember(Name="valid_time_end", EmitDefaultValue=false)]
        public DateTime? ValidTimeEnd { get; set; }

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
            sb.Append("class ModelContingencyPlans {\n");
            sb.Append("  ContingencyId: ").Append(ContingencyId).Append("\n");
            sb.Append("  ContingencyCause: ").Append(ContingencyCause).Append("\n");
            sb.Append("  ContingencyResponse: ").Append(ContingencyResponse).Append("\n");
            sb.Append("  ContingencyPolygon: ").Append(ContingencyPolygon).Append("\n");
            sb.Append("  LoiterAltitude: ").Append(LoiterAltitude).Append("\n");
            sb.Append("  RelativePreference: ").Append(RelativePreference).Append("\n");
            sb.Append("  ContingencyLocationDescription: ").Append(ContingencyLocationDescription).Append("\n");
            sb.Append("  RelevantOperationVolumes: ").Append(RelevantOperationVolumes).Append("\n");
            sb.Append("  ValidTimeBegin: ").Append(ValidTimeBegin).Append("\n");
            sb.Append("  ValidTimeEnd: ").Append(ValidTimeEnd).Append("\n");
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
            return this.Equals(input as ModelContingencyPlans);
        }

        /// <summary>
        /// Returns true if ModelContingencyPlans instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelContingencyPlans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelContingencyPlans input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContingencyId == input.ContingencyId ||
                    (this.ContingencyId != null &&
                    this.ContingencyId.Equals(input.ContingencyId))
                ) && 
                (
                    this.ContingencyCause == input.ContingencyCause ||
                    this.ContingencyCause != null &&
                    input.ContingencyCause != null &&
                    this.ContingencyCause.SequenceEqual(input.ContingencyCause)
                ) && 
                (
                    this.ContingencyResponse == input.ContingencyResponse ||
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    (this.ContingencyResponse != null &&
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    this.ContingencyResponse.Equals(input.ContingencyResponse))
                ) && 
                (
                    this.ContingencyPolygon == input.ContingencyPolygon ||
                    (this.ContingencyPolygon != null &&
                    this.ContingencyPolygon.Equals(input.ContingencyPolygon))
                ) && 
                (
                    this.LoiterAltitude == input.LoiterAltitude ||
                    (this.LoiterAltitude != null &&
                    this.LoiterAltitude.Equals(input.LoiterAltitude))
                ) && 
                (
                    this.RelativePreference == input.RelativePreference ||
                    (this.RelativePreference != null &&
                    this.RelativePreference.Equals(input.RelativePreference))
                ) && 
                (
                    this.ContingencyLocationDescription == input.ContingencyLocationDescription ||
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    (this.ContingencyLocationDescription != null &&
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    this.ContingencyLocationDescription.Equals(input.ContingencyLocationDescription))
                ) && 
                (
                    this.RelevantOperationVolumes == input.RelevantOperationVolumes ||
                    this.RelevantOperationVolumes != null &&
                    input.RelevantOperationVolumes != null &&
                    this.RelevantOperationVolumes.SequenceEqual(input.RelevantOperationVolumes)
                ) && 
                (
                    this.ValidTimeBegin == input.ValidTimeBegin ||
                    (this.ValidTimeBegin != null &&
                    this.ValidTimeBegin.Equals(input.ValidTimeBegin))
                ) && 
                (
                    this.ValidTimeEnd == input.ValidTimeEnd ||
                    (this.ValidTimeEnd != null &&
                    this.ValidTimeEnd.Equals(input.ValidTimeEnd))
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
                if (this.ContingencyId != null)
                    hashCode = hashCode * 59 + this.ContingencyId.GetHashCode();
                if (this.ContingencyCause != null)
                    hashCode = hashCode * 59 + this.ContingencyCause.GetHashCode();
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (this.ContingencyResponse != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    hashCode = hashCode * 59 + this.ContingencyResponse.GetHashCode();
                if (this.ContingencyPolygon != null)
                    hashCode = hashCode * 59 + this.ContingencyPolygon.GetHashCode();
                if (this.LoiterAltitude != null)
                    hashCode = hashCode * 59 + this.LoiterAltitude.GetHashCode();
                if (this.RelativePreference != null)
                    hashCode = hashCode * 59 + this.RelativePreference.GetHashCode();
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                if (this.ContingencyLocationDescription != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    hashCode = hashCode * 59 + this.ContingencyLocationDescription.GetHashCode();
                if (this.RelevantOperationVolumes != null)
                    hashCode = hashCode * 59 + this.RelevantOperationVolumes.GetHashCode();
                if (this.ValidTimeBegin != null)
                    hashCode = hashCode * 59 + this.ValidTimeBegin.GetHashCode();
                if (this.ValidTimeEnd != null)
                    hashCode = hashCode * 59 + this.ValidTimeEnd.GetHashCode();
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
