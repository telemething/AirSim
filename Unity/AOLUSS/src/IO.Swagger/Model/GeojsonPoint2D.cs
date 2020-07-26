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
    /// GeojsonPoint2D
    /// </summary>
    [DataContract]
        public partial class GeojsonPoint2D :  IEquatable<GeojsonPoint2D>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Point for value: Point
            /// </summary>
            [EnumMember(Value = "Point")]
            Point = 1        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeojsonPoint2D" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="coordinates">coordinates (required).</param>
        public GeojsonPoint2D(TypeEnum type = default(TypeEnum), Point2D coordinates = default(Point2D))
        {
            // to ensure "type" is required (not null)
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (type == null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            {
                throw new InvalidDataException("type is a required property for GeojsonPoint2D and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "coordinates" is required (not null)
            if (coordinates == null)
            {
                throw new InvalidDataException("coordinates is a required property for GeojsonPoint2D and cannot be null");
            }
            else
            {
                this.Coordinates = coordinates;
            }
        }
        

        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="coordinates", EmitDefaultValue=false)]
        public Point2D Coordinates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeojsonPoint2D {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
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
            return this.Equals(input as GeojsonPoint2D);
        }

        /// <summary>
        /// Returns true if GeojsonPoint2D instances are equal
        /// </summary>
        /// <param name="input">Instance of GeojsonPoint2D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeojsonPoint2D input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    (this.Type != null &&
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Coordinates == input.Coordinates ||
                    (this.Coordinates != null &&
                    this.Coordinates.Equals(input.Coordinates))
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
                if (this.Type != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Coordinates != null)
                    hashCode = hashCode * 59 + this.Coordinates.GetHashCode();
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
