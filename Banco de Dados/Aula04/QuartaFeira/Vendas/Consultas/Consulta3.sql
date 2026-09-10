-- 1. Seleciona todas as colunas atraves do * da tabela vendas
SELECT * FROM Vendas;
GO
-- 2 Seleciona todas as colunas e tras dados somente com fat. maior que 100
SELECT * FROM Vendas WHERE Faturamento > 100;
GO
-- 3. Seleciona apenas as colunas Tipo e Lucro da tabela vendas e traz todos os dados que contenham a palavra Camisa na coluna Tipo
SELECT Tipo, Lucro FROM Vendas WHERE Tipo LIKE 'Camisa';
GO