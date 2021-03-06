USE [VerdeUrbano]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 05/08/2016 10:56:27 ******/
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
SET IDENTITY_INSERT [dbo].[Permiso] ON
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (1, N'Administrador', NULL, 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (2, N'Visualizar Bitacora', N'~/visualizarBitacora.aspx', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (3, N'Administrar Usuarios', N'~/administrarUsuarios.aspx', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (5, N'Usuarios', NULL, 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (8, N'Agregar Usuario', N'~/administrarUsuarios.aspx', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (9, N'Diseñador', NULL, 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (10, N'Solicitudes', NULL, 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (11, N'Nueva', N'~/nuevaSolicitudCurso.aspx', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (12, N'En curso', N'~/solicitudesEnCurso.aspx', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (13, N'Finalizadas', N'~/solicitudesFinalizadas.aspx', 1)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (14, N'Cursos', NULL, 0)
INSERT [dbo].[Permiso] ([ID_Permiso], [Descripcion], [URL], [Accion]) VALUES (15, N'Consultar', N'~/consultarCursos.aspx', 1)
SET IDENTITY_INSERT [dbo].[Permiso] OFF
/****** Object:  Table [dbo].[Leyenda]    Script Date: 05/08/2016 10:56:27 ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 05/08/2016 10:56:27 ******/
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
/****** Object:  Table [dbo].[DVV]    Script Date: 05/08/2016 10:56:27 ******/
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
/****** Object:  StoredProcedure [dbo].[s_ConsultarTabla]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Leyenda_ListarTodas]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Idioma_ListarTodos]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Idioma_Crear]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Idioma_Consultar]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_DVV_Listar]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_DVV_Alta]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  Table [dbo].[Permiso_Padre]    Script Date: 05/08/2016 10:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_Padre](
	[ID_PermisoPadre] [int] NOT NULL,
	[ID_Permiso] [int] NOT NULL,
 CONSTRAINT [PK_Permiso_Padre] PRIMARY KEY CLUSTERED 
(
	[ID_PermisoPadre] ASC,
	[ID_Permiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (1, 2)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (1, 5)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (5, 3)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (5, 8)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (9, 10)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (9, 14)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (10, 11)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (10, 12)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (10, 13)
INSERT [dbo].[Permiso_Padre] ([ID_PermisoPadre], [ID_Permiso]) VALUES (14, 15)
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/08/2016 10:56:27 ******/
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
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Pass], [DNI], [Activo], [Perfil], [Bloqueado], [FechaAlta], [Editable], [Intentos], [ID_Idioma], [DVH]) VALUES (6, N'diseñador1', N'18A8D20BD7E5E9CEA24049D3D9CF5C1B', 32345432, 0, 9, 0, CAST(0x5A3B0B00 AS Date), 0, 0, 1, N'o7tlrUYhlL6fXNsr/UNys2rD6A8=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Pass], [DNI], [Activo], [Perfil], [Bloqueado], [FechaAlta], [Editable], [Intentos], [ID_Idioma], [DVH]) VALUES (7, N'test', N'098F6BCD4621D373CADE4E832627B4F6', 23432543, 0, 1, 0, CAST(0x5A3B0B00 AS Date), 0, 0, 1, N'PEq7/9WUzvW4DRLyq1LPZOBCMec=')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Traduccion]    Script Date: 05/08/2016 10:56:27 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarCompuestos]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Crear]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_ConsultarPorID]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Baja]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 05/08/2016 10:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[ID_Evento] [int] IDENTITY(1,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[Bitacora] ON
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (1, 4, 4, CAST(0x0000A5FF00999E57 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'Xd5RkpRAKwMEtqjGcru86X2qHDc=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (2, 4, 4, CAST(0x0000A5FF0099DE55 AS DateTime), N'El usuario admin ingreso mal la contraseña.', N'j9sa+6AeXSpuobt4mISmKRjlhO4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (3, 4, 4, CAST(0x0000A5FF0099E2D0 AS DateTime), N'El usuario admin ingreso mal la contraseña.', N'wuvkqXLEEavHcjIGGn26KveV1YQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (4, 4, 4, CAST(0x0000A5FF0099E6BF AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'FBmrn43EuMcVoByVZ4IABffZb44=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (5, 4, 4, CAST(0x0000A5FF009A4069 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'ycme1Ttt9R0xPxz3+W3A1mXRn00=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (6, 4, 4, CAST(0x0000A5FF009A9127 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'DOGUxr3D7x7hxpxD/Wir/OanIUU=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (7, 4, 4, CAST(0x0000A5FF009D7914 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'JbKnJGPJxh4Lqae6+WuwmbHvXFk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (8, 4, 4, CAST(0x0000A5FF009F04D4 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'xjzLnKcSAWGDLCi6EH9gWBZLKSw=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (9, 4, 4, CAST(0x0000A5FF009F2680 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'iBsb/rL7LZ873yzieHqztc+AyOk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (10, 4, 4, CAST(0x0000A5FF009F3769 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'UiBo/o31SFP/SyYn3Jxw3WG3kQ4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (11, 4, 4, CAST(0x0000A5FF00A02D49 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'VVT+98BJADKAF1n1yjAfqaXVfws=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (12, 4, 4, CAST(0x0000A5FF00A1C56F AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'4jU72P3FQ87HBnP1tgcQXd/Kgy4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (13, 4, 4, CAST(0x0000A5FF00A1DA40 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'QPv3wP1EU6Alq2TilORTK1Jtwqk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (14, 4, 4, CAST(0x0000A5FF00A1E2D1 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'XlX+0teegITCQ9FfPEeiWYNC6jA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (15, 4, 4, CAST(0x0000A5FF00A2B8EF AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'Vx9qyRmo4CAQ3efD7t7cBLssRwM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (16, 4, 4, CAST(0x0000A5FF00A2C93C AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'jf2agwmN+ceORMY2aqu3Y9sLcOA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (17, 4, 4, CAST(0x0000A5FF00A72B0F AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'7+cJzdupvybdfhd+44FqOAEz2l4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (18, 4, 4, CAST(0x0000A5FF00A78908 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'ghqt4/hDJrE4VhXYDsTKm7tHmRA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (19, 4, 4, CAST(0x0000A5FF00AAE2FD AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'CzJKmYAcLYjRpMfsdiIGcjfcFk4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (20, 4, 4, CAST(0x0000A5FF00B2A615 AS DateTime), N'El usuario admin ingreso mal la contraseña.', N'arlQk+ITaCOrWsRTM3/rtPf096U=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (21, 4, 4, CAST(0x0000A5FF00B2AC2F AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'rWmys2k3vX1+MBs8YkvNgga48f8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (22, 4, 4, CAST(0x0000A5FF00B43919 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'+dS/4HNyQFLxG37FdlyfkyHNmcs=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (23, 4, 4, CAST(0x0000A5FF00B58A65 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'iwVt2GAAaf1Ck32LQxt6Z8UBgEM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (24, 4, 4, CAST(0x0000A5FF00B64C23 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'EOZG3d+pURXmvqXFhMbJVhncaEc=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (25, 4, 4, CAST(0x0000A5FF00B9D0EF AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'tvuQiRuZd1nzJgUiIPxdexO2HTQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (26, 4, 4, CAST(0x0000A5FF013C14EC AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'+6gBXtw8nWSXWLFqdV0GHMSqeMI=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (27, 4, 4, CAST(0x0000A5FF01456D4A AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'vsNlRwtWD5k7c/u3Yn2FnCTbx6U=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (28, 4, 4, CAST(0x0000A5FF014B792A AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'vljqvOX/VkxUUUX/w8JiPeg23O4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (31, 4, 4, CAST(0x0000A5FF014E2E4A AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'Ag2hQYDca1Qu/8/6FnCU4aSUf98=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (32, 4, 4, CAST(0x0000A5FF014EE159 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'6fDpjRJ4nlJEdQ1KKkfeQ2mpsiI=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (33, 4, 4, CAST(0x0000A5FF01502CB2 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'E/abYo9ieQD6W99Wh8p/6Va4pqY=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (35, 4, 4, CAST(0x0000A5FF01517902 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'vRqj6KzlTW4nqn7qa1Q7rkUyD5w=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (36, 4, 1, CAST(0x0000A5FF01519500 AS DateTime), N'Se genero correctamente el usuario test3', N'Xtk9aELE4V0ZIpASyrdexWjiPOg=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (37, 6, 3, CAST(0x0000A63900999E57 AS DateTime), N'Prueba', N'asdsad')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (38, 6, 3, CAST(0x0000A63800999E57 AS DateTime), N'Prueba', N'asdsad')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (39, 6, 2, CAST(0x0000A65700999E57 AS DateTime), N'Prueba', N'asdsad')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (41, 7, 2, CAST(0x0000A66600999E57 AS DateTime), N'Prueba', N'asdsad')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (42, 7, 6, CAST(0x0000A65F00999E57 AS DateTime), N'Prueba', N'asdsad')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (43, 4, 4, CAST(0x0000A5FF0153D49B AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'k0YZ+cGr7dpASsUtv2p1aw+L3Yc=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (44, 4, 4, CAST(0x0000A5FF0154FC04 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'Iff8M26iVlBvXg1WsXulxHIaXfA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (45, 4, 4, CAST(0x0000A5FF01561A28 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'FJh4CUz8PCkOwAQTDpCtm2ReeUs=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (46, 4, 4, CAST(0x0000A5FF01576AE6 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'Xexc95AR0hUUaE3au7PNNAg5T6E=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (47, 4, 4, CAST(0x0000A5FF015CA19D AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'uYXZxod3/uZ/TtQ+SxF6AcOztuY=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (48, 4, 4, CAST(0x0000A5FF015E38CA AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'Pb9dDSjoKH/4/ghgh+53zVEtIOI=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (49, 4, 4, CAST(0x0000A5FF015F9D60 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'gf7BiT1vWX9V7Kuja4CUU1IUGe0=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (50, 6, 4, CAST(0x0000A600009AE6BD AS DateTime), N'El usuario Diesñador1 intento loguearse pero se encuentra bloqueado.', N'OsbaWVN4gvi7UuixWhuVmkY0sNA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (51, 6, 4, CAST(0x0000A600009B35AD AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'd6aKIfP+vKKO5wSFsXMJddG9BA4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (52, 6, 4, CAST(0x0000A600009BDE38 AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'hhfKSkFIccfsnW2Xgit/3ecUYOQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (53, 6, 4, CAST(0x0000A600009CEFFF AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'8dBk8Ori7ZPpInNIlvnmmlZx/SA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (54, 6, 4, CAST(0x0000A600009D9B8C AS DateTime), N'El usuario Diesñador1 ingreso mal la contraseña.', N'0vtPDXJaQXbe7WUfhCfymZ0U7bk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (55, 6, 4, CAST(0x0000A600009DA739 AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'MYORg1oRzaw0DlJtfmu06AWB5oo=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (56, 6, 4, CAST(0x0000A600009DD476 AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'7h1j4rfjXHKUB+B7Zkb/PAK73Xk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (57, 6, 4, CAST(0x0000A600009EAC63 AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'uLSeyBqcN5zQlKPMkXoUnhl76uU=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (58, 6, 4, CAST(0x0000A600009ED8CA AS DateTime), N'El usuario Diesñador1 ingreso mal la contraseña.', N'k5L+zb3GHmsZYjcSyw4jyoEpl+Q=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (59, 6, 4, CAST(0x0000A600009EE239 AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'WofK7k6sL8SCThGf/77bZH6/Ct8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (60, 6, 4, CAST(0x0000A600009F7446 AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'eSn6T/JXSqv41VYO53Rf4rSk6iI=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (61, 6, 4, CAST(0x0000A600009FCAC2 AS DateTime), N'El usuario Diesñador1 se logueo correctamente en el sistema.', N'cjsdZfxsxc7NnvW85/+438UbY6M=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (62, 4, 4, CAST(0x0000A60000A17C5E AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'a65eURJ4hoMv8yatwRObPHw2XyQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (63, 4, 4, CAST(0x0000A60000A32FB2 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'0XlPwb0VcHjW4eAkPLZqAdqjlZ8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (64, 6, 4, CAST(0x0000A60000A45DEB AS DateTime), N'El usuario diseñador1 se logueo correctamente en el sistema.', N'Tf6bDPI7DFTiWp8vOvmR1/7Fy8M=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (65, 4, 4, CAST(0x0000A60000A46FB2 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'vwopX4QVonRT+6TXtOSeB+G5GXQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (66, 4, 4, CAST(0x0000A60000A9D37F AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'kI1DoArgL8s5SnzROjfnNFWenzk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (67, 4, 4, CAST(0x0000A60000AA5692 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'/8lc3yyk0PZEn1yDIIfsG59hpz8=')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
/****** Object:  StoredProcedure [dbo].[s_Usuario_Modificar]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Usuario_ListarTodos]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Usuario_Crear]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar_PorNombre]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Usuario_ChequearUsuario]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Usuario_Baja]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Traduccion_ListarPorIdioma]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Crear]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Consultar]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Padre_Crear]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Padre_Baja]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarHuerfanos]    Script Date: 05/08/2016 10:56:22 ******/
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
	select * from Permiso
	where not exists (select * from Permiso_Padre where Permiso.ID_Permiso = Permiso_Padre.ID_Permiso)
END
GO
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarHijos]    Script Date: 05/08/2016 10:56:22 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioOperacion]    Script Date: 05/08/2016 10:56:21 ******/
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
	@Operacion as int,
	@Desde as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario and Bitacora.TipoOperacion= @Operacion
	and ID_Evento <= @Desde
	order by ID_Evento desc
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioFechaOperacion]    Script Date: 05/08/2016 10:56:21 ******/
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
	@Operacion as int,
	@Desde as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario and DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha) and Bitacora.TipoOperacion = @Operacion
	and ID_Evento <= @Desde
	order by ID_Evento
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioFecha]    Script Date: 05/08/2016 10:56:21 ******/
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
	@Fecha as date,
	@Desde as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario and DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha)
	and ID_Evento <= @Desde
	order by ID_Evento desc
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuario]    Script Date: 05/08/2016 10:56:21 ******/
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
	@ID_Usuario as int,
	@Desde as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from Bitacora
	where Bitacora.ID_Usuario = @ID_Usuario and ID_Evento <= @Desde
	order by ID_Evento desc
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarTodos]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarOperacion]    Script Date: 05/08/2016 10:56:21 ******/
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
	@Operacion as int,
	@Desde as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from Bitacora
	where Bitacora.TipoOperacion = @Operacion and Bitacora.ID_Evento <= @Desde
	order by ID_Evento desc
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarFechaOperacion]    Script Date: 05/08/2016 10:56:21 ******/
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
	@Operacion as int,
	@Desde as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from Bitacora
	where DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha) and Bitacora.TipoOperacion= @Operacion
	and ID_Evento <= @Desde
	order by ID_Evento desc
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarFecha]    Script Date: 05/08/2016 10:56:21 ******/
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
	@Fecha as date,
	@Desde as int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT top 10 ID_Evento, ID_Usuario, TipoOperacion, FechaHora, DescripcionEvento from Bitacora
	where DATEPART(dayofyear, Bitacora.FechaHora) = DATEPART(dayofyear, @Fecha) and ID_Evento <= @Desde
	ORDER BY ID_Evento DESC
END
GO
/****** Object:  StoredProcedure [dbo].[s_Bitacora_Crear]    Script Date: 05/08/2016 10:56:21 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ConsultarUltimoID]    Script Date: 05/08/2016 10:56:21 ******/
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
	order by ID_Evento desc
END
GO
/****** Object:  ForeignKey [FK_Bitacora_Bitacora]    Script Date: 05/08/2016 10:56:27 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Bitacora] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Bitacora]
GO
/****** Object:  ForeignKey [FK_Permiso_Padre_Permiso]    Script Date: 05/08/2016 10:56:27 ******/
ALTER TABLE [dbo].[Permiso_Padre]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Padre_Permiso] FOREIGN KEY([ID_PermisoPadre])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Padre] CHECK CONSTRAINT [FK_Permiso_Padre_Permiso]
GO
/****** Object:  ForeignKey [FK_Permiso_Padre_Permiso1]    Script Date: 05/08/2016 10:56:27 ******/
ALTER TABLE [dbo].[Permiso_Padre]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Padre_Permiso1] FOREIGN KEY([ID_PermisoPadre])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Padre] CHECK CONSTRAINT [FK_Permiso_Padre_Permiso1]
GO
/****** Object:  ForeignKey [FK_Traduccion_Idioma]    Script Date: 05/08/2016 10:56:27 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
/****** Object:  ForeignKey [FK_Traduccion_Leyenda]    Script Date: 05/08/2016 10:56:27 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Leyenda] FOREIGN KEY([ID_Leyenda])
REFERENCES [dbo].[Leyenda] ([ID_Leyenda])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Leyenda]
GO
/****** Object:  ForeignKey [FK_Usuario_Idioma]    Script Date: 05/08/2016 10:56:27 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
