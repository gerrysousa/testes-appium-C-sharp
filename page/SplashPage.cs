﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testes_appium_C_sharp.page
{
    class SplashPage
    {
    }
}
/*

package br.ce.gsousa.appium.page;

import java.util.concurrent.TimeUnit;

import org.openqa.selenium.By;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import br.ce.gsousa.appium.core.BasePage;
import br.ce.gsousa.appium.core.DriverFactory;

public class SplashPage extends BasePage
{




    public boolean isTelaSplashVisivel()
{
    return existeElementoPorTexto("Splash!");
}

public void aguardarSplashSumir()
{
    DriverFactory.getDriver().manage().timeouts().implicitlyWait(0, TimeUnit.SECONDS);
    WebDriverWait wait = new WebDriverWait(DriverFactory.getDriver(), 10);
    wait.until(ExpectedConditions.invisibilityOfElementLocated(By.xpath("//*[@text='Splash!']")));

}
}


*/