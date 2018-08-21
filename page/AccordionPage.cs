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
    class AccordionPage : BasePage
    {
        public void selecionarOpc1()
        {
            clicarTexto("Opção 1");
        }

        public String obterValorOpc1()
        {
            return obterTexto(By.XPath("//*[@text='Opção 1']/../..//following-sibling::android.view.ViewGroup//android.widget.TextView"));
        }
    }
}
/*
package br.ce.gsousa.appium.page;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;

public class AccordionPage extends BasePage
{


    public void selecionarOpc1()
{
    clicarTexto("Opção 1");
}

public String obterValorOpc1()
{
    return obterTexto(By.XPath("//*[@text='Opção 1']/../..//following-sibling::android.view.ViewGroup//android.widget.TextView"));
}
}


*/
