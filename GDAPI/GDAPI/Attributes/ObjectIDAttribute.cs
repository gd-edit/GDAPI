﻿using System;
using GDAPI.Enumerations.GeometryDash;
using GDAPI.Objects.GeometryDash;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Orbs;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Pads;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.Portals;
using GDAPI.Objects.GeometryDash.LevelObjects.SpecialObjects.SpecialBlocks;
using GDAPI.Objects.GeometryDash.LevelObjects.Triggers;

namespace GDAPI.Attributes
{
    /// <summary>Contains the object ID of the <seealso cref="LevelObject"/> class.</summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ObjectIDAttribute : Attribute
    {
        /// <summary>The object ID of the <seealso cref="LevelObject"/>.</summary>
        public int ObjectID { get; }

        /// <summary>Creates a new instance of the <seealso cref="ObjectIDAttribute"/> attribute.</summary>
        /// <param name="objectID">The object ID of the <seealso cref="LevelObject"/>.</param>
        public ObjectIDAttribute(int objectID)
        {
            ObjectID = objectID;
        }
        /// <summary>Creates a new instance of the <seealso cref="ObjectIDAttribute"/> attribute.</summary>
        /// <param name="objectID">The object ID of the <seealso cref="Orb"/>.</param>
        public ObjectIDAttribute(OrbType objectID) : this((int)objectID) { }
        /// <summary>Creates a new instance of the <seealso cref="ObjectIDAttribute"/> attribute.</summary>
        /// <param name="objectID">The object ID of the <seealso cref="Pad"/>.</param>
        public ObjectIDAttribute(PadType objectID) : this((int)objectID) { }
        /// <summary>Creates a new instance of the <seealso cref="ObjectIDAttribute"/> attribute.</summary>
        /// <param name="objectID">The object ID of the <seealso cref="Portal"/>.</param>
        public ObjectIDAttribute(PortalType objectID) : this((int)objectID) { }
        /// <summary>Creates a new instance of the <seealso cref="ObjectIDAttribute"/> attribute.</summary>
        /// <param name="objectID">The object ID of the <seealso cref="SpecialBlock"/>.</param>
        public ObjectIDAttribute(SpecialBlockType objectID) : this((int)objectID) { }
        /// <summary>Creates a new instance of the <seealso cref="ObjectIDAttribute"/> attribute.</summary>
        /// <param name="objectID">The object ID of the <seealso cref="SpecialObject"/>.</param>
        public ObjectIDAttribute(SpecialObjectType objectID) : this((int)objectID) { }
        /// <summary>Creates a new instance of the <seealso cref="ObjectIDAttribute"/> attribute.</summary>
        /// <param name="objectID">The object ID of the <seealso cref="Trigger"/>.</param>
        public ObjectIDAttribute(TriggerType objectID) : this((int)objectID) { }
    }
}