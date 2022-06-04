﻿using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckBusiness.Queries
{
    /// <summary>
    /// 
    /// </summary>
    internal class EvaluationQuery : BaseQuery<Evaluation>
    {
        public EvaluationQuery(Context context) : base(context) { }

        public new Evaluation Add(Evaluation evaluation) => base.Add(evaluation);
    }
}
