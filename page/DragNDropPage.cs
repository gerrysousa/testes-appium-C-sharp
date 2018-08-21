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
    class DragNDropPage
    {
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
    MobileElement inicio = getDriver().findElement(By.xpath("//*[@text='" + origem + "']"));
    MobileElement fim = getDriver().findElement(By.xpath("//*[@text='" + destino + "']"));

    new TouchAction(getDriver())
            .longPress(inicio)
            .moveTo(fim)
            .release()
            .perform();
}

public String[] obterLista()
{
    List<MobileElement> elements = getDriver().findElements(By.className("android.widget.TextView"));
    String[] retorno = new String[elements.size()];

    for (int i = 0; i < elements.size(); i++)
    {
        retorno[i] = elements.get(i).getText();
        //System.out.print("\""+retorno[i]+"\", ");
    }

    return retorno;
}

}


*/
