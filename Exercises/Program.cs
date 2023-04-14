using Exercises;

ExerciseDictionary exercisesDictionary = new ExerciseDictionary();

// Main loop of the program, which keeps running until interrupted by the user.
while (true)
{
    Console.Clear();

    // Show the available exercise lists and allow the user to select one.
    int selectedList = ShowExerciseLists(exercisesDictionary);
    if (selectedList == -1)
    {
        break;
    }

    // Gets the selected exercise list and allows the user to select an exercise.
    Dictionary<int, List<Action>> exercisesList = exercisesDictionary.GetExercisesList(selectedList);
    int selectedExercise = ShowExercises(exercisesList);
    if (selectedExercise == -1)
    {
        continue;
    }

    // Gets the list of solutions for the selected exercise and allows the user to select a solution.
    List<Action> solutionsList = exercisesList[selectedExercise];
    while (true)
    {
        Console.Clear();
        int selectedSolution = ReadSolutionNumber(solutionsList.Count);
        if (selectedSolution == -1)
        {
            break;
        }

        // Runs the solution selected by the user.
        Action solution = solutionsList[selectedSolution - 1];
        solution();
        Console.WriteLine("Pressione qualquer tecla para continuar.");
        Console.ReadKey();
    }
}


// Show the available exercise lists and allow the user to select one of them.
static int ShowExerciseLists(ExerciseDictionary exercisesDictionary)
{
    Console.WriteLine("Digite o número da lista de exercícios abaixo:\n");
    foreach (int listNumber in exercisesDictionary.GetLists())
    {
        Console.WriteLine($"{listNumber} - Lista {listNumber}");
    }

    int selectedList;
    while (!int.TryParse(Console.ReadLine(), out selectedList) || !exercisesDictionary.ContainsList(selectedList))
    {
        Console.WriteLine("Lista inválida. Digite um número de lista válido ou 's' para sair.");
        if (Console.ReadLine().ToLower() == "s")
        {
            return -1;
        }
    }

    return selectedList;
}

// Gets the selected exercise list and allows the user to select an exercise.
static int ShowExercises(Dictionary<int, List<Action>> exercisesList)
{
    Console.WriteLine($"\nExercícios - Lista {exercisesList.Keys.First()}\n");
    Console.WriteLine("Digite o número do exercício abaixo ou 'q' para voltar as listas de exercícios.\n");
    foreach (int exerciseNumber in exercisesList.Keys)
    {
        Console.WriteLine($"{exerciseNumber} - Exercício {exerciseNumber}");
    }

    string input = Console.ReadLine().ToLower();
    if (input == "q")
    {
        return -1;
    }

    int selectedExercise;
    while (!int.TryParse(input, out selectedExercise) || !exercisesList.ContainsKey(selectedExercise))
    {
        Console.WriteLine("Exercício inválido. Digite um número de exercício válido ou 'q' para voltar as listas de exercícios.");
        input = Console.ReadLine().ToLower();
        if (input == "q")
        {
            return -1;
        }
    }

    return selectedExercise;
}

// Gets the solution selected by the user and executes it.
static int ReadSolutionNumber(int maxSolutionNumber)
{
    Console.WriteLine("Digite o número da solução abaixo ou 'q' para voltar ao menu anterior.");
    for (int i = 0; i < maxSolutionNumber; i++)
    {
        Console.WriteLine($"{i + 1} - Solução {i + 1}");
    }

    string input = Console.ReadLine().ToLower();
    if (input == "q")
    {
        return -1;
    }
    else if (!int.TryParse(input, out int selectedSolution) || selectedSolution < 1 || selectedSolution > maxSolutionNumber)
    {
        Console.WriteLine("Solução inválida. Digite um número de solução válido ou 'q' para voltar ao menu anterior.");
        return ReadSolutionNumber(maxSolutionNumber);
    }
    else
    {
        return selectedSolution;
    }
}