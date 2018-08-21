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
    class SBLoginPage : BasePage
    {
        public void setEmail(String email)
        {
            escrever(By.ClassName("android.widget.EditText"), email);
        }

        public void setSenha(String senha)
        {
            escrever(By.XPath("//android.widget.EditText[2]"), senha);
        }

        public void entrar()
        {
            clicarTexto("ENTRAR");
        }
    }
}
/*
package br.ce.gsousa.appium.page.SeuBarriga;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;

public class SBLoginPage extends BasePage
{


    public void setEmail(String email)
{
    escrever(By.ClassName("android.widget.EditText"), email);
}

public void setSenha(String senha)
{
    escrever(By.XPath("//android.widget.EditText[2]"), senha);
}

public void entrar()
{
    clicarTexto("ENTRAR");
}

}


*/
