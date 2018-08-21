using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //List<IMobileElement> elementos = DriverFactory.getDriver().FindElements(By.XPath("//*[@text='" + texto + "']"));
            //return elementos.Size() > 0;
            return true;
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

        /*
        public void swipeElement(IMobileElement elemento, double inicio, double fim)
        {
            int y = elemento.getLocation().y + (elemento.getSize().height / 2);

            int start_x = (int)(elemento.getSize().width * inicio);
            int end_x = (int)(elemento.getSize().width * fim);

            new TouchAction(DriverFactory.getDriver())
            .Press(start_x, y)
            .Wait(TimeSpan.FromMilliseconds(500).Milliseconds)
            .MoveTo(end_x, y)
            .Release()
            .Perform();
        }*/

        public void cliqueLongo(By by)
        {
            new TouchAction(DriverFactory.getDriver()).LongPress(DriverFactory.getDriver().FindElement(by)).Perform();
        }
    }
}

/*
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
		getDriver().findElement(by).sendKeys(texto);
	}
	
	public String obterTexto(By by) {
		return getDriver().findElement(by).getText();
	}
	
	public void clicar(By by) {
		getDriver().findElement(by).click();
	}
	
	public void clicarTexto(String texto) {
		clicar(By.xpath("//*[@text='"+texto+"']"));
	}
	
	public void selecionarCombo(By by, String valor) {
		getDriver().findElement(by).click();
		clicarTexto(valor);
	}
	
	public boolean isCheckMarcado(By by) {
		return getDriver().findElement(by).getAttribute("checked").equals("true");		
	}
	
	public boolean existeElementoPorTexto(String texto) {
		List<MobileElement> elementos =  getDriver().findElements(By.xpath("//*[@text='"+texto+"']"));
		return elementos.size()>0;
	}
	
	public void tap(int x, int y) {
		new TouchAction(getDriver()).tap(x, y).perform();
		
	}
	
	public void scroll(double inicio, double fim) {
		Dimension size =  getDriver().manage().window().getSize();
		
		int x = size.width/2;
		
		int start_y =(int) (size.height* inicio);
		int end_y =(int) (size.height* fim);
		
		new TouchAction(getDriver())
		.press(x, start_y)
		.waitAction(Duration.ofMillis(500))
		.moveTo(x, end_y)
		.release()
		.perform();
	}
	
	public String obterTituloAlerta() {
		return obterTexto(By.id("android:id/alertTitle"));
	}
	
	public String obterMensageAlerta() {
		return obterTexto(By.id("android:id/message"));
	}
	
	public void swipe(double inicio, double fim) {
		Dimension size =  getDriver().manage().window().getSize();
		
		int y = size.height/2;
		
		int start_x =(int) (size.width* inicio);
		int end_x =(int) (size.width* fim);
		
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
	
	public void swipeElement(MobileElement elemento, double inicio, double fim) {
		int y= elemento.getLocation().y + (elemento.getSize().height / 2);
		
		int start_x =(int) (elemento.getSize().width* inicio);
		int end_x =(int) (elemento.getSize().width* fim);
		
		new TouchAction(getDriver())
		.press(start_x, y)
		.waitAction(Duration.ofMillis(500))
		.moveTo(end_x, y)
		.release()
		.perform();
	}

	public void cliqueLongo(By by) {
		new TouchAction(getDriver()).longPress(getDriver().findElement(by)).perform();
		
	}
	
}
*/