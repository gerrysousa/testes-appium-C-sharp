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

namespace testes_appium_C_sharp.core
{
    public class DriverFactory
    {
        private static AppiumDriver<AppiumWebElement> driver;

        public static AppiumDriver<AppiumWebElement> getDriver()
        {
            if (driver == null)
            {
                createDrive();
                // createTestObjectDrive();
            }
            return driver;
        }

        private static void createDrive()
        {
            //String apkCaminho = new File(@"dadsadfsa").getCanonicalPath();

            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("platformName", "Android");
            desiredCapabilities.SetCapability("deviceName", "emulator-5554");
            desiredCapabilities.SetCapability("automationName", "uiAutomator2");
            //desiredCapabilities.SetCapability("appPackage", "com.");
            desiredCapabilities.SetCapability(OpenQA.Selenium.Appium.Enums.MobileCapabilityType.App, @"D:\Treinamento\testes-appium-C-sharp\resources\CTAppium-1-1.apk");

            // desiredCapabilities.SetCapability(MobileCapabilityType.APP, apkCaminho);

            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), desiredCapabilities);

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        private static void createTestObjectDrive()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("platformName", "Android");
            desiredCapabilities.SetCapability("testobject_api_key", "B5B0F35D95494712997B4EA2A1DADC4A");
            desiredCapabilities.SetCapability("appiumVersion", "1.7.2");
            desiredCapabilities.SetCapability("language", "pt");
            desiredCapabilities.SetCapability("automationName", "uiAutomator2");

            driver = new AndroidDriver<AppiumWebElement>(new Uri("https://eu1.appium.testobject.com/wd/hub"), desiredCapabilities);

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

        }

        public static void killDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
/*
package br.ce.gsousa.appium.core;

import java.io.File;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.concurrent.TimeUnit;

import org.openqa.selenium.remote.DesiredCapabilities;

import io.appium.java_client.MobileElement;
import io.appium.java_client.android.AndroidDriver;
import io.appium.java_client.remote.MobileCapabilityType;

public class DriverFactory
{

    private static AndroidDriver<MobileElement> driver;

    public static AndroidDriver<MobileElement> getDriver()
    {
        if (driver == null)
        {
            // createDrive();
            createTestObjectDrive();
        }
        return driver;
    }

    private static void createDrive()
    {
        try
        {
            String apkCaminho = new File("../CursoAppium/src/main/resources/CTAppium-1-1.apk").getCanonicalPath();

            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.setCapability("platformName", "Android");
            desiredCapabilities.setCapability("deviceName", "emulator-5554");
            desiredCapabilities.setCapability("automationName", "uiAutomator2");
            desiredCapabilities.setCapability(MobileCapabilityType.APP, apkCaminho);

            try
            {
                driver = new AndroidDriver<MobileElement>(new URL("http://localhost:4723/wd/hub"), desiredCapabilities);
            }
            catch (MalformedURLException e)
            {
                e.printStackTrace();
            }
            driver.Manage().Timeouts().ImplicitlyWait(10, TimeUnit.SECONDS);

        }
        catch (IOException e1)
        {
            // TODO Auto-generated catch block
            e1.printStackTrace();
        }
    }

    private static void createTestObjectDrive()
    {
        DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
        desiredCapabilities.setCapability("platformName", "Android");
        desiredCapabilities.setCapability("testobject_api_key", "B5B0F35D95494712997B4EA2A1DADC4A");
        desiredCapabilities.setCapability("appiumVersion", "1.7.2");
        desiredCapabilities.setCapability("language", "pt");
        desiredCapabilities.setCapability("automationName", "uiAutomator2");

        try
        {
            driver = new AndroidDriver<MobileElement>(new URL("https://eu1.appium.testobject.com/wd/hub"),
                    desiredCapabilities);
        }
        catch (MalformedURLException e)
        {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        driver.Manage().Timeouts().ImplicitlyWait(10, TimeUnit.SECONDS);

    }

    public static void killDriver()
    {
        if (driver != null)
        {
            driver.quit();
            driver = null;
        }
    }
}
*/