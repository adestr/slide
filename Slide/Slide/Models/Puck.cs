using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide.Models
{
    /// <summary>
    /// A puck
    /// </summary>
    /// <remarks>
    /// Pucks are the objects which you slide on a <see cref="Stage"/> in an attempt to reach a <see cref="Target"/>
    /// </remarks>
    public class Puck
    {
        /// <summary>
        /// Gets or sets the position of the puck
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Gets or sets the stage within which the puck is located
        /// </summary>
        public Stage Stage { get; set; }
    }
}
