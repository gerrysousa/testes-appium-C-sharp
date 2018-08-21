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
    class AbasTeste : BaseTest
    {
        private MenuPage page = new MenuPage();
        private AbasPage abas = new AbasPage();

        [Test]
    public void deveInteragirComAbas()
        {
            //acessar menu abas
            page.acessarAbas();
            //verificar que esta na aba 1
            //abas.deveClicarAba1();
            Assert.True(abas.isAba1());

            //acessar aba 2 
            abas.deveClicarAba2();
            //verificar que esta na aba 2
            Assert.True(abas.isAba2());
        }
    }
}
/*
package br.ce.gsousa.appium.test;

import org.junit.Assert;
import org.junit.Test;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.AbasPage;
import br.ce.gsousa.appium.page.MenuPage;

public class AbasTeste extends BaseTest
{

    private MenuPage page = new MenuPage();
private AbasPage abas = new AbasPage();

[Test]
    public void deveInteragirComAbas()
{
    //acessar menu abas
    page.acessarAbas();
    //verificar que esta na aba 1
    //abas.deveClicarAba1();
    Assert.True(abas.isAba1());

    //acessar aba 2 
    abas.deveClicarAba2();
    //verificar que esta na aba 2
    Assert.True(abas.isAba2());
}

}


*/
