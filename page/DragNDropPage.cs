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
    class DragNDropPage : BasePage
    {
        public void arrastar(String origem, String destino)
        {
            AppiumWebElement inicio = DriverFactory.getDriver().FindElement(By.XPath("//*[@text='" + origem + "']"));
            AppiumWebElement fim = DriverFactory.getDriver().FindElement(By.XPath("//*[@text='" + destino + "']"));

            //new TouchAction(DriverFactory.getDriver()).LongPress(DriverFactory.getDriver().FindElement(by)).Perform();
            new TouchAction(DriverFactory.getDriver())
                    .LongPress(inicio)
                    .MoveTo(fim)
                    .Release()
                    .Perform();
        }
        
        public String[] obterLista()
        {
            //List<AppiumWebElement> elements = DriverFactory.getDriver().FindElements(By.ClassName("android.widget.TextView"));
            IList<AppiumWebElement> elements = DriverFactory.getDriver().FindElementsByClassName("android.widget.TextView");
            String[] retorno = new String[elements.Count()];

            for (int i = 0; i < elements.Count(); i++)
            {
                retorno[i] = elements.ElementAt(i).Text;
                //System.out.print("\""+retorno[i]+"\", ");
            }

            return retorno;
        }
    }
}
/*
package br.ce.gsousa.appium.page;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import java.util.List;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;
import io.appium.java_client.MobileElement;
import io.appium.java_client.TouchAction;

public class DragNDropPage extends BasePage
{


    public void arrastar(String origem, String destino)
{
    AppiumWebElement inicio = getDriver().FindElement(By.XPath("//*[@text='" + origem + "']"));
    AppiumWebElement fim = getDriver().FindElement(By.XPath("//*[@text='" + destino + "']"));

    new TouchAction(getDriver())
            .longPress(inicio)
            .moveTo(fim)
            .release()
            .perform();
}

public String[] obterLista()
{
    List<AppiumWebElement> elements = getDriver().FindElements(By.ClassName("android.widget.TextView"));
    String[] retorno = new String[elements.size()];

    for (int i = 0; i < elements.size(); i++)
    {
        retorno[i] = elements.get(i).Text;
        //System.out.print("\""+retorno[i]+"\", ");
    }

    return retorno;
}

}


*/
