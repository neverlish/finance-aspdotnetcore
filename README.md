# docs

- [요구사항](./docs/GOAL.md)
- [학습 및 구현 설명](./docs/DESCRIPTION.md)

# requirements

- [dotnet sdk](https://dotnet.microsoft.com/download/dotnet/5.0)

# install dependencies

- `$ dotnet restore`

# run

- `$ dotnet run`

## APIs

- 구간별 주가 확인
  - `https://localhost:5001/api/Stock?from=YYYYMMDD&to=YYYYMMDD`
    - ex) https://localhost:5001/api/Stock?from=20210902&to=20211001
