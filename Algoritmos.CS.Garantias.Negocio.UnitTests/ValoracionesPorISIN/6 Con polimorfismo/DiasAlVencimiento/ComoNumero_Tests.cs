﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;

namespace Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.DiasAlVencimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeLaValoracionPorISIN losDatos;

        [TestMethod]
        public void ComoNumero_DosFechas_LosDiasDeDiferencia()
        {
            elResultadoEsperado = 221;

            InicialiceLasFechas();
            elResultadoObtenido = new DiasAlVencimiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLasFechas()
        {
            losDatos = new DatosDeUnISINEnColones();
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);
        }
    }
}