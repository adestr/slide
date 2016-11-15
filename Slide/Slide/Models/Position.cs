using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide.Models
{
    /// <summary>
    /// Represents a position within a <see cref="Stage"/>
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Gets or sets the x-component of the position
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Gets or sets the y-component of the position
        /// </summary>
        public float Y { get; set; }
    }
}
