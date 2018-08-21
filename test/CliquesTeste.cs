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
    class CliquesTeste : BaseTest
    {
        private MenuPage menu = new MenuPage();
        private CliquesPage page = new CliquesPage();

        [SetUp]
    public void setup()
        {
            menu.acessarCliques();
        }

        [Test]
    public void deveRealizarCliqueLongo()
        {
            page.cliqueLongo();

            Assert.AreEqual("Clique Longo", page.obterTextoCampo());
        }

        [Test]
    public void deveRealizarCliqueDuplo()
        {
            page.clicarTexto("Clique duplo");
            page.clicarTexto("Clique duplo");

            Assert.AreEqual("Duplo Clique", page.obterTextoCampo());
        }
    }
}
/*
package br.ce.gsousa.appium.test;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.CliquesPage;
import br.ce.gsousa.appium.page.MenuPage;

public class CliquesTeste extends BaseTest
{


    private MenuPage menu = new MenuPage();
private CliquesPage page = new CliquesPage();

[SetUp]
    public void setup()
{
    menu.acessarCliques();
}

[Test]
    public void deveRealizarCliqueLongo()
{
    page.cliqueLongo();

    Assert.AreEqual("Clique Longo", page.obterTextoCampo());
}

[Test]
    public void deveRealizarCliqueDuplo()
{
    page.clicarTexto("Clique duplo");
    page.clicarTexto("Clique duplo");

    Assert.AreEqual("Duplo Clique", page.obterTextoCampo());
}
}


*/
