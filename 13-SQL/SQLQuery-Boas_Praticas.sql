CREATE TABLE PRODUTOS (

	 CODIGO			INT			NOT NULL
	,DESCRICAO		VARCHAR(50) NOT NULL
	,DATA_VALIDADE	DATETIME
	,EAN			VARCHAR(15)	NOT NULL
	,IND_INATIVO	INT			NOT NULL DEFAULT 0
)
;

ALTER TABLE PRODUTOS
	ADD CONSTRAINT PK_PRODUTOS
		PRIMARY KEY (CODIGO)
;

CREATE INDEX IDX_PRODUTOS_EAN
	ON PRODUTOS(EAN)
;

INSERT INTO PRODUTOS VALUES (1, 'Nome do Produto', GETDATE(), '1234567890', 0);

INSERT INTO PRODUTOS (CODIGO, DESCRICAO, EAN) VALUES (2, 'Nome do Produto 2', '1234567890');

SELECT * FROM PRODUTOS;

SELECT *
	FROM PRODUTOS
	WHERE CODIGO = 2;

SELECT *
	FROM PRODUTOS
	WHERE DESCRICAO LIKE '%PRODUTO%';

SELECT COUNT(*)
	FROM PRODUTOS;

SELECT COUNT(*) AS TOTAL
	FROM PRODUTOS;

DROP TABLE LOJA;

CREATE TABLE LOJAS (
	CODIGO			INT			NOT NULL
	,NOME			VARCHAR(50) NOT NULL
	,IND_INATIVO	INT			NOT NULL DEFAULT 0
	,CONSTRAINT LOJAS_PK PRIMARY KEY (CODIGO)
)
;

INSERT INTO LOJAS (CODIGO, NOME) VALUES (1000, 'Filial Nova Igua�u');
INSERT INTO LOJAS (CODIGO, NOME) VALUES (2000, 'Filial S�o Paulo');
INSERT INTO LOJAS (CODIGO, NOME) VALUES (3000, 'Filial Recife');

SELECT * FROM LOJAS;

SELECT		CODIGO
	,		NOME
	FROM	LOJAS
	WHERE	IND_INATIVO = 0;

CREATE TABLE ESTOQUE(
	CODIGO_PRODUTO	INT		NOT NULL
	,CODIGO_FILIAL	INT		NOT NULL
	,QUANTIDADE		DECIMAL NOT NULL DEFAULT 0
	,CONSTRAINT ESTOQUE_PK PRIMARY KEY (CODIGO_PRODUTO, CODIGO_FILIAL)
)
;

INSERT INTO ESTOQUE (CODIGO_PRODUTO, CODIGO_FILIAL, QUANTIDADE) VALUES (99, 10, 1);

SELECT * FROM ESTOQUE;

DELETE FROM ESTOQUE;

ALTER TABLE ESTOQUE
	ADD CONSTRAINT FK_ESTOQUE_PRODUTOS
		FOREIGN KEY (CODIGO_PRODUTO)
		REFERENCES PRODUTOS (CODIGO)
;

ALTER TABLE ESTOQUE
	ADD CONSTRAINT FK_ESTOQUE_LOJAS
		FOREIGN KEY (CODIGO_FILIAL)
		REFERENCES LOJAS (CODIGO)
;

INSERT INTO ESTOQUE (CODIGO_PRODUTO, CODIGO_FILIAL, QUANTIDADE) VALUES (1, 1000, 10);

SELECT * FROM ESTOQUE;

SELECT E.CODIGO_FILIAL
	   ,L.NOME
	   ,E.CODIGO_PRODUTO
	   ,P.DESCRICAO
	   ,E.QUANTIDADE
	FROM ESTOQUE E INNER JOIN LOJAS L
		ON E.CODIGO_FILIAL = L.CODIGO
			INNER JOIN PRODUTOS P
				ON E.CODIGO_PRODUTO = P.CODIGO
;


