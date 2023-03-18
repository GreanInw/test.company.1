namespace TestPOS
{
    internal class Test2
    {
        private char[] Characters => "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
        private List<string> AllChars = new List<string>();

        public Test2() => InitializeData();

        public void Run()
        {
            while (true)
            {
                Console.Write("Please enter number : ");
                var line = Console.ReadLine();
                if (!int.TryParse(line, out int value) || value > AllChars.Count)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                Console.WriteLine($"Output character : {AllChars[value - 1]}");
            }
        }

        private void InitializeData()
        {
            AllChars = WriteCharacter(WriteCharacter());
        }

        private List<string> WriteCharacter(List<string> items = null)
        {
            var values = items is null ? new List<string>() : new List<string>(items);
            foreach (char c in Characters)
            {
                if (items is null)
                {
                    values.Add($"{c}");
                }
                else if (items is not null)
                {
                    foreach (string s in items)
                    {
                        values.Add($"{c}{s}");
                    }
                }
            }
            return values;
        }
    }
}
