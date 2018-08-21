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
    class WebViewTeste
    {
    }
}
/*
package br.ce.gsousa.appium.test;

import org.junit.Assert;
import org.junit.Test;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.MenuPage;
import br.ce.gsousa.appium.page.WebViewPage;

public class WebViewTeste extends BaseTest
{


    private MenuPage menu = new MenuPage();
private WebViewPage page = new WebViewPage();

@Test
    public void deveFazerLogin()
{
    menu.acessaSBHibrido();
    esperar(6000);
    page.entrarContextoWeb();

    page.setEmail("em@em ");
    page.setSenha("1");
    page.entrar();
    esperar(6000);

    //System.out.print(DriverFactory.getDriver().getPageSource());
    //Assert.assertEquals("Bem vindo, teste!", page.getMensagem());	
    Assert.assertTrue(page.getMensagem2("Bem vindo, teste!"));
}

}


*/
