using System;

namespace Voluntinder.API.Models
{
    /// <summary>
    /// Represents an availability period of a volunteer
    /// </summary>
    /// <remarks>
    /// If a period is null assume no availability
    /// </remarks>
    public class Availability
    {
        /// <summary>
        /// The availability on a Monday
        /// </summary>
        public AvailabilityPeriod Monday { get; private set; }

        /// <summary>
        /// The availability on a Tuesday
        /// </summary>
        public AvailabilityPeriod Tuesday { get; private set; }

        /// <summary>
        /// The availability on a Wednesday
        /// </summary>
        public AvailabilityPeriod Wednesday { get; private set; }

        /// <summary>
        /// The availability on a Thursday
        /// </summary>

        public AvailabilityPeriod Thursday { get; private set; }


        /// <summary>
        /// The availability on a Friday
        /// </summary>
        public AvailabilityPeriod Friday { get; private set; }

        /// <summary>
        /// The availability on a Saturday
        /// </summary>
        public AvailabilityPeriod Saturday { get; private set; }

        /// <summary>
        /// The availability on a Sunday
        /// </summary>
        public AvailabilityPeriod Sunday { get; private set; }

        /// <summary>
        /// Represents the (inclusive) period of availability for a volunteer on a certain day
        /// </summary>
        /// <remarks>
        /// Must be in the format HH:mm (24 hours)
        /// </remarks>
        public class AvailabilityPeriod
        {
            /// <summary>
            /// The start time of the period
            /// </summary>
            public String StartTime { get; private set; }

            /// <summary>
            /// The end time of the period
            /// </summary>
            public String EndTime { get; private set; }
        }
    }
}
