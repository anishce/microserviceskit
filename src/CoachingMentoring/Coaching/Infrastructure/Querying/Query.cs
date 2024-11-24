﻿using System.Collections.Generic;

namespace AnishCeDev.CoachingMentoring.Coaching.Infra.Querying
{
    public class Query
    {
        private IList<Query> _subQueries = new List<Query>();

        public IEnumerable<Query> SubQueries
        {
            get { return _subQueries; }
        }

        public void AddSubQuery(Query subQuery)
        {
            _subQueries.Add(subQuery);
        }

    }
}
