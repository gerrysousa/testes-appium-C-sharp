using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testes_appium_C_sharp.core;
namespace testes_appium_C_sharp.page
{
    class AlertaPage : BasePage
    {
        public void clicarAlertaConfirm()
        {
            clicarTexto("ALERTA CONFIRM");
        }

        public void confirmar()
        {
            clicarTexto("CONFIRMAR");
        }

        public void sair()
        {
            clicarTexto("SAIR");
        }

        public void clicarAlertaSimples()
        {
            clicarTexto("ALERTA SIMPLES");
        }

        public void clicarForaCaixa()
        {
            tap(100, 150);
        }
    }
}
/*

package br.ce.gsousa.appium.page;

import br.ce.gsousa.appium.core.BasePage;

public class AlertaPage extends BasePage
{


    public void clicarAlertaConfirm()
{
    clicarTexto("ALERTA CONFIRM");
}



public void confirmar()
{
    clicarTexto("CONFIRMAR");
}

public void sair()
{
    clicarTexto("SAIR");
}

public void clicarAlertaSimples()
{
    clicarTexto("ALERTA SIMPLES");
}

public void clicarForaCaixa()
{
    tap(100, 150);
}
	
}


*/
