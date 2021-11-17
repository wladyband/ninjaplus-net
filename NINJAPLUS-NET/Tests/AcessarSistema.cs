using Coypu;
using NINJAPLUS_NET.Common;
using NINJAPLUS_NET.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NINJAPLUS_NET.Tests
{
    public class AcessarSistema:BaseTest
    {
        public BrowserSession browser;
        private AcessarTelaPrincipalPage _acessaPage;


        [SetUp]
        public void IniciarFerramenta()
        {
            _acessaPage = new AcessarTelaPrincipalPage(browser);
         }


        [Test]
        public void Test1()
        {


        }

    }
}
