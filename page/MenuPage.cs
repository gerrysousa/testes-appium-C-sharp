using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testes_appium_C_sharp.core;

namespace testes_appium_C_sharp.page
{
    public class MenuPage : BasePage
    {
        public void acessarFormulario()
        {
            clicarTexto("Formulário");
        }

        public void acessarSplash()
        {
            clicarTexto("Splash");
        }

        public void acessarAlertas()
        {
            clicarTexto("Alertas");
        }

        public void acessarAbas()
        {
            clicarTexto("Abas");
        }

        public void acessarAccordion()
        {
            clicarTexto("Accordion");
        }

        public void acessarCliques()
        {
            clicarTexto("Cliques");
        }

        public void acessarSwipe()
        {
            clicarTexto("Swipe");
        }

        public void acessarSwipeList()
        {
            clicarTexto("Swipe List");
        }

        public void acessarDragNDrop()
        {
            clicarTexto("Drag and drop");
        }

        public void acessaSBHibrido()
        {
            clicarTexto("SeuBarriga Híbrido");
        }

        public void acessaSBNativo()
        {
            clicarTexto("SeuBarriga Nativo");
        }

    }
}

/*
 * package br.ce.gsousa.appium.page;

import br.ce.gsousa.appium.core.BasePage;

public class MenuPage extends BasePage{
	
	public void	 acessarFormulario() {
	    clicarTexto("Formulário");
	}
	
	public void	 acessarSplash() {
	    clicarTexto("Splash");
	}
	
	public void	 acessarAlertas() {
	    clicarTexto("Alertas");
	}
	
	public void	 acessarAbas() {
	    clicarTexto("Abas");
	}
	
	public void	 acessarAccordion() {
	    clicarTexto("Accordion");
	}
	
	public void	 acessarCliques() {
	    clicarTexto("Cliques");
	}
	
	public void	 acessarSwipe() {
		clicarTexto("Swipe");
	}

	public void acessarSwipeList() {
		clicarTexto("Swipe List");		
	}

	public void acessarDragNDrop() {
		clicarTexto("Drag and drop");		
	}

	public void acessaSBHibrido() {
		clicarTexto("SeuBarriga Híbrido");		
	}
	
	public void acessaSBNativo() {
		clicarTexto("SeuBarriga Nativo");		
	}
	
}
*/