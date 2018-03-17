using System;
using System.Collections.Generic;
using System.Text;

namespace Voluntinder.API.Models
{
    /// <summary>
    /// Represents a volunteer's response to a position offer
    /// </summary>
    public class PositionResponse
    {
        /// <summary>
        /// The ID of the position to respond to
        /// </summary>
        public String PositionID { get; private set; }

        /// <summary>
        /// The response status
        /// </summary>
        public Status ResponseStatus { get; private set; }

        /// <summary>
        /// Represents the status of a response to a position (ie, Accept, Reject, etc)
        /// </summary>
        public enum Status
        {
            Accept = 0,
            Reject = 1
        }
    }
}
