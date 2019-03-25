using System;

// Vai me permitir usar ficheiros, leitura escrita entre outros
using System.IO;

// Permite o use de listas
using System.Collections.Generic;

// Json
using Newtonsoft.Json;

namespace FreqTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui podiam usar um array ou algo do genero eu prefiro usar lista por ser mais dinamico e não ter que me preocupar em definir o seu tamanho
            // mas sim apenas uma nova instancia.
            List<Person> ppl = new List<Person>();

            // Aqui estou a definir varivael do StreamReader para poder ler o meu ficheiro json
            using (var file = new StreamReader("data.json"))
            {
                // Aqui estou a ler do meu ficheiro e a converter no tipo da minha class que 
                // corresponde a formatacao do ficheiro json
                JsonStructure message = JsonConvert.DeserializeObject<JsonStructure>(file.ReadToEnd());

                /* Ciclo esta a percorrer o meu array data
                 * 
                 * Exemplo :
                 * 
                 * Tenho um array string com os dados { "Chandler", "Joey", "Ross", "Rachel", "Phoebe", "Monica"}
                 * 
                 * O for each vai me percorrer o meu array todo pegando somente num item de cada vez.
                 */
                foreach (var content in message.data)
                {
                    /* Aqui estou a colocar diretamente a nova instancia da class na lista como novo elemento
                     * 
                     * Outra maneira
                     * Person p = new Person();
                     * p.Id = content[0];
                     * p.Name = content[1];
                     * p.Email = content[2];
                     * 
                     * ppl.add(p);
                     * 
                     * Mais uma vez eu faço apenas de uma maneira mais "direta"
                     */
                    ppl.Add(new Person()
                    {
                        Id = content[0],
                        Name = content[1],
                        Email = content[2]
                    });
                }
            }
            
            // Aqui usa o streamwriter para escrever no ficheiro
            using (var file = new StreamWriter("sql.sql"))
            {
                // Mesmo exemplo do foreach mas agora a percorrer a minha lista
                foreach (var content in ppl)
                {
                    // Estou a escrever linha a linha o conteudo de cada elemento da lista do tipo da class Person. dai a variavel content ter acesso aos campos "Id", "Name", "Email"
                    file.WriteLine($"INSERT INTO people (id, name, email) VALUES ('{content.Id}', '{content.Name}', '{content.Email}');");
                }
            }
            
            // Fica a espera de fechar o comando
            Console.ReadKey();
        }
    }
}

