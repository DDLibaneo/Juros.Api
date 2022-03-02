# Juros.Api
Este é um desafio da empresa SoftPlan. Consiste em desenvolver uma API com um endpoint para incluir uma taxa de juro, e um endpoint para recuperar a ultima taxa de juro incluída.

### Ferramentas utilizadas
Foi utilizado .NET Core 3.1, Enitity Framework Core com migrações code-first e xUnit para os testes. 
O Banco de dados utilizado foi o SQL Server. A IDE utilizada foi o Visual Studio 2022.

### Passos para rodar o projeto no visual studio
##### 1. Faça um clean e build do projeto Api
Clique com o botão direito na Solution e escolha a opção Clean. Depois, clique novamente com o botão direito na solution e escolha a opção Build. Caso não apresente erros pode passar para o próximo passo. Caso apresente erros, tente fazer os builds por projeto, um de cada vez, começando pelo Model, depois pelo DataStore, depois pelo Services e por fim pela API. Faça o mesmo com os projetos nas pastas testes.

##### 2. Configure o Banco de dados
No Nuget Package Manager Console, no cabeçalho do Drop Down List "Default Project" escolha Juros.DataStore. Agora no próprio Console, digite "update-database".

##### 3. Rode o projeto
Rode o projeto clicando no botão Run do Visual Studio, escolhendo IIS Express como opção de Host.

##### 4. Endpoints
Voce pode testar os endpoints no postman.
* Get Last Juro
  * Método: GET
  * Url exemplo: http://localhost/api/taxa/juros
* Create Juro
  * Método: POST
  * Url exemplo: http://localhost/api/taxa/juros
  * exemplo body válido para uma taxa de 1%: 
  ```
  {
    "Taxa": 0.01
  }
  ```
  
##### 5. Rodando os Testes
Para rodar os testes da Solução abra o test Explorer e clique em "Run all tests". Os projetos de teste são aqueles com o sufixo ".Tests".
  
