using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqTemplate
{
    /* Esta class vai ser usada para consumir os dados dentro do json
     * Neste caso vamos consumir a informação que esta dentro do array de array de string (data).
     */
    class Person
    {
        // Variaveis tipo string com get e set
        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
    }
}
