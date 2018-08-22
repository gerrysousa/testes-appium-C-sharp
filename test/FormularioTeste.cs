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
    public class FormularioTeste : BaseTest
    {
        private MenuPage menu = new MenuPage();
        private FormularioPage page = new FormularioPage();

        [SetUp]
        public void inicializarAppium()
        {
            //driver = DriverFactory.getDriver();
            menu.acessarFormulario();
        }

        [Test]
        public void devePreencherCampoTexto()
        {
            page.escreverNome("Gerry");

            Assert.AreEqual("Gerry", page.obterNome());
        }

        [Test]
        public void deveInteragirComCombo()
        {
            page.selecionarCombo("Nintendo Switch");

            Assert.AreEqual("Nintendo Switch", page.obterValorCombo());
        }

        [Test]
        public void deveInteragirComSwitchCheckBox()
        {
            Assert.False(page.isCheckMarcado());
            Assert.True(page.isSwitchMarcado());

            page.clicarCheck();
            page.clicarSwitch();

            Assert.True(page.isCheckMarcado());
            Assert.False(page.isSwitchMarcado());
        }

        [Test]
        public void deveRealizarCadastro()
        {
            page.escreverNome("Gerry");
            page.clicarCheck();
            page.clicarSwitch();
            page.selecionarCombo("PS4");
            page.salvar();

            Assert.AreEqual("Nome: Gerry", page.obterNomeCadastrato());
            Assert.AreEqual("Console: ps4", page.obterConsoleCadastrado());
            Assert.True(page.obterCheckCadastrado().EndsWith("Off"));
            Assert.True(page.obterSwithCadastrado().EndsWith("Marcado"));
        }

        [Test]
        public void deveRealizarCadastroDemorado()
        {
            page.escreverNome("Gerry");
            DriverFactory.getDriver().Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            page.salvarDemorado();
            // esperar(3000);

            WebDriverWait wait = new WebDriverWait(DriverFactory.getDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@text='Nome: Gerry']")));

            Assert.AreEqual("Nome: Gerry", page.obterNomeCadastrato());
        }

        [Test]
        public void deveMudarData()
        {
            page.clicarTexto("01/01/2000");
            page.clicarTexto("20");
            page.clicarTexto("OK");

            Assert.True(page.existeElementoPorTexto("20/2/2000"));
        }

        [Test]
        public void deveMudarHora()
        {
            page.clicarTexto("06:00");
            page.clicar(MobileBy.AccessibilityId("10"));
            page.clicar(MobileBy.AccessibilityId("40"));
            page.clicarTexto("OK");

            Assert.True(page.existeElementoPorTexto("10:40"));
        }

        [Test]
        public void deveInteragirComSeekbar()
        {
            page.clicarSeekbar(0.65);

            page.salvar();
            Assert.AreEqual("Slider: 65", page.obterSliderCadastrado());
        }

    }
}

/*
package br.ce.gsousa.appium.test;

import static org.junit.Assert.AreEqual;
import static org.junit.Assert.True;

import java.net.MalformedURLException;
import java.util.concurrent.TimeUnit;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.core.DriverFactory;
import br.ce.gsousa.appium.page.FormularioPage;
import br.ce.gsousa.appium.page.MenuPage;
import io.appium.java_client.MobileBy;

public class FormularioTeste extends BaseTest {
	private MenuPage menu = new MenuPage();
	private FormularioPage page = new FormularioPage();

	[SetUp]
	public void inicializarAppium() throws MalformedURLException {
		// driver = DriverFactory.getDriver();
		menu.acessarFormulario();
	}

	[Test]
	public void devePreencherCampoTexto() throws MalformedURLException {
		page.escreverNome("Gerry");

		assertEquals("Gerry", page.obterNome());
	}

	[Test]
	public void deveInteragirComCombo() throws MalformedURLException {
		page.selecionarCombo("Nintendo Switch");

		Assert.AreEqual("Nintendo Switch", page.obterValorCombo());
	}

	[Test]
	public void deveInteragirComSwitchCheckBox() throws MalformedURLException {
		Assert.False(page.isCheckMarcado());
		Assert.True(page.isSwitchMarcado());

		page.clicarCheck();
		page.clicarSwitch();

		Assert.True(page.isCheckMarcado());
		Assert.False(page.isSwitchMarcado());
	}

	[Test]
	public void deveRealizarCadastro() throws MalformedURLException {
		page.escreverNome("Gerry");
		page.clicarCheck();
		page.clicarSwitch();
		page.selecionarCombo("PS4");
		page.salvar();

		assertEquals("Nome: Gerry", page.obterNomeCadastrato());
		assertEquals("Console: ps4", page.obterConsoleCadastrado());
		assertTrue(page.obterCheckCadastrado().endsWith("Off"));
		assertTrue(page.obterSwithCadastrado().endsWith("Marcado"));
	}

	[Test]
	public void deveRealizarCadastroDemorado() throws MalformedURLException {
		page.escreverNome("Gerry");
		DriverFactory.getDriver().Manage().Timeouts().ImplicitlyWait( TimeSpan.FromSeconds(0));

		page.salvarDemorado();
		// esperar(3000);

		WebDriverWait wait = new WebDriverWait(DriverFactory.getDriver(), TimeSpan.FromSeconds(10));
		wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@text='Nome: Gerry']")));

		assertEquals("Nome: Gerry", page.obterNomeCadastrato());
	}

	[Test]
	public void deveMudarData() {
		page.clicarTexto("01/01/2000");
		page.clicarTexto("20");
		page.clicarTexto("OK");

		Assert.True(page.existeElementoPorTexto("20/2/2000"));
	}

	[Test]
	public void deveMudarHora() {
		page.clicarTexto("06:00");
		page.clicar(MobileBy.AccessibilityId("10"));
		page.clicar(MobileBy.AccessibilityId("40"));
		page.clicarTexto("OK");

		Assert.True(page.existeElementoPorTexto("10:40"));
	}
	
	[Test]
	public void deveInteragirComSeekbar() {
		page.clicarSeebar(0.65);

		page.salvar();
		assertEquals("Slider: 65", page.obterSliderCadastrado());
		//Assert.True(page.existeElementoPorTexto("Slider: 65"));
	}
}


 */
