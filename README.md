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
- `Services`: Contains the service interfaces and implementations.
  - `ICuadradoService.cs`
  - `CuadradoService.cs`
- `Models`: Contains the data models (not retrieved but assumed).

## Usage

### Endpoints

- `GET /api/tesla/GetAlbum`: Returns album details.
- `POST /api/tesla/ReciboValor`: Receives an album and returns its name.
- `POST /api/tesla/ReciboUnValor`: Receives a string value.
- `POST /api/cuadrado/Area`: Calculates the area of a square.

### Example Requests

#### Calculate Area of a Square

```bash
POST /api/cuadrado/Area
Content-Type: application/json

{
  "Lado": 5
}
