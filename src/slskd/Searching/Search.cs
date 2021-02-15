﻿// <copyright file="Search.cs" company="slskd Team">
//     Copyright (c) slskd Team. All rights reserved.
//
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as published
//     by the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
//
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see https://www.gnu.org/licenses/.
// </copyright>

namespace slskd.Searching
{
    using System;
    using Soulseek;

    public class Search
    {
        public Guid Id { get; init; }

        /// <summary>
        ///     Gets the text for which to search.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        ///     Gets the state of the search.
        /// </summary>
        public SearchStates State { get; set; }

        /// <summary>
        ///     Gets the unique identifier for the search.
        /// </summary>
        public int Token { get; set; }

        public static Search FromSoulseekSearch(Soulseek.Search s)
        {
            return new Search
            {
                Id = Guid.NewGuid(),
                SearchText = s.SearchText,
                State = s.State,
                Token = s.Token,
            };
        }
    }
}
