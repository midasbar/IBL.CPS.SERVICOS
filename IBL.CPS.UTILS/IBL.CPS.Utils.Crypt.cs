using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace IBL.CPS.UTILS
{

    static public class EncryptUtils
    {
        static public string Encrypt(String text, KeyType keyType)
        {
            return Crypt(text, keyType, false);
        }

        static public string Decrypt(String text, KeyType keyType)
        {
            return Crypt(text, keyType, true);
        }

        static public String Crypt(String s, KeyType keyType, Boolean Decrypt)
        {
            // Modificado para utilizar MD5 para login atendendo às normas de segurança previstas em contrato
            if (keyType == KeyType.UserInfo)
            {
                    MD5 md5Hasher = MD5.Create();


                    byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(s));
                    
                    StringBuilder sBuilder = new StringBuilder();

                    for (int i = 0; i < data.Length; i++)
                    {
                        sBuilder.Append(data[i].ToString("x2"));
                    }

                    return sBuilder.ToString();
                
            }

            Int32 cont;
            Int64 iasc;
            String s1 = "", s2 = "", h = "", chave = "", soma = "", retorno = "";
            Char c1, c2;

            chave = GetKey(keyType);

            if (Decrypt)
                for (int i = 0; i <= s.Length - 1; i += 2)
                {
                    h = "0x" + s.Substring(i, 2);
                    iasc = Convert.ToInt64(h, 16);
                    s1 = s1 + (char)iasc;
                }
            else
                s1 = s;

            cont = 0;
            for (int j = 0; j <= s1.Length - 1; j++)
            {
                c1 = (Char)s1.Substring(j, 1)[0];
                c2 = (Char)chave.Substring(cont, 1)[0];
                soma = soma + (Char)((int)c1 ^ (int)c2);
                cont++;
                if (cont > chave.Length - 1)
                    cont = 0;
                retorno = soma;
            }

            if (!Decrypt) //Criptografar
            {
                for (int i = 0; i <= soma.Length - 1; i++)
                {
                    c1 = (Char)soma.Substring(i, 1)[0];
                    iasc = (Int32)c1;
                    h = String.Format("{0:x2}", iasc);
                    h = h.ToUpper();
                    s2 = s2 + h.Substring(h.Length - 2, h.Length);
                }
                retorno = s2;
            }

            return retorno;
        }

        static private String GetKey(KeyType keyType)
        {
            switch (keyType)
            {
                case KeyType.UserInfo:
                    return "ASDFGHJKZXCVBNM"; // Usuário
                case KeyType.Token:
                    return "MNBVCXZLKJHGFDS"; // Token
                default:
                    throw new Exception("Criptografia: Chave inválida.");
            }
        }
    }

    public enum KeyType { UserInfo, Token };


}
