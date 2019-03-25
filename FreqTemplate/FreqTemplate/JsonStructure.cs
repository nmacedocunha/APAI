using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreqTemplate
{
    /// <summary>
    /// Esta class vai ser usada para consumir o nosso ficheiro JSON, logo a estrutura tem que ir de acordo com o template do ficheiro .json
    /// </summary>
    class JsonStructure
    {
        /*
        "cols": [
		     "id",
		    "name",
		    "email"
	    ],*/
        public string[] cols;

        /*
        "data": [
		    [
			    "CBDF23E3-83B2-246F-948C-D4CB7FED3ECA",
			    "Jerry Herman",
			    "et.netus.et@imperdiet.co.uk"
		    ],
		    [
			    "B9C3B63E-6282-F566-E592-796C17E67509",
			    "Zenia Moss",
			    "amet.consectetuer.adipiscing@imperdietullamcorperDuis.com"
		    ],           
        ]
        */
        public string[][] data;

        /* Em cima de cada variavel é possivel ver a comparação do tipo das variaveis e a sua estrutura
         * No caso do cols é um array de string
         * No data é um array de arrays de string
         * 
         * Mais uma vez é necessário ter sempre atenção ao nome das variaveis e seu tipo\estrutura para corresponder a informação que estamos a "despejar"
         */         
    }
}
