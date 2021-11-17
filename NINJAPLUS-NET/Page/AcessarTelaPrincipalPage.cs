using Coypu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NINJAPLUS_NET.Page
{
   public class AcessarTelaPrincipalPage
    {
        private readonly BrowserSession _browser;

        public AcessarTelaPrincipalPage(BrowserSession browser) {
            _browser = browser;


        }

        public void acessaTelaSistema(String caminho) {
            _browser.Visit(caminho);
        }
    }
}
