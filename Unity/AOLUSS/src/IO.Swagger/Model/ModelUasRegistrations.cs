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
    /// ModelUasRegistrations
    /// </summary>
    [DataContract]
        public partial class ModelUasRegistrations :  IEquatable<ModelUasRegistrations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUasRegistrations" /> class.
        /// </summary>
        /// <param name="registrationId">registrationId (required).</param>
        /// <param name="registrationLocation">registrationLocation (required).</param>
        public ModelUasRegistrations(Guid? registrationId = default(Guid?), string registrationLocation = default(string))
        {
            // to ensure "registrationId" is required (not null)
            if (registrationId == null)
            {
                throw new InvalidDataException("registrationId is a required property for ModelUasRegistrations and cannot be null");
            }
            else
            {
                this.RegistrationId = registrationId;
            }
            // to ensure "registrationLocation" is required (not null)
            if (registrationLocation == null)
            {
                throw new InvalidDataException("registrationLocation is a required property for ModelUasRegistrations and cannot be null");
            }
            else
            {
                this.RegistrationLocation = registrationLocation;
            }
        }
        
        /// <summary>
        /// Gets or Sets RegistrationId
        /// </summary>
        [DataMember(Name="registration_id", EmitDefaultValue=false)]
        public Guid? RegistrationId { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationLocation
        /// </summary>
        [DataMember(Name="registration_location", EmitDefaultValue=false)]
        public string RegistrationLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelUasRegistrations {\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  RegistrationLocation: ").Append(RegistrationLocation).Append("\n");
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
            return this.Equals(input as ModelUasRegistrations);
        }

        /// <summary>
        /// Returns true if ModelUasRegistrations instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelUasRegistrations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelUasRegistrations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegistrationId == input.RegistrationId ||
                    (this.RegistrationId != null &&
                    this.RegistrationId.Equals(input.RegistrationId))
                ) && 
                (
                    this.RegistrationLocation == input.RegistrationLocation ||
                    (this.RegistrationLocation != null &&
                    this.RegistrationLocation.Equals(input.RegistrationLocation))
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
                if (this.RegistrationId != null)
                    hashCode = hashCode * 59 + this.RegistrationId.GetHashCode();
                if (this.RegistrationLocation != null)
                    hashCode = hashCode * 59 + this.RegistrationLocation.GetHashCode();
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
