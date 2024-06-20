using CommunityToolkit.Mvvm.ComponentModel;
using JokenPo.Models;
using System.Windows.Input;

namespace JokenPo.ViewModels
{
    public partial class jokenpoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private int jPontos;

        [ObservableProperty]
        private int opPontos;

        [ObservableProperty]
        private string jNome;

        [ObservableProperty]
        private string opNome;

        [ObservableProperty]
        private string jImagem;

        [ObservableProperty]
        private string opImagem;

        [ObservableProperty]
        private string jEscolha;

        public ICommand JogarCommand { get; set; }

        public jokenpoViewModel()
        {
            JogarCommand = new Command(Jogar);
            jNome = "Jogador";
            opNome = "Máquina";
        }

        public void Jogar()
        {
            Jogador jogador = new Jogador();
            Jogador oponente = new Jogador();

            if (jEscolha == "Pedra")
            {
                jogador.Escolha = Escolha.Pedra;
            }
            else if (jEscolha == "Papel")
            {
                jogador.Escolha = Escolha.Papel;
            }
            else if (jEscolha == "Tesoura")
            {
                jogador.Escolha = Escolha.Tesoura;
            }
            else
            {
                jogador.Escolha = Escolha.Pedra; // Valor padrão se a entrada for inválida
            }

            oponente.FazerEscolha();

            // Atualizar jImagem com base na escolha do jogador
            switch (jogador.Escolha)
            {
                case Escolha.Pedra:
                    JImagem = "pedra.png";
                    break;
                case Escolha.Papel:
                    JImagem = "papel.png";
                    break;
                case Escolha.Tesoura:
                    JImagem = "tesoura.png";
                    break;
            }

            // Atualizar opImagem com base na escolha do oponente
            switch (oponente.Escolha)
            {
                case Escolha.Pedra:
                    OpImagem = "pedra.png";
                    break;
                case Escolha.Papel:
                    OpImagem = "papel.png";
                    break;
                case Escolha.Tesoura:
                    OpImagem = "tesoura.png";
                    break;
            }

            // Lógica para determinar o resultado do jogo...
            if (jPontos < 10 && opPontos < 10)
            {
                if (jogador.Escolha == oponente.Escolha)
                {
                    Resultado = "Empate";
                }
                else if ((jogador.Escolha == Escolha.Pedra && oponente.Escolha == Escolha.Tesoura) ||
                         (jogador.Escolha == Escolha.Papel && oponente.Escolha == Escolha.Pedra) ||
                         (jogador.Escolha == Escolha.Tesoura && oponente.Escolha == Escolha.Papel))
                {
                    Resultado = $"{jogador.Escolha} vence {oponente.Escolha}, {jNome} venceu";
                    JPontos++;
                }
                else
                {
                    Resultado = $"{oponente.Escolha} vence {jogador.Escolha}, {opNome} venceu";
                    OpPontos++;
                }
            }
            else if (jPontos == 10)
            {
                Resultado = $"Jogo encerrado, {jNome} venceu";
            }
            else
            {
                Resultado = $"Jogo encerrado, {opNome} venceu";
            }
        }
    }
}
