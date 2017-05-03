using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//@fabiopos
namespace SECarros
{
    public partial class Form1 : Form
    {
        #region Properties
        public string fileName = "carros.clp";
        public string assertString { get; set; }
        public string Precio { get; set; }
        public string Tamano { get; set; }
        public string Caballos { get; set; }
        public string Abs { get; set; }
        public string Consumo { get; set; }

        #endregion

        ClipsFramework cw;

        public Form1()
        {
            InitializeComponent();
            cw = new ClipsFramework();
            cw.Load(fileName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "";
            GetFormValues();
            assertString = string.Format("(preferencias (precio {0})(tamano {1})(caballos {2})(abs {3})(consumo {4}))", Precio, Tamano, Caballos, Abs, Consumo);
            cw.Reset();
            cw.CreateAssert(assertString);
            cw.Run();
            string response = cw.GetResponse();
            if (!string.IsNullOrEmpty(response))
                lblRespuesta.Text = response;
            else
            {
                // aplicar la otra estrategia
                ApplyStrateghy();
            }

        }

        private void ApplyStrateghy()
        {
            cw.Reset();
            LoadAssertsCarros();
            var results = LoadResultsByDimensions();
            var response = TranslateFinalResult(results);
            lblRespuesta.Text = "El carro más acorde para ud es el " + response;
        }

        private Dictionary<string, int> LoadResultsByDimensions()
        {
            List<string> _resultados = new List<string>();
            Dictionary<string,int> _resultadosFinales = new Dictionary<string, int>();
            _resultados.Add(ByPrice(Precio));
            _resultados.Add(ByHorsePower(Caballos));
            _resultados.Add(ByConsume(Consumo));
            _resultados.Add(ByBagSize(Tamano));
            _resultados.Add(ByAbs(Abs));
            
            int cM1 = _resultados.Count(x => x == "1");
            int cM2 = _resultados.Count(x => x == "2");
            int cM3 = _resultados.Count(x => x == "3");
            int cM4 = _resultados.Count(x => x == "4");
            int cM5 = _resultados.Count(x => x == "5");

            _resultadosFinales.Add("Modelo 1", cM1);
            _resultadosFinales.Add("Modelo 2", cM2);
            _resultadosFinales.Add("Modelo 3", cM3);
            _resultadosFinales.Add("Modelo 4", cM4);
            _resultadosFinales.Add("Modelo 5", cM5);

            return _resultadosFinales;
        }

        private string TranslateFinalResult(Dictionary<string, int> results)
        {
            return results.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        }


        private void GetFormValues()
        {
            Precio = txtPrecio.Text;
            Tamano = (rbMaleteroG.Checked ? "g" : rbMaleteroM.Checked ? "m" : rbMaleteroP.Checked ? "p" : "");
            Caballos = txtCaballos.Text;
            Abs = rbAbsSi.Checked ? "s" : "n";
            Consumo = txtConsumo.Text;

        }

        private void LoadAssertsCarros()
        {
            string modeloUno = "(carro(modelo 1)(precio 12000)(tamano p)(caballos 65)(abs n)(consumo 4.7))";
            string modeloDos = "(carro(modelo 2)(precio 12500)(tamano p)(caballos 80)(abs s)(consumo 4.9))";
            string modeloTres = "(carro(modelo 3)(precio 13000)(tamano m)(caballos 100)(abs s)(consumo 4.9))";
            string modeloCuatro = "(carro(modelo 4)(precio 14000)(tamano g)(caballos 125)(abs s)(consumo 6.0))";
            string modeloCinco = "(carro(modelo 5)(precio 15000)(tamano p)(caballos 147)(abs s)(consumo 8.5))";
            cw.CreateAssert(modeloUno);
            cw.CreateAssert(modeloDos);
            cw.CreateAssert(modeloTres);
            cw.CreateAssert(modeloCuatro);
            cw.CreateAssert(modeloCinco);

        }

        private string FindByOtherStrateghy(string strateghyProperty, string valueToSearch, string compOperator)
        {
            return cw.GetFact("carro", strateghyProperty, valueToSearch, "modelo", "0", compOperator);
        }

        #region Little Strateghy finding in facts
        private string ByPrice(string value)
        {
            return FindByOtherStrateghy("precio", value, "<=");
        }
        private string ByBagSize(string value)
        {
            return FindByOtherStrateghy("tamano", value, "eq");
        }
        private string ByHorsePower(string value)
        {
            return FindByOtherStrateghy("caballos", value, ">=");
        }
        private string ByConsume(string value)
        {
            return FindByOtherStrateghy("consumo", value, "<=");
        }
        private string ByAbs(string value)
        {
            return FindByOtherStrateghy("abs", value, "eq");
        }
        #endregion

    }
}


