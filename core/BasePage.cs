﻿using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using testes_appium_C_sharp.core;

namespace testes_appium_C_sharp.core
{
    public class BasePage
    {
        public void escrever(By by, String texto)
        {
            DriverFactory.getDriver().FindElement(by).SendKeys(texto);
        }

        public String obterTexto(By by)
        {
            return DriverFactory.getDriver().FindElement(by).Text;
        }

        public void clicar(By by)
        {
            DriverFactory.getDriver().FindElement(by).Click();
        }

        public void clicarTexto(String texto)
        {
            clicar(By.XPath("//*[@text='" + texto + "']"));
        }

        public void selecionarCombo(By by, String valor)
        {
            DriverFactory.getDriver().FindElement(by).Click();
            clicarTexto(valor);
        }

        public bool isCheckMarcado(By by)
        {
            return DriverFactory.getDriver().FindElement(by).GetAttribute("checked").Equals("true");
        }

        public bool existeElementoPorTexto(String texto)
        {
            IList<AppiumWebElement> elementos = DriverFactory.getDriver().FindElements(By.XPath("//*[@text='" + texto + "']"));
            return elementos.Count() > 0;


            /*
             IList<AppiumWebElement> elements = DriverFactory.getDriver().FindElementsByClassName("android.widget.TextView");
            String[] retorno = new String[elements.Count()];

            for (int i = 0; i < elements.Count(); i++)
            {
                retorno[i] = elements.ElementAt(i).ToString();
                //System.out.print("\""+retorno[i]+"\", ");
            }

             */


            //return true;
        }

        public void tap(int x, int y)
        {
            new TouchAction(DriverFactory.getDriver()).Tap(x, y).Perform();
        }

        public void scroll(double inicio, double fim)
        {
            System.Drawing.Size size = DriverFactory.getDriver().Manage().Window.Size;

            int x = size.Width / 2;

            int start_y = (int)(size.Height * inicio);
            int end_y = (int)(size.Height * fim);

            new TouchAction(DriverFactory.getDriver())
            .Press(x, start_y)
            .Wait(TimeSpan.FromMilliseconds(500).Milliseconds)
            .MoveTo(x, end_y)
            .Release()
            .Perform();
        }

        public String obterTituloAlerta()
        {
            return obterTexto(By.Id("android:id/alertTitle"));
        }

        public String obterMensageAlerta()
        {
            return obterTexto(By.Id("android:id/message"));
        }

        public void swipe(double inicio, double fim)
        {
            System.Drawing.Size size = DriverFactory.getDriver().Manage().Window.Size;

            int y = size.Height / 2;

            int start_x = (int)(size.Width * inicio);
            int end_x = (int)(size.Width * fim);

            new TouchAction(DriverFactory.getDriver())
            .Press(start_x, y)
            .Wait(TimeSpan.FromMilliseconds(500).Milliseconds)
            .MoveTo(end_x, y)
            .Release()
            .Perform();
        }

        public void scrollDown()
        {
            scroll(0.9, 0.1);
        }

        public void scrollUp()
        {
            scroll(0.1, 0.9);
        }

        public void swipeLeft()
        {
            swipe(0.1, 0.9);
        }

        public void swipeRight()
        {
            swipe(0.9, 0.1);
        }


        public void swipeElement(AppiumWebElement elemento, double inicio, double fim)
        {
            int y = elemento.Location.Y + (elemento.Size.Height / 2);

            int start_x = (int)(elemento.Size.Width * inicio);
            int end_x = (int)(elemento.Size.Width * fim);

            new TouchAction(DriverFactory.getDriver())
            .Press(start_x, y)
            .Wait(TimeSpan.FromMilliseconds(500).Milliseconds)
            .MoveTo(end_x, y)
            .Release()
            .Perform();
        }

