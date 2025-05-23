# Туристический путеводитель

## Описание

Веб-приложение "Туристический путеводитель" разработано на ASP.NET Core MVC с использованием Entity Framework Core и PostgreSQL. Приложение позволяет просматривать информацию о городах и их достопримечательностях, включая название, регион, население, историю, фотографии и герб. Реализован поиск по названию города.

### Основной функционал

- **Список городов**: На главной странице отображается список городов с кратким описанием, населением и фотографией.
- **Поиск**: Возможность поиска городов по названию.
- **Информация о городе**: Подробная информация о городе (название, регион, население, история, герб, фото) и список связанных достопримечательностей.
- **Информация о достопримечательности**: Подробная информация о достопримечательности (название, описание, история, фото, часы работы, стоимость).

## Технологии

- **Фреймворк**: ASP.NET Core MVC (.NET 8.0)
- **База данных**: PostgreSQL
- **ORM**: Entity Framework Core
- **Frontend**: Bootstrap 5.3 для стилизации
- **Среда разработки**: Visual Studio 2022

## Структура проекта

- `Models/` — Модели данных (`City`, `Attraction`).
- `Data/` — Контекст базы данных (`TravelGuideContext`) и инициализация тестовых данных (`TravelGuideContextSeed`).
- `Controllers/` — Контроллеры (`CitiesController`, `AttractionsController`).
- `Views/` — Razor-представления для отображения данных.
- `wwwroot/images/` — Изображения городов и достопримечательностей.

## Установка и запуск

### Требования

- .NET 8.0 SDK
- PostgreSQL (версия 15 или новее)
- Visual Studio 2022 (или другая IDE, поддерживающая .NET)

### Шаги для запуска

1. **Клонирование репозитория**:

   ```bash
   git clone https://github.com/1vanch0s/Travel-Guilde-Csharp
   cd TravelGuide
   ```

2. **Установка зависимостей**: Установите необходимые NuGet-пакеты:

   ```bash
   dotnet restore
   ```

   Или через Visual Studio:

   - Откройте **Сервис &gt; Диспетчер пакетов NuGet &gt; Управление пакетами NuGet для решения**.
   - Убедитесь, что установлены:
     - `Microsoft.EntityFrameworkCore` (8.0.x)
     - `Npgsql.EntityFrameworkCore.PostgreSQL` (8.0.x)
     - `Microsoft.EntityFrameworkCore.Design` (8.0.x)

3. **Настройка базы данных**:

   - Установите PostgreSQL и создайте базу данных `TravelGuideDb`:

     ```sql
     CREATE DATABASE TravelGuideDb;
     ```
   - Обновите строку подключения в `appsettings.json`:

     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Database=TravelGuideDb;Username=postgres;Password=your_password"
     }
     ```

     Замените `your_password` на ваш пароль для PostgreSQL.

4. **Применение миграций**: В **Консоли диспетчера пакетов** (или через `dotnet ef`):

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

   Это создаст таблицы `Cities`, `Attractions` и `__EFMigrationsHistory`.

5. **Добавление тестовых данных**:

   - Тестовые данные автоматически добавляются при запуске приложения через `TravelGuideContextSeed`.
   - Если данные не добавились, выполните SQL-скрипт из `SeedData.sql` в папке проекта.

6. **Добавление изображений**:

   - Поместите изображения в папку `wwwroot/images`. Список необходимых файлов:
     - `moscow.jpg`, `moscow_coat.png`, `red_square.jpg`, `kremlin.jpg`, `bolshoi.jpg`, `christ_savior.jpg`, `gorky_park.jpg`
     - `spb.jpg`, `spb_coat.png`, `hermitage.jpg`, `peter_paul.jpg`, `isaac.jpg`
     - `krasnodar.jpg`, `krasnodar_coat.png`, `galitsky_park.jpg`, `krasnodar_museum.jpg`

7. **Запуск приложения**:

   ```bash
   dotnet run
   ```

   Или запустите через Visual Studio (F5). Приложение откроется по адресу: `http://localhost:5174`.

## Дополнительные замечания

- Если возникают проблемы с HTTPS, проверьте сертификат:

  ```bash
  dotnet dev-certs https --clean
  dotnet dev-certs https --trust
  ```

  Или используйте HTTP, отредактировав `Properties/launchSettings.json`.

- Для проверки базы данных используйте pgAdmin или `psql`:

  ```sql
  SELECT * FROM "Cities";
  SELECT * FROM "Attractions";
  ```