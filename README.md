# WebApi_Locadora
Web API - ASP Net Core + Entity Framework

Para rodar aplicação é necessário executar as migrations criadas em um ambiente de teste, podendo ser um banco local, apenas sendo necessário alterar a connectionString no arquivo de configuração.

----- ENDPOINTS ------

** ADICIONAR CLIENTE **

URL: https://localhost:44367/api/clientes </br>
VERBO HTTP: POST </br>
CONTENT TYPE: application/json </br>

Exemplo de JSON: 
```yaml
{
    "nome": "Caio Oliveira",
    "rg": "375846232"
} 
```

** LISTA TODOS OS CLIENTES CADASTRADOS ** </br>

URL: https://localhost:44367/api/clientes </br>
VERBO HTTP: GET </br>

--------------------------------------------------------------------------- </br>

** ADICIONAR FILME ** </br>

URL: https://localhost:44367/api/filmes </br>
VERBO HTTP: POST </br>
CONTENT TYPE: application/json </br>

Exemplo de JSON: </br>
```yaml
{
    "nome": "Velozes e Furiosos 9", </br>
    "sinopse": "Dominic Toretto e Letty vivem uma vida pacata ao lado do filho. Mas eles logo são. ", </br>
    "genero": "Ação" </br>
}
```

** LISTA TODOS OS FILMES CADASTRADOS ** </br>

URL: https://localhost:44367/api/filmes </br>
VERBO HTTP: GET </br>

-------------------------------------------------------------------------------


** LISTA TODAS AS LOCACOES CADASTRADOS **

URL: https://localhost:44367/api/locacao </br>
VERBO HTTP: GET </br>

** LOCAR FILME **

URL: https://localhost:44367/api/locacao/locar
VERBO HTTP: POST
CONTENT TYPE: application/json
```yaml
{
    "ClienteId": "048e02cc-dfc5-4a10-6b91-08d9632b4a80",
    "FilmeId": "ae7d664a-17a9-4ce1-8762-08d96374f627",
    "QuantidadeDiasLocacao": 5
}
```

** DEVOLVER FILME **

URL: https://localhost:44367/api/locacao/devolver
VERBO HTTP: POST
CONTENT TYPE: application/json

```yaml
{
    "clienteId": "048e02cc-dfc5-4a10-6b91-08d9632b4a80",
    "filmeId": "ec506896-98be-49a2-8761-08d96374f627"
} 
```

