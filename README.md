Este repositório contém um projeto desenvolvido enquanto pessoa estudante da @betrybe.

# Video Portal

O projeto Video Portal foi desenvolvido em C# utilizando o ASP.NET com um banco de dados SQL Server e tem como objetivo ser uma API que contem informações de uma plataforma de vídeos. Possui os seguintes endpoints:

- GET /api/video : Retorna todos os vídeos;

- GET /api/video/{id}: Retorna um vídeo através do seu id;

- GET /api/channel: Retorna todos os canais;

- GET /api/channel: Retorna um canal através do seu id;

- DELETE /api/channel/{id}: Remove um canal através do seu id;

- GET /api/channel/{id}/video: Retorna os vídeos de um determinado canal;

- GET /api/video/{id}/comment: Retorna os comentários de um determinado vídeo;

- POST /api/channel/{channelId}/video/{videoId}: Adiciona um vídeo em um determinado canal;

## Testes

Foram realizados testes utilizando o XUnit e o FluentAssertions.

## Inicialização

Para rodar a aplicação, utilize os seguintes comandos:

- Na pasta raiz: docker compose up

- Na pasta src: dotnet restore

- Na pasta video-portal: dotnet run 

## Feedbacks

Caso tenha alguma sugestão ou tenha encontrado algum erro no código, estou disponível para contato no meu [LinkedIn](https://www.linkedin.com/in/rafael-de-jesus-lima/)
