using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBL.CPS.UTILS
{

    static public class TokenUtils
    {
        static public String GetToken()
        {
            return EncryptUtils.Encrypt(DateTimeUtils.GetNow().Ticks.ToString(), KeyType.Token);
        }

        static public Boolean IsValidToken(String token)
        {
            try
            {
                var decryptedToken = EncryptUtils.Decrypt(token, KeyType.Token);
                var ticks = long.Parse(decryptedToken);
                var dttoken = new DateTime(ticks);

                var ts = DateTimeUtils.GetNow() - dttoken;

                // Token é válido até 10 minutos. Data-Hora adiantada também é inválida.
                return (ts.Minutes >= 0) && (ts.Minutes <= 10);
            }
            catch
            {
                return false;
            }
        }

        static public String GetInvalidTokenMessage()
        {
            return "Token expirado ou inválido.";
        }

    }



}
