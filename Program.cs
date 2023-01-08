namespace TexEditor {
    class Program {
        static void Main(string[] args) {

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
                case 1: break;
                case 2: break;
                default: break;
            }
        }

        static void Create_File() {}
        static void Open_File() {}
        static void Edit_File() {}
    }
}