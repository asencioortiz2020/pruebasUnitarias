using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alumno_ASEOR;

namespace TestNota
{
    [TestClass]
    public class TestAlumno
    {

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestPlaza()
        {

            Vuelo vue = new Vuelo();


            //try
            //{

            //    vue.Dni_Novalido(vue.Nif);
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Assert.AreEqual("menos mal dni",e.Message);
            //    throw;
            //}

            
            vue.Nif = "124523333";



            try
            {
                vue.Dni_Novalido(vue.Nif);
            }
            catch(Exception)
            {
                throw;
            }
          
          
      


        }
        //[TestMethod]
        //public void TestNombre()
        //{
        //    Alumno alum = new Alumno();

        //    string nombre = "Julian";

        //    string esperado = "Julian";

        //    alum.Nombre = nombre;

        //    Assert.AreEqual(esperado, alum.Nombre);

        //}
        //[TestMethod]
        //public void TestNombrenulo()
        //{
        //    Alumno alum = new Alumno();

        //    Assert.IsNull(alum.Nombre);

        //}
        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void TestNotaNovalida()
        //{
        //    Alumno alum = new Alumno();

        //    int nota = 60;
          
        //    try
        //    {
        //        alum.Nota = nota;
        //    }
        //    catch(Exception e)
        //    {
        //        Assert.AreEqual("mal",e.Message);
        //        throw;
        //    }
            
           
            
        //}
    }
}
