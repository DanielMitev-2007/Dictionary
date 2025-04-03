namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ComputerProgram> computerPrograms = ComputerProgramGenerator.GeneratePrograms();
            PrintPrograms(computerPrograms);
            Console.WriteLine();

            if (ContainsDuplicate(computerPrograms))
            {
                Console.WriteLine("Virus is found!");
            }
            else
            {
                Console.WriteLine("Virus isn't found.");
            }


        }

        public static bool ContainsDuplicate(List<ComputerProgram> programs)
        {
            Dictionary<int, int> idTracker = new Dictionary<int, int>();

            foreach (var program in programs)
            {
                if (idTracker.ContainsKey(program.ID))
                {
                    return true;
                }
                idTracker[program.ID] = 1; 
            }

            return false;
        }

        public static void PrintPrograms(List<ComputerProgram> programs)
        {
            foreach (var program in programs)
            {
                Console.WriteLine(program.ToString());
            }
        }
    }
}
