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
    class SBTeste : BaseTest
    {
        private MenuPage menu = new MenuPage();
        private SBLoginPage login = new SBLoginPage();
        private SBMenuPage menuSb = new SBMenuPage();
        private SBContasPage contasSb = new SBContasPage();
        private SBMovimentacaoPage mov = new SBMovimentacaoPage();
        private SBHomePage home = new SBHomePage();
        private SBResumoPage resumo = new SBResumoPage();
        [SetUp]
    public void setup()
        {
            menu.acessaSBNativo();
            login.setEmail("em@em");
            login.setSenha("1");
            login.entrar();
        }

        [Test]
    public void deveInserirContaComSucesso()
        {
            menuSb.acessarContas();
            contasSb.setConta("Conta de Teste");
            contasSb.salvar();

            Assert.True(contasSb.existeElementoPorTexto("Conta adicionada com sucesso"));

        }

        [Test]
    public void deveExcluirContaComSucesso()
        {
            menuSb.acessarContas();
            contasSb.selecionarContas("Conta para alterar");
            contasSb.excluir();

            Assert.True(contasSb.existeElementoPorTexto("Conta excluída com sucesso"));
        }

        [Test]
    public void deveValidarInclusaoMov()
        {
            menuSb.acessarMovimentacoes();

            mov.salvar();
            Assert.True(contasSb.existeElementoPorTexto("Descrição é um campo obrigatório"));

            mov.setDescricao("Descri");
            mov.salvar();
            Assert.True(contasSb.existeElementoPorTexto("Interessado é um campo obrigatório"));

            mov.setInteressado("Interess");
            mov.salvar();
            Assert.True(contasSb.existeElementoPorTexto("Valor é um campo obrigatório"));

            mov.setValor("100");
            mov.salvar();
            Assert.True(contasSb.existeElementoPorTexto("Conta é um campo obrigatório"));

            mov.setConta("Conta para alterar");
            mov.salvar();
            Assert.True(contasSb.existeElementoPorTexto("Movimentação cadastrada com sucesso"));
        }

        [Test]
    public void deveAtualizarSaldoAoExcluirMovimentacao()
        {
            Assert.AreEqual("534.00", home.obterSaldoConta("Conta para saldo"));

            menuSb.acessarResumo();
            esperar(1000);
            resumo.excluirMovimetacao("Movimentacao 3, calculo saldo");
            Assert.True(resumo.existeElementoPorTexto("Movimentação removida com sucesso!"));
            menuSb.acessarHome();

            esperar(1000);
            home.scroll(0.2, 0.9);
            Assert.AreEqual("-1000.00", home.obterSaldoConta("Conta para saldo"));
        }

    }
}
/*
package br.ce.gsousa.appium.test;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import br.ce.gsousa.appium.core.BaseTest;
import br.ce.gsousa.appium.page.MenuPage;
import br.ce.gsousa.appium.page.SeuBarriga.SBContasPage;
import br.ce.gsousa.appium.page.SeuBarriga.SBHomePage;
import br.ce.gsousa.appium.page.SeuBarriga.SBLoginPage;
import br.ce.gsousa.appium.page.SeuBarriga.SBMenuPage;
import br.ce.gsousa.appium.page.SeuBarriga.SBMovimentacaoPage;
import br.ce.gsousa.appium.page.SeuBarriga.SBResumoPage;

public class SBTeste extends BaseTest
{


    private MenuPage menu = new MenuPage();
private SBLoginPage login = new SBLoginPage();
private SBMenuPage menuSb = new SBMenuPage();
private SBContasPage contasSb = new SBContasPage();
private SBMovimentacaoPage mov = new SBMovimentacaoPage();
private SBHomePage home = new SBHomePage();
private SBResumoPage resumo = new SBResumoPage();
[SetUp]
    public void setup()
{
    menu.acessaSBNativo();
    login.setEmail("em@em");
    login.setSenha("1");
    login.entrar();
}

[Test]
    public void deveInserirContaComSucesso()
{
    menuSb.acessarContas();
    contasSb.setConta("Conta de Teste");
    contasSb.salvar();

    Assert.True(contasSb.existeElementoPorTexto("Conta adicionada com sucesso"));

}

[Test]
    public void deveExcluirContaComSucesso()
{
    menuSb.acessarContas();
    contasSb.selecionarContas("Conta para alterar");
    contasSb.excluir();

    Assert.True(contasSb.existeElementoPorTexto("Conta excluída com sucesso"));
}

[Test]
    public void deveValidarInclusaoMov()
{
    menuSb.acessarMovimentacoes();

    mov.salvar();
    Assert.True(contasSb.existeElementoPorTexto("Descrição é um campo obrigatório"));

    mov.setDescricao("Descri");
    mov.salvar();
    Assert.True(contasSb.existeElementoPorTexto("Interessado é um campo obrigatório"));

    mov.setInteressado("Interess");
    mov.salvar();
    Assert.True(contasSb.existeElementoPorTexto("Valor é um campo obrigatório"));

    mov.setValor("100");
    mov.salvar();
    Assert.True(contasSb.existeElementoPorTexto("Conta é um campo obrigatório"));

    mov.setConta("Conta para alterar");
    mov.salvar();
    Assert.True(contasSb.existeElementoPorTexto("Movimentação cadastrada com sucesso"));
}

[Test]
    public void deveAtualizarSaldoAoExcluirMovimentacao()
{
    Assert.AreEqual("534.00", home.obterSaldoConta("Conta para saldo"));

    menuSb.acessarResumo();
    esperar(1000);
    resumo.excluirMovimetacao("Movimentacao 3, calculo saldo");
    Assert.True(resumo.existeElementoPorTexto("Movimentação removida com sucesso!"));
    menuSb.acessarHome();

    esperar(1000);
    home.scroll(0.2, 0.9);
    Assert.AreEqual("-1000.00", home.obterSaldoConta("Conta para saldo"));
}

	
	//Descrição é um campo obrigatório
}


*/
