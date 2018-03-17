using System;
using System.Collections.Generic;

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
        public string Name { get; private set; }

        /// <summary>
        /// A URL of the volunteer's profile picture
        /// </summary>
        public Uri Picture { get; private set; }

        /// <summary>
        /// The volunteer's birth date
        /// </summary>
        public DateTime BirthDate { get; private set; }

        /// <summary>
        /// The volunteer's chosen gender
        /// </summary>
        public Gender ChosenGender { get; private set; }

        /// <summary>
        /// The volunteer's biography
        /// </summary>
        public String Biography { get; private set; }

        /// <summary>
        /// The volunteer's employment history
        /// </summary>
        public List<EmploymentHistory> EmploymentHistories { get; private set; }

        /// <summary>
        /// The volunteer's qualifications
        /// </summary>
        public List<String> Qualifications { get; private set; }

        /// <summary>
        /// Represents a period of employment history
        /// </summary>
        public class EmploymentHistory
        {
            /// <summary>
            /// The start date of the employment history
            /// </summary>
            public DateTime StartDate { get; private set; }

            /// <summary>
            /// The end date of the employment history
            /// </summary>
            /// <remarks>
            /// If null can be assumed the volunteer is still in the position
            /// </remarks>
            public DateTime? EndDate { get; private set; } // Nullable because the volunteer may still be in this position

            /// <summary>
            /// The description of the employment history
            /// </summary>
            public String Description { get; private set; }
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
