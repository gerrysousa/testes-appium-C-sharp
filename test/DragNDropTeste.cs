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
    class DragNDropTeste : BaseTest
    {
        private MenuPage menu = new MenuPage();
        private DragNDropPage page = new DragNDropPage();

        private String[] estadoInicial = new String[] { "Esta", "é uma lista", "Drag em Drop!", "Faça um clique longo,", "e arraste para", "qualquer local desejado." };
        private String[] estadoIntermediario = new String[] { "é uma lista", "Drag em Drop!", "Faça um clique longo,", "e arraste para", "Esta", "qualquer local desejado." };
        private String[] estadoFinal = new String[] { "Faça um clique longo,", "é uma lista", "Drag em Drop!", "e arraste para", "Esta", "qualquer local desejado." };

        [Test]
        public void deveEfetuarDragNDrop()
        {
            WebDriverWait wait = new WebDriverWait(DriverFactory.getDriver(), TimeSpan.FromSeconds(0));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@text='Formulário']")));
            menu.scroll(0.9, 0.10);

            menu.acessarDragNDrop();
            esperar(1000);
            CollectionAssert.AreEqual(estadoInicial, page.obterLista());

            page.arrastar("Esta", "e arraste para");
            CollectionAssert.AreEqual(estadoIntermediario, page.obterLista()); 
    
            page.arrastar("Faça um clique longo,", "é uma lista");
            CollectionAssert.AreEqual(estadoFinal, page.obterLista());

        }
    }
}
/*
package br.ce.gsousa.appium.test;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import org.junit.Assert;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.DragNDropPage;
import br.ce.gsousa.appium.page.MenuPage;

public class DragNDropTeste extends BaseTest
{


    private MenuPage menu = new MenuPage();
private DragNDropPage page = new DragNDropPage();

private String[] estadoInicial = new String[] { "Esta", "é uma lista", "Drag em Drop!", "Faça um clique longo,", "e arraste para", "qualquer local desejado." };
private String[] estadoIntermediario = new String[] { "é uma lista", "Drag em Drop!", "Faça um clique longo,", "e arraste para", "Esta", "qualquer local desejado." };
private String[] estadoFinal = new String[] { "Faça um clique longo,", "é uma lista", "Drag em Drop!", "e arraste para", "Esta", "qualquer local desejado." };

[Test]
    public void deveEfetuarDragNDrop()
{
    WebDriverWait wait = new WebDriverWait(getDriver(), TimeSpan.FromSeconds(10));
    wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@text='Formulário']")));
    menu.scroll(0.9, 0.TimeSpan.FromSeconds(10));

    menu.acessarDragNDrop();
    esperar(1000);
    Assert.assertArrayEquals(estadoInicial, page.obterLista());

    page.arrastar("Esta", "e arraste para");
    Assert.assertArrayEquals(estadoIntermediario, page.obterLista());

    page.arrastar("Faça um clique longo,", "é uma lista");
    Assert.assertArrayEquals(estadoFinal, page.obterLista());

}
}


*/
