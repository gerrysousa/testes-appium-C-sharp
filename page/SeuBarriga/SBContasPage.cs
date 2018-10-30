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
    class SBContasPage : BasePage
    {
        public void setConta(String nome)
        {
            escrever(By.ClassName("android.widget.EditText"), nome);
        }

        public void salvar()
        {
            clicarTexto("SALVAR");
        }

        public void selecionarContas(String conta)
        {
            cliqueLongo(By.XPath("//*[@text='" + conta + "']"));
        }

        public void excluir()
        {
            clicarTexto("EXCLUIR");
        }
    }
}
/*
package br.ce.gsousa.appium.page.SeuBarriga;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;

public class SBContasPage extends BasePage
{


    public void setConta(String nome)
{
    escrever(By.ClassName("android.widget.EditText"), nome);
}

public void salvar()
{
    clicarTexto("SALVAR");
}

public void selecionarContas(String conta)
{
    cliqueLongo(By.XPath("//*[@text='" + conta + "']"));
}

public void excluir()
{
    clicarTexto("EXCLUIR");
}
}


*/
