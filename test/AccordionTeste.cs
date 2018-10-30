using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testes_appium_C_sharp.core;
using testes_appium_C_sharp.page;


namespace testes_appium_C_sharp.test
{
    class AccordionTeste : BaseTest
    {
        private MenuPage menu = new MenuPage();
        private AccordionPage page = new AccordionPage();

        [Test]
    public void deveInteragirComAccordion()
        {

            menu.acessarAccordion();
            page.selecionarOpc1();
            esperar(1000);

            Assert.AreEqual("Esta é a descrição da opção 1", page.obterValorOpc1());

        }
    }
}
/*
package br.ce.gsousa.appium.test;

import org.junit.Test;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.AccordionPage;
import br.ce.gsousa.appium.page.MenuPage;
import org.junit.Assert;

public class AccordionTeste extends BaseTest
{


    private MenuPage menu = new MenuPage();
private AccordionPage page = new AccordionPage();

[Test]
    public void deveInteragirComAccordion()
{

    menu.acessarAccordion();
    page.selecionarOpc1();
    esperar(1000);

    Assert.AreEqual("Esta é a descrição da opção 1", page.obterValorOpc1());

}
}


*/
