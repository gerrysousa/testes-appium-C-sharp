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
    class SBHomePage : BasePage
    {
        public String obterSaldoConta(String conta)
        {
            return obterTexto(By.XPath("//*[@text='" + conta + "']/following-sibling::android.widget.TextView"));
        }
    }
}
/*
package br.ce.gsousa.appium.page.SeuBarriga;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;

public class SBHomePage extends BasePage
{


    public String obterSaldoConta(String conta)
{
    return obterTexto(By.XPath("//*[@text='" + conta + "']/following-sibling::android.widget.TextView"));
}

}


*/
