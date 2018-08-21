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
    class CalculadoraTesteMotoG : BaseTest
    {
        [Test]
    public void deveSomarDoisValoress() throws MalformedURLException
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
        desiredCapabilities.setCapability("platformName", "Android");
	    desiredCapabilities.setCapability("deviceName", "0030260344");
	    desiredCapabilities.setCapability("automationName", "uiautomator2");
	    desiredCapabilities.setCapability("appPackage", "com.google.android.calculator");
	    desiredCapabilities.setCapability("appActivity", "com.android.calculator2.CalculatorGoogle");
	    	    
	    AndroidDriver<MobileElement> driver = new AndroidDriver<MobileElement>(new URL("http://localhost:4723/wd/hub"), desiredCapabilities);

        AppiumWebElement el1 = (MobileElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
        el1.click();
	    el1.click();
	    AppiumWebElement el2 = (MobileElement)driver.FindElementByAccessibilityId("mais");
        el2.click();
	    AppiumWebElement el3 = (MobileElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
        el3.click();
	    AppiumWebElement el4 = (MobileElement)driver.FindElementById("com.google.android.calculator:id/result");

        Assert.AreEqual("8", el4.getText());
	    driver.quit();
	}
}
}
/*
package br.ce.gsousa.appium.test;

import java.net.MalformedURLException;
import java.net.URL;

import org.junit.Assert;
import org.junit.Test;
import org.openqa.selenium.remote.DesiredCapabilities;

import io.appium.java_client.MobileElement;
import io.appium.java_client.android.AndroidDriver;


public class CalculadoraTesteMotoG
{

    [Test]
    public void deveSomarDoisValoress() throws MalformedURLException
    {
        DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
    desiredCapabilities.setCapability("platformName", "Android");
	    desiredCapabilities.setCapability("deviceName", "0030260344");
	    desiredCapabilities.setCapability("automationName", "uiautomator2");
	    desiredCapabilities.setCapability("appPackage", "com.google.android.calculator");
	    desiredCapabilities.setCapability("appActivity", "com.android.calculator2.CalculatorGoogle");
	    	    
	    AndroidDriver<MobileElement> driver = new AndroidDriver<MobileElement>(new URL("http://localhost:4723/wd/hub"), desiredCapabilities);

    AppiumWebElement el1 = (MobileElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
    el1.click();
	    el1.click();
	    AppiumWebElement el2 = (MobileElement)driver.FindElementByAccessibilityId("mais");
    el2.click();
	    AppiumWebElement el3 = (MobileElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
    el3.click();
	    AppiumWebElement el4 = (MobileElement)driver.FindElementById("com.google.android.calculator:id/result");

    Assert.AreEqual("8", el4.getText());
	    driver.quit();
	}
}


*/
