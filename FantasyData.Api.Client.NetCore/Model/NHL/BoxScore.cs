﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NHL
{
    [DataContract(Namespace="", Name="BoxScore")]
    [Serializable]
    public partial class BoxScore
    {
        /// <summary>
        /// The details of the game associated with this box score
        /// </summary>
        [Description("The details of the game associated with this box score")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// The details of the periods associated with this box score
        /// </summary>
        [Description("The details of the periods associated with this box score")]
        [DataMember(Name = "Periods", Order = 20002)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// The team game stats associated with this box score
        /// </summary>
        [Description("The team game stats associated with this box score")]
        [DataMember(Name = "TeamGames", Order = 20003)]
        public TeamGame[] TeamGames { get; set; }

        /// <summary>
        /// The player game stats associated with this box score
        /// </summary>
        [Description("The player game stats associated with this box score")]
        [DataMember(Name = "PlayerGames", Order = 20004)]
        public PlayerGame[] PlayerGames { get; set; }

        /// <summary>
        /// The details of any shootout plays associated with this box score
        /// </summary>
        [Description("The details of any shootout plays associated with this box score")]
        [DataMember(Name = "ShootoutPlays", Order = 20005)]
        public Play[] ShootoutPlays { get; set; }

    }
}

