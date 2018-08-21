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
    class SwipeListTeste
    {
    }
}
/*
package br.ce.gsousa.appium.test;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import org.junit.Assert;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.MenuPage;
import br.ce.gsousa.appium.page.SwipeListPage;

public class SwipeListTeste extends BaseTest
{


    private MenuPage menu = new MenuPage();
private SwipeListPage page = new SwipeListPage();

@Test
    public void deveIntaragirSwipeList()
{
    WebDriverWait wait = new WebDriverWait(getDriver(), 10);
    wait.until(ExpectedConditions.presenceOfElementLocated(By.XPath("//*[@text='Formulário']")));
    menu.scroll(0.9, 0.10);
    menu.acessarSwipeList();

    page.swipeElementRight("Opção 1");
    page.clicarBotaoMais();
    Assert.assertTrue(page.existeElementoPorTexto("Opção 1 (+)"));

    page.swipeElementRight("Opção 4");
    page.clicarTexto("(-)");
    Assert.assertTrue(page.existeElementoPorTexto("Opção 4 (-)"));

    page.swipeElementLeft("Opção 5 (-)");
    Assert.assertTrue(page.existeElementoPorTexto("Opção 5"));
}

}


*/
