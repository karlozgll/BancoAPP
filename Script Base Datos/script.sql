USE [master]
GO
/****** Object:  Database [Banco]    Script Date: 10/12/2019 21:31:36 ******/
CREATE DATABASE Banco
USE [Banco]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [char](8) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[ApPaterno] [varchar](20) NULL,
	[ApMaterno] [varchar](20) NULL,
	[Celular] [char](9) NULL,
	[Direccion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuentaBancaria]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaBancaria](
	[IdCtaBancaria] [char](5) NOT NULL,
	[NumCuenta] [varchar](20) NULL,
	[IdTipoCuenta] [char](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCtaBancaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimiento]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimiento](
	[IdMovimiento] [char](8) NOT NULL,
	[IdCtaBancaria] [char](5) NULL,
	[IdOperacion] [char](4) NULL,
	[FechaTransaccion] [date] NULL,
	[CuentaDestino] [varchar](20) NULL,
	[Monto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarjeta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarjeta](
	[NumTarjeta] [char](16) NOT NULL,
	[IdCliente] [char](8) NULL,
	[IdCtaBancaria] [char](5) NULL,
	[IdTipoTarj] [char](4) NULL,
	[FechaAfiliacion] [date] NULL,
	[FechaCaducidad] [date] NULL,
	[Saldo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NumTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCuenta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCuenta](
	[IdTipoCuenta] [char](4) NOT NULL,
	[Descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoOperacion]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoOperacion](
	[IdOperacion] [char](4) NOT NULL,
	[Descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTarjeta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTarjeta](
	[IdTipoTarj] [char](4) NOT NULL,
	[Descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoTarj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[codigo] [nchar](5) NULL,
	[nombre] [nvarchar](100) NULL,
	[apellidop] [nvarchar](100) NULL,
	[apellidom] [nvarchar](100) NULL,
	[usuario] [nvarchar](50) NULL,
	[pass] [nvarchar](100) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CuentaBancaria]  WITH CHECK ADD  CONSTRAINT [fk_TipoCuenta] FOREIGN KEY([IdTipoCuenta])
REFERENCES [dbo].[TipoCuenta] ([IdTipoCuenta])
GO
ALTER TABLE [dbo].[CuentaBancaria] CHECK CONSTRAINT [fk_TipoCuenta]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [fk_CuentaT] FOREIGN KEY([IdCtaBancaria])
REFERENCES [dbo].[CuentaBancaria] ([IdCtaBancaria])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [fk_CuentaT]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [fk_OperacionT] FOREIGN KEY([IdOperacion])
REFERENCES [dbo].[TipoOperacion] ([IdOperacion])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [fk_OperacionT]
GO
ALTER TABLE [dbo].[Tarjeta]  WITH CHECK ADD  CONSTRAINT [fk_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Tarjeta] CHECK CONSTRAINT [fk_Cliente]
GO
ALTER TABLE [dbo].[Tarjeta]  WITH CHECK ADD  CONSTRAINT [fk_Cuenta] FOREIGN KEY([IdCtaBancaria])
REFERENCES [dbo].[CuentaBancaria] ([IdCtaBancaria])
GO
ALTER TABLE [dbo].[Tarjeta] CHECK CONSTRAINT [fk_Cuenta]
GO
ALTER TABLE [dbo].[Tarjeta]  WITH CHECK ADD  CONSTRAINT [fk_Tarjeta] FOREIGN KEY([IdTipoTarj])
REFERENCES [dbo].[TipoTarjeta] ([IdTipoTarj])
GO
ALTER TABLE [dbo].[Tarjeta] CHECK CONSTRAINT [fk_Tarjeta]
GO
/****** Object:  StoredProcedure [dbo].[pa_ListaClientes]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pa_ListaClientes]

AS

SELECT * FROM Cliente
 --ELSE
--	BEGIN
--		SET @MENSAJE ='NO'
--	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscaUsuario]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
CREATE PROCEDURE [dbo].[Sp_BuscaUsuario] 
@User varchar(30),
@contrasenna char(30)

AS
 IF EXISTS(SELECT * FROM usuarios where Usuario = @User  and pass = @contrasenna)
	BEGIN
		SELECT usuarios.* FROM usuarios where  usuarios.usuario = @User  and usuarios.pass = @contrasenna
	END
 --ELSE
--	BEGIN
--		SET @MENSAJE ='NO'
--	END
GO
/****** Object:  StoredProcedure [dbo].[sp_consultaCta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultaCta]
@DNI char(8)
AS
IF EXISTS (Select NumCuenta from CuentaBancaria where IdCtaBancaria = (Select IdCtaBancaria from Tarjeta where IdCliente = @DNI) )
BEGIN
(Select NumCuenta from CuentaBancaria where IdCtaBancaria = (Select IdCtaBancaria from Tarjeta where IdCliente = @DNI))
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarCliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_EliminarCliente] 
@id_cliente nchar(5)
AS
BEGIN
	
	SET NOCOUNT ON;

	
	DELETE FROM [dbo].Cliente
      WHERE [dbo].[Cliente].IdCliente=@id_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GuardarCliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_GuardarCliente] 
@id nchar(6),
@Nombre nvarchar(100),
@Apellidop nvarchar(100),
@Apellidom nvarchar(100),
@Celular nvarchar(100),
@Direccion nvarchar(100)
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO Cliente VALUES	(@id,@Nombre,@Apellidop,@Apellidom,@Celular,@Direccion)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarCliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_ModificarCliente]
@id nchar(6) ,
@Nombre nvarchar(100),
@Apellidop nvarchar(100),
@Apellidom nvarchar(100),
@Celular nvarchar(100),
@Direccion nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	UPDATE [dbo].Cliente
	   SET [IdCliente]=@id
		   ,[nombre] = @Nombre
		  ,[ApPaterno] = @Apellidop
		  ,[ApMaterno] = @Apellidom
		  ,[Celular] = @Celular
		  ,[Direccion] =@Direccion
	 WHERE [IdCliente]=@id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_reportes]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_reportes]
@DNI char (8) 
AS 
IF EXISTS (SELECT IdCtaBancaria, IdOperacion, FechaTransaccion, CuentaDestino, Monto FROM Movimiento Where IdCtaBancaria = ( SELECT IdCtaBancaria FROM Tarjeta WHERE IdCliente = @DNI))
BEGIN
(SELECT IdCtaBancaria, IdOperacion, FechaTransaccion, CuentaDestino, Monto FROM Movimiento Where IdCtaBancaria = ( SELECT IdCtaBancaria FROM Tarjeta WHERE IdCliente = @DNI))
END
GO
USE [master]
GO
ALTER DATABASE [Banco] SET  READ_WRITE 
GO
