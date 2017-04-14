using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFormClasse27757
{
    public partial class frmFormClasse27757 : Form
    {
        public frmFormClasse27757()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            prjClasse27757.validarCPF classe = new prjClasse27757.validarCPF();

            try 
	        {	        
		        classe = new prjClasse27757.validarCPF(txtCPF.Text.Replace(".", "").Replace("-", ""));

                if (classe.valido)
                {
                    lblValido.ForeColor = Color.Green;
                    lblValido.Text = "Válido";
                }
                else
                {
                    lblValido.ForeColor = Color.Red;
                    lblValido.Text = "Não é válido!";
                }
            }
	        catch
	        {
		        MessageBox.Show("Desculpe, aconteceu um erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
		        return;
	        }
        }

        #region Habilitar Botão
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtCPF.Text.Replace("_", "").Replace("-", "").Replace(".", "").Length == 11)
            {
                btnOk.Enabled = true;
                btnOk.Focus();
            }
            else
            {
                btnOk.Enabled = false;
            }
        }
        #endregion
    }
}
