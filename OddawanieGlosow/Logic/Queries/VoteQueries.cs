using System.Collections.Generic;
using System.Linq;
using Dapper;
using OddawanieGlosow.Models.Entities;

namespace OddawanieGlosow.Logic.Queries
{
    public class VoteQueries
    {
        private readonly ConnectionFactory _connectionFactory;

        public VoteQueries()
        {
            _connectionFactory = new ConnectionFactory();
        }

        public PollOption GetPollOptionByNumberAndPollId(int optionNumber, int pollId)
        {
            using (var connection = _connectionFactory.OpenConnection())
            {
                var pollOptions = connection.Query<PollOption>(GetPollOptionByNumberAndPollIdQuery, new { POLLID = pollId, OPTIONNUMBER = optionNumber });
                return pollOptions.FirstOrDefault();
            }
        }

        public void CreateVote(int pollOptionId)
        {
            using (var connection = _connectionFactory.OpenConnection())
            {
                connection.Query(InsertVoteQuery, new { POLLOPTIONID = pollOptionId });
            }
        }

        public List<PollOption> GetPollOptions(int pollId)
        {
            using (var connection = _connectionFactory.OpenConnection())
            {
                var pollOptions = connection.Query<PollOption>(GetPollOptionsByPollIdQuery, new { POLLID = pollId });
                return pollOptions.ToList();
            }
        }

        public Poll GetPollById(int pollId)
        {
            using (var connection = _connectionFactory.OpenConnection())
            {
                var poll = connection.Query<Poll>(GetPollByIdQuery, new { ID = pollId });
                return poll.FirstOrDefault();
            }
        }

        private const string GetPollOptionByNumberAndPollIdQuery = @"SELECT * FROM [dbo].[PollOptions] WHERE PollId = @POLLID AND OptionNumber = @OPTIONNUMBER";
        private const string GetPollByIdQuery = @"SELECT * FROM [dbo].[Polls] WHERE Id = @ID";
        private const string GetPollOptionsByPollIdQuery = @"SELECT * FROM [dbo].[PollOptions] WHERE PollId = @POLLID";
        private const string InsertVoteQuery = @"INSERT INTO [dbo].[Votes] (PollOptionId) VALUES (@POLLOPTIONID)";
    }
}