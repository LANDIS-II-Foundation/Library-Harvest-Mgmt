﻿// This file is part of the Harvest Management library for LANDIS-II.

namespace Landis.Library.HarvestManagement
{
    /// <summary>
    /// Constants for known parameter names
    /// </summary>
    public static class ParameterNames
    {
        /// <summary>
        /// Parameter for preventing tree establishment (to mimic development).
        /// </summary>
        public const string PreventEstablishment = "PreventEstablishment";

        /// <summary>
        /// Paramter for list of species to plant at a site.
        /// </summary>
        public const string Plant = "Plant";

        /// <summary>
        /// Parameter for allowing patches to overlap when patch cutting.
        /// </summary>
        public const string AllowOverlap = "AllowOverlap";
    }
}
