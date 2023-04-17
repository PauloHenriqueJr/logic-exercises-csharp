namespace Exercises
{
    public class ExerciseDictionary
    {
        private readonly Dictionary<int, Dictionary<int, List<Action>>> _exercises = new Dictionary<int, Dictionary<int, List<Action>>>();

        public ExerciseDictionary()
        {
            Initialize();
        }

        private void Initialize()
        {
            AddExerciseList(1, new List<(int, Action[])>
            {
                (1, new[] { SquaresOfSequence.Solution1 }),
                (2, new[] { SumOfNNumbers.Solution1, SumOfNNumbers.Solution2 }),
                (3, new[] { OddNumbers.Solution1, OddNumbers.Solution2 }),
                (4, new[] { PowerOfX.Solution1, PowerOfX.Solution2 }),
                (5, new[] { DailySalesMarch.Solution1, DailySalesMarch.Solution2}),
                (6, new[] { GradeStatistics.Solution1})
            });
        }

        private void AddExerciseList(int listNumber, List<(int, Action[])> exercises)
        {
            var exercisesList = new Dictionary<int, List<Action>>();
            foreach (var exercise in exercises)
            {
                exercisesList[exercise.Item1] = exercise.Item2.ToList();
            }
            _exercises[listNumber] = exercisesList;
        }

        public bool ContainsList(int listNumber)
        {
            return _exercises.ContainsKey(listNumber);
        }

        public Dictionary<int, List<Action>> GetExercisesList(int listNumber)
        {
            return _exercises[listNumber];
        }

        public List<int> GetLists()
        {
            return _exercises.Keys.ToList();
        }
    }
}
