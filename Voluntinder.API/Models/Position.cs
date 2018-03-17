using System;
using System.Collections.Generic;
using System.Text;

namespace Voluntinder.API.Models
{
    /// <summary>
    /// Represents a position that is available to the volunteer
    /// </summary>
    public class Position
    {
        /// <summary>
        /// The position ID
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        /// The banner picture for the position as provided by the company
        /// </summary>
        public Uri BannerPicture { get; set; }

        /// <summary>
        /// The name of the company offering the position
        /// </summary>
        public String CompanyName { get; set; }

        /// <summary>
        /// The name of the position
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// A description of the position
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// The duration of the position
        /// </summary>
        public PositionDuration Duration { get; set; }

        /// <summary>
        /// Represents the duration of a position - can be a date range or a custom string as provided
        /// </summary>
        public class PositionDuration
        {
            /// <summary>
            /// The start date of the position duration
            /// </summary>
            /// <remarks>
            /// If this is null it can be assumed that there is a custom string set
            /// </remarks>
            public DateTime? StartDate { get; set; }

            /// <summary>
            /// The end date of the position duration
            /// </summary>
            /// <remarks>
            /// If this is null and the start date isn't, it can be assumed that the position does not have a fixed duration
            /// </remarks>
            public DateTime? EndDate { get; set; }

            /// <summary>
            /// A custom duration string that may be supplied for the position
            /// </summary>
            public String CustomDuration { get; set; }
        }
    }
}
