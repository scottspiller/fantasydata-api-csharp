﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Soccer
{
    [DataContract(Namespace="", Name="GameStat")]
    [Serializable]
    public partial class GameStat
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 1)]
        public int? GameId { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentId", Order = 2)]
        public int? OpponentId { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 3)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (UTC)
        /// </summary>
        [Description("The date and time of the game (UTC)")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 6)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 7)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 8)]
        public int? GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentId", Order = 9)]
        public int? GlobalOpponentId { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (UTC Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (UTC Time)")]
        [DataMember(Name = "UpdatedUtc", Order = 11)]
        public DateTime? UpdatedUtc { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 12)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 13)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total Fan Duel daily fantasy points scored
        /// </summary>
        [Description("Total Fan Duel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 14)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total Draft Kings daily fantasy points scored
        /// </summary>
        [Description("Total Draft Kings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 15)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 16)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total Mondogoal fantasy points scored
        /// </summary>
        [Description("Total Mondogoal fantasy points scored")]
        [DataMember(Name = "FantasyPointsMondogoal", Order = 17)]
        public decimal? FantasyPointsMondogoal { get; set; }

        /// <summary>
        /// Total minutes played
        /// </summary>
        [Description("Total minutes played")]
        [DataMember(Name = "Minutes", Order = 18)]
        public decimal? Minutes { get; set; }

        /// <summary>
        /// Total goals scored
        /// </summary>
        [Description("Total goals scored")]
        [DataMember(Name = "Goals", Order = 19)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total assists scored
        /// </summary>
        [Description("Total assists scored")]
        [DataMember(Name = "Assists", Order = 20)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total shots attempted
        /// </summary>
        [Description("Total shots attempted")]
        [DataMember(Name = "Shots", Order = 21)]
        public decimal? Shots { get; set; }

        /// <summary>
        /// Total shots on goal attempted
        /// </summary>
        [Description("Total shots on goal attempted")]
        [DataMember(Name = "ShotsOnGoal", Order = 22)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total yellow cards against
        /// </summary>
        [Description("Total yellow cards against")]
        [DataMember(Name = "YellowCards", Order = 23)]
        public decimal? YellowCards { get; set; }

        /// <summary>
        /// Total red cards against
        /// </summary>
        [Description("Total red cards against")]
        [DataMember(Name = "RedCards", Order = 24)]
        public decimal? RedCards { get; set; }

        /// <summary>
        /// Total double yellow cards against (which result in a red card)
        /// </summary>
        [Description("Total double yellow cards against (which result in a red card)")]
        [DataMember(Name = "YellowRedCards", Order = 25)]
        public decimal? YellowRedCards { get; set; }

        /// <summary>
        /// Total passes from a wide area of the field towards the center of the field near the opponent's goal
        /// </summary>
        [Description("Total passes from a wide area of the field towards the center of the field near the opponent's goal")]
        [DataMember(Name = "Crosses", Order = 26)]
        public decimal? Crosses { get; set; }

        /// <summary>
        /// Total tackles won
        /// </summary>
        [Description("Total tackles won")]
        [DataMember(Name = "TacklesWon", Order = 27)]
        public decimal? TacklesWon { get; set; }

        /// <summary>
        /// Total interceptions made
        /// </summary>
        [Description("Total interceptions made")]
        [DataMember(Name = "Interceptions", Order = 28)]
        public decimal? Interceptions { get; set; }

        /// <summary>
        /// Total goals scored against own team (accidentally)
        /// </summary>
        [Description("Total goals scored against own team (accidentally)")]
        [DataMember(Name = "OwnGoals", Order = 29)]
        public decimal? OwnGoals { get; set; }

        /// <summary>
        /// Total fouls made
        /// </summary>
        [Description("Total fouls made")]
        [DataMember(Name = "Fouls", Order = 30)]
        public decimal? Fouls { get; set; }

        /// <summary>
        /// Total times fouled
        /// </summary>
        [Description("Total times fouled")]
        [DataMember(Name = "Fouled", Order = 31)]
        public decimal? Fouled { get; set; }

        /// <summary>
        /// Total offsides against
        /// </summary>
        [Description("Total offsides against")]
        [DataMember(Name = "Offsides", Order = 32)]
        public decimal? Offsides { get; set; }

        /// <summary>
        /// Total passes attempted
        /// </summary>
        [Description("Total passes attempted")]
        [DataMember(Name = "Passes", Order = 33)]
        public decimal? Passes { get; set; }

        /// <summary>
        /// Total passes completed successfully to teammate
        /// </summary>
        [Description("Total passes completed successfully to teammate")]
        [DataMember(Name = "PassesCompleted", Order = 34)]
        public decimal? PassesCompleted { get; set; }

        /// <summary>
        /// Total tackles made when there is no one else available to stop the opponent from scoring (this can be the goalkeeper)
        /// </summary>
        [Description("Total tackles made when there is no one else available to stop the opponent from scoring (this can be the goalkeeper)")]
        [DataMember(Name = "LastManTackle", Order = 35)]
        public decimal? LastManTackle { get; set; }

        /// <summary>
        /// Total corner kicks awarded
        /// </summary>
        [Description("Total corner kicks awarded")]
        [DataMember(Name = "CornersWon", Order = 36)]
        public decimal? CornersWon { get; set; }

        /// <summary>
        /// Total shots blocked
        /// </summary>
        [Description("Total shots blocked")]
        [DataMember(Name = "BlockedShots", Order = 37)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total times this player touched the ball
        /// </summary>
        [Description("Total times this player touched the ball")]
        [DataMember(Name = "Touches", Order = 38)]
        public decimal? Touches { get; set; }

        /// <summary>
        /// Total defender clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)
        /// </summary>
        [Description("Total defender clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)")]
        [DataMember(Name = "DefenderCleanSheets", Order = 39)]
        public decimal? DefenderCleanSheets { get; set; }

        /// <summary>
        /// Total saves made by goalkeeper
        /// </summary>
        [Description("Total saves made by goalkeeper")]
        [DataMember(Name = "GoalkeeperSaves", Order = 40)]
        public decimal? GoalkeeperSaves { get; set; }

        /// <summary>
        /// Total goals allowed by goalkeeper
        /// </summary>
        [Description("Total goals allowed by goalkeeper")]
        [DataMember(Name = "GoalkeeperGoalsAgainst", Order = 41)]
        public decimal? GoalkeeperGoalsAgainst { get; set; }

        /// <summary>
        /// Total games where this goalkeeper allowed exactly one goal
        /// </summary>
        [Description("Total games where this goalkeeper allowed exactly one goal")]
        [DataMember(Name = "GoalkeeperSingleGoalAgainst", Order = 42)]
        public decimal? GoalkeeperSingleGoalAgainst { get; set; }

        /// <summary>
        /// Total goalkeeper clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)
        /// </summary>
        [Description("Total goalkeeper clean sheets (awarded when zero goals were allowed to the opponent and the player played at least 60 minutes)")]
        [DataMember(Name = "GoalkeeperCleanSheets", Order = 43)]
        public decimal? GoalkeeperCleanSheets { get; set; }

        /// <summary>
        /// Total goalkeeper wins (awarded when zero goals were allowed to the opponent and the player played at least 45 minutes)
        /// </summary>
        [Description("Total goalkeeper wins (awarded when zero goals were allowed to the opponent and the player played at least 45 minutes)")]
        [DataMember(Name = "GoalkeeperWins", Order = 44)]
        public decimal? GoalkeeperWins { get; set; }

        /// <summary>
        /// Total penalty kick goals
        /// </summary>
        [Description("Total penalty kick goals")]
        [DataMember(Name = "PenaltyKickGoals", Order = 45)]
        public decimal? PenaltyKickGoals { get; set; }

        /// <summary>
        /// Total penalty kick misses
        /// </summary>
        [Description("Total penalty kick misses")]
        [DataMember(Name = "PenaltyKickMisses", Order = 46)]
        public decimal? PenaltyKickMisses { get; set; }

        /// <summary>
        /// Total penalty kick saves
        /// </summary>
        [Description("Total penalty kick saves")]
        [DataMember(Name = "PenaltyKickSaves", Order = 47)]
        public decimal? PenaltyKickSaves { get; set; }

        /// <summary>
        /// Total penalties won
        /// </summary>
        [Description("Total penalties won")]
        [DataMember(Name = "PenaltiesWon", Order = 48)]
        public decimal? PenaltiesWon { get; set; }

        /// <summary>
        /// Total penalties conceded 
        /// </summary>
        [Description("Total penalties conceded ")]
        [DataMember(Name = "PenaltiesConceded", Order = 49)]
        public decimal? PenaltiesConceded { get; set; }

        /// <summary>
        /// Goals scored by entire team
        /// </summary>
        [Description("Goals scored by entire team")]
        [DataMember(Name = "Score", Order = 50)]
        public decimal? Score { get; set; }

        /// <summary>
        /// Goals allowed to opponent
        /// </summary>
        [Description("Goals allowed to opponent")]
        [DataMember(Name = "OpponentScore", Order = 51)]
        public decimal? OpponentScore { get; set; }

    }
}

