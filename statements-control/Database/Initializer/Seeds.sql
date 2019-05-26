

usp_InsertUser 'Thales', 'image1', '18/03/1999', 'Senha'
GO
usp_InsertUser 'Leonardo', 'image2', '10/12/1999', 'Senha'
GO
usp_InsertUser 'Barreto', 'image3', '01/01/1999', 'Senha'
GO

usp_InsertInvestment 1, 'Tesouro Direto', 2045.2, '01/01/2019', '17/08/2026'
GO
usp_InsertInvestment 2, 'CDB', 5300.12, '05/06/2019', '20/12/2023'
GO
usp_InsertInvestment 3, 'LCI', 2045.3, '20/01/2016', '01/01/2019'
GO

usp_InsertGoal 1, 'MacBook', 9324.57, '29/10/2020'
GO
usp_InsertGoal 2, 'Carro', 23000, '29/12/2025'
GO
usp_InsertGoal 3, 'Intercâmbio', 17000.32, '22/02/2021'
GO

usp_InsertEnvironment 'Trabalho', 'Essas compras são feitas no ambiente do trampo'
GO
usp_InsertEnvironment 'Faculdade', NULL
GO
usp_InsertEnvironment 'Viagens', NULL
GO

usp_InsertType 'Comida', NULL, 'Gasto'
GO
usp_InsertType 'Conta', NULL, 'Gasto'
GO
usp_InsertType 'Venda', 'Vendi meu carro uuhu', 'Lucro'
GO

usp_InsertStatement 1, 1, 1, 'Burguer King', 23.20, '27/05/2019'
GO
usp_InsertStatement 1, 1, 1, 'Ropinhas Legais', 203, '23/12/2019'
GO
usp_InsertStatement 1, 1, 1, 'Carneiro', 1200.50, '27/05/2019'
GO