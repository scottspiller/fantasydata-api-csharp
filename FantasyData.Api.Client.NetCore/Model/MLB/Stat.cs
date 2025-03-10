﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.MLB
{
    [DataContract(Namespace="", Name="Stat")]
    [Serializable]
    public partial class Stat
    {
        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 2)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 3)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// At bats while hitting
        /// </summary>
        [Description("At bats while hitting")]
        [DataMember(Name = "AtBats", Order = 4)]
        public decimal? AtBats { get; set; }

        /// <summary>
        /// Total runs scored.
        /// </summary>
        [Description("Total runs scored.")]
        [DataMember(Name = "Runs", Order = 5)]
        public decimal? Runs { get; set; }

        /// <summary>
        /// Total hits
        /// </summary>
        [Description("Total hits")]
        [DataMember(Name = "Hits", Order = 6)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total singles
        /// </summary>
        [Description("Total singles")]
        [DataMember(Name = "Singles", Order = 7)]
        public decimal? Singles { get; set; }

        /// <summary>
        /// Total doubles
        /// </summary>
        [Description("Total doubles")]
        [DataMember(Name = "Doubles", Order = 8)]
        public decimal? Doubles { get; set; }

        /// <summary>
        /// Total triples
        /// </summary>
        [Description("Total triples")]
        [DataMember(Name = "Triples", Order = 9)]
        public decimal? Triples { get; set; }

        /// <summary>
        /// Total home runs
        /// </summary>
        [Description("Total home runs")]
        [DataMember(Name = "HomeRuns", Order = 10)]
        public decimal? HomeRuns { get; set; }

        /// <summary>
        /// Total runs batted in
        /// </summary>
        [Description("Total runs batted in")]
        [DataMember(Name = "RunsBattedIn", Order = 11)]
        public decimal? RunsBattedIn { get; set; }

        /// <summary>
        /// Total batting average
        /// </summary>
        [Description("Total batting average")]
        [DataMember(Name = "BattingAverage", Order = 12)]
        public decimal? BattingAverage { get; set; }

        /// <summary>
        /// Total outs
        /// </summary>
        [Description("Total outs")]
        [DataMember(Name = "Outs", Order = 13)]
        public decimal? Outs { get; set; }

        /// <summary>
        /// Total strikeouts
        /// </summary>
        [Description("Total strikeouts")]
        [DataMember(Name = "Strikeouts", Order = 14)]
        public decimal? Strikeouts { get; set; }

        /// <summary>
        /// Total walks
        /// </summary>
        [Description("Total walks")]
        [DataMember(Name = "Walks", Order = 15)]
        public decimal? Walks { get; set; }

        /// <summary>
        /// Total times hit by pitch
        /// </summary>
        [Description("Total times hit by pitch")]
        [DataMember(Name = "HitByPitch", Order = 16)]
        public decimal? HitByPitch { get; set; }

        /// <summary>
        /// Total sacrifices
        /// </summary>
        [Description("Total sacrifices")]
        [DataMember(Name = "Sacrifices", Order = 17)]
        public decimal? Sacrifices { get; set; }

        /// <summary>
        /// Total sacrifice flies
        /// </summary>
        [Description("Total sacrifice flies")]
        [DataMember(Name = "SacrificeFlies", Order = 18)]
        public decimal? SacrificeFlies { get; set; }

        /// <summary>
        /// Total times grounded into double play
        /// </summary>
        [Description("Total times grounded into double play")]
        [DataMember(Name = "GroundIntoDoublePlay", Order = 19)]
        public decimal? GroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Total stolen bases
        /// </summary>
        [Description("Total stolen bases")]
        [DataMember(Name = "StolenBases", Order = 20)]
        public decimal? StolenBases { get; set; }

        /// <summary>
        /// Total caught stealing
        /// </summary>
        [Description("Total caught stealing")]
        [DataMember(Name = "CaughtStealing", Order = 21)]
        public decimal? CaughtStealing { get; set; }

        /// <summary>
        /// Total pitches seen
        /// </summary>
        [Description("Total pitches seen")]
        [DataMember(Name = "PitchesSeen", Order = 22)]
        public decimal? PitchesSeen { get; set; }

        /// <summary>
        /// Total on base percentage
        /// </summary>
        [Description("Total on base percentage")]
        [DataMember(Name = "OnBasePercentage", Order = 23)]
        public decimal? OnBasePercentage { get; set; }

        /// <summary>
        /// Total slugging percentage
        /// </summary>
        [Description("Total slugging percentage")]
        [DataMember(Name = "SluggingPercentage", Order = 24)]
        public decimal? SluggingPercentage { get; set; }

        /// <summary>
        /// Total on base plus percentage 
        /// </summary>
        [Description("Total on base plus percentage ")]
        [DataMember(Name = "OnBasePlusSlugging", Order = 25)]
        public decimal? OnBasePlusSlugging { get; set; }

        /// <summary>
        /// Total errors
        /// </summary>
        [Description("Total errors")]
        [DataMember(Name = "Errors", Order = 26)]
        public decimal? Errors { get; set; }

        /// <summary>
        /// Total wins by the team/player
        /// </summary>
        [Description("Total wins by the team/player")]
        [DataMember(Name = "Wins", Order = 27)]
        public decimal? Wins { get; set; }

        /// <summary>
        /// Total losses by the team/player
        /// </summary>
        [Description("Total losses by the team/player")]
        [DataMember(Name = "Losses", Order = 28)]
        public decimal? Losses { get; set; }

        /// <summary>
        /// Total saves by team/player
        /// </summary>
        [Description("Total saves by team/player")]
        [DataMember(Name = "Saves", Order = 29)]
        public decimal? Saves { get; set; }

        /// <summary>
        /// Decimal representation of total innings pitched (e.g. 1.33, 7.66, etc)
        /// </summary>
        [Description("Decimal representation of total innings pitched (e.g. 1.33, 7.66, etc)")]
        [DataMember(Name = "InningsPitchedDecimal", Order = 30)]
        public decimal? InningsPitchedDecimal { get; set; }

        /// <summary>
        /// Total outs pitched by team/player
        /// </summary>
        [Description("Total outs pitched by team/player")]
        [DataMember(Name = "TotalOutsPitched", Order = 31)]
        public decimal? TotalOutsPitched { get; set; }

        /// <summary>
        /// Total full innings pitched (e.g. 6, 71, 89, etc)
        /// </summary>
        [Description("Total full innings pitched (e.g. 6, 71, 89, etc)")]
        [DataMember(Name = "InningsPitchedFull", Order = 32)]
        public decimal? InningsPitchedFull { get; set; }

        /// <summary>
        /// Outs pitched beyond InningsPitchedFull (possible values: 0, 1, 2)
        /// </summary>
        [Description("Outs pitched beyond InningsPitchedFull (possible values: 0, 1, 2)")]
        [DataMember(Name = "InningsPitchedOuts", Order = 33)]
        public decimal? InningsPitchedOuts { get; set; }

        /// <summary>
        /// Total earned run average by team/player
        /// </summary>
        [Description("Total earned run average by team/player")]
        [DataMember(Name = "EarnedRunAverage", Order = 34)]
        public decimal? EarnedRunAverage { get; set; }

        /// <summary>
        /// Hits allowed while pitching
        /// </summary>
        [Description("Hits allowed while pitching")]
        [DataMember(Name = "PitchingHits", Order = 35)]
        public decimal? PitchingHits { get; set; }

        /// <summary>
        /// Runs allowed while pitching
        /// </summary>
        [Description("Runs allowed while pitching")]
        [DataMember(Name = "PitchingRuns", Order = 36)]
        public decimal? PitchingRuns { get; set; }

        /// <summary>
        /// Earned runs allowed while pitching
        /// </summary>
        [Description("Earned runs allowed while pitching")]
        [DataMember(Name = "PitchingEarnedRuns", Order = 37)]
        public decimal? PitchingEarnedRuns { get; set; }

        /// <summary>
        /// Walks allowed while pitching
        /// </summary>
        [Description("Walks allowed while pitching")]
        [DataMember(Name = "PitchingWalks", Order = 38)]
        public decimal? PitchingWalks { get; set; }

        /// <summary>
        /// Strikeouts allowed while pitching
        /// </summary>
        [Description("Strikeouts allowed while pitching")]
        [DataMember(Name = "PitchingStrikeouts", Order = 39)]
        public decimal? PitchingStrikeouts { get; set; }

        /// <summary>
        /// Home runs allowed while pitching
        /// </summary>
        [Description("Home runs allowed while pitching")]
        [DataMember(Name = "PitchingHomeRuns", Order = 40)]
        public decimal? PitchingHomeRuns { get; set; }

        /// <summary>
        /// Total pitches thrown while pitching
        /// </summary>
        [Description("Total pitches thrown while pitching")]
        [DataMember(Name = "PitchesThrown", Order = 41)]
        public decimal? PitchesThrown { get; set; }

        /// <summary>
        /// Total pitches thrown for strikes while pitching
        /// </summary>
        [Description("Total pitches thrown for strikes while pitching")]
        [DataMember(Name = "PitchesThrownStrikes", Order = 42)]
        public decimal? PitchesThrownStrikes { get; set; }

        /// <summary>
        /// Walks plus hits per innings pitched (WHIP) while pitching
        /// </summary>
        [Description("Walks plus hits per innings pitched (WHIP) while pitching")]
        [DataMember(Name = "WalksHitsPerInningsPitched", Order = 43)]
        public decimal? WalksHitsPerInningsPitched { get; set; }

        /// <summary>
        /// Total batting average against (BAA) while pitching
        /// </summary>
        [Description("Total batting average against (BAA) while pitching")]
        [DataMember(Name = "PitchingBattingAverageAgainst", Order = 44)]
        public decimal? PitchingBattingAverageAgainst { get; set; }

        /// <summary>
        /// Total grand slams
        /// </summary>
        [Description("Total grand slams")]
        [DataMember(Name = "GrandSlams", Order = 45)]
        public decimal? GrandSlams { get; set; }

        /// <summary>
        /// Total FanDuel fantasy points
        /// </summary>
        [Description("Total FanDuel fantasy points")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 46)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total DraftKings fantasy points
        /// </summary>
        [Description("Total DraftKings fantasy points")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 47)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo fantasy points
        /// </summary>
        [Description("Total Yahoo fantasy points")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 48)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total plate appearances
        /// </summary>
        [Description("Total plate appearances")]
        [DataMember(Name = "PlateAppearances", Order = 49)]
        public decimal? PlateAppearances { get; set; }

        /// <summary>
        /// Number of total bases
        /// </summary>
        [Description("Number of total bases")]
        [DataMember(Name = "TotalBases", Order = 50)]
        public decimal? TotalBases { get; set; }

        /// <summary>
        /// Total fly outs
        /// </summary>
        [Description("Total fly outs")]
        [DataMember(Name = "FlyOuts", Order = 51)]
        public decimal? FlyOuts { get; set; }

        /// <summary>
        /// Total ground outs
        /// </summary>
        [Description("Total ground outs")]
        [DataMember(Name = "GroundOuts", Order = 52)]
        public decimal? GroundOuts { get; set; }

        /// <summary>
        /// Total line outs
        /// </summary>
        [Description("Total line outs")]
        [DataMember(Name = "LineOuts", Order = 53)]
        public decimal? LineOuts { get; set; }

        /// <summary>
        /// Total pop outs
        /// </summary>
        [Description("Total pop outs")]
        [DataMember(Name = "PopOuts", Order = 54)]
        public decimal? PopOuts { get; set; }

        /// <summary>
        /// Total intentional walks
        /// </summary>
        [Description("Total intentional walks")]
        [DataMember(Name = "IntentionalWalks", Order = 55)]
        public decimal? IntentionalWalks { get; set; }

        /// <summary>
        /// Total times reached on error
        /// </summary>
        [Description("Total times reached on error")]
        [DataMember(Name = "ReachedOnError", Order = 56)]
        public decimal? ReachedOnError { get; set; }

        /// <summary>
        /// Total balls in play
        /// </summary>
        [Description("Total balls in play")]
        [DataMember(Name = "BallsInPlay", Order = 57)]
        public decimal? BallsInPlay { get; set; }

        /// <summary>
        /// Total batting average on balls in play (BABIP
        /// </summary>
        [Description("Total batting average on balls in play (BABIP")]
        [DataMember(Name = "BattingAverageOnBallsInPlay", Order = 58)]
        public decimal? BattingAverageOnBallsInPlay { get; set; }

        /// <summary>
        /// Total weight on base percentage
        /// </summary>
        [Description("Total weight on base percentage")]
        [DataMember(Name = "WeightedOnBasePercentage", Order = 59)]
        public decimal? WeightedOnBasePercentage { get; set; }

        /// <summary>
        /// Total singles allowed while pitching
        /// </summary>
        [Description("Total singles allowed while pitching")]
        [DataMember(Name = "PitchingSingles", Order = 60)]
        public decimal? PitchingSingles { get; set; }

        /// <summary>
        /// Total doubles allowed while pitching
        /// </summary>
        [Description("Total doubles allowed while pitching")]
        [DataMember(Name = "PitchingDoubles", Order = 61)]
        public decimal? PitchingDoubles { get; set; }

        /// <summary>
        /// Total triples allowed while pitching
        /// </summary>
        [Description("Total triples allowed while pitching")]
        [DataMember(Name = "PitchingTriples", Order = 62)]
        public decimal? PitchingTriples { get; set; }

        /// <summary>
        /// Total grand slams allowed while pitching
        /// </summary>
        [Description("Total grand slams allowed while pitching")]
        [DataMember(Name = "PitchingGrandSlams", Order = 63)]
        public decimal? PitchingGrandSlams { get; set; }

        /// <summary>
        /// Total batters hit by pitch while pitching
        /// </summary>
        [Description("Total batters hit by pitch while pitching")]
        [DataMember(Name = "PitchingHitByPitch", Order = 64)]
        public decimal? PitchingHitByPitch { get; set; }

        /// <summary>
        /// Total sacrifices while pitching
        /// </summary>
        [Description("Total sacrifices while pitching")]
        [DataMember(Name = "PitchingSacrifices", Order = 65)]
        public decimal? PitchingSacrifices { get; set; }

        /// <summary>
        /// Total sacrifice flies while pitching
        /// </summary>
        [Description("Total sacrifice flies while pitching")]
        [DataMember(Name = "PitchingSacrificeFlies", Order = 66)]
        public decimal? PitchingSacrificeFlies { get; set; }

        /// <summary>
        /// Total grounded into double plays while pitching
        /// </summary>
        [Description("Total grounded into double plays while pitching")]
        [DataMember(Name = "PitchingGroundIntoDoublePlay", Order = 67)]
        public decimal? PitchingGroundIntoDoublePlay { get; set; }

        /// <summary>
        /// Total complete games while pitching
        /// </summary>
        [Description("Total complete games while pitching")]
        [DataMember(Name = "PitchingCompleteGames", Order = 68)]
        public decimal? PitchingCompleteGames { get; set; }

        /// <summary>
        /// Total shuouts while pitching
        /// </summary>
        [Description("Total shuouts while pitching")]
        [DataMember(Name = "PitchingShutOuts", Order = 69)]
        public decimal? PitchingShutOuts { get; set; }

        /// <summary>
        /// Total no hitters while pitching
        /// </summary>
        [Description("Total no hitters while pitching")]
        [DataMember(Name = "PitchingNoHitters", Order = 70)]
        public decimal? PitchingNoHitters { get; set; }

        /// <summary>
        /// Total perfect games while pitching
        /// </summary>
        [Description("Total perfect games while pitching")]
        [DataMember(Name = "PitchingPerfectGames", Order = 71)]
        public decimal? PitchingPerfectGames { get; set; }

        /// <summary>
        /// Total plate appearances while pitching
        /// </summary>
        [Description("Total plate appearances while pitching")]
        [DataMember(Name = "PitchingPlateAppearances", Order = 72)]
        public decimal? PitchingPlateAppearances { get; set; }

        /// <summary>
        /// Total bases while pitching
        /// </summary>
        [Description("Total bases while pitching")]
        [DataMember(Name = "PitchingTotalBases", Order = 73)]
        public decimal? PitchingTotalBases { get; set; }

        /// <summary>
        /// Total fly outs while pitching
        /// </summary>
        [Description("Total fly outs while pitching")]
        [DataMember(Name = "PitchingFlyOuts", Order = 74)]
        public decimal? PitchingFlyOuts { get; set; }

        /// <summary>
        /// Total ground outs while pitching
        /// </summary>
        [Description("Total ground outs while pitching")]
        [DataMember(Name = "PitchingGroundOuts", Order = 75)]
        public decimal? PitchingGroundOuts { get; set; }

        /// <summary>
        /// Total line outs while pitching
        /// </summary>
        [Description("Total line outs while pitching")]
        [DataMember(Name = "PitchingLineOuts", Order = 76)]
        public decimal? PitchingLineOuts { get; set; }

        /// <summary>
        /// Total pop outs while pitching
        /// </summary>
        [Description("Total pop outs while pitching")]
        [DataMember(Name = "PitchingPopOuts", Order = 77)]
        public decimal? PitchingPopOuts { get; set; }

        /// <summary>
        /// Total intentional walks while pitching
        /// </summary>
        [Description("Total intentional walks while pitching")]
        [DataMember(Name = "PitchingIntentionalWalks", Order = 78)]
        public decimal? PitchingIntentionalWalks { get; set; }

        /// <summary>
        /// Total times reached on error while pitching
        /// </summary>
        [Description("Total times reached on error while pitching")]
        [DataMember(Name = "PitchingReachedOnError", Order = 79)]
        public decimal? PitchingReachedOnError { get; set; }

        /// <summary>
        /// Total catchers interference while pitching
        /// </summary>
        [Description("Total catchers interference while pitching")]
        [DataMember(Name = "PitchingCatchersInterference", Order = 80)]
        public decimal? PitchingCatchersInterference { get; set; }

        /// <summary>
        /// Total balls in play while pitching
        /// </summary>
        [Description("Total balls in play while pitching")]
        [DataMember(Name = "PitchingBallsInPlay", Order = 81)]
        public decimal? PitchingBallsInPlay { get; set; }

        /// <summary>
        /// Total on base percentage (OBP) while pitching
        /// </summary>
        [Description("Total on base percentage (OBP) while pitching")]
        [DataMember(Name = "PitchingOnBasePercentage", Order = 82)]
        public decimal? PitchingOnBasePercentage { get; set; }

        /// <summary>
        /// Total slugging percentage (SLG) while pitching
        /// </summary>
        [Description("Total slugging percentage (SLG) while pitching")]
        [DataMember(Name = "PitchingSluggingPercentage", Order = 83)]
        public decimal? PitchingSluggingPercentage { get; set; }

        /// <summary>
        /// Total on base plus slugging (OPS) while pitching
        /// </summary>
        [Description("Total on base plus slugging (OPS) while pitching")]
        [DataMember(Name = "PitchingOnBasePlusSlugging", Order = 84)]
        public decimal? PitchingOnBasePlusSlugging { get; set; }

        /// <summary>
        /// Total strikeouts per nine innings (K/9) while pitching
        /// </summary>
        [Description("Total strikeouts per nine innings (K/9) while pitching")]
        [DataMember(Name = "PitchingStrikeoutsPerNineInnings", Order = 85)]
        public decimal? PitchingStrikeoutsPerNineInnings { get; set; }

        /// <summary>
        /// Total walks per nine innings (BB/9) while pitching
        /// </summary>
        [Description("Total walks per nine innings (BB/9) while pitching")]
        [DataMember(Name = "PitchingWalksPerNineInnings", Order = 86)]
        public decimal? PitchingWalksPerNineInnings { get; set; }

        /// <summary>
        /// Total batting average on balls in play (BABIP) while pitching
        /// </summary>
        [Description("Total batting average on balls in play (BABIP) while pitching")]
        [DataMember(Name = "PitchingBattingAverageOnBallsInPlay", Order = 87)]
        public decimal? PitchingBattingAverageOnBallsInPlay { get; set; }

        /// <summary>
        /// Total weighted on base percentage while pitching 
        /// </summary>
        [Description("Total weighted on base percentage while pitching ")]
        [DataMember(Name = "PitchingWeightedOnBasePercentage", Order = 88)]
        public decimal? PitchingWeightedOnBasePercentage { get; set; }

        /// <summary>
        /// Total double plays
        /// </summary>
        [Description("Total double plays")]
        [DataMember(Name = "DoublePlays", Order = 89)]
        public decimal? DoublePlays { get; set; }

        /// <summary>
        /// Total double plays while pitching
        /// </summary>
        [Description("Total double plays while pitching")]
        [DataMember(Name = "PitchingDoublePlays", Order = 90)]
        public decimal? PitchingDoublePlays { get; set; }

        /// <summary>
        /// Whether the batting order is confirmed (true/false)
        /// </summary>
        [Description("Whether the batting order is confirmed (true/false)")]
        [DataMember(Name = "BattingOrderConfirmed", Order = 91)]
        public bool? BattingOrderConfirmed { get; set; }

        /// <summary>
        /// Total isolated power (ISO)
        /// </summary>
        [Description("Total isolated power (ISO)")]
        [DataMember(Name = "IsolatedPower", Order = 92)]
        public decimal? IsolatedPower { get; set; }

        /// <summary>
        /// Total fielding independent pitching (FIP)
        /// </summary>
        [Description("Total fielding independent pitching (FIP)")]
        [DataMember(Name = "FieldingIndependentPitching", Order = 93)]
        public decimal? FieldingIndependentPitching { get; set; }

        /// <summary>
        /// Total quality starts pitched
        /// </summary>
        [Description("Total quality starts pitched")]
        [DataMember(Name = "PitchingQualityStarts", Order = 94)]
        public decimal? PitchingQualityStarts { get; set; }

        /// <summary>
        /// The inning that the pitcher entered the game (if any).
        /// </summary>
        [Description("The inning that the pitcher entered the game (if any).")]
        [DataMember(Name = "PitchingInningStarted", Order = 95)]
        public int? PitchingInningStarted { get; set; }

        /// <summary>
        /// Total left on base percentage 
        /// </summary>
        [Description("Total left on base percentage ")]
        [DataMember(Name = "LeftOnBase", Order = 96)]
        public decimal? LeftOnBase { get; set; }

        /// <summary>
        /// Total holds pitched
        /// </summary>
        [Description("Total holds pitched")]
        [DataMember(Name = "PitchingHolds", Order = 97)]
        public decimal? PitchingHolds { get; set; }

        /// <summary>
        /// Total blown saves pitched
        /// </summary>
        [Description("Total blown saves pitched")]
        [DataMember(Name = "PitchingBlownSaves", Order = 98)]
        public decimal? PitchingBlownSaves { get; set; }

        /// <summary>
        /// The position in the batting order where this player was substituted into the game (does not include players in the starting lineup)
        /// </summary>
        [Description("The position in the batting order where this player was substituted into the game (does not include players in the starting lineup)")]
        [DataMember(Name = "SubstituteBattingOrder", Order = 99)]
        public int? SubstituteBattingOrder { get; set; }

        /// <summary>
        /// The sequence in which this player was substituted into the game, within the particular batting order
        /// </summary>
        [Description("The sequence in which this player was substituted into the game, within the particular batting order")]
        [DataMember(Name = "SubstituteBattingOrderSequence", Order = 100)]
        public int? SubstituteBattingOrderSequence { get; set; }

        /// <summary>
        /// Total FantasyDraft fantasy points
        /// </summary>
        [Description("Total FantasyDraft fantasy points")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 101)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

    }
}

