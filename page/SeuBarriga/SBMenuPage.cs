using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testes_appium_C_sharp.core;

namespace testes_appium_C_sharp.page.SeuBarriga
{
    class SBMenuPage : BasePage
    {
        public void acessarContas()
        {
            clicarTexto("CONTAS");
        }

        public void acessarMovimentacoes()
        {
            clicarTexto("MOV...");
        }

        public void acessarResumo()
        {
            clicarTexto("RESUMO");
        }

        public void acessarHome()
        {
            clicarTexto("HOME");
        }
    }
}
/*

package br.ce.gsousa.appium.page.SeuBarriga;

import br.ce.gsousa.appium.core.BasePage;

public class SBMenuPage extends BasePage
{


    public void acessarContas()
{
    clicarTexto("CONTAS");
}

public void acessarMovimentacoes()
{
    clicarTexto("MOV...");
}

public void acessarResumo()
{
    clicarTexto("RESUMO");
}

public void acessarHome()
{
    clicarTexto("HOME");
}
}


*/
