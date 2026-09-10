-- 1. Seleciona todas as colunas através do * da tabela Vendas
SELECT * FROM Vendas;
GO
-- 2. Seleciona todas as colunas e trás dados somente com fat. maior que 100
SELECT * FROM Vendas WHERE Faturamento > 100;
GO
-- 3. Seleciona apenas as colunas Tipo e Lucro da tabela Vendas e traz todos os dados que contém a palavra escrita entre '%Palavra%'
SELECT Tipo, Lucro FROM Vendas WHERE Tipo Like 'Camisa';
GO