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
    class AlertTest
    {
    }
}

/*
package br.ce.gsousa.appium.test;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.AlertaPage;
import br.ce.gsousa.appium.page.MenuPage;

public class AlertTest extends BaseTest
{


    private MenuPage menu = new MenuPage();
private AlertaPage alerta = new AlertaPage();

@Before
    public void setup()
{
    menu.acessarAlertas();
}

@Test
    public void deveConfirmarAlerta()
{
    alerta.clicarAlertaConfirm();

    Assert.assertEquals("Info", alerta.obterTituloAlerta());
    Assert.assertEquals("Confirma a operação?", alerta.obterMensageAlerta());

    alerta.confirmar();

    Assert.assertEquals("Confirmado", alerta.obterMensageAlerta());

    alerta.sair();
}

@Test
    public void deveClicarForaAlerta()
{
    alerta.clicarAlertaSimples();
    Assert.assertTrue(alerta.existeElementoPorTexto("Pode clicar no OK ou fora da caixa para sair"));
    esperar(1000);
    alerta.clicarForaCaixa();

    Assert.assertFalse(alerta.existeElementoPorTexto("Pode clicar no OK ou fora da caixa para sair"));
}

}


*/
