﻿/* Copyright (C) 2009 Matthew Geyer
 * 
 * This file is part of UO Machine.
 * 
 * UO Machine is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * UO Machine is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with UO Machine.  If not, see <http://www.gnu.org/licenses/>. */

using System;
using System.Threading;
namespace UOMachine.Utility
{
    public static class ThreadHelper
    {
        /// <summary>
        /// Generic implementation of System.Threading.Thread.VolatileRead.
        /// Reads current value from memory bypassing any cached copy.
        /// </summary>
        /// <param name="location">The field to be read.</param>
        /// <returns></returns>
        public static T VolatileRead<T>(ref T location)
        {
            T value = location;
            Thread.MemoryBarrier();
            return value;
        }
    }
}