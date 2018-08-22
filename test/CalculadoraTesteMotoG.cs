using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Interfaces;
using System.IO;
using testes_appium_C_sharp.core;
using NUnit.Framework;
using testes_appium_C_sharp.page;


namespace testes_appium_C_sharp.test
{
    class CalculadoraTesteMotoG : BaseTest
    {
        [Test]
    public void deveSomarDoisValoress()
        {
        DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
        desiredCapabilities.SetCapability("platformName", "Android");
	    desiredCapabilities.SetCapability("deviceName", "0030260344");
	    desiredCapabilities.SetCapability("automationName", "uiautomator2");
	    desiredCapabilities.SetCapability("appPackage", "com.google.android.calculator");
	    desiredCapabilities.SetCapability("appActivity", "com.android.calculator2.CalculatorGoogle");

            AndroidDriver<AppiumWebElement> driver = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), desiredCapabilities);

            AppiumWebElement el1 = (AppiumWebElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
        el1.Click();
	    el1.Click();
	    AppiumWebElement el2 = (AppiumWebElement)driver.FindElementByAccessibilityId("mais");
        el2.Click();
	    AppiumWebElement el3 = (AppiumWebElement)driver.FindElementById("com.google.android.calculator:id/digit_4");
        el3.Click();
	    AppiumWebElement el4 = (AppiumWebElement)driver.FindElementById("com.google.android.calculator:id/result");

        Assert.AreEqual("8", el4.Text);
	    driver.Quit();
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

    Assert.AreEqual("8", el4.Text);
	    driver.quit();
	}
}


*/
