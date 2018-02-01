using System;
using System.Linq;
using Dapper;
using OddawanieGlosow.Models.Entities;

namespace OddawanieGlosow.Logic.Queries
{
    public class UsersPresenceQueries
    {
        private readonly ConnectionFactory _connectionFactory;

        public UsersPresenceQueries()
        {
            _connectionFactory = new ConnectionFactory();
        }

        public bool HasUserAlreadyParticipated(string pesel, int pollId)
        {
            using (var connection = _connectionFactory.OpenConnection())
            {
                var poll = connection.Query<Poll>(HasUserAlreadyParticipatedQuery, new { PESEL = pesel, POLLID = pollId });
                return poll.Any();
            }
        }

        public void RegisterPresence(string pesel, int pollId)
        {
            using (var connection = _connectionFactory.OpenConnection())
            {
                connection.Query(RegisterPresenceQuery, new { PESEL = pesel, POLLID = pollId });
            }
        }

        private const string HasUserAlreadyParticipatedQuery = @"SELECT * FROM [dbo].[Presences] WHERE Pesel = @PESEL AND PollId = @POLLID";
        private const string RegisterPresenceQuery = @"INSERT INTO [dbo].[Presences] (Pesel, PollId) VALUES (@PESEL, @POLLID)";
    }
}