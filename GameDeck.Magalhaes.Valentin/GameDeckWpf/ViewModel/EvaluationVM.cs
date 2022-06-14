using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckWpf.ViewModel
{
    /// <summary>
    /// Represente le VM de l'entite <see cref="Evaluation"/>.
    /// </summary>
    public class EvaluationVM : BaseVM
    {
        private int _id;
        /// <summary>
        /// Obtient ou definit l'identifiant de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _nomEvaluateur;
        /// <summary>
        /// Obtient ou definit le nom de l'evaluateur de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public string NomEvaluateur
        {
            get => _nomEvaluateur;
            set
            {
                _nomEvaluateur = value;
                OnPropertyChanged();
            }
        }

        private DateTime _date;
        /// <summary>
        /// Obtient ou definit la date de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        private float _note;
        /// <summary>
        /// Obtient ou definit la note de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public float Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged();
            }
        }

        private int _jeuId;
        /// <summary>
        /// Obtient ou definit l'identifiant du <see cref="Jeu"/> de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public int JeuId
        {
            get => _jeuId;
            set
            {
                _jeuId = value;
                OnPropertyChanged();
            }
        }

        private JeuVM _jeuObj;
        /// <summary>
        /// Obtient ou definit le <see cref="Jeu"/> de l'<see cref="EvaluationVM"/>.
        /// </summary>
        public JeuVM JeuObj
        {
            get => _jeuObj;
            set
            {
                _jeuObj = value;
                OnPropertyChanged();
            }
        }
    }
}
