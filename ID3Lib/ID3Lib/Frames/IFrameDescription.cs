﻿using JetBrains.Annotations;

namespace Id3Lib.Frames
{
    /// <summary>
    /// Frame description
    /// </summary>
    /// <remarks>
    /// Frames that have a description must include this interface, 
    /// it will be used to make a validation that the frames are unique by description;
    /// </remarks>
    [PublicAPI]
    public interface IFrameDescription
    {
        /// <summary>
        /// Description of the frame, it means different things on the specific frame.
        /// </summary>
        [NotNull]
        string Description { get; set; }
    }
}
