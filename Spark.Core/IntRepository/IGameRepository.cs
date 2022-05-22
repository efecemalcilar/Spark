﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spark.Core.Models;

namespace Spark.Core.IntRepository
{
    public interface IGameRepository: IRepository<Question>
    {
        Task<IEnumerable<Question>>GetAllWithAnswersAsync();
        Task<Question> GetWithAnswersByIdAsync(Guid qId);
    }
}
