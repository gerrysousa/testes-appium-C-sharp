using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testes_appium_C_sharp.core;

namespace testes_appium_C_sharp.page
{
    class SwipeListPage : BasePage
    {
        public void swipeElementLeft(String opcao)
        {
            swipeElement(DriverFactory.getDriver().FindElement(By.XPath("//*[@text='" + opcao + "']/..")), 0.1, 0.9);
        }

        public void swipeElementRight(String opcao)
        {
            swipeElement(DriverFactory.getDriver().FindElement(By.XPath("//*[@text='" + opcao + "']/..")), 0.9, 0.1);
        }

        public void clicarBotaoMais()
        {
            AppiumWebElement botao = DriverFactory.getDriver().FindElement(By.XPath("//*[@text='(+)']/.."));

            new TouchAction(DriverFactory.getDriver()).Tap(botao, -50, 0).Perform();
        }
    }
}
/*
package br.ce.gsousa.appium.page;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;
import io.appium.java_client.MobileElement;
import io.appium.java_client.TouchAction;

public class SwipeListPage extends BasePage
{


    public void swipeElementLeft(String opcao)
{
    swipeElement(getDriver().FindElement(By.XPath("//*[@text='" + opcao + "']/..")), 0.1, 0.9);
}

public void swipeElementRight(String opcao)
{
    swipeElement(getDriver().FindElement(By.XPath("//*[@text='" + opcao + "']/..")), 0.9, 0.1);
}

public void clicarBotaoMais()
{
    AppiumWebElement botao = getDriver().FindElement(By.XPath("//*[@text='(+)']/.."));

    new TouchAction(getDriver()).tap(botao, -50, 0).perform();
}
}


*/
