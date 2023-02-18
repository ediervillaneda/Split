using System.Text;
using System;

namespace Split
{
    public partial class Main : Form
    {
        private readonly object Cupid = "";

        public List<string> salida { get; private set; }
        public Main()
        {
            InitializeComponent();
        }


        private void Procesar_Click(object sender, EventArgs e)
        {
            bool titulosOk = false;
            string titulos = "";
            salida = new List<string>();
            if (Input.Text.Trim().Length > 0)
            {
                string[] texto = Input.Text.Trim().Split('#');
                foreach (var items in texto)
                {
                    string[] fullItems = items.Split('|');
                    if (fullItems.Length > 1)
                    {
                        string datos = "";
                        foreach (var item in fullItems)
                        {
                            string[] contenido = item.Split(":");
                            if (!titulosOk)
                            {
                                titulos += $"{contenido[0].Trim()};";
                            }
                            datos += $"{contenido[1].Trim()};";

                        }
                        if (!titulosOk)
                        {
                            salida.Add(titulos);
                            titulosOk = true;
                        }
                        salida.Add(datos);
                    }
                    else
                    {
                        salida.Add(fullItems[0].Trim());
                    }
                }
            }

            if (salida.Count > 0)
            {
                SaveFileDialog saveFD = new SaveFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Title = "Guardar archivo como",
                    CheckFileExists = false,
                    CheckPathExists = true,
                    DefaultExt = "csv",
                    Filter = "CSV file (*.csv)|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    FileName = "salida.csv"

                };
                StreamWriter writer = null;


                if (saveFD.ShowDialog() == DialogResult.OK)
                {
                    writer = new StreamWriter(saveFD.FileName, false, Encoding.Latin1);
                    //string combinedString = string.Join( ",", myList.ToArray() );

                    writer.WriteLine(string.Join("\r\n", salida.ToArray()));

                    writer.Close();
                }

                DialogResult res = MessageBox.Show($"Te acabo de generar el archivo \"{saveFD.FileName}\". \n\rConsultalo, que allí esta todo lo que necesitas.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {
                    MessageBox.Show($"¿Te dije que te amo? \n\r {Cupid}");
                    //Some task…
                }

            }
        }

        private void Adios_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}