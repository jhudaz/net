# Tesla API

A simple API built with ASP.NET Core to demonstrate basic CRUD operations and service injection.

## Features

- **Controllers**: Handles HTTP requests and responses.
- **Services**: Business logic for calculating areas.
- **Models**: Data structures used in the application.

## Project Structure

- `Controllers`: Contains the API controllers.
  - `TeslaController.cs`
  - `CuadradoController.cs`
  - `CalculadoraController.cs`
  - `AlbumController.cs`
- `Services`: Contains the service interfaces and implementations.
  - `ICuadradoService.cs`
  - `CuadradoService.cs`
  - `ICalculadoraService.cs`
  - `CalculadoraService.cs`
  - `ICuadradService.cs`
  - `CuadradoService.cs`
- `Models`: Contains the data models (not retrieved but assumed).

## Usage

### Endpoints

- `GET /api/tesla/GetAlbum`: Returns all albums.
- `POST /api/tesla/ReciboValor`: Receives a JSON with two numbers and returns the sum of both.
- `POST /api/tesla/ReciboUnValor`: Receives a square side and returns its area.

### Example Requests

#### Calculate Area of a Square

```bash
POST /api/cuadrado/Area
Content-Type: application/json

{
  "Lado": 5
}
