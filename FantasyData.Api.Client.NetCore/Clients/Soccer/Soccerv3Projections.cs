﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.NetCore.Model.Soccer;

namespace FantasyData.Api.Client.NetCore
{
    public partial class Soccerv3ProjectionsClient : BaseClient
    {
        public Soccerv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public Soccerv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get Projected Player Game Stats by Competition (w/ DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByCompetitionAsync(string competition, string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("competition", competition.ToString()));
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/soccer/projections/{format}/PlayerGameProjectionStatsByCompetition/{competition}/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Competition (w/ DFS Salaries)
        /// </summary>
        /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByCompetition(string competition, string date)
        {
            return this.GetPlayerGameProjectionStatsByCompetitionAsync(competition, date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/soccer/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            return this.GetPlayerGameProjectionStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/soccer/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameProjectionStatsByPlayerAsync(date, playerid).Result;
        }

    }
}

