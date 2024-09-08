using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EjemploModuli1
{
    public partial class FrmSumaVector : Form
    {
        public FrmSumaVector()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = 0, contador = 0, numero;
            int[] vectorNum;
            lstNumeros.Items.Clear();
            if (int.TryParse(txtNum.Text, out cantidad))
            {
                vectorNum = new int[cantidad];
                while (cantidad > contador)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese el {contador + 1} valor", "Cargar Números");
                    if (int.TryParse(input, out numero))
                    {
                        vectorNum[contador] = numero;
                        lstNumeros.Items.Add(numero);
                        contador++;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valo númerico",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    }

                }
                lstNumeros.Items.Add($"Sumatoria => {sumarNumeros(vectorNum)}");
            }
            else
            {
                MessageBox.Show("Ingrese un valo númerico",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int sumarNumeros(int[] vectorNum)
        {
            int suma = 0;
            foreach (int item in vectorNum)
            {
                suma += item;
            }
            return suma;
        }

    }
}
