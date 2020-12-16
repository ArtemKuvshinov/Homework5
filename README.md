# Homework5
Лекция 5: Безопасность

Применил фильтр ValidateAntiforgeryToken к контроллерам POST, PUT, DELETE для противодействия подделке межсайтовых запросов.
  С помощью диспетчера секретов, включил хранилище секретов: D:\SimbirSoft\Lesson5\Homework5\Homework5>dotnet user-secrets init
  Задал секрет: dotnet user-secrets set "Connect:ConnectionString" "Server=(localdb)\\mssqllocaldb;Database=Movie-1;Trusted_Connection=True;MultipleActiveResultSets=true"
