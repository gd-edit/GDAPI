﻿using System;

namespace GDAPI.Enumerations
{
    /// <summary>Represents the mode of an ID migration operation.</summary>
    [Obsolete("Use the GDAPI.Enumerations.GeometryDash.LevelObjectIDType enum instead.")]
    public enum IDMigrationMode
    {
        /// <summary>The Group ID migration mode.</summary>
        Groups,
        /// <summary>The Color ID migration mode.</summary>
        Colors,
        /// <summary>The Item ID migration mode.</summary>
        Items,
        /// <summary>The Block ID migration mode.</summary>
        Blocks,
    }
}
