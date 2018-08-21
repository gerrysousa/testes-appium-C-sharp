﻿using NUnit.Framework;
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
    class CalculadoraTeste
    {
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

    @Test
    public void deveSomarDoisValores() throws MalformedURLException
    {
        DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
    desiredCapabilities.setCapability("platformName", "Android");
	    desiredCapabilities.setCapability("deviceName", "emulator-5554");
	    desiredCapabilities.setCapability("automationName", "uiautomator2");
	    desiredCapabilities.setCapability("appPackage", "com.android.calculator2");
	    desiredCapabilities.setCapability("appActivity", "com.android.calculator2.Calculator");
	    	    
	    AndroidDriver<MobileElement> driver = new AndroidDriver<MobileElement>(new URL("http://localhost:4723/wd/hub"), desiredCapabilities);

    MobileElement el3 = (MobileElement)driver.findElementById("com.android.calculator2:id/digit_2");
    el3.click();
	    MobileElement el4 = (MobileElement)driver.findElementByAccessibilityId("plus");
    el4.click();
	    MobileElement el5 = (MobileElement)driver.findElementById("com.android.calculator2:id/digit_2");
    el5.click();
	    MobileElement el6 = (MobileElement)driver.findElementById("com.android.calculator2:id/result");

    //System.out.print(el6.getText());

    Assert.assertEquals("4", el6.getText());
	    driver.quit();
	}
}


*/
