namespace Application {

    public class Program {

        public static void Main(String[] args) {

            Console.Write("Digite um texto: ");
            var input01 = Console.ReadLine();

            Console.Write("Esta frase têm {0} palavras.", Length(input01));
        }

        public static int Length(string text) {
            String[] parts = text.Split(' ');
            return parts.Length;
        }
    }
}