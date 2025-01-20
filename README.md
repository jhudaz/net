
# Tesla API

A simple API built with ASP.NET Core to demonstrate basic CRUD operations and service injection.

## Features

- **Controllers**: Handles HTTP requests and responses. Acts as the entry point for client interactions with the application.
- **Services**: Business logic for calculating areas. This layer processes the input data and ensures the appropriate logic is applied.
- **Interfaces**: Define contracts for the services and models, ensuring consistency and flexibility in the application. They provide a blueprint for how different parts of the application interact.
- **Models**: Data structures used in the application. Represent the shape of data, such as the attributes and relationships of objects (e.g., shapes, dimensions, and area properties).

## Project Structure

- `Controllers`: Contains the API controllers.
  - `CuadradoController.cs`
  - `CalculadoraController.cs`
  - `AlbumController.cs`
- `Services`: Contains the service interfaces and implementations.
  - `CuadradoService.cs`
  - `CuadradoService.cs`
  - `AlbumService.cs`
- `Interfaces`: Contains the service interfaces and implementations.
  - `ICuadradService.cs`
  - `ICalculadoraService.cs`
  - `IAlbumService.cs`
- `Models`: Contains the data models (not retrieved but assumed).

## Usage

### Endpoints

- `GET /api/tesla/GetAlbum`: Returns all albums.
- `POST /api/calculadora/sumar`: Receives a JSON with two numbers and returns the sum of both.
- `POST /api/cuadrado/getArea`: Receives a square side and returns its area.

### Example Requests

#### Calculate Area of a Square

```bash
POST /api/cuadrado/Area
Content-Type: application/json

{
  "Lado": 5
}