        public void cliqueLongo(By by)
        {
           // TouchAction action = new TouchAction(DriverFactory.getDriver());
            //action.Press(DriverFactory.getDriver().FindElement(by)).Release().Perform();

            AppiumWebElement teste = DriverFactory.getDriver().FindElement(by);
           // AppiumWebElement fim = DriverFactory.getDriver().FindElement(By.XPath("//*[@text='" + destino + "']"));

            //var appiumDriver; //you've instantiated it somehow
            if (teste != null)
            {
                new TouchAction(DriverFactory.getDriver())
                .LongPress(teste) //i've tried using coordinates as well
                .Release();//.Perform();
                Thread.Sleep(2000);
                return;
            }


            // new TouchAction(DriverFactory.getDriver()).LongPress(DriverFactory.getDriver().FindElement(by), 0.5, 0.5 ).Perform();
            /*
                        new TouchAction(DriverFactory.getDriver())
                       .Press(DriverFactory.getDriver().FindElement(by))
                       .Wait(TimeSpan.FromMilliseconds(3000).Milliseconds)
                       .Release()
                       .Perform();

                        */

            //new TouchAction(getDriver()).longPress(getDriver().FindElement(by)).perform();
            //TouchActions action = 
            //               new TouchActions(DriverFactory.getDriver())
            //         .LongPress(DriverFactory.getDriver().FindElement(by)).Release().Perform();

            //          ITouchAction touchAction = new TouchAction(DriverFactory.getDriver())
            //        .LongPress(DriverFactory.getDriver().FindElement(by))
            //.Wait(TimeSpan.FromMilliseconds(2000).Milliseconds)
            //.MoveTo(endX, endY)
            //       .Release();

            //     touchAction.Perform();

            /*
                        ITouchAction touchAction = new TouchAction(DriverFactory.getDriver())
               .Press(startX, startY)
               .Wait(duration)
               .MoveTo(endX, endY)
               .Release();

                        touchAction.Perform();
                        */

            // new TouchAction(DriverFactory.getDriver())
            //   .LongPress(DriverFindElement(by))
            // .Perform();
        }
    }
}

/*
new TouchAction(appiumDriver)
.LongPress(element) //i've tried using coordinates as well
.Release().Perform();
Thread.Sleep(2000);
 * 
 * 
package br.ce.gsousa.appium.core;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import java.time.Duration;
import java.util.List;

import org.openqa.selenium.By;
import org.openqa.selenium.Dimension;

import io.appium.java_client.MobileElement;
import io.appium.java_client.TouchAction;

public class BasePage {
public void escrever(By by, String texto) {
getDriver().FindElement(by).SendKeys(texto);
}

public String obterTexto(By by) {
return getDriver().FindElement(by).Text;
}

public void clicar(By by) {
getDriver().FindElement(by).click();
}

public void clicarTexto(String texto) {
clicar(By.XPath("//*[@text='"+texto+"']"));
}

public void selecionarCombo(By by, String valor) {
getDriver().FindElement(by).click();
clicarTexto(valor);
}

public bool isCheckMarcado(By by) {
return getDriver().FindElement(by).getAttribute("checked").equals("true");		
}

public bool existeElementoPorTexto(String texto) {
List<AppiumWebElement> elementos =  getDriver().FindElements(By.XPath("//*[@text='"+texto+"']"));
return elementos.size()>0;
}

public void tap(int x, int y) {
new TouchAction(getDriver()).tap(x, y).perform();

}

public void scroll(double inicio, double fim) {
Dimension size =  getDriver().Manage().window().Size;

int x = size.Width/2;

int start_y =(int) (size.Height* inicio);
int end_y =(int) (size.Height* fim);

new TouchAction(getDriver())
.press(x, start_y)
.waitAction(Duration.ofMillis(500))
.moveTo(x, end_y)
.release()
.perform();
}

public String obterTituloAlerta() {
return obterTexto(By.Id("android:id/alertTitle"));
}

public String obterMensageAlerta() {
return obterTexto(By.Id("android:id/message"));
}

public void swipe(double inicio, double fim) {
Dimension size =  getDriver().Manage().window().Size;

int y = size.Height/2;

int start_x =(int) (size.Width* inicio);
int end_x =(int) (size.Width* fim);

new TouchAction(getDriver())
.press(start_x, y)
.waitAction(Duration.ofMillis(500))
.moveTo(end_x, y)
.release()
.perform();
}

public void scrollDown() {
scroll(0.9, 0.1);
}

public void scrollUp() {
scroll(0.1, 0.9);
}

public void swipeLeft() {
swipe(0.1, 0.9);
}

public void swipeRight() {
swipe(0.9, 0.1);
}

public void swipeElement(AppiumWebElement elemento, double inicio, double fim) {
int y= elemento.Location.Y  + (elemento.Size.Height / 2);

int start_x =(int) (elemento.Size.Width* inicio);
int end_x =(int) (elemento.Size.Width* fim);

new TouchAction(getDriver())
.press(start_x, y)
.waitAction(Duration.ofMillis(500))
.moveTo(end_x, y)
.release()
.perform();
}

public void cliqueLongo(By by) {
new TouchAction(getDriver()).longPress(getDriver().FindElement(by)).perform();

}

}
*/
