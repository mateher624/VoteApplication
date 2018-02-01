using System;
using System.Collections.Generic;
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
                //todo tu robimy co chcemy, using sam zamyka connection
                var dupa = connection.Query<Poll>(GetPollQuery, new { id = 1 });


            }

            throw new NotImplementedException();
        }

        public void CreateVote(int pollOptionId)
        {
            throw new NotImplementedException();
        }

        public List<PollOption> GetPollOptions(int pollId)
        {
            throw new NotImplementedException();
        }

        public Poll GetPollById(int pollId)
        {
            throw new NotImplementedException();
        }

        private const string GetPollQuery = @"SELECT * FROM Poll";
    }
}