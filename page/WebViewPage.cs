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
    class WebViewPage : BasePage
    {
        public void entrarContextoWeb()
        {
            var contextNames = DriverFactory.getDriver().Contexts;
            
            //ISet<String> 
             // string  contextHandles = (DriverFactory.getDriver().Contexts).ToString();
           // for (String valor : contextHandles)
            //{
                //System.out.print(valor);
                //System.out.print(contextHandles);
           // }
            // getDriver().context((String)contextHandles.toArray()[1]);

        }

        public void setEmail(String email)
        {
            DriverFactory.getDriver().FindElement(By.Id("email")).SendKeys(email);
        }

        public void setSenha(String senha)
        {
            DriverFactory.getDriver().FindElement(By.Id("senha")).SendKeys(senha);
        }

        public void sairContextoWeb()
        {
           // DriverFactory.getDriver().Context((String)getDriver().getContextHandles().toArray()[0]);
        }

        public String getMensagem()
        {
            return obterTexto(By.XPath("//* /div[@class='alert alert-sucess']"));
        }

        public bool getMensagem2(String texto)
        {
            return existeElementoPorTexto(texto);
        }

        public void entrar()
        {
            clicarTexto("Entrar");
        }
    }
}
/*
package br.ce.gsousa.appium.page;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import java.util.Set;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;
import br.ce.gsousa.appium.core.DriverFactory;

public class WebViewPage extends BasePage
{


    public void entrarContextoWeb()
{
    Set<String> contextHandles = DriverFactory.getDriver().getContextHandles();
    for (String valor : contextHandles)
    {
        System.out.print(valor);
        System.out.print(contextHandles);
    }
    // getDriver().context((String)contextHandles.toArray()[1]);
}

public void setEmail(String email)
{
    getDriver().FindElement(By.Id("email")).SendKeys(email);
}

public void setSenha(String senha)
{
    getDriver().FindElement(By.Id("senha")).SendKeys(senha);
}

public void sairContextoWeb()
{
    getDriver().context((String)getDriver().getContextHandles().toArray()[0]);
}

public String getMensagem()
{
    return obterTexto(By.XPath("//* /div[@class='alert alert-sucess']"));
}

public bool getMensagem2(String texto)
{
    return existeElementoPorTexto(texto);
}

public void entrar()
{
    clicarTexto("Entrar");
}

}


*/
