﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CBB
{
    [DataContract(Namespace="", Name="PlayerSeason")]
    [Serializable]
    public partial class PlayerSeason
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The college basketball regular season for which these totals apply
        /// </summary>
        [Description("The college basketball regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 5)]
        public int? Season { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// Player's position in the starting lineup (if started), otherwise the position he substituted for
        /// </summary>
        [Description("Player's position in the starting lineup (if started), otherwise the position he substituted for")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// A globally unique ID for this player's team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this player's team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 9)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 11)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 12)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 13)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of field goals made
        /// </summary>
        [Description("Total number of field goals made")]
        [DataMember(Name = "FieldGoalsMade", Order = 14)]
        public int? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total number of field goals attempted
        /// </summary>
        [Description("Total number of field goals attempted")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 15)]
        public int? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goal percentage
        /// </summary>
        [Description("Total field goal percentage")]
        [DataMember(Name = "FieldGoalsPercentage", Order = 16)]
        public decimal? FieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total effective field goals percentage
        /// </summary>
        [Description("Total effective field goals percentage")]
        [DataMember(Name = "EffectiveFieldGoalsPercentage", Order = 17)]
        public decimal? EffectiveFieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total two pointers made
        /// </summary>
        [Description("Total two pointers made")]
        [DataMember(Name = "TwoPointersMade", Order = 18)]
        public int? TwoPointersMade { get; set; }

        /// <summary>
        /// Total two pointers attempted
        /// </summary>
        [Description("Total two pointers attempted")]
        [DataMember(Name = "TwoPointersAttempted", Order = 19)]
        public int? TwoPointersAttempted { get; set; }

        /// <summary>
        /// Total two pointers percentage
        /// </summary>
        [Description("Total two pointers percentage")]
        [DataMember(Name = "TwoPointersPercentage", Order = 20)]
        public decimal? TwoPointersPercentage { get; set; }

        /// <summary>
        /// Total three pointers made
        /// </summary>
        [Description("Total three pointers made")]
        [DataMember(Name = "ThreePointersMade", Order = 21)]
        public int? ThreePointersMade { get; set; }

        /// <summary>
        /// Total three pointers attempted
        /// </summary>
        [Description("Total three pointers attempted")]
        [DataMember(Name = "ThreePointersAttempted", Order = 22)]
        public int? ThreePointersAttempted { get; set; }

        /// <summary>
        /// Total three pointers percentage
        /// </summary>
        [Description("Total three pointers percentage")]
        [DataMember(Name = "ThreePointersPercentage", Order = 23)]
        public decimal? ThreePointersPercentage { get; set; }

        /// <summary>
        /// Total free throws made
        /// </summary>
        [Description("Total free throws made")]
        [DataMember(Name = "FreeThrowsMade", Order = 24)]
        public int? FreeThrowsMade { get; set; }

        /// <summary>
        /// Total free throws attempted
        /// </summary>
        [Description("Total free throws attempted")]
        [DataMember(Name = "FreeThrowsAttempted", Order = 25)]
        public int? FreeThrowsAttempted { get; set; }

        /// <summary>
        /// Total free throws percentage
        /// </summary>
        [Description("Total free throws percentage")]
        [DataMember(Name = "FreeThrowsPercentage", Order = 26)]
        public decimal? FreeThrowsPercentage { get; set; }

        /// <summary>
        /// Total offensive rebounds
        /// </summary>
        [Description("Total offensive rebounds")]
        [DataMember(Name = "OffensiveRebounds", Order = 27)]
        public int? OffensiveRebounds { get; set; }

        /// <summary>
        /// Total defensive rebounds
        /// </summary>
        [Description("Total defensive rebounds")]
        [DataMember(Name = "DefensiveRebounds", Order = 28)]
        public int? DefensiveRebounds { get; set; }

        /// <summary>
        /// Total rebounds
        /// </summary>
        [Description("Total rebounds")]
        [DataMember(Name = "Rebounds", Order = 29)]
        public int? Rebounds { get; set; }

        /// <summary>
        /// Total offensive rebounds percentage
        /// </summary>
        [Description("Total offensive rebounds percentage")]
        [DataMember(Name = "OffensiveReboundsPercentage", Order = 30)]
        public decimal? OffensiveReboundsPercentage { get; set; }

        /// <summary>
        /// Total defensive rebounds percentage
        /// </summary>
        [Description("Total defensive rebounds percentage")]
        [DataMember(Name = "DefensiveReboundsPercentage", Order = 31)]
        public decimal? DefensiveReboundsPercentage { get; set; }

        /// <summary>
        /// The player/team total rebounds percentage
        /// </summary>
        [Description("The player/team total rebounds percentage")]
        [DataMember(Name = "TotalReboundsPercentage", Order = 32)]
        public decimal? TotalReboundsPercentage { get; set; }

        /// <summary>
        /// Total assists
        /// </summary>
        [Description("Total assists")]
        [DataMember(Name = "Assists", Order = 33)]
        public int? Assists { get; set; }

        /// <summary>
        /// Total steals
        /// </summary>
        [Description("Total steals")]
        [DataMember(Name = "Steals", Order = 34)]
        public int? Steals { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "BlockedShots", Order = 35)]
        public int? BlockedShots { get; set; }

        /// <summary>
        /// Total turnovers
        /// </summary>
        [Description("Total turnovers")]
        [DataMember(Name = "Turnovers", Order = 36)]
        public int? Turnovers { get; set; }

        /// <summary>
        /// Total personal fouls
        /// </summary>
        [Description("Total personal fouls")]
        [DataMember(Name = "PersonalFouls", Order = 37)]
        public int? PersonalFouls { get; set; }

        /// <summary>
        /// Total points
        /// </summary>
        [Description("Total points")]
        [DataMember(Name = "Points", Order = 38)]
        public int? Points { get; set; }

        /// <summary>
        /// The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingAttempts", Order = 39)]
        public decimal? TrueShootingAttempts { get; set; }

        /// <summary>
        /// The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TrueShootingPercentage", Order = 40)]
        public decimal? TrueShootingPercentage { get; set; }

        /// <summary>
        /// The player's linear weight efficiency rating as defined here: http://bleacherreport.com/articles/113144-cracking-the-code-how-to-calculate-hollingers-per-without-all-the-mess
        /// </summary>
        [Description("The player's linear weight efficiency rating as defined here: http://bleacherreport.com/articles/113144-cracking-the-code-how-to-calculate-hollingers-per-without-all-the-mess")]
        [DataMember(Name = "PlayerEfficiencyRating", Order = 41)]
        public decimal? PlayerEfficiencyRating { get; set; }

        /// <summary>
        /// The player's assist percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's assist percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "AssistsPercentage", Order = 42)]
        public decimal? AssistsPercentage { get; set; }

        /// <summary>
        /// The player's steal percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's steal percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "StealsPercentage", Order = 43)]
        public decimal? StealsPercentage { get; set; }

        /// <summary>
        /// The player's block percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's block percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "BlocksPercentage", Order = 44)]
        public decimal? BlocksPercentage { get; set; }

        /// <summary>
        /// The player's turnover percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's turnover percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "TurnOversPercentage", Order = 45)]
        public decimal? TurnOversPercentage { get; set; }

        /// <summary>
        /// The player's usage rate percentage as defined here: http://www.basketball-reference.com/about/glossary.html
        /// </summary>
        [Description("The player's usage rate percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
        [DataMember(Name = "UsageRatePercentage", Order = 46)]
        public decimal? UsageRatePercentage { get; set; }

        /// <summary>
        /// Total Fan Duel daily fantasy points scored
        /// </summary>
        [Description("Total Fan Duel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 47)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Draft Kings daily fantasy points scored
        /// </summary>
        [Description("Total Draft Kings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 48)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 49)]
        public decimal? FantasyPointsYahoo { get; set; }

    }
}

