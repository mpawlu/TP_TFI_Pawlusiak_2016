USE [VerdeUrbano]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[ID_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[URL] [nvarchar](300) NULL,
	[Accion] [bit] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID_Permiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leyenda]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leyenda](
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[Leyenda] [nvarchar](500) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Leyenda] PRIMARY KEY CLUSTERED 
(
	[ID_Leyenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'btnActualizarIdioma', N'Actualizar Idioma', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Ingresar', N'Ingresar', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Inicio', N'Inicio', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Institucional', N'Institucional', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'labelTest', N'TextoLeyenda', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Nuestros Productos', N'Nuestros Productos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Quienes Somos', N'Quienes Somos', N'asd')
/****** Object:  Table [dbo].[Idioma]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[ID_Idioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (1, N'Español', NULL)
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (3, N'Ingles', N'asd')
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (4, N'Portugues', N'asd')
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (5, N'Portugues2', N'asd')
INSERT [dbo].[Idioma] ([ID_Idioma], [Descripcion], [DVH]) VALUES (6, N'Portugues3', N'asd')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
/****** Object:  Table [dbo].[DVV]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DVV](
	[Nombre_Table] [nvarchar](50) NOT NULL,
	[DVV] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_DVV] PRIMARY KEY CLUSTERED 
(
	[Nombre_Table] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DVV] ([Nombre_Table], [DVV]) VALUES (N'Usuario', N'bwHST8PJy2Mk5LC54ph2T5yWFHk=')
/****** Object:  StoredProcedure [dbo].[s_ConsultarTabla]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_ConsultarTabla]
	-- Add the parameters for the stored procedure here
	@NombreTabla as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @sql NVARCHAR(MAX)

SET @sql = 'SELECT * FROM ' + @NombreTabla

EXEC sp_executesql @sql
END
GO
/****** Object:  StoredProcedure [dbo].[s_Leyenda_ListarTodas]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Leyenda_ListarTodas] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Leyenda
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idioma_ListarTodos]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Idioma_ListarTodos]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * 
	From Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idioma_Crear]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Idioma_Crear]
	-- Add the parameters for the stored procedure here
	@Descripcion nvarchar(50),
	@DVH nvarchar(500) 
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Idioma(Descripcion, DVH) values (@Descripcion, @DVH)
END
GO
/****** Object:  StoredProcedure [dbo].[s_Idioma_Consultar]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Idioma_Consultar]			
	-- Add the parameters for the stored procedure here
	@ID_Idioma int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	ID_Idioma,
	Descripcion
	From Idioma
	where ID_Idioma = @ID_Idioma
END
GO
/****** Object:  StoredProcedure [dbo].[s_DVV_Listar]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_DVV_Listar]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from DVV
END
GO
/****** Object:  StoredProcedure [dbo].[s_DVV_Alta]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_DVV_Alta]
	-- Add the parameters for the stored procedure here
	@Tabla as varchar(50),
	@DVV AS varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into dvv values(@Tabla, @DVV)
END
GO
/****** Object:  Table [dbo].[Permiso_Padre]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_Padre](
	[ID_PermisoPadre] [int] NOT NULL,
	[ID_Permiso] [int] NOT NULL,
 CONSTRAINT [PK_Permiso_Padre] PRIMARY KEY CLUSTERED 
(
	[ID_PermisoPadre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](100) NOT NULL,
	[Pass] [nvarchar](500) NOT NULL,
	[DNI] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[Perfil] [int] NOT NULL,
	[Bloqueado] [bit] NOT NULL,
	[FechaAlta] [date] NOT NULL,
	[Editable] [bit] NOT NULL,
	[Intentos] [int] NULL,
	[ID_Idioma] [int] NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Pass], [DNI], [Activo], [Perfil], [Bloqueado], [FechaAlta], [Editable], [Intentos], [ID_Idioma], [DVH]) VALUES (4, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 34713868, 0, 1, 0, CAST(0x493B0B00 AS Date), 0, 0, 1, N'H6wtKEM2lTA643Fw/l2Yta+aQN0=')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Traduccion]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[ID_Idioma] [int] NOT NULL,
	[Traduccion] [nvarchar](500) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[ID_Leyenda] ASC,
	[ID_Idioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnActualizarIdioma', 1, N'Actualizar Idioma', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnActualizarIdioma', 3, N'Update Language', N'dd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Ingresar', 1, N'Ingresar', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Ingresar', 3, N'Sign In', N'asdsd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Inicio', 1, N'Inicio', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Inicio', 3, N'Home', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Institucional ', 1, N'Institucional', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Institucional', 3, N'Our Company', N'sdf')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'labelTest', 1, N'Label Test en Españolo', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'labelTest', 3, N'Label Test en Ingles', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nuestros Productos', 1, N'Nuestros Productos', N'sad')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nuestros Productos', 3, N'Products', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Quienes Somos', 1, N'Quienes Somos', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Quienes Somos', 3, N'About Us', N'asds')
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarCompuestos]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_ListarCompuestos]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Permiso where Permiso.Accion = 0
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_Crear]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_Crear]
	-- Add the parameters for the stored procedure here
	@Descripcion as nvarchar(200),
	@URL as nvarchar(300),
	@Accion as bit
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Permiso(Descripcion,URL,Accion) values(@Descripcion,@URL,@Accion)
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_ConsultarPorID]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_ConsultarPorID]
	-- Add the parameters for the stored procedure here
	@ID_Permiso as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Permiso where Permiso.ID_Permiso = @ID_Permiso
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarHuerfanos]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_ListarHuerfanos]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from permiso where permiso.Accion = 0
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarHijos]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_ListarHijos]
	-- Add the parameters for the stored procedure here
	@ID_Permiso as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Permiso LEFT JOIN Permiso_Padre as b ON (b.ID_Permiso=Permiso.ID_Permiso) WHERE b.ID_PermisoPadre = @ID_Permiso  ORDER BY Permiso.ID_Permiso ASC
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_Baja]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_Baja]
	-- Add the parameters for the stored procedure here
	@ID_Permiso as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Permiso_Padre where ID_PermisoPadre = @ID_Permiso or ID_Permiso = ID_Permiso
	
	
END
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Permiso where ID_Permiso = ID_Permiso
	
	
END
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[ID_Evento] [int] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[TipoOperacion] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[DescripcionEvento] [nvarchar](500) NOT NULL,
	[DVH] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[ID_Evento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Modificar]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Modificar]
	-- Add the parameters for the stored procedure here
	@ID_Usuario int,
	@Pass nvarchar(500),
	@DNI int,
	@Activo bit,
	@Perfil int,
	@Bloqueado bit,
	@Editable bit,
	@Intentos int,
	@ID_Idioma int,
	@DVH nvarchar(500)
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   UPDATE Usuario
   SET [Pass] = @Pass,
       [DNI] = @DNI,
       [Activo]= @Activo,
       [Perfil]= @Perfil,
       [Bloqueado]= @Bloqueado,
       [Editable]= @Editable,
       [Intentos] = @Intentos,
       [ID_Idioma]= @ID_Idioma,
       [DVH]= @DVH

        WHERE ID_Usuario=@ID_Usuario
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_ListarTodos]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_ListarTodos]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		Usuario.ID_Idioma,
		Idioma.Descripcion

	FROM	Usuario, Idioma

	
	WHERE	Idioma.ID_Idioma = Usuario.ID_Idioma 
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Crear]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Crear]
	-- Add the parameters for the stored procedure here
	@NombreUsuario nvarchar(100),
	@Pass nvarchar(500),
	@DNI int,
	@Activo bit,
	@Perfil int,
	@Bloqueado bit,
	@FechaAlta date,
	@Editable bit,
	@Intentos int,
	@ID_Idioma int,
	@DVH nvarchar(500)
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Usuario
	(NombreUsuario, Pass, DNI, Activo, Perfil, Bloqueado, FechaAlta, Editable, Intentos, ID_Idioma, DVH)
     VALUES
    (@NombreUsuario, @Pass, @DNI, @Activo, @Perfil, @Bloqueado, @FechaAlta, @Editable, @Intentos, @ID_Idioma, @DVH)
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar_PorNombre]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Consultar_PorNombre]
	-- Add the parameters for the stored procedure here
	@NombreUsuario varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		ID_Idioma
		
	from Usuario
	where usuario.NombreUsuario = @NombreUsuario 
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Consultar]
	-- Add the parameters for the stored procedure here
	@ID_Usuario int
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		Usuario.ID_Idioma,
		Idioma.Descripcion

	FROM	Usuario, Idioma

	
	WHERE	Usuario.ID_USUARIO = @ID_Usuario and Idioma.ID_Idioma = Usuario.ID_Idioma 
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_ChequearUsuario]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_ChequearUsuario]
	-- Add the parameters for the stored procedure here
	@NombreUsuario varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	ID_Usuario,
		NombreUsuario,
		Pass,
		DNI,
		Activo,
		Perfil,
		Bloqueado,
		FechaAlta,
		Editable,
		Intentos,
		Usuario.ID_Idioma
		
	from Usuario
	where usuario.NombreUsuario = @NombreUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Baja]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Usuario_Baja]
	-- Add the parameters for the stored procedure here
	@ID_Usuario int,
	@Activo bit
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   UPDATE Usuario
   SET 
       [Activo]= @Activo

        WHERE ID_Usuario=@ID_Usuario
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Traduccion_ListarPorIdioma]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Traduccion_ListarPorIdioma]
	-- Add the parameters for the stored procedure here

	@ID_Idioma int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	    select
    Traduccion.ID_Idioma,
    Idioma.Descripcion,
	Traduccion.ID_Leyenda,
	Leyenda.Leyenda,
	Traduccion.Traduccion
	
	FROM Traduccion, Idioma, Leyenda
	
	where Traduccion.ID_Idioma = Idioma.ID_Idioma and traduccion.ID_Leyenda = Leyenda.ID_Leyenda
	and Traduccion.ID_Idioma = @ID_Idioma and Traduccion.ID_Idioma =  @ID_Idioma 
END
GO
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Crear]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Traduccion_Crear]			
	-- Add the parameters for the stored procedure here
	@ID_Idioma int,
	@ID_Leyenda int,
	@traduccion varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Traduccion(ID_Idioma, ID_Leyenda, Traduccion) values (@ID_Idioma, @ID_Leyenda, @Traduccion)
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Consultar]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Traduccion_Consultar]
	-- Add the parameters for the stored procedure here

@ID_Idioma int,
@ID_Leyenda nvarchar
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select
    Traduccion.ID_Idioma,
    Idioma.Descripcion,
	Traduccion.ID_Leyenda,
	Leyenda.Leyenda,
	Traduccion.Traduccion
	
	FROM Traduccion, Idioma, Leyenda
	
	where Traduccion.ID_Idioma = Idioma.ID_Idioma and traduccion.ID_Leyenda = Leyenda.ID_Leyenda
	and Traduccion.ID_Idioma = @ID_Idioma and Traduccion.ID_Leyenda like + '%' +  @ID_Leyenda + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_Padre_Crear]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_Padre_Crear]
	-- Add the parameters for the stored procedure here
	@ID_PermisoPadre as int,
	@ID_Permiso as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Permiso_Padre(ID_PermisoPadre, ID_Permiso) values(@ID_PermisoPadre,@ID_Permiso)
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_Padre_Baja]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Permiso_Padre_Baja]
	-- Add the parameters for the stored procedure here
	@ID_Permiso as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Permiso_Padre where ID_PermisoPadre = @ID_Permiso
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioOperacion]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarUsuarioOperacion]
	-- Add the parameters for the stored procedure here
	@ID_Usuario as int,
	@Operacion as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario and Bitacora.TipoOperacion= @Operacion
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioFechaOperacion]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarUsuarioFechaOperacion]
	-- Add the parameters for the stored procedure here
	@ID_Usuario as int,
	@Fecha as date,
	@Operacion as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario and DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha) and Bitacora.TipoOperacion = @Operacion
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioFecha]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarUsuarioFecha]
	-- Add the parameters for the stored procedure here
	@ID_Usuario as int,
	@Fecha as date
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario and DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha)
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuario]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarUsuario]
	-- Add the parameters for the stored procedure here
	@ID_Usuario as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarTodos]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarTodos] 
	-- Add the parameters for the stored procedure here
	@Desde as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from bitacora where Bitacora.ID_Evento <=@Desde 
	order by ID_Evento desc
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarOperacion]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarOperacion]
	-- Add the parameters for the stored procedure here
	@Operacion as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Bitacora
	where Bitacora.TipoOperacion = @Operacion
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarFechaOperacion]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarFechaOperacion]
	-- Add the parameters for the stored procedure here
	@Fecha as date,
	@Operacion as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Bitacora
	where DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha) and Bitacora.TipoOperacion= @Operacion
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarFecha]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ListarFecha]
	-- Add the parameters for the stored procedure here
	@Fecha as date
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT * from Bitacora
	where DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha)
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_Crear]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_Crear] 
	-- Add the parameters for the stored procedure here
	@ID_Usuario as int,
	@TipoOperacion as int,
	@FechaHora as datetime,
	@Descripcion as nvarchar(500),
	@DVH as nvarchar(500)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into bitacora(ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento, DVH) values (@ID_Usuario, @TipoOperacion, @FechaHora, @Descripcion, @DVH)
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ConsultarUltimoID]    Script Date: 05/06/2016 15:34:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[s_Bitacora_ConsultarUltimoID]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select top 1 ID_Evento from Bitacora
END
GO
/****** Object:  ForeignKey [FK_Bitacora_Bitacora]    Script Date: 05/06/2016 15:34:04 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Bitacora] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Bitacora]
GO
/****** Object:  ForeignKey [FK_Permiso_Padre_Permiso]    Script Date: 05/06/2016 15:34:04 ******/
ALTER TABLE [dbo].[Permiso_Padre]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Padre_Permiso] FOREIGN KEY([ID_PermisoPadre])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Padre] CHECK CONSTRAINT [FK_Permiso_Padre_Permiso]
GO
/****** Object:  ForeignKey [FK_Permiso_Padre_Permiso1]    Script Date: 05/06/2016 15:34:04 ******/
ALTER TABLE [dbo].[Permiso_Padre]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Padre_Permiso1] FOREIGN KEY([ID_PermisoPadre])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Padre] CHECK CONSTRAINT [FK_Permiso_Padre_Permiso1]
GO
/****** Object:  ForeignKey [FK_Traduccion_Idioma]    Script Date: 05/06/2016 15:34:04 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
/****** Object:  ForeignKey [FK_Traduccion_Leyenda]    Script Date: 05/06/2016 15:34:04 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Leyenda] FOREIGN KEY([ID_Leyenda])
REFERENCES [dbo].[Leyenda] ([ID_Leyenda])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Leyenda]
GO
/****** Object:  ForeignKey [FK_Usuario_Idioma]    Script Date: 05/06/2016 15:34:04 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
