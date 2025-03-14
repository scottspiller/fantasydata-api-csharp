﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.NetCore.Model.NHL;

namespace FantasyData.Api.Client.NetCore
{
    public partial class NHLv3ProjectionsClient : BaseClient
    {
        public NHLv3ProjectionsClient(string apiKey) : base(apiKey) { }
        public NHLv3ProjectionsClient(Guid apiKey) : base(apiKey) { }

        /// <summary>
        /// Get DFS Slates by Date Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
        public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<DfsSlate>>(() =>
                base.Get<List<DfsSlate>>("/v3/nhl/projections/{format}/DfsSlatesByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get DFS Slates by Date
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
        public List<DfsSlate> GetDfsSlatesByDate(string date)
        {
            return this.GetDfsSlatesByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            return Task.Run<List<PlayerGameProjection>>(() =>
                base.Get<List<PlayerGameProjection>>("/v3/nhl/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Date (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        public List<PlayerGameProjection> GetPlayerGameProjectionStatsByDate(string date)
        {
            return this.GetPlayerGameProjectionStatsByDateAsync(date).Result;
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries) Asynchronous
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code>.</param>
        public Task<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("date", date.ToString()));
            parameters.Add(new KeyValuePair<string, string>("playerid", playerid.ToString()));
            return Task.Run<PlayerGameProjection>(() =>
                base.Get<PlayerGameProjection>("/v3/nhl/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters)
            );
        }

        /// <summary>
        /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries)
        /// </summary>
        /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
        /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code>.</param>
        public PlayerGameProjection GetPlayerGameProjectionStatsByPlayer(string date, int playerid)
        {
            return this.GetPlayerGameProjectionStatsByPlayerAsync(date, playerid).Result;
        }

    }
}

