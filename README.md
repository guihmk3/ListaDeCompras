# ?? Gerenciador de Lista de Compras
 
Um aplicativo desktop simples e intuitivo desenvolvido em C# com Windows Forms para gerenciar suas listas de compras de forma pr�tica e eficiente.
 
## ?? Sobre o Projeto
 
Este projeto � uma aplica��o de desktop que permite aos usu�rios criar, editar e gerenciar suas listas de compras de maneira simples e organizada. O aplicativo oferece uma interface limpa e funcional para adicionar itens, visualiz�-los em uma lista e remov�-los conforme necess�rio.
 
## ?? Screenshot
 
![Interface do Aplicativo](print.jpg)
 
*Interface principal do Gerenciador de Lista de Compras*
 
## ? Funcionalidades
 
- ? **Adicionar itens**: Insira novos produtos � sua lista de compras atrav�s de um campo de texto
- ?? **Visualizar lista**: Todos os itens adicionados s�o exibidos em um ListBox organizado
- ??? **Remover item �nico**: Selecione e exclua itens espec�ficos da lista
- ?? **Limpar lista completa**: Apague todos os itens da lista com um �nico clique
- ?? **Interface intuitiva**: Design simples e focado na usabilidade
- ?? **Recursos de usabilidade**: Implementados para melhorar a experi�ncia do usu�rio
 
## ??? Tecnologias Utilizadas
 
- **Linguagem**: C#
- **Framework**: .NET Framework / .NET
- **Interface**: Windows Forms
- **IDE**: Visual Studio
 
## ?? Pr�-requisitos
 
Antes de executar o projeto, certifique-se de ter instalado:
 
- [.NET Framework 4.7.2+](https://dotnet.microsoft.com/download/dotnet-framework) ou [.NET 6.0+](https://dotnet.microsoft.com/download)
- [Visual Studio 2019+](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
 
## ?? Como Executar
 
1. **Clone o reposit�rio**
   ```bash
   git clone https://github.com/seu-usuario/gerenciador-lista-compras.git
   ```
 
2. **Abra o projeto**
   - Abra o arquivo `.sln` no Visual Studio
   - Ou abra a pasta do projeto no Visual Studio Code
 
3. **Compile e execute**
   - No Visual Studio: Pressione `F5` ou clique em "Iniciar"
   - No terminal: Execute `dotnet run` na pasta do projeto
 
## ?? Como Usar
 
1. **Adicionar item**: Digite o nome do produto no campo de texto e pressione Enter ou clique no bot�o "Adicionar"
2. **Visualizar itens**: Todos os produtos adicionados aparecer�o na lista principal
3. **Remover item espec�fico**: Selecione um item na lista e clique em "Remover Item"
4. **Limpar lista**: Clique em "Limpar Tudo" para apagar todos os itens da lista
 
## ??? Estrutura do Projeto
 
```
?? GerenciadorListaCompras/
+-- ?? Properties/
+-- ?? Form1.cs              # Formul�rio principal
+-- ?? Form1.Designer.cs     # Designer do formul�rio
+-- ?? Form1.resx           # Recursos do formul�rio
+-- ?? Program.cs           # Ponto de entrada da aplica��o
+-- ?? README.md            # Documenta��o do projeto
```
 
## ?? Interface do Usu�rio
 
A interface � composta por:
- **TextBox**: Campo para inserir novos itens
- **ListBox**: Exibe todos os itens da lista de compras
- **Bot�es**: Controles para adicionar, remover e limpar itens
- **Layout responsivo**: Interface adapt�vel e de f�cil uso
 
## ?? Poss�veis Melhorias Futuras
 
- [ ] Salvar listas em arquivo para persist�ncia de dados
- [ ] Categoriza��o de produtos
- [ ] Quantidade de itens
- [ ] Pre�os estimados
- [ ] M�ltiplas listas de compras
- [ ] Exportar lista para diferentes formatos
- [ ] Tema escuro/claro
 
## ?? Contribui��o
 
Contribui��es s�o sempre bem-vindas! Para contribuir:
 
1. Fa�a um Fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudan�as (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request
 
## ?? Licen�a
 
Este projeto est� sob a licen�a MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
 
## ????? Autor
 
**Guilherme vitor**
- GitHub: https://github.com/guihmk3/
 
## ?? Agradecimentos
 
- Obrigado por usar este projeto!
- Se voc� gostou, n�o esque�a de dar uma ? no reposit�rio!
 
---
 
*Desenvolvido usando C# e Windows Forms*