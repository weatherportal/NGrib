﻿/*
 * This file is part of NGrib.
 *
 * Copyright © 2020 Nicolas Mangué
 * 
 * NGrib is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 * 
 * NGrib is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License
 * along with NGrib.  If not, see <https://www.gnu.org/licenses/>.
 */

namespace NGrib.Sections.Templates.ProductDefinitionTemplates
{
    public abstract class ProductDefinition
    {
        public long Offset { get; }

        /// <summary> parameter Category .</summary>
        /// <returns> parameterCategory as int
        /// </returns>
        public int ParameterCategory { get; }

        /// <summary> parameter Number.</summary>
        /// <returns> ParameterNumber
        /// </returns>
        public int ParameterNumber { get; }

        /// <summary> typeGenProcess.</summary>
        /// <returns> GenProcess
        /// </returns>
        public int TypeGenProcess { get; }
        
        private protected ProductDefinition(BufferedBinaryReader reader)
        {
            Offset = reader.Position;
            ParameterCategory = reader.ReadUInt8();
            ParameterNumber = reader.ReadUInt8();
            TypeGenProcess = reader.ReadUInt8();
        }
    }
}
