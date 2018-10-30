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
    class SBMovimentacaoPage : BasePage
    {
        public void salvar()
        {
            clicarTexto("SALVAR");
        }

        public void setDescricao(String descricao)
        {
            escrever(By.ClassName("android.widget.EditText"), descricao);
        }

        public void setInteressado(String interessado)
        {
            escrever(By.XPath("//android.widget.EditText[2]"), interessado);
        }

        public void setValor(String valor)
        {
            escrever(By.XPath("//android.widget.EditText[3]"), valor);
        }

        public void setConta(String conta)
        {
            selecionarCombo(By.XPath("//android.widget.Spinner[2]"), conta);
        }
    }
}
/*
package br.ce.gsousa.appium.page.SeuBarriga;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;

public class SBMovimentacaoPage extends BasePage
{


    public void salvar()
{
    clicarTexto("SALVAR");
}

public void setDescricao(String descricao)
{
    escrever(By.ClassName("android.widget.EditText"), descricao);
}

public void setInteressado(String interessado)
{
    escrever(By.XPath("//android.widget.EditText[2]"), interessado);
}

public void setValor(String valor)
{
    escrever(By.XPath("//android.widget.EditText[3]"), valor);
}

public void setConta(String conta)
{
    selecionarCombo(By.XPath("//android.widget.Spinner[2]"), conta);
}
}


*/
