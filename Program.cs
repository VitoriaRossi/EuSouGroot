Console.WriteLine("--- Groot Chatbot ---\n");

string pergunta;
do
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;

    if (pergunta.ToLower() == "tchau") {
      Console.WriteLine($"                          Resposta: Eu sou Groot!");
    } else {
      Console.WriteLine($"                          Resposta: Eu sou Groot.");
    }

} while (pergunta.ToLower() != "tchau");