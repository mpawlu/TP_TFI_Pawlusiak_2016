USE [VerdeUrbano]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  Table [dbo].[Leyenda]    Script Date: 05/09/2016 10:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leyenda](
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[Leyenda] [nvarchar](max) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Leyenda] PRIMARY KEY CLUSTERED 
(
	[ID_Leyenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Administrar Usuarios', N'Administrar Usuarios', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Agregar Usuario', N'Agregar Usuario', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'btn_Agregar', N'Agregar', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'btn_buscar', N'Buscar', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'btnActualizarIdioma', N'Actualizar Idioma', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'btnCancelar', N'Cancelar', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Consultar', N'Consultar', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Cursos', N'Cursos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Diseñador', N'Diseñador', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'En Curso', N'En Curso', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Finalizadas', N'Finalizadas', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Ingresar', N'Ingresar', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Inicio', N'Inicio', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Institucional', N'Institucional', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'labelTest', N'TextoLeyenda', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_AdministracionDeUsuarios', N'Administracion de usuarios', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_AgregarIdioma', N'Agregar Idioma', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_AgregarUsuario', N'Agregar Usuario', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Bienvenido', N'Bienvenido al Sitio Web de Verde Urbano', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_CambiarIdioma', N'Cambiar Idioma', N'asdf')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_ConfirmarPass', N'Confirmar contraseña', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_ConoceNuestrosProductos', N'Conoce nuestros productos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DescripcionEmpresa', N'Somos la emnpresa lider en instalación y mantenimiento de jardines verticales y terrazas verdes de Buenos Aires. Mas de 200 empresas ya nos han contratado y abalan la calidad de nuestros trabajos.', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DetalleJardin', N'Cultivar plantas en una superficie vertical ha sido posible gracias a estudios de locaciones verticales naturales (rocas, acantilados y troncos de árboles), lugares sin suelo y con abundancia de especies vegetales. Las técnicas imitan estas condiciones y se adaptan a cualquier geometría.', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DetalleMacetas', N'Puede utilizarse tanto en interiores como en exteriores. Fácil de implementar, impermeabilizada, ayuda a la respiración de las raíces, y mantiene regadas las plantas.', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DetalleMision', N'Detalle Mision', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DetalleQuienesSomos', N'Somos una empresa dedicada a la comercialización de jardines verticales y terrazas verdes. Nuestros productos le ayudaran a convertir sus paredes interiores y exteriores, en magníficos jardines verticales, y sus terrazas en agradables espacios verdes, mejorando las condiciones de habitabilidad y calidad de vida, además de contribuir con el medio ambiente. Nuestros productos personalizados se adaptan a diferentes tipos de diseños arquitectónicos, y superficies impensadas para ser habitados por plantas, transformándose en una solución a la falta de espacios verdes. La fácil implementación y mantenimiento es otra de las ventajas que ofrecen nuestros jardines. También contamos con una línea de productos que no requieren de nuestra intervención para ser instalados, simplemente siguiendo la guía instructiva podrán ser colocados. Esta capacitación será dada por cursos de E-Learing generados por nuestra propia compañía donde podrán aprender no solo sobre la instalación de alguno de nuestros productos, sino también sobre el mantenimiento de los jardines instalados por nuestra empresa. De esta forma, no solo nos desligaríamos de esta tarea, la cual ahorraremos tiempo y dinero, sino que también nuestros empleados podrán enfocarse en el diseño y creación de los jardines para ofrecer una mejor calidad de servicio.', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DetalleSobres', N'Diseñado para interiores, de material hidrófugo, fácil de implementar y mantener. No mancha ni humedece las paredes.', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DetalleTerraza', N'Una cubierta verde es un sistema de ingeniería que permite el crecimiento de vegetación en la parte superior de los edificios (ya sea en techos o azoteas) manteniendo protegida su estructura. En general, tienen un impacto neto positivo sobre el ambiente: capturan agua de lluvia, reduciendo inundaciones y niveles de contaminación; mejoran el aislamiento térmico de los edificios y enfrían el aire; representan un hábitat para especies nativas o migratorias; y ayudan a mejorar la calidad de vida.', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_DetalleVision', N'Detalle Vision', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Directorio', N'Directorio', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_dni', N'DNI', N'ads')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Fecha', N'Fecha', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Idioma', N'Idioma', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Mision', N'Mision', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Nombre', N'Nombre', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_NombreUsuario', N'Nombre de Usuario', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_password', N'Contraseña', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Perfil', N'Perfil', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_QuienesSomos', N'Quienes Somos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_RealizarBackup', N'Realizar Backup', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_RealizarRestore', N'Realizar Restore', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_TipoOperacion', N'Tipo de operacion', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_TitJardin', N'Jardin Vertical', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_TitMacetas', N'Macetas', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_TitSobres', N'Sobres', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_TitTerraza', N'Terraza Verde', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Usuario', N'Usuario', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_Vision', N'Vision', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'lbl_VisualizarBitacora', N'Visualizar Bitacora', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Nuestros Productos', N'Nuestros Productos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Nueva', N'Nueva', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Productos', N'Productos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Quienes Somos', N'Quienes Somos', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Solicitudes', N'Solicitudes', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Usuarios', N'Usuarios', N'asd')
