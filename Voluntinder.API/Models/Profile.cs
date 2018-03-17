using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voluntinder.API.Models
{
    /// <summary>
    /// Represents a volunteer's profile
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// The volunteer's name
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// A URL of the volunteer's profile picture
        /// </summary>
        [JsonProperty("Picture")]
        public Uri Picture { get; set; }

        /// <summary>
        /// The volunteer's birth date
        /// </summary>
        [JsonProperty("BirthDate")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The volunteer's chosen gender
        /// </summary>
        [JsonProperty("ChosenGender")]
        public Gender ChosenGender { get; set; }

        /// <summary>
        /// The volunteer's biography
        /// </summary>
        [JsonProperty("Biography")]
        public String Biography { get; set; }

        /// <summary>
        /// The volunteer's employment history
        /// </summary>
        public List<EmploymentHistory> EmploymentHistories { get; set; }

        /// <summary>
        /// The volunteer's qualifications
        /// </summary>
        public List<String> Qualifications { get; set; }

        /// <summary>
        /// Represents a period of employment history
        /// </summary>
        public class EmploymentHistory
        {
            /// <summary>
            /// The start date of the employment history
            /// </summary>
            public DateTime StartDate { get; set; }

            /// <summary>
            /// The end date of the employment history
            /// </summary>
            /// <remarks>
            /// If null can be assumed the volunteer is still in the position
            /// </remarks>
            public DateTime? EndDate { get; set; }

            /// <summary>
            /// The description of the employment history
            /// </summary>
            public String Description { get; set; }
        }

        /// <summary>
        /// Represents a gender for the volunteer
        /// </summary>
        public enum Gender
        {
            Undisclosed = 0,
            Female = 1,
            Male = 2
        }
    }
}
