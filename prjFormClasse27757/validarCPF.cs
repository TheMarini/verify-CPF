using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjClasse27757
{
    public class validarCPF
    {
        //Campos
        private string _cpf;

        //Propriedades
        public string cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }

        public bool valido
        {
            get
            {   
                int resto;
                int total = 0;
                int multiplica;

                if (cpf.Length == 11 && cpf != "00000000000" && cpf != "11111111111" && cpf != "22222222222" && cpf != "33333333333" && cpf != "44444444444" && cpf != "55555555555" && cpf != "66666666666" && cpf != "77777777777" && cpf != "88888888888" && cpf != "99999999999")
                {
                    #region Primeiro Dígito
                    multiplica = 10;
                    for (int i = 0; i < 9; i++)
                    {
                        int numero = int.Parse(cpf.ToString().Substring(i, 1));
                        total += numero * multiplica;
                        multiplica--;
                    }

                    #region resto
                    resto = (total * 10) % 11;
                    if (resto > 9)
                    {
                        resto = 0;
                    }
                    #endregion

                    if (resto != int.Parse(cpf.ToString().Substring(9, 1)))
                    {
                        return false;
                    }
                    #endregion

                    #region Segundo Dígito
                    total = 0;
                    multiplica = 11;
                    for (int i = 0; i < 10; i++)
                    {
                        int numero = int.Parse(cpf.ToString().Substring(i, 1));
                        total += numero * multiplica;
                        multiplica--;
                    }

                    #region resto
                    resto = (total * 10) % 11;
                    if (resto == 10)
                    {
                        resto = 0;
                    }
                    #endregion

                    if (resto != int.Parse(cpf.ToString().Substring(10, 1)))
                    {
                        return false;
                    }
                    #endregion

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Construtor
        public validarCPF()
        {
            _cpf = "12345678909";
        }

        public validarCPF(string valor)
        {
            _cpf = valor;
        }
    }
}