INSERT [dbo].[Leyenda] ([ID_Leyenda], [Leyenda], [DVH]) VALUES (N'Visualizar Bitacora', N'Visualizar Bitacora', N'asd')
/****** Object:  Table [dbo].[Idioma]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  Table [dbo].[DVV]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_ConsultarTabla]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Leyenda_ListarTodas]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Idioma_ListarTodos]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Idioma_Crear]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Idioma_Consultar]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_DVV_Listar]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_DVV_Alta]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  Table [dbo].[Permiso_Padre]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/09/2016 10:45:32 ******/
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
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Pass], [DNI], [Activo], [Perfil], [Bloqueado], [FechaAlta], [Editable], [Intentos], [ID_Idioma], [DVH]) VALUES (4, N'admin', N'21232F297A57A5A743894A0E4A801FC3', 34713868, 1, 1, 0, CAST(0x493B0B00 AS Date), 0, 0, 3, N'NJYxLb3wcHS0DCR0KbIBZ8yYfcU=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Pass], [DNI], [Activo], [Perfil], [Bloqueado], [FechaAlta], [Editable], [Intentos], [ID_Idioma], [DVH]) VALUES (6, N'diseñador1', N'18A8D20BD7E5E9CEA24049D3D9CF5C1B', 32345432, 1, 9, 0, CAST(0x5A3B0B00 AS Date), 1, 0, 1, N'gfopBNjFFvJDSpN6QSXWdKSMeZ8=')
INSERT [dbo].[Usuario] ([ID_Usuario], [NombreUsuario], [Pass], [DNI], [Activo], [Perfil], [Bloqueado], [FechaAlta], [Editable], [Intentos], [ID_Idioma], [DVH]) VALUES (7, N'test', N'098F6BCD4621D373CADE4E832627B4F6', 23432543, 1, 1, 0, CAST(0x5A3B0B00 AS Date), 1, 0, 1, N'2xNIt74p/kNWshMstLtzssFLBy0=')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[Traduccion]    Script Date: 05/09/2016 10:45:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID_Leyenda] [nvarchar](200) NOT NULL,
	[ID_Idioma] [int] NOT NULL,
	[Traduccion] [nvarchar](max) NOT NULL,
	[DVH] [nvarchar](500) NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[ID_Leyenda] ASC,
	[ID_Idioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Administrar Usuarios', 1, N'Administrar Usuarios', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Administrar Usuarios', 3, N'Manage Users', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Agregar Usuario', 1, N'Agregar Usuario', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Agregar Usuario', 3, N'Add users', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btn_Agregar', 1, N'Agregar', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btn_Agregar', 3, N'Add', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btn_buscar', 1, N'Buscar', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btn_buscar', 3, N'Search', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnActualizarIdioma', 1, N'Actualizar Idioma', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnActualizarIdioma', 3, N'Update Language', N'dd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnCancelar', 1, N'Cancelar', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'btnCancelar', 3, N'Cancel', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Consultar', 1, N'Consultar', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Consultar', 3, N'See All', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Cursos', 1, N'Cursos', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Cursos', 3, N'Courses', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Diseñador', 1, N'Diseñador', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Diseñador', 3, N'Designer', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'En Curso', 1, N'En Curso', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'En Curso', 3, N'In Progerss', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Finalizadas', 1, N'Finalizadas', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Finalizadas', 3, N'Completed', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Ingresar', 1, N'Ingresar', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Ingresar', 3, N'Sign In', N'asdsd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Inicio', 1, N'Inicio', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Inicio', 3, N'Home', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Institucional ', 1, N'Institucional', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Institucional', 3, N'Our Company', N'sdf')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'labelTest', 1, N'Label Test en Españolo', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'labelTest', 3, N'Label Test en Ingles', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_AdministracionDeUsuarios', 1, N'Administracion de Usuarios', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_AdministracionDeUsuarios', 3, N'Users Manage', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_AgregarIdioma', 1, N'Agregar Idioma', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_AgregarIdioma', 3, N'Create New Language', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_AgregarUsuario', 1, N'Agregar Usuario', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_AgregarUsuario', 3, N'Add User', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Bienvenido', 1, N'Bienvenido al Sitio Web de Verde Urbano', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Bienvenido', 3, N'Welcome to Verde Urbano web site.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_CambiarIdioma', 1, N'Cambiar Idioma', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_CambiarIdioma', 3, N'Change Language', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_ConfirmarPass', 1, N'Confirmar contraseña', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_ConfirmarPass', 3, N'Confirm password', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_ConoceNuestrosProductos', 1, N'Conoce nuestros productos', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_ConoceNuestrosProductos', 3, N'See our products', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DescripcionEmpresa', 1, N'Somos la emnpresa lider en instalación y mantenimiento de jardines verticales y terrazas verdes de Buenos Aires. Mas de 200 empresas ya nos han contratado y abalan la calidad de nuestros trabajos.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DescripcionEmpresa', 3, N'We are the main company in charge of installation and maintenance of vertical gardens and green roof. More than 200 customers approved our work.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleJardin', 1, N'Cultivar plantas en una superficie vertical ha sido posible gracias a estudios de locaciones verticales naturales (rocas, acantilados y troncos de árboles), lugares sin suelo y con abundancia de especies vegetales. Las técnicas imitan estas condiciones y se adaptan a cualquier geometría.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleJardin', 3, N'Growing plants on a vertical surface has been made possible by studies of natural vertical locations (rocks, cliffs and tree trunks), places without soil and abundance of plant species. The techniques mimic these conditions and adapt to any geometry.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleMacetas', 1, N'Puede utilizarse tanto en interiores como en exteriores. Fácil de implementar, impermeabilizada, ayuda a la respiración de las raíces, y mantiene regadas las plantas.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleMacetas', 3, N'It can be used both indoors and outdoors. Easy to implement, waterproofed, it helps root respiration and keeps plants watered.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleMision', 1, N'Contribuir al desarrollo urbanístico sustentable, a través de la difusión, concientización y aplicación de tecnologías que disminuyan el impacto ambiental y que mejore la calidad de vida de la población, brindando un producto de alta calidad y duradero. Contribuir al bienestar de los habitantes de la Ciudad autónoma de buenos aires y la zona norte del conurbano bonaerense.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleMision', 3, N'Contribute to sustainable urban development through dissemination, awareness and application of technologies that reduce environmental impact and improve the quality of life of the population, providing a high-quality and durable. Contribute to the welfare of the inhabitants of the autonomous city of Buenos Aires and the northern part of Buenos Aires province.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleQuienesSomos', 1, N'Somos una empresa dedicada a la comercialización de jardines verticales y terrazas verdes. Nuestros productos le ayudaran a convertir sus paredes interiores y exteriores, en magníficos jardines verticales, y sus terrazas en agradables espacios verdes, mejorando las condiciones de habitabilidad y calidad de vida, además de contribuir con el medio ambiente. Nuestros productos personalizados se adaptan a diferentes tipos de diseños arquitectónicos, y superficies impensadas para ser habitados por plantas, transformándose en una solución a la falta de espacios verdes. La fácil implementación y mantenimiento es otra de las ventajas que ofrecen nuestros jardines. También contamos con una línea de productos que no requieren de nuestra intervención para ser instalados, simplemente siguiendo la guía instructiva podrán ser colocados. Esta capacitación será dada por cursos de E-Learing generados por nuestra propia compañía donde podrán aprender no solo sobre la instalación de alguno de nuestros productos, sino también sobre el mantenimiento de los jardines instalados por nuestra empresa. De esta forma, no solo nos desligaríamos de esta tarea, la cual ahorraremos tiempo y dinero, sino que también nuestros empleados podrán enfocarse en el diseño y creación de los jardines para ofrecer una mejor calidad de servicio.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleQuienesSomos', 3, N'We are a company dedicated to the commercialization of vertical gardens and green terraces. Our products help you convert your interior and exterior walls, magnificent vertical gardens, terraces and pleasant green spaces, improving living conditions and quality of life, and contribute to the environment. Our customized products to suit different types of architectural designs, and unthought to be inhabited by plants, becoming a solution to the lack of green spaces surfaces. The easy implementation and maintenance is another advantage offered by our gardens. We also have a line of products that do not require our intervention to be installed by simply following the instructional guide may be placed. This training will be given by E-Learing courses generated by our own company where they can learn not only about the installation of any of our products, but also on maintaining the gardens installed by our company. Thus, not only desligaríamos us this task, which save time and money, but also our employees can focus on the design and creation of gardens to provide better quality of service.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleSobres', 1, N'Diseñado para interiores, de material hidrófugo, fácil de implementar y mantener. No mancha ni humedece las paredes.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleSobres', 3, N'Designed for indoor, water-repellent material, easy to implement and maintain. No stain or wets the walls.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleTerraza', 1, N'Una cubierta verde es un sistema de ingeniería que permite el crecimiento de vegetación en la parte superior de los edificios (ya sea en techos o azoteas) manteniendo protegida su estructura. En general, tienen un impacto neto positivo sobre el ambiente: capturan agua de lluvia, reduciendo inundaciones y niveles de contaminación; mejoran el aislamiento térmico de los edificios y enfrían el aire; representan un hábitat para especies nativas o migratorias; y ayudan a mejorar la calidad de vida.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleTerraza', 3, N'A green roof is an engineering system that allows the growth of vegetation on top of buildings (either on ceilings or roofs) maintaining protected structure. They generally have a net positive impact on the environment: capture rainwater, reducing flooding and pollution levels; improve the thermal insulation of buildings and cool the air; They represent a habitat for native or migratory species; and help improve the quality of life.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleVision', 1, N'Ser empresa líder en Jardines verticales y terrazas verdes, brindando las mejores tecnologías del mercado para trasformar las principales ciudades del país en color verde, mejorando la calidad de vida de las personas.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_DetalleVision', 3, N'Being a leader in vertical gardens and green terraces, providing the best technologies on the market to transform the country''s major cities in green, improving the quality of life of people.', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Directorio', 1, N'Directorio', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Directorio', 3, N'Path', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_dni', 1, N'DNI', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_dni', 3, N'ID #', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Fecha', 1, N'Fecha', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Fecha', 3, N'Date', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Idioma', 1, N'Idioma', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Idioma', 3, N'Language', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Mision', 1, N'Misión', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Mision', 3, N'Mission', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Nombre', 1, N'Nombre', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Nombre', 3, N'Name', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_NombreUsuario', 1, N'Nombre de Usuario', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_NombreUsuario', 3, N'Username', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_password', 1, N'Contraseña', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_password', 3, N'Password', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Perfil', 1, N'Perfil', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Perfil', 3, N'Profile', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_QuienesSomos', 1, N'¿Quienes Somos?', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_QuienesSomos', 3, N'Who we are?', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_RealizarBackup', 1, N'Realizar Backup', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_RealizarBackup', 3, N'Backup Database', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_RealizarRestore', 1, N'Realizar Restore', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_RealizarRestore', 3, N'Restore Database', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TipoOperacion', 1, N'Tipo de operacion', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TipoOperacion', 3, N'Operation type', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitJardin', 1, N'Jardin Vertical', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitJardin', 3, N'Vertical Garden', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitMacetas', 1, N'Macetas', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitMacetas', 3, N'Wall Planter', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitSobres', 1, N'Sobres', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitSobres', 3, N'Pockets', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitTerraza', 1, N'Terrazas Verdes', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_TitTerraza', 3, N'Green Roof', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Usuario', 1, N'Usuario', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Usuario', 3, N'User', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Vision', 1, N'Visión', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_Vision', 3, N'Vision', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_VisualizarBitacora', 1, N'Visualizar Bitacora', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'lbl_VisualizarBitacora', 3, N'System Log', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nuestros Productos', 1, N'Nuestros Productos', N'sad')
GO
print 'Processed 100 total records'
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nuestros Productos', 3, N'Products', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nueva', 1, N'Nueva', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Nueva', 3, N'New', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Productos', 1, N'Productos', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Productos', 3, N'Products', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Quienes Somos', 1, N'Quienes Somos', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Quienes Somos', 3, N'About Us', N'asds')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Solicitudes', 1, N'Solicitudes', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Solicitudes', 3, N'Requests', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Usuarios', 1, N'Usuarios', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Usuarios', 3, N'Users', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Visualizar Bitacora', 1, N'Visualizar Bitacora', N'asd')
INSERT [dbo].[Traduccion] ([ID_Leyenda], [ID_Idioma], [Traduccion], [DVH]) VALUES (N'Visualizar Bitacora', 3, N'System Log', N'asd')
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarCompuestos]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Crear]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_ConsultarPorID]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Baja]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 05/09/2016 10:45:32 ******/
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
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (68, 4, 4, CAST(0x0000A600013253A5 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'wmCjN3a/RpHEskovKwuarkDk3uA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (69, 6, 4, CAST(0x0000A60001329F8B AS DateTime), N'El usuario diseñador1 ingreso mal la contraseña.', N'RPEqQ+dR1JVFDsRP59gwpwj5v+0=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (70, 6, 4, CAST(0x0000A6000132A580 AS DateTime), N'El usuario diseñador1 se logueo correctamente en el sistema.', N'ReiKEI9WOWEtXQ2T/mDeennonio=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (71, 4, 4, CAST(0x0000A6000132E0F1 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'aHrRQEfciN+adzLfJ7hLT/4OLPU=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (72, 7, 4, CAST(0x0000A6000135AB71 AS DateTime), N'Se ha bloqueado al usuario test', N'4mFSo6qluVOJpCG24CN468x5LaY=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (73, 4, 4, CAST(0x0000A6000137EC11 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'bZRqfbMAZhFnb7Jay5LZwdP9rmE=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (74, 4, 4, CAST(0x0000A6000139D93B AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'hBo2YbPn0R/sKXA5dnNuTRPYirs=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (75, 6, 4, CAST(0x0000A6000139E2B8 AS DateTime), N'Se ha bloqueado al usuario diseñador1', N'bDOBKiyKUG282fkweTSDY/mzJi8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (76, 6, 4, CAST(0x0000A6000139EB6B AS DateTime), N'Se ha desbloqueado al usuario diseñador1', N'StHdYf1BKM+3BFG/9MebxBKG6V0=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (77, 7, 4, CAST(0x0000A6000139F407 AS DateTime), N'Se ha bloqueado al usuario test', N'Qir01aolt7FZKvzQDCwKEPMLcUk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (78, 7, 4, CAST(0x0000A6000139F84F AS DateTime), N'Se ha desbloqueado al usuario test', N'SvsfdibvkRm5/fnX1h+lRBlZY9Q=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (79, 4, 4, CAST(0x0000A600013AD2C2 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'3sSdJhHzPY/jwOKA+2krn/ICScI=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (80, 4, 4, CAST(0x0000A600013C2BDA AS DateTime), N'El usuario admin ingreso mal la contraseña.', N'Y2Pp4JqpYNJhWOnKLxxU5x3ZEHU=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (81, 4, 4, CAST(0x0000A600013C4009 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'4tYSqN7OQXmxHfhT/cs7QcgB67g=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (82, 4, 4, CAST(0x0000A600013CC29F AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'gYQLoL5/NWq4X8T1APaVli12Vvs=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (83, 6, 4, CAST(0x0000A600013CD449 AS DateTime), N'Se ha bloqueado al usuario diseñador1', N'/2JIXcxOg6+ZHrreHLcm9KmILpo=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (84, 7, 4, CAST(0x0000A600013CE191 AS DateTime), N'Se ha bloqueado al usuario test', N'3iWN2Ml7v9Y3B7ErXrgWNsyO8ZQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (85, 6, 4, CAST(0x0000A600013CE68E AS DateTime), N'Se ha desbloqueado al usuario diseñador1', N'EvSPItR64WC0VDijTTPl0JZR5/A=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (86, 7, 4, CAST(0x0000A600013CEBEB AS DateTime), N'Se ha desbloqueado al usuario test', N'oLu2xm6JPWgLfPdMP9j8gVaqWR8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (87, 6, 4, CAST(0x0000A600013CEF9E AS DateTime), N'Se ha bloqueado al usuario diseñador1', N'boXpEOUjWMFNEtk9xMfYO+G/TS4=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (88, 7, 4, CAST(0x0000A600013CF2CE AS DateTime), N'Se ha bloqueado al usuario test', N'18i62H31QVMTXI0OecElRA2bwkM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (89, 4, 4, CAST(0x0000A600013E09E7 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'r3ld+4tRsqkWIEUnXm86xpGMwhM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (90, 6, 4, CAST(0x0000A600013E1174 AS DateTime), N'Se ha desbloqueado al usuario diseñador1', N'VbcZBClSnYc1QKLN2MREaC+IQao=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (91, 7, 4, CAST(0x0000A600013E1786 AS DateTime), N'Se ha desbloqueado al usuario test', N'rD0VDUd7NXQTYww8p5yJgquBtuQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (92, 6, 4, CAST(0x0000A600013E1B41 AS DateTime), N'Se ha bloqueado al usuario diseñador1', N'J6+UAPj7H3hXoyzujhpOyHyHrGM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (93, 7, 4, CAST(0x0000A600013E1EDD AS DateTime), N'Se ha bloqueado al usuario test', N'6L1DB8TtecXuy7z5UpnCiPDYyXk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (94, 6, 4, CAST(0x0000A600013E22D2 AS DateTime), N'Se ha desbloqueado al usuario diseñador1', N'czSZp5sIL7GIjeJYV+k6nGXo93k=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (95, 4, 2, CAST(0x0000A600013E3265 AS DateTime), N'Ocurrio un error al intentar dar de baja un usuario', N'rms10cUh3yHTtnoDQU7lnCr1pr0=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (96, 4, 4, CAST(0x0000A600013F2B80 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'G8fLgrrMcPszsOBPOWONSZbYnVU=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (97, 6, 4, CAST(0x0000A600013F341A AS DateTime), N'Se ha bloqueado al usuario diseñador1', N'hkdduCDa+NfYobcB2zNTzHMLgwM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (98, 7, 4, CAST(0x0000A600013F3699 AS DateTime), N'Se ha desbloqueado al usuario test', N'OOnG4AeLOhtPTl7rcXcnx5uXKWw=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (99, 7, 4, CAST(0x0000A600013F456D AS DateTime), N'Se ha bloqueado al usuario test', N'QIC/H4zDGk1ChHyTMBnmZRY9GyY=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (100, 4, 2, CAST(0x0000A600013F72D2 AS DateTime), N'La baja del usuario testse realizó correctamente', N'G2iKWeYDmp/2Jiw0b6qQZH0OfJ8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (101, 4, 4, CAST(0x0000A6000140A11A AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'8RbQF/nxAM813acXmG9JhhPJFEE=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (102, 4, 2, CAST(0x0000A6000140B4BB AS DateTime), N'La baja del usuario diseñador1se realizó correctamente', N'R1Uftc/A8q3USpThGLzBjpEipE8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (103, 4, 4, CAST(0x0000A600015D6970 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'sBHEW8CDsGxxAD1YopOAvwz6Ea8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (104, 4, 4, CAST(0x0000A600015E2548 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'tixighAQYw4GAr1LbQ8DAR0ZtAg=')
GO
print 'Processed 100 total records'
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (105, 4, 3, CAST(0x0000A600015E5D56 AS DateTime), N'Se modifico correctamente el usuario admin', N'uEwtpjwHEGYiLL5XF6+Urbc4vqM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (106, 4, 4, CAST(0x0000A6000160DA19 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'tQXoKtkyZi2b7Z4gxkm4IB0oFRw=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (107, 4, 4, CAST(0x0000A6000161CA51 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'BLgV5reb9b2s92UEvpI6PFa/wUg=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (108, 4, 3, CAST(0x0000A6000161D713 AS DateTime), N'Se modifico correctamente el usuario admin', N'wo5IPD6wf1bNu7Lm12FOYMe9AsI=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (109, 4, 3, CAST(0x0000A6000161E1E1 AS DateTime), N'Se modifico correctamente el usuario admin', N'6DKqCR0ZR6esDe/C0UOy7EFpII0=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (110, 4, 3, CAST(0x0000A6000161E9D6 AS DateTime), N'Se modifico correctamente el usuario admin', N'0pIcyjpByGfK2UAmhiLG5hMub2M=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (111, 4, 4, CAST(0x0000A60001660F22 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'oQz+KLu70SFEJIwVTZu2shcZwv0=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (112, 4, 3, CAST(0x0000A600016624CF AS DateTime), N'Se modifico correctamente el usuario admin', N'znmJgVXMroQitsF36Bi3mh9a3aA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (113, 4, 4, CAST(0x0000A6000168FE00 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'9/KqVoS8I+gv7TrRuuo4X0gnXmM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (114, 4, 3, CAST(0x0000A60001691431 AS DateTime), N'Se modifico correctamente el usuario admin', N'l3Lo26zRRbZ4dTCsRM+gk6RVbsA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (115, 4, 4, CAST(0x0000A600016ADA64 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'gAY+EJbE07occK6FHesisjKI5Ek=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (116, 4, 4, CAST(0x0000A600016B1E5D AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'VH3l1hzO7NVLzy0W031fg5vFkDQ=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (117, 4, 4, CAST(0x0000A600016B5B55 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'ydaACQGo9mQCYTrjoWd7qZ8EiLU=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (118, 4, 4, CAST(0x0000A600016BAFDC AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'hJPZSwe4OOwtQbqHnQuQMIcCW4I=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (119, 4, 4, CAST(0x0000A600016CC7DD AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'uoZClUdkyoPvPA3UOuKlDlQsYS8=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (120, 6, 4, CAST(0x0000A600016D399F AS DateTime), N'El usuario diseñador1 intento loguearse pero se encuentra bloqueado.', N'744xOhVsJi0hsMgY+LZQfqLkYNw=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (121, 6, 4, CAST(0x0000A600016D67B7 AS DateTime), N'El usuario diseñador1 ingreso mal la contraseña.', N'AjVYw8dCinqBPX4wt9CshC1yD30=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (122, 6, 4, CAST(0x0000A600016D6E84 AS DateTime), N'El usuario diseñador1 se logueo correctamente en el sistema.', N'eMFcxu7kKebrweT9J+qrq1Tpkfk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (123, 4, 4, CAST(0x0000A6000176A2EB AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'fDaTNBG1jZYGez7UT43X0ZqjgxA=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (124, 4, 3, CAST(0x0000A6000176AEAD AS DateTime), N'Se modifico correctamente el usuario admin', N'IZB4SQFyBkHdA08aWHpHe7qNllU=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (125, 4, 3, CAST(0x0000A6000176BD64 AS DateTime), N'Se modifico correctamente el usuario admin', N'DE/0o860SU/HiOa5H+S0oJejsPM=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (126, 4, 4, CAST(0x0000A600017B4C33 AS DateTime), N'El usuario admin se logueo correctamente en el sistema.', N'j7hqQl1gpgnEikk1T00WwdqJ6kk=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (127, 4, 3, CAST(0x0000A600017B6690 AS DateTime), N'Se modifico correctamente el usuario admin', N'YxCxdbGxJ+2t0oewZRwzgrxCOpE=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (128, 4, 3, CAST(0x0000A600017EBCEA AS DateTime), N'Se modifico correctamente el usuario admin', N'HLoSpeenjqFINg4/t2PYFpwxrNs=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (129, 4, 3, CAST(0x0000A6000185ED47 AS DateTime), N'Se modifico correctamente el usuario admin', N'wWZzkWvBQ74jRMiSXIXHWwHLyXc=')
INSERT [dbo].[Bitacora] ([ID_Evento], [ID_Usuario], [TipoOperacion], [FechaHora], [DescripcionEvento], [DVH]) VALUES (130, 4, 3, CAST(0x0000A600018600DE AS DateTime), N'Se modifico correctamente el usuario admin', N'GTgXy/ioUuffDu5AT6YFU3+XNM0=')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
/****** Object:  StoredProcedure [dbo].[s_Usuario_Modificar]    Script Date: 05/09/2016 10:45:32 ******/
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
       [Perfil]= @Perfil,
       [Bloqueado]= @Bloqueado,
       [Editable]= @Editable,
       [Intentos] = @Intentos,
       [ID_Idioma]= @ID_Idioma,
       [DVH]= @DVH

        WHERE ID_Usuario=@ID_Usuario
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_ListarTodos]    Script Date: 05/09/2016 10:45:32 ******/
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

	
	WHERE	Idioma.ID_Idioma = Usuario.ID_Idioma and Activo = 1
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Crear]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar_PorNombre]    Script Date: 05/09/2016 10:45:32 ******/
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
	where usuario.NombreUsuario = @NombreUsuario and Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Consultar]    Script Date: 05/09/2016 10:45:32 ******/
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

	
	WHERE	Usuario.ID_USUARIO = @ID_Usuario and Idioma.ID_Idioma = Usuario.ID_Idioma and Activo = 1
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_ChequearUsuario]    Script Date: 05/09/2016 10:45:32 ******/
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
	where usuario.NombreUsuario = @NombreUsuario and Activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[s_Usuario_Baja]    Script Date: 05/09/2016 10:45:32 ******/
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
	@ID_Usuario int
	
AS
BEGIN
	--SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
   UPDATE Usuario
   SET 
       [Activo]= 0

        WHERE ID_Usuario=@ID_Usuario and Editable = 1
	
END
GO
/****** Object:  StoredProcedure [dbo].[s_Traduccion_ListarPorIdioma]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Crear]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Traduccion_Consultar]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Padre_Crear]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_Padre_Baja]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarHuerfanos]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Permiso_ListarHijos]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioOperacion]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioFechaOperacion]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuarioFecha]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarUsuario]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarTodos]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarOperacion]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarFechaOperacion]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ListarFecha]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_Crear]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  StoredProcedure [dbo].[s_Bitacora_ConsultarUltimoID]    Script Date: 05/09/2016 10:45:32 ******/
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
/****** Object:  ForeignKey [FK_Bitacora_Bitacora]    Script Date: 05/09/2016 10:45:32 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Bitacora] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Bitacora]
GO
/****** Object:  ForeignKey [FK_Permiso_Padre_Permiso]    Script Date: 05/09/2016 10:45:32 ******/
ALTER TABLE [dbo].[Permiso_Padre]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Padre_Permiso] FOREIGN KEY([ID_PermisoPadre])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Padre] CHECK CONSTRAINT [FK_Permiso_Padre_Permiso]
GO
/****** Object:  ForeignKey [FK_Permiso_Padre_Permiso1]    Script Date: 05/09/2016 10:45:32 ******/
ALTER TABLE [dbo].[Permiso_Padre]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Padre_Permiso1] FOREIGN KEY([ID_PermisoPadre])
REFERENCES [dbo].[Permiso] ([ID_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Padre] CHECK CONSTRAINT [FK_Permiso_Padre_Permiso1]
GO
/****** Object:  ForeignKey [FK_Traduccion_Idioma]    Script Date: 05/09/2016 10:45:32 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
/****** Object:  ForeignKey [FK_Traduccion_Leyenda]    Script Date: 05/09/2016 10:45:32 ******/
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Leyenda] FOREIGN KEY([ID_Leyenda])
REFERENCES [dbo].[Leyenda] ([ID_Leyenda])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Leyenda]
GO
/****** Object:  ForeignKey [FK_Usuario_Idioma]    Script Date: 05/09/2016 10:45:32 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
