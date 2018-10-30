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
    class SBResumoPage : BasePage
    {
        public void excluirMovimetacao(String desc)
        {
            AppiumWebElement elm = DriverFactory.getDriver().FindElement(By.XPath("//*[@text='" + desc + "']/.."));
            swipeElement(elm, 0.9, 0.1);
            clicarTexto("Del");
        }
    }
}
/*
package br.ce.gsousa.appium.page.SeuBarriga;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;
import br.ce.gsousa.appium.core.DriverFactory;
import io.appium.java_client.MobileElement;

public class SBResumoPage extends BasePage
{


    public void excluirMovimetacao(String desc)
{
    AppiumWebElement elm = DriverFactory.getDriver().FindElement(By.XPath("//*[@text='" + desc + "']/.."));
    swipeElement(elm, 0.9, 0.1);
    clicarTexto("Del");
}
}


*/
