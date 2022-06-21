//Que es lo que se esta utilizando de librerias
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //Importante agregar para poder manejar puertos de entrada/salida y el manejo de archivos
using System.Globalization; //Agregar para el manejo de conversiones entre tipos de datos
using ChartControl;

namespace PICRS232_cg
{
    public partial class Form_Principal : Form
    {
        //Con esta declaración se crea un objeto que guardara en memoria para ser desplegado cuando sea requerido
        private System.Drawing.Bitmap myBitmap; //Declaración del Bitmap

        //Se colocan loas variables a utilizar en el programa
        //Se usará una cadena "String" como buffer de recepción
        string Recibidos;
        string cadtmp;
        string cadtmp2;
        byte[] cadca = new byte[3];

        double timp;
        
        public Form_Principal()
        {
            InitializeComponent();
            //Abrir el puerto serie COM, mientras se ejecuta la aplicación
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    stato.ForeColor = Color.Blue;
                    stato.Text = "Conectado";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    stato.ForeColor = Color.Red;
                    stato.Text = "No Conectado";
                    /*Añadir que se deshabilite todo para evitar problemas*/
                }
            }
            //Ejecutar la función recepción por disparo del Evento DataReceived
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Recepcion);
            //Evento scroll de la TrackBar1
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
        }
        //Al recibir los datos
        private void Recepcion(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Leer lo que venga del buffer
            cadtmp2 = serialPort1.ReadExisting();
            //Acumular los caracteres que se vayan recibiendo en el buffer string
            Recibidos += cadtmp2;

            //Invocar el proceso de tramas
            this.Invoke(new EventHandler(Actualizar));
        }
        //Procesar los datos recibidos en el buffer y extraer las tramas completas
        private void Actualizar(object s, EventArgs e)
        {
            int qu;
            //Cadena de caracteres para crear al ruta del archivo donde se guardan los datos
            //Esta ruta es la misma donde se ejecuta el archivo
            string ruta;

            //Asignar el valor de la trama al textBox
            textBox_visualizar_mensaje.Text = cadtmp2;
            textBox6.Text = Convert.ToString(cadtmp2.Length);
            //textBox7.Text = cadtmp2;

            //Romper la cadena que se va recibiendo y mostrar los datos de 3 en 3 como se envia-recibe-manda
            //Esta instrucción me separa de lo que se recibe (cadtmp2) los elementos seprados por '\n', osea
            //me genera las tercias de datos recibidos del uC, se genera entonces un arreglo de cadenas con estas
            //cadenas separadas, entonces se tiene que separar cada cadena
            string[] cadrot = cadtmp2.Split(new char[] {'\n'});
            //Después del arreglo anterior se debe de recorrer todo para ir separando las tercias en elementos
            foreach (string sc in cadrot)
            {
                string[] cadrot2 = sc.Split(new char[] { '\t' });
                //Ahora hay que separar cada uno de los elementos y asegurarse que se estan colocando en el lugar que
                //son
                qu = 0;
                foreach (string sc2 in cadrot2)
                {
                    if (qu == 0)
                        textBox7.Text = sc2;
                    else if (qu == 1)
                        textBox8.Text = sc2;
                    else
                        textBox9.Text = sc2;
                    qu++;
                }
            }
            textBox10.Text=cadrot[0];

            //Mandar al archivo
            //Obtener la ruta donde se esta ejecutando el programa
            //(se usa @ antes de la cadena para evitar que detecte '\' como secuencia de escape)
            ruta=Environment.CurrentDirectory + @"\Archivot.txt";
            //Evento FileStream ediante el método Create de File
            //Método Create, crea el archivo en la ruta especificada y en caso de que este exista, se sobreescribe
            FileStream fs = File.Create(ruta); 
            //Se obtiene la equivalencia en bytes de la cadena utilizando un codificador UTF8
            byte[] bytess = Encoding.UTF8.GetBytes(Recibidos);
            //Escribir lo que se lee
            //El método Write escribe en el archivo un vector de bytes
            fs.Write(bytess,0,bytess.Length);
            fs.Flush();
            fs.Close();
        }

        /*
         * En caso de querer enviar una trama de datos, lo que se puede hacer es lo siguiente:
         * byte[] myBuffer = new Byte[3]; //Enviar máximo 3
         * myBuffer[0]=0x74;
         * myBuffer[1]=0x54;
         * myBuffer[2]=0x13;
         * this.serialPort1.Write(miBuffer,0,miBuffer.Length);
         */
      
        //Evento al dar click en el botón t (RESET)
        private void button_t_Click(object sender, EventArgs e)
        {
            //Crear variable local tipo byte para enviar al puerto serial
            byte[] mBuffer = new byte[1];
            //Apagar el LED
            mBuffer[0] = 0; //Valor 0 en PWM
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Colocar ceros en las cajas de texto de los valores del PWM
            textBox1.Text = mBuffer[0].ToString();
            textBox2.Text = mBuffer[0].ToString();
            //Y mandar a cero a la TrackBar
            trackBar1.Value = mBuffer[0];
            //Mandar el valor del botón
            mBuffer[0] = 0x74; //ASCII de la letra "t".
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Habilitar/Deshabilitar los botones pertinentes
            button_a.Enabled = true;
            button_b.Enabled = true;
            button_l.Enabled = true;
            button_ini.Enabled = false;
            trackBar1.Enabled = false;
            textBox4.ReadOnly = true;
            timp = 0;

        }

        //Evento al dar click en el botón b
        private void button_b_Click(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            mBuffer[0] = 0x62; //ASCII de la letra "b".
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            MessageBox.Show("Dar Click","Algo",MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
            /*
            //Tomar decisión dependiendo de que botón se presionó
            MessageBoxButtons bottones = MessageBoxButtons.OKCancel;
            DialogResult result;
            //mostrar el mensaje
            if(result == System.Windows.Forms.DialogResult.OK
             * { //Aqui van las acciones a seguir }
             */
        }

        //Evento al dar click en el botón a (PWM Manual)
        private void button_a_Click(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            mBuffer[0] = 0x61; //ASCII de la letra "a".
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Deshabilitar todos los controles expecto el botón t
            button_b.Enabled = false;
            button_l.Enabled = false;
            //Activar el slider para control del PWM
            trackBar1.Enabled = true;
            button_ini.Enabled = true;
            textBox4.ReadOnly = false;
            mBuffer[0] = 0;
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
        }

        //Evento al dar click en el botón l (Lector ADC)
        private void button_l_Click(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            mBuffer[0] = 0x6C; //ASCII de la letra "l".
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Deshabilitar controles
            button_a.Enabled = false;
            button_b.Enabled = false;
            trackBar1.Enabled = false;
        }

        //Botón de inicio de cualquier actividad
        private void button_ini_Click(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            mBuffer[0] = 0x2A; //ASCII de "*".
            serialPort1.Write(mBuffer, 0, mBuffer.Length);

            //Temporizador principal a 0
            timp = 0;
            //Inhabilitar controles
            textBox4.ReadOnly = true;
            button_a.Enabled = false;
            button_ini.Enabled = false;
            trackBar1.Enabled = false;
            //Habilitar el temporizador
            timer2.Enabled = true;
        }

        //Un timer para incluir la hora del sistema en la aplicación
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToLongTimeString();
        }

        //Otro timer para el control del tiempo de irradiación
        private void timer2_Tick(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            byte[] mBuffer2 = new byte[1];
            int dsk;

            int pbv;
            //En caso de que se llegue al valor colocado
            if (textBox4.Text == timp.ToString())
            {
                //Se manda a que todo se apague en el sistema
                mBuffer2[0] = 0x74;
                serialPort1.Write(mBuffer2, 0, mBuffer2.Length);
                //Se da un reset a todo
                button_a.Enabled = true;
                button_ini.Enabled = true;
                trackBar1.Enabled = true;
                trackBar1.Value = 0;
                mBuffer[0] = 0x61;
                serialPort1.Write(mBuffer, 0, mBuffer.Length);
                mBuffer[0] = 0;
                textBox1.Text = mBuffer[0].ToString();
                textBox2.Text = mBuffer[0].ToString();
                textBox3.Text = mBuffer[0].ToString();
                textBox4.Clear();
                textBox4.ReadOnly = false;
                pBar1.Value = 0;
                timer2.Enabled = false;
            }
            //En otro caso, se cuenta
            else
            {
                //Incrementar el contador
                timp++;
                //Mandar el valor del contador a cadena para mostrarlo en el cuadro de texto
                textBox3.Text = timp.ToString();
                //Convertir el valor en el textbox4 a int16
                pbv = Convert.ToInt16(textBox4.Text);
                //Calcular los valores para mostrar en la barra de estado
                pBar1.Value=(int)(100*timp/pbv);

                //Asignar el valor del tiempo
                dsk = Convert.ToInt16(timp);
                //Convertir el valor del TrackBar (entero de 16 bits) a un entero de 8 bits (byte)
                mBuffer2[0] = Convert.ToByte(dsk);
                //Mandar dicho valor convertido a tipo byte al puerto serial
                serialPort1.Write(mBuffer2, 0, mBuffer2.Length);
            }
        }

        //Manejar el slider TrackBar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            int dsk=trackBar1.Value;
            //Como los valores inferiores a 3 no tienen salida x el BUCK, entonces esos mandarlos de una vez a 0
            if (trackBar1.Value < 3)
            {
                dsk = 0;
            }
            //Convertir el valor del TrackBar (entero de 16 bits) a un entero de 8 bits (byte)
            mBuffer[0] = Convert.ToByte(dsk);
            //Mandar dicho valor convertido a tipo byte al puerto serial
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Mostrar el valor en una caja de texto (esto es el porcentaje de DCPWM)
            textBox1.Text = mBuffer[0].ToString();
            //Cambiar a potencia óptica de salida
            double temp;
            temp = 3.006 * dsk - 0.6725;
            //Mostar en otra caja de texto
            textBox2.Text = temp.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indixs = comboBox1.SelectedIndex;
            object itemslc = comboBox1.SelectedItem;

            /*MessageBox.Show("Texto Seleccionado: " + itemslc.ToString() + "\n" +
                    "Index: " + indixs.ToString());*/
            if (indixs == 0)
            {
                MessageBox.Show("Ya esta seleccionado");
            }
        }

        private void but_POIR_Click_1(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            mBuffer[0] = 0x77; //ASCII de la letra "z".
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Deshabilitar controles
            button_a.Enabled = false;
            button_b.Enabled = false;
            trackBar1.Enabled = false;
            trackBar2.Enabled = true;
            trackBar2.Value = 0;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            int dsk = trackBar2.Value;

            //Convertir el valor del TrackBar (entero de 16 bits) a un entero de 8 bits (byte)
            mBuffer[0] = Convert.ToByte(dsk);
            //Mandar dicho valor convertido a tipo byte al puerto serial
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Mostrar el valor en una caja de texto (esto es el porcentaje de DCPWM)
            textBox5.Text = mBuffer[0].ToString();
        }

        private void POR_but_Click(object sender, EventArgs e)
        {
            byte[] mBuffer = new byte[1];
            mBuffer[0] = 0x79; //ASCII de la letra "y".
            serialPort1.Write(mBuffer, 0, mBuffer.Length);
            //Deshabilitar controles
            button_a.Enabled = false;
            button_b.Enabled = false;
            trackBar1.Enabled = false;
            trackBar2.Enabled = true;
            trackBar2.Value = 0;
        }

        /*Eventos de control para "ver" el botón reset*/
        //Al estar sobre el botón
        private void button_t_MouseHover(object sender, EventArgs e)
        {
            button_t.BackColor = Color.Tomato;
        }

        //Al dejar el botón, sino se queda trabado
        private void button_t_MouseLeave(object sender, EventArgs e)
        {
            button_t.BackColor = Color.Red;
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            //Declarar objeto gráfico
            Graphics graphicsObj;
            //Crear la instancia del bitmap
            myBitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //Después crear el objeto graphico para poder dibujar en el bitmap
            graphicsObj = Graphics.FromImage(myBitmap);

            graphicsObj.Clear(Color.WhiteSmoke); //Pone el fondo del bitmap en algún color, en este caso blanco

            //Generar entonces todo lo que se va a dibujar
            Pen myPen = new Pen(System.Drawing.Color.Plum, 3);
            /*Crear el cuadro donde se colocará el fotopletismografo*/
            Rectangle rectangleObj = new Rectangle(10, 170, 800, 200);
            graphicsObj.DrawRectangle(myPen, rectangleObj);
            graphicsObj.DrawLine(myPen, 10, 270, 810, 270);
            graphicsObj.DrawLine(myPen, 210, 170, 210, 370);
            graphicsObj.DrawLine(myPen, 410, 170, 410, 370);
            graphicsObj.DrawLine(myPen, 610, 170, 610, 370);

            //Esto genera el bitmap, pero aún no lo muestra
            graphicsObj.Dispose(); //Disponer del objeto gráfico antes de salir para que se liberen recursos
        }

        private void Form_Principal_Paint(object sender, PaintEventArgs e)
        {
            //Para el caso de crear el objeto gráfico por medio de un bitmap
            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(myBitmap, 0, 0, myBitmap.Width, myBitmap.Height);
            graphicsObj.Dispose();
        }

    }
}
