using System.IO ;
namespace TexEditor {
    class Program {
        static void Main(string[] args) {
            MenuApp();
        }

        static void MenuApp() {
            short option;

            Console.Clear();
            Console.WriteLine("Choose your option:");
            Console.WriteLine("1 - Open File");
            Console.WriteLine("2 - Create New File ");
            Console.WriteLine("0 - Exit");

            option = short.Parse(Console.ReadLine());

            switch(option) {
                case 1: Open_File(); break;
                case 2: Edit_File(); break;
                case 0: System.Environment.Exit(0); break;
                default: MenuApp(); break;
            }
        }

        static void Open_File() {}
        static void Edit_File() {
            string text = "";

            Console.Clear();
            Console.WriteLine("Type your text below");
            Console.WriteLine("-----------------------");

            do {
                text += Console.ReadLine();
                text += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save_File(text);
            
        }

        static void Save_File(string text) {
            string path = "./files";
            string filename;
            bool check_directory = Directory.Exists(path);

            Console.WriteLine("How will be named your file?");
            filename = Console.ReadLine();

            if (check_directory == false) {
               Directory.CreateDirectory(path);
            }

            using (var file = new StreamWriter($"{path}/{filename}.txt")) {
                file.Write(text);
            }

            Console.WriteLine($"File saved in {path} successfully");
            MenuApp();
        }
    }
}