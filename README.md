PROVA ESCRITA PAM 20-06-24 - HELLEN NOVI 2º AI:

1. Para que serve o MVVM?
MVVM, abreviação de Model-View-ViewModel, é um padrão de arquitetura de software amplamente adotado para o desenvolvimento de interfaces de usuário, especialmente em aplicações orientadas a objetos.
•	ViewModel: Atua como um intermediário entre a View (interface do usuário) e o Model. Ele contém a lógica de apresentação que prepara e adapta os dados do Model para serem exibidos pela View.
•	View: É a camada que representa e exibe a interface do usuário para o usuário final. 
•	Model: Responsável por encapsular os dados e a lógica de negócios da aplicação.

----------------------------------------------------------------------------------------------------------
2. O que é o MVVM Community Toolkit?

O MVVM Community Toolkit representa uma iniciativa de código aberto desenvolvida colaborativamente para fortalecer a aplicação do padrão MVVM (Model-View-ViewModel) em ambientes WPF (Windows Presentation Foundation), UWP (Universal Windows Platform) e Xamarin.Forms. Esta biblioteca é um conjunto abrangente de utilitários, controles personalizados e extensões concebidos para otimizar o desenvolvimento de aplicações, incentivando a adoção de práticas avançadas do MVVM de maneira eficaz e eficiente.
----------------------------------------------------------------------------------------------------------
3. Para quê serve o arquivo appShell? Como adicionar uma view para ser exibida no lugar da main page?

O arquivo AppShell é utilizado em aplicações XAML para estabelecer a estrutura principal da aplicação, incluindo a gestão da navegação entre diferentes partes da interface do usuário. Ele serve como o recipiente central onde as páginas views da aplicação são organizadas e acessadas.
Adicionar uma view para ser exibida no lugar da main page:
Defina a página:
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="AplicativoEx.Views.PamExemplo ">
    <!-- Conteúdo da página -->
...
</ContentPage>

Registre a página no AppShell:
public partial class MyAppShell : Xamarin.Forms.Shell
{
    public MyAppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(PamExemplo), typeof(PamExemplo));
    }
}
----------------------------------------------------------------------------------------------------------
4. Para que serve <TabBar> no appshell?

<TabBar> é um componente usado para criar a navegação entre diferentes telas ou seções dentro de um aplicativo.
----------------------------------------------------------------------------------------------------------
5. Em aula, como instalamos pacotes usando Nuget no C#?
No Visual Studio, ir para o Solution Explorer (Explorador de Soluções). Clicar com o botão direito no projeto onde deseja instalar o pacote e selecione "Gerenciar Pacotes NuGet.

----------------------------------------------------------------------------------------------------------

6. O que é o Binding? Em que arquivo criamos os bindings?
O Binding possibilita uma conexão dinâmica e automática entre os dados do Model e a View. Essa ligação assegura que qualquer modificação nos dados seja imediatamente refletida na interface e vice-versa, eliminando a necessidade de intervenção manual para sincronização.
Os Bindings que foram criados por nós em sala de aula estão nos arquivos escritos em XAML.
<Label Text="{Binding Resultado}" />
----------------------------------------------------------------------------------------------------------
7. O que é um Command?
Command é um padrão eficaz para gerenciar interações de usuário em aplicativos .NET MAUI, proporcionando um controle estruturado sobre a lógica de ações executadas em resposta a eventos de interface do usuário.
EX:
<Button 
Text="Girar a moeda" 
Command="{Binding JogarCommand}" />
O Command, neste contexto, serve para associar uma ação específica que será executada quando o botão "Girar a moeda" for clicado.
----------------------------------------------------------------------------------------------------------
8. O que é o Binding context? Escreva como associamos o binding context a classe ViewModel
A função da ViewModel é essencial no contexto de estruturas de desenvolvimento de interfaces de usuário como Xamarin.Forms e WPF. Ela atua como um intermediário crucial entre o modelo de dados e a interface do usuário, permitindo uma ligação dinâmica e automática dos dados da ViewModel aos elementos visuais da View.

Para associar o Binding Context com a viewModel, fazemos:
<ContentPage x:Class="PamApp.PamPagina"
             xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:viewModel="clr-namespace:MinhaApp.ViewModels"
             BindingContext="{Binding Source={x:Static viewModel:MinhaViewModel.Instance}}">
    <!-- Conteúdo da página -->
	...
</ContentPage>
----------------------------------------------------------------------------------------------------------
9. Para que serve a ViewModel?
A ViewModel contribui muito para a estrutura e o funcionamento das aplicações de software. Ao promover uma organização mais clara e coesa do código, ela simplifica a manutenção contínua e facilita a reutilização de componentes. Além disso, a ViewModel eleva consideravelmente a testabilidade das aplicações, tornando-se fundamental na arquitetura moderna de sistemas voltados para interfaces de usuário dinâmicas e interativas.
----------------------------------------------------------------------------------------------------------
10. Qual a diferença entre construir uma view no MVVM e fora do MVVM?
No MVVM:
Construir uma View dentro do padrão MVVM separa claramente a lógica de apresentação (View) da lógica de negócios e apresentação de dados (ViewModel). Isso resulta em código mais organizado, modular e fácil de manter.

Fora do MVVM:
Construir uma View fora do MVVM pode misturar responsabilidades, tornando a manutenção e os testes mais difíceis, especialmente em aplicações grandes e complexas.
----------------------------------------------------------------------------------------------------------
11. O que quer dizer que um atributo é uma propriedade observável? [Observable Propriety]?
Uma propriedade observável é aquela que vem com um sistema embutido de alertas de mudança. Quando o valor dessa propriedade é atualizado, notifica automaticamente outras partes do sistema, garantindo que estejam sempre atualizadas com as últimas alterações. 
----------------------------------------------------------------------------------------------------------
12. Quando criamos uma observable Property, que cuidado devemos ter com os atributos?
Antes de atualizar uma propriedade, é essencial verificar se o novo valor difere do atual para evitar notificações desnecessárias ao sistema. Utilizando campos privados para armazenar os valores das propriedades e propriedades públicas para acessá-los, garante-se uma gestão consistente das mudanças. Além disso, é importante certificar-se de que todas as bibliotecas foram corretamente importadas e instaladas.
public partial class PamPage : ObservableObject
{ ... }
