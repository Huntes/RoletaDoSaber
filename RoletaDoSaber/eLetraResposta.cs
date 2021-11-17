using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoletaDoSaber
{
    public enum eResposta
    {
        LetraA = 1,
        LetraB = 2,
        LetraC = 3,
        LetraD = 4,
    }
    public class eLetraResposta
    {
        public static List<Opcao> GetOpcoes()
        {
            List<Opcao> opcoes = new List<Opcao>();
            int i = 0;
            foreach (var item in Enum.GetValues(typeof(eResposta)))
            {
                opcoes.Insert(i, new Opcao { ID = (int)item, Nome = GetNomeTela((int)item) });
                i++;
            }
            return opcoes;
        }

        public static string GetNomeTela(long id)
        {
            switch (id)
            {
                case (int)eResposta.LetraA:
                    return "Letra A";
                case (int)eResposta.LetraB:
                    return "Letra B";
                case (int)eResposta.LetraC:
                    return "Letra C";
                case (int)eResposta.LetraD:
                    return "Letra D";

                default:
                    return string.Empty;
            }
        }
    }
}

