using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testes_appium_C_sharp.core;

namespace testes_appium_C_sharp.page
{
    class FormularioPage : BasePage
    {
        public void escreverNome(String nome)
        {
            escrever(MobileBy.AccessibilityId("nome"), nome);
        }

        public String obterNome()
        {
            return obterTexto(MobileBy.AccessibilityId("nome"));
        }

        public void selecionarCombo(String valor)
        {
            selecionarCombo(MobileBy.AccessibilityId("console"), valor);
        }

        public String obterValorCombo()
        {
            return obterTexto(By.XPath("//android.widget.Spinner/android.widget.TextView"));
        }

        public void clicarCheck()
        {
            clicar(By.ClassName("android.widget.CheckBox"));
        }

        public void clicarSwitch()
        {
            clicar(MobileBy.AccessibilityId("switch"));
        }

        public bool isCheckMarcado()
        {
            return isCheckMarcado(By.ClassName("android.widget.CheckBox"));
        }

        public bool isSwitchMarcado()
        {
            return isCheckMarcado(MobileBy.AccessibilityId("switch"));
        }

        public void clicarSeekbar(double posicao)
        {
            int delta = 50;

            AppiumWebElement seek = DriverFactory.getDriver().FindElement(MobileBy.AccessibilityId("slid"));
            int y = seek.Location.Y + (seek.Size.Height / 2);

            int xInicial = seek.Location.X + delta;
            int x = (int)(xInicial + ((seek.Size.Width - 2 * delta) * posicao));

            tap(x, y);                                
        }

        public void salvar()
        {
            clicarTexto("SALVAR");
        }

        public void salvarDemorado()
        {
            clicarTexto("SALVAR DEMORADO");
        }

        public String obterNomeCadastrato()
        {
            return obterTexto(By.XPath("//android.widget.TextView[starts-with(@text,'Nome:')]"));
        }

        public String obterConsoleCadastrado()
        {
            return obterTexto(By.XPath("//android.widget.TextView[starts-with(@text,'Console:')]"));
        }

        public String obterCheckCadastrado()
        {
            return obterTexto(By.XPath("//android.widget.TextView[starts-with(@text,'Switch:')]"));
        }

        public String obterSwithCadastrado()
        {
            return obterTexto(By.XPath("//android.widget.TextView[starts-with(@text,'Checkbox:')]"));
        }

        public String obterSliderCadastrado()
        {
            return obterTexto(By.XPath("//android.widget.TextView[starts-with(@text,'Slider:')]"));
        }

    }
}

/*
 package br.ce.gsousa.appium.page;

import static br.ce.gsousa.appium.core.DriverFactory.getDriver;

import org.openqa.selenium.By;

import br.ce.gsousa.appium.core.BasePage;
import io.appium.java_client.MobileBy;
import io.appium.java_client.MobileElement;

public class FormularioPage extends BasePage{

	
	public void escreverNome(String nome) {
		escrever(MobileBy.AccessibilityId("nome"), nome);
	}
	
	public String obterNome() {
		return obterTexto(MobileBy.AccessibilityId("nome"));
	}
	
	public void selecionarCombo(String valor) {
		selecionarCombo(MobileBy.AccessibilityId("console"), valor);
	}
	
	public String obterValorCombo() {
		return obterTexto(By.xpath("//android.widget.Spinner/android.widget.TextView"));
	}
	
	public void clicarCheck() {
		clicar(By.className("android.widget.CheckBox"));
	}
	
	public void clicarSwitch() {
		clicar(MobileBy.AccessibilityId("switch"));
	}
	
	public boolean isCheckMarcado() {
		return isCheckMarcado(By.className("android.widget.CheckBox"));
	}
	
	public boolean isSwitchMarcado() {
		return isCheckMarcado(MobileBy.AccessibilityId("switch"));
	}
	
	public void clicarSeebar(double posicao) {
		int delta = 50;
		MobileElement seek =  getDriver().findElement(MobileBy.AccessibilityId("slid"));
		int y = seek.getLocation().y+ (seek.getSize().height/2);
				
		int xInicial = seek.getLocation().x+ delta;
		int x = (int) (xInicial+ ((seek.getSize().width- 2*delta)* posicao));
		
		tap(x,y);		
	}
	
	public void salvar() {
		clicarTexto("SALVAR");		
	}
	
	public void salvarDemorado() {
		clicarTexto("SALVAR DEMORADO");		
	}
	
	public String obterNomeCadastrato() {
		return obterTexto(By.xpath("//android.widget.TextView[starts-with(@text,'Nome:')]"));
	}
	
	public String obterConsoleCadastrado() {
		return obterTexto(By.xpath("//android.widget.TextView[starts-with(@text,'Console:')]"));
	}
	
	public String obterCheckCadastrado() {
		return obterTexto(By.xpath("//android.widget.TextView[starts-with(@text,'Switch:')]"));
	}
	
	public String obterSwithCadastrado() {
		return obterTexto(By.xpath("//android.widget.TextView[starts-with(@text,'Checkbox:')]"));
	}
	
	public String obterSliderCadastrado() {
		return obterTexto(By.xpath("//android.widget.TextView[starts-with(@text,'Slider:')]"));
	}
	
	
	
	
	
	
}

*/
