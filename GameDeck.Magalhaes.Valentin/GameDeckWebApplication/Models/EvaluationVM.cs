﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameDeckWebApplication.Models
{
    /// <summary>
    /// Represente le viewmodel d'une evaluation.
    /// </summary>
    public class EvaluationVM
    {
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtient ou definit le nom de l'evaluateur de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public string NomEvaluateur { get; set; }

        /// <summary>
        /// Obtient ou definit la date de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Obtient ou definit la note de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public float Note { get; set; }

        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="JeuVM"/> de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public int JeuId { get; set; }

        /// <summary>
        /// Obtient ou definit le <see cref="JeuVM"/> de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public JeuVM JeuObj { get; set; }
    }
}