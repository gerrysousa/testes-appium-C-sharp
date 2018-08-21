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
    class OpcaoEscondidaTeste : BaseTest
    {
        private MenuPage menu = new MenuPage();

        [Test]
    public void deveAcessarOpcaoEscondida()
        {
            WebDriverWait wait = new WebDriverWait(getDriver(), 10);
            Wait.Until(ExpectedConditions.presenceOfElementLocated(By.XPath("//*[@text='Formulário']")));

            menu.scrollDown();

            menu.clicarTexto("Opção bem escondida");

            Assert.AreEqual("Você achou essa opção", menu.obterMensageAlerta());

            menu.clicarTexto("OK");

        }
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


public class OpcaoEscondidaTeste extends BaseTest
{


    private MenuPage menu = new MenuPage();

[Test]
    public void deveAcessarOpcaoEscondida()
{
    WebDriverWait wait = new WebDriverWait(getDriver(), 10);
    Wait.Until(ExpectedConditions.presenceOfElementLocated(By.XPath("//*[@text='Formulário']")));

    menu.scrollDown();

    menu.clicarTexto("Opção bem escondida");

    Assert.AreEqual("Você achou essa opção", menu.obterMensageAlerta());

    menu.clicarTexto("OK");

}

}


*/
