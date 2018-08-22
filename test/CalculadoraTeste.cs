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
    class CalculadoraTeste : BaseTest
    {
        [Test]
    public void deveSomarDoisValores() 
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
        desiredCapabilities.SetCapability("platformName", "Android");
	    desiredCapabilities.SetCapability("deviceName", "emulator-5554");
	    desiredCapabilities.SetCapability("automationName", "uiautomator2");
	    desiredCapabilities.SetCapability("appPackage", "com.android.calculator2");
	    desiredCapabilities.SetCapability("appActivity", "com.android.calculator2.Calculator");

            AndroidDriver<AppiumWebElement> driver = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), desiredCapabilities);

            AppiumWebElement el3 = (AppiumWebElement)driver.FindElementById("com.android.calculator2:id/digit_2");
        el3.Click();
	    AppiumWebElement el4 = (AppiumWebElement)driver.FindElementByAccessibilityId("plus");
        el4.Click();
	    AppiumWebElement el5 = (AppiumWebElement)driver.FindElementById("com.android.calculator2:id/digit_2");
        el5.Click();
	    AppiumWebElement el6 = (AppiumWebElement)driver.FindElementById("com.android.calculator2:id/result");

        //System.out.print(el6.Text);

        Assert.AreEqual("4", el6.Text);
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


public class CalculadoraTeste
{

    [Test]
    public void deveSomarDoisValores() throws MalformedURLException
    {
        DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
    desiredCapabilities.setCapability("platformName", "Android");
	    desiredCapabilities.setCapability("deviceName", "emulator-5554");
	    desiredCapabilities.setCapability("automationName", "uiautomator2");
	    desiredCapabilities.setCapability("appPackage", "com.android.calculator2");
	    desiredCapabilities.setCapability("appActivity", "com.android.calculator2.Calculator");
	    	    
	    AndroidDriver<MobileElement> driver = new AndroidDriver<MobileElement>(new URL("http://localhost:4723/wd/hub"), desiredCapabilities);

    AppiumWebElement el3 = (MobileElement)driver.FindElementById("com.android.calculator2:id/digit_2");
    el3.click();
	    AppiumWebElement el4 = (MobileElement)driver.FindElementByAccessibilityId("plus");
    el4.click();
	    AppiumWebElement el5 = (MobileElement)driver.FindElementById("com.android.calculator2:id/digit_2");
    el5.click();
	    AppiumWebElement el6 = (MobileElement)driver.FindElementById("com.android.calculator2:id/result");

    //System.out.print(el6.Text);

    Assert.AreEqual("4", el6.Text);
	    driver.quit();
	}
}


*/
