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
    class CliquesPage : BasePage
    {
        public void cliqueLongo()
        {
            cliqueLongo(By.XPath("//*[@text='Clique Longo']"));
        }

        public String obterTextoCampo()
        {
            return getDriver().FindElement(By.XPath("(//android.widget.TextView)[3]")).getText();
        }
    }
}
/*
package br.ce.gsousa.appium.page;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;

public class CliquesPage extends BasePage
{


    public void cliqueLongo()
{
    cliqueLongo(By.XPath("//*[@text='Clique Longo']"));
}

public String obterTextoCampo()
{
    return getDriver().FindElement(By.XPath("(//android.widget.TextView)[3]")).getText();
}

}


*/
