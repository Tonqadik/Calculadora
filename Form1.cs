using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora
{
    public enum TipoLog
    {
        DEBUG,
        INFO,
        WARN,
        ERROR
    }
    enum Operacion
    {
        DEFAULT,
        SUMA,
        RESTA,
        MULTIPLICACION,
        DIVISION
    }

    // Creación de la clase Log
    public class Log
    {

        // Añade una línea al log, junto con el tipo
        public static void AddLinea(string linea, TipoLog tipo)
        {
            System.IO.File.AppendAllText("Log.txt", $"{DateTime.Now.ToString()}" + $" -{tipo}-".PadRight(8)  + $" {linea}\n");
        }

        // Añade una línea al log
        public static void AddLinea(string linea)
        {

            System.IO.File.AppendAllText("Log.txt", $"{DateTime.Now.ToString()} -INFO-  {linea}\n");
        }

        // Se crea el archivo log
        public static void IniciarLog()
        {
            System.IO.File.WriteAllText("Log.txt", ""); // Crea el archivo log, en caso de existir, entonces borra su contenido
            Log.AddLinea("Programa iniciado");
        }

    }

    public partial class Form1 : Form
    {

        char decimalOp = char.Parse(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        public Form1()
        {
            // Se inicializa los componentes del forms
            InitializeComponent();
            Log.IniciarLog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log.AddLinea("Inicializando variables del forms", TipoLog.DEBUG);
            this.AcceptButton = btnIgual;
            this.CancelButton = btnC;
            Log.AddLinea("Form cargado", TipoLog.INFO);
        }

        //********************* INPUTS BOTONES DEL FORMS **********************
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return ;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "1";           
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "2";            
                
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "3";            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "4";
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "5";
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "6";
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "7";
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "8";
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "9";
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplayEstaLLeno()) return;
            setEstadoBtnOperadores(true);
            txtDisplay.Text += "0";
            
        }

        //********************* INPUTS BOTONES NÚMEROS DEL FORMS **************
        private void btnPunto_Click(object sender, EventArgs e)
        {
            // En caso de que el anterior simbolo sea el punto, entonces no lo agrega.
            if(AnteriorSimbolo(getTexto()) == decimalOp) return;
            if (txtDisplayEstaLLeno()) return;
            if (getTextoLength() == 0) txtDisplay.Text += "0";

            txtDisplay.Text += decimalOp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (getTextoLength() == 0) return;

            setEstadoBtnOperadores(true);
            txtDisplay.Text = getTexto().Substring(0, getTextoLength() - 1);
            if (txtEstaVacio()) txtDisplay.Text += "0";          

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtEstaVacio()) { mostrarErrorEstado("No se puede ingresar un operador de primero"); return; }
            if (txtDisplayEstaLLeno()) { mostrarErrorEstado("El display está lleno, borra un carácter"); return; }
            if (UltimoCharEsOperador()) { mostrarErrorEstado("El último carácter es un operador, es necesario borrarlo"); return; }

            setEstadoBtnOperadores(false);
            txtDisplay.Text += "*";
            
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtEstaVacio()) { mostrarErrorEstado("No se puede ingresar un operador de primero"); return; }
            if (txtDisplayEstaLLeno()) { mostrarErrorEstado("El display está lleno, borra un carácter"); return; }
            if (UltimoCharEsOperador()) { mostrarErrorEstado("El último carácter es un operador, es necesario borrarlo"); return; }

            setEstadoBtnOperadores(false);
            txtDisplay.Text += "/";
            
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (txtEstaVacio()) { mostrarErrorEstado("No se puede ingresar un operador de primero"); return; }
            if (txtDisplayEstaLLeno()) { mostrarErrorEstado("El display está lleno, borra un carácter"); return; }
            if (UltimoCharEsOperador()) { mostrarErrorEstado("El último carácter es un operador, es necesario borrarlo"); return; }

            setEstadoBtnOperadores(false);
            txtDisplay.Text += "+";
            
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtEstaVacio()) { mostrarErrorEstado("No se puede ingresar un operador de primero"); return; }
            if (txtDisplayEstaLLeno()) { mostrarErrorEstado("El display está lleno, borra un carácter"); return; }
            if (UltimoCharEsOperador()) { mostrarErrorEstado("El último carácter es un operador, es necesario borrarlo"); return; }

            setEstadoBtnOperadores(false);
            txtDisplay.Text += "-";
            
        }

        // Al darle al botón igual se calcula la operaciones aritméticas, primero se hacen las multiplicaciones y divisiones y después las sumas y restas.
        private void btnIgual_Click(object sender, EventArgs e)
        {        
            try
            {
                // Validaciones 
                if (txtEstaVacio()) { mostrarErrorEstado("No hay ningún operador"); return; }
                if (AnteriorSimbolo(getTexto()) == ' ') { mostrarErrorEstado("No se puede hacer una operación sin operador"); return; }
                if (UltimoCharEsOperador()) { mostrarErrorEstado("El último carácter es un operador, es necesario borrarlo o insertar otro número"); return; }
                List<float> Numeros = new List<float>(Array.ConvertAll(getTexto().Split(new Char[] { '*', '/', '-', '+' }), float.Parse));
                List<string> operadores = getTexto().Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', decimalOp }, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> operadores2 = operadores;

                Log.AddLinea("Calculando operación aritmética", TipoLog.INFO);

                // Operaciones aritméticas multiplicacion y division
                int idx = 0;
                foreach (string c in operadores)
                {
                    if (c == "*" || c == "/")
                    {
                        float res = 0;
                        res = realizarOperacionMat(
                            Numeros[idx], 
                            Numeros[idx + 1], 
                            getTipoOperacion(
                                Numeros[idx].ToString() + c + Numeros[idx + 1]
                                )
                        );
                        Numeros.Remove(Numeros[idx]);
                        Numeros.Remove(Numeros[idx]);
                        Numeros.Insert(0, res);
                        idx--;
                    }
                    // El indice solo avanza si se ha hecho alguna operación, en caso contrario no se mueve
                    idx++;
                }

                // Se obtiene primero solo los operadores de suma y resta
                operadores = operadores.Where(x => x == "+" || x== "-").ToList();


                // Operaciones aritméticas suma y resta
                foreach (string c in operadores)
                {
                    float res = 0;
                    res = realizarOperacionMat(Numeros[0], Numeros[1], getTipoOperacion(Numeros[0].ToString() + c + Numeros[1]));
                    Numeros.Remove(Numeros[0]);
                    Numeros.Remove(Numeros[0]);
                    Numeros.Insert(0, res);

                }
                

                Log.AddLinea("Cálculo de la Operación aritmética terminada", TipoLog.INFO);
                // Se setea el texbox con su resultado
                txtDisplay.Text = String.Format("{0:0.#}", Numeros[0]);
            }
            catch (DivideByZeroException ex) { mostrarErrorEstado("No se puede dividir por cero" + ex.StackTrace + " Error: " + ex.Message); }
            catch (NotFiniteNumberException ef) { mostrarErrorEstado("El resultado es infinito" + ef.StackTrace + " Error: " + ef.Message); }
            catch (ArithmeticException em) { mostrarErrorEstado("Los operadores o resultado no son un número " + em.StackTrace +  " Error: "+ em.Message  ); }
            catch (Exception ep) { mostrarErrorEstado("Ha ocurrido un error linea: " + ep.StackTrace +  " Error: "+ ep.Message ); }

        }

        //*********************** MÉTODOS DEL FORMS ***************************

        private string getTexto() => txtDisplay.Text;
        

        private int getTextoLength() => txtDisplay.Text.Length;
        
        private void mostrarErrorEstado(string msj)
        {
            Log.AddLinea(msj, TipoLog.ERROR);
            lblEstado.ForeColor = Color.Red;
            lblEstado.Text = msj;
        }

        private void mostrarMsjrEstado(string msj)
        {
            lblEstado.ForeColor = Color.Black;
            lblEstado.Text = msj;
        }

        private bool txtDisplayEstaLLeno()
        {
            return txtDisplay.Text.Length == 12;
        }

        private bool txtEstaVacio() => txtDisplay.Text.Length == 0;
        

        private Operacion getTipoOperacion(string txt) {
            if (txt.IndexOf("+") > -1) return Operacion.SUMA;
            if (txt.IndexOf("-") > -1) return Operacion.RESTA;
            if (txt.IndexOf("/") > -1) return Operacion.DIVISION;
            if (txt.IndexOf("*") > -1) return Operacion.MULTIPLICACION;

            return Operacion.DEFAULT;
        }

        private float realizarOperacionMat(float n1, float n2, Operacion tipo)
        {
            if (n2 == 0 && tipo == Operacion.DIVISION) throw new DivideByZeroException("Error, no se puede divir por 0");
            float num1 = n1;
            float num2 = n2;
            float resultado = 0;
            switch (tipo)
            {
                case Operacion.SUMA:
                    resultado = num1 + num2;
                    break;

                case Operacion.RESTA:
                    resultado = num1 - num2;
                    break;

                case Operacion.DIVISION:
                    resultado = num1 / num2;
                    break;

                case Operacion.MULTIPLICACION:
                    resultado = num1 * num2;
                    break;

                default:
                    resultado = 0;
                    break;
            }

            if (float.IsInfinity(resultado)) throw new NotFiniteNumberException("Error, el resultado es infinito");
            if (float.IsNaN(resultado)) throw new ArithmeticException("Error, el resultado no es un número");
            return resultado;
        }

        // Obtiene el último simbolo añadido
        private char AnteriorSimbolo(string str)
        { 
            List<char> c = str.ToList();

            // Se hace un for loop reverso, para encontrar el último simbolo del text display agregado
            for (int i = c.Count - 1; i > 0 ; i--)
            {
                if (Array.IndexOf(new char[] { '*', '/', '+', '-', decimalOp }, c[i]) != -1) return c[i];
            }
            return ' ';
        }

        // Obtiene el indice del último simbolo añadido
        private int AnteriorSimboloIdx(string str)
        {
            List<char> c = str.ToList();

            // Se hace un for loop reverso, para encontrar el último simbolo del text display agregado
            for (int i = c.Count - 1; i > 0; i--)
            {
                if (Array.IndexOf(new char[] { '*', '/', '+', '-', decimalOp }, c[i]) != -1) return i;
            }
            return -1;
        }

        private char PenultimoSimbolo(string str)
        {
            int ult = AnteriorSimboloIdx(str);
            return AnteriorSimbolo(str.Substring(0,ult));
        }



        private bool UltimoCharEsOperador() => getTexto().Last().ToString().IndexOfAny("*/-+".ToCharArray()) != -1;
        
        private void setEstadoBtnOperadores(bool est)
        {
            lblEstado.Text = "";
            btnMas.Enabled = est;
            btnMenos.Enabled = est;
            btnMulti.Enabled = est;
            btnDivision.Enabled = est;
        }
    }
}
