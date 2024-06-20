using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo.Models
{
    public partial class Jogador : ObservableObject
    {
        public Escolha Escolha { get; set; }

        public void FazerEscolha()
        {
            Random random = new Random();

            Escolha = (Escolha)random.Next(3);
        }
    }
}
